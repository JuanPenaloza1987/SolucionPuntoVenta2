using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppPuntoVenta.Venta.Vista.Modal;
using SRATAPV.Ventas.Negocio;
using AppPuntoVenta.Catalogos.Negocio;
using AppPuntoVenta.Venta.Negocio;
using AppPuntoVenta.Entidades;
using AppPuntoVenta.Paquete.Negocio;

namespace AppPuntoVenta
{
    public partial class frmVenta : Form
    {
        List<ConfMetodo> atajosMetodoPago = new List<ConfMetodo>();
        List<DetalleMetodoPago> detallePagos = new List<DetalleMetodoPago>();
        decimal dolaresEnPesosVenta = 0;
        decimal pagosVenta = 0;
        List<Entidades.PromocionAplicada> promocionesEnEspera = new List<Entidades.PromocionAplicada>();
        string codigoCorte;

        List<ArticuloVenta> listaArticulosVenta = new List<ArticuloVenta>();

        public frmVenta()
        {
            InitializeComponent();
            codigoCorte = Sesion.CodigoCorte;
            CargarConfiguracionMetodosPago();
            lblTipoCambio.Text = Sesion.CambioDolar.ToString("0.00"); //Cargar tipo de cambio
        }

        private void txtClaveProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarProducto();
        }

        void BuscarProducto()
        {
            if (string.IsNullOrEmpty(txtClaveProducto.Text))
                return;

            string[] cantidadCodigo = txtClaveProducto.Text.Split('*');
            int cantidad = 0;
            string codigo = "";

            if (cantidadCodigo.Length > 1)
            {
                if (!int.TryParse(cantidadCodigo[0], out cantidad))
                    cantidad = 1;
                codigo = cantidadCodigo[1];
            }
            else
            {
                cantidad = 1;
                codigo = cantidadCodigo[0];
            }

            clsArticulos articulos = new clsArticulos();
            articulos.art_codbar = codigo;
            DataSet respuesta = articulos.leerArticulosUnicoPorCodigoBarras();

            bool articuloEncontrado = false;
            bool esPaquete = false;

            if (!string.IsNullOrEmpty(articulos.mensaje))
            {
                MessageBox.Show(articulos.mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            articuloEncontrado = respuesta != null && respuesta.Tables[0].Rows.Count > 0;

            if (!articuloEncontrado)
            {
                respuesta = articulos.leerArticulosUnicoPorClave(codigo);
                articuloEncontrado = respuesta != null && respuesta.Tables[0].Rows.Count > 0;
            }

            if (!articuloEncontrado)
            {
                clsPaquete cPaquete = new clsPaquete();
                respuesta = cPaquete.TraerPaqueteUnicoPorClave(codigo);
                articuloEncontrado = respuesta != null && respuesta.Tables[0].Rows.Count > 0;
                esPaquete = articuloEncontrado;
            }

            if (!articuloEncontrado)
            {
                txtClaveProducto.Text = "";
                return;
            }

            string clavearticulo = esPaquete ? respuesta.Tables[0].Rows[0][1].ToString() : respuesta.Tables[0].Rows[0][0].ToString();
            string codigoBarras = esPaquete ? respuesta.Tables[0].Rows[0][1].ToString() : respuesta.Tables[0].Rows[0][20].ToString();
            string nombreArticulo = esPaquete ? respuesta.Tables[0].Rows[0][4].ToString() : respuesta.Tables[0].Rows[0][1].ToString();
            decimal precio = esPaquete ? decimal.Parse(respuesta.Tables[0].Rows[0][5].ToString()) : decimal.Parse(respuesta.Tables[0].Rows[0][10].ToString());
            
            AgregarVentaArticulo(clavearticulo, nombreArticulo, cantidad, precio, esPaquete);
            CalcularMontos();
            txtClaveProducto.Text = "";
        }

        void AgregarVentaArticulo(string clave, string nombreArticulo, decimal cantidad, decimal precio, bool esPaquete)
        {
            AgregarArticuloALista(clave, nombreArticulo, cantidad, precio, esPaquete,ref listaArticulosVenta);

            if (!esPaquete)
            {
                if (cantidad > 0)
                    BuscarYAgregarPromocion(clave, nombreArticulo, (int)cantidad, precio);
                else
                    BuscarYRestarPromocion(clave, nombreArticulo, (int)cantidad, precio);
            }

            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = null;
            if (listaArticulosVenta.Count > 0)
            {
                txtTotal.Text = (listaArticulosVenta.Sum(a => a.Monto) - TraerDecuento()).ToString("0.00");
                dgvProductos.DataSource = listaArticulosVenta;
            }
            else
            {
                txtTotal.Text = "0.00";
            }
            dgvProductos.ClearSelection();
        }

        void AgregarArticuloALista(string clave, string nombreArticulo, decimal cantidad, decimal precio, bool esPaquete,ref List<ArticuloVenta> lista)
        {
            var consultaExiste = from art in lista where art.ClaveArticulo == clave select art;
            if (consultaExiste.Count() > 0)
            {
                if (consultaExiste.First().Cantidad <= (cantidad * -1))
                {
                    lista.Remove(consultaExiste.First());
                }
                else
                {
                    consultaExiste.First().Cantidad = (consultaExiste.First().Cantidad + cantidad);
                    consultaExiste.First().Monto = consultaExiste.First().Cantidad * consultaExiste.First().Precio;
                }
            }
            else
            {
                if (cantidad <= 0)
                    return;

                ArticuloVenta artVenta = new ArticuloVenta();
                artVenta.Cantidad = cantidad;
                artVenta.ClaveArticulo = clave;
                artVenta.CodigoArticulo = clave;
                artVenta.Precio = precio;
                artVenta.NombreArticulo = nombreArticulo;
                artVenta.Monto = precio * cantidad;
                artVenta.EsPaquete = esPaquete;
                lista.Add(artVenta);
            }
        }

        decimal TraerDecuento()
        {
            return promocionesEnEspera.Where(p => p.cumplida).Sum(p => p.descuento);
        }

        void Limpiar()
        {
            dgvProductos.DataSource = null;
            txtClaveProducto.Text = "";
            txtTotal.Text = "0.00";
            txtEfectivo.Text = "";
            txtCambio.Text = "";
            txtOtrosPagos.Text = "";
            detallePagos = new List<DetalleMetodoPago>();
            dolaresEnPesosVenta = 0;
            pagosVenta = 0;
            listaArticulosVenta = new List<ArticuloVenta>();
            txtClaveProducto.Focus();
            txtFaltaPAgar.Text = "";
            promocionesEnEspera = new List<Entidades.PromocionAplicada>();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Vender();
        }

        void Vender()
        {
            if(listaArticulosVenta.Count == 0)
            {
                return;
            }
            decimal efectivo = 0;
            decimal.TryParse(txtEfectivo.Text, out efectivo);
            decimal total = 0;
            decimal.TryParse(txtTotal.Text, out total);
            if ((pagosVenta + efectivo) < total)
            {
                MessageBox.Show("No se ha cubierto el total de la venta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEfectivo.Focus();
                return;
            }

            decimal descuentoPaquetes = 0;
            List<ArticuloVenta> articulosVendidosFinal = ObtenerListaArticulosAGuardar(ref descuentoPaquetes); 

            decimal descuentoTotal = promocionesEnEspera.Where(p => p.cumplida).Sum(p => p.descuento) + descuentoPaquetes;
            total += descuentoTotal;
            //decimal porcentajeDescuentoTotal = (total * 100) / (total + descuentoTotal);

            
            clsVenta venta = new clsVenta();
            venta.ven_almace = "'Nombre'";//Pendiente viene de confpara
            venta.ven_caja = "'Caja 1'";//Por ver de donde viene este dato
            venta.ven_cliente = "'Público en general'";
            venta.ven_coment = "NULL";//No se que es
            venta.ven_estado = "'Pagada'";//No se
            venta.ven_fecreg = "GETDATE()";//Fecha de registro de la venta
            venta.ven_formapago = "'Contado'";
            venta.ven_keycor = Sesion.CodigoCorte;//Clave del corte
            venta.ven_porciva = Sesion.Impuesto;
            venta.ven_subtot = total - (total * (Sesion.Impuesto / 100));
            venta.ven_total = total;
            venta.ven_iva = total * (Sesion.Impuesto / 100);
            venta.ven_usrven = string.Format("'{0}'",Sesion.Usuario);//Usuario vendio?
            venta.ven_descue = descuentoPaquetes;//Aqui aplicaré el descuento que se genera por se paquete
            venta.ven_ieps = 0;//No se manejara ieps
            venta.ven_porcdesc = 0;//No APLICA
            venta.ven_docsap = "0";//No se
            venta.ven_porcieps = 0;//No se manejara ieps
            venta.ven_porcretencion = 0;//No creo que lleve retención
            venta.ven_retencion = 0;//No creo que aplique
            venta.ven_enviad = "NULL";//No se. Probablemente es si ya se envio a SAP
            venta.ven_eqenvi = "NULL";//No se
            venta.ven_fecenv = "NULL";
            venta.ven_feccan = "NULL";//Una fecha pero no se de que
            venta.ven_fecdoc = "NULL";//Fecha pero no se de que
            venta.ven_fecmod = "NULL";//Fecha de modificación (es nuevo, no se modifica)
            venta.ven_groupnum = "NULL";//No se
            venta.ven_ipenvi = "NULL";//No se;
            venta.ven_keyase = "NULL";//No se
            venta.ven_keycot = "NULL";//No se;
            venta.ven_keyser = "NULL";//Usuario?
            //venta.ven_keyven = "NULL";//Clave de la venta? Se autogenera?
            venta.ven_macadd = "NULL";//¿MAC Address?
            venta.ven_metododet = "NULL";//Método de pago? no creo
            venta.ven_metodopago = "NULL";//Pueden ser varios. ¿Mixto? hay que poner el de mayor
            venta.ven_metodoref = "NULL";//¿Sera el detalle del método de pago?
            venta.ven_motcan = "NULL";//No se
            venta.ven_msjErr = "NULL";//Mensaje error
            venta.ven_nomser = "NULL";//No se. ¿Nombre usuario?
            venta.ven_pac = "NULL";//¿Pac de facturación?
            venta.ven_referencia = "NULL";//Referencia de que?
            venta.ven_timacuse = "NULL";//No se
            venta.ven_timfeccan = "NULL";//No se
            venta.ven_timusrcan = "";//No se
            venta.ven_usrcan = "NULL";//No se
            venta.ven_usrmod = "NULL";//Usuario que modifico (ninguno)
            venta.ven_webIde = "NULL";//No se
            venta.ven_xml = "NULL";//No se

            if (venta.Guardar())
            {
                foreach (ArticuloVenta art in articulosVendidosFinal)
                {
                    venta.ven1_artdes = string.Format("'{0}'", art.NombreArticulo);
                    venta.ven1_articulo = string.Format("'{0}'", art.ClaveArticulo);
                    venta.ven1_cantidad = string.Format("'{0}'", art.Cantidad.ToString());

                    decimal descuento = 0;
                    decimal porcentajeDescuento = 0;
                    decimal totalProducto = art.Precio * art.Cantidad;
                    var productoEnPromocion = from ele in promocionesEnEspera where ele.cumplida && ele.articulos.Where(a => a.Articulo.Codigo == art.CodigoArticulo).Count() > 0 select ele;
                    if (productoEnPromocion.Count() > 0)
                    {
                        descuento = productoEnPromocion.Sum(s => s.descuento);
                        porcentajeDescuento = (descuento * 100) / totalProducto;
                    }
                    venta.ven1_descuento = descuento;//Cuando aplique promociones
                    venta.ven1_porcdesc = porcentajeDescuento;//Aun no se aplica
                    venta.ven1_totallinea = totalProducto;

                    venta.ven1_escompues = art.EsPaquete;
                    venta.ven1_idpaquete = string.Format("'{0}'", art.EsPaquete ? art.ClaveArticulo : "");
                    venta.ven1_ieps = 0;
                    venta.ven1_iva = art.Monto * (Sesion.Impuesto / 100);
                    venta.ven1_keyalm = "NULL";
                    venta.ven1_keypro = "NULL";
                    venta.ven1_keyven = venta.ven_keyven;
                    venta.ven1_moneda = dolaresEnPesosVenta > 0 ? dolaresEnPesosVenta >= total ? "'Dólares'" : "'Dólares/Pesos'" : "'Pesos'";
                    venta.ven1_numlin = "NULL";//No se
                    venta.ven1_OcrCode = "NULL";
                    venta.ven1_precio = art.Precio;
                    venta.ven1_tipocambio = Sesion.CambioDolar;
                    venta.GuardarDetalle();
                }

                foreach (DetalleMetodoPago det in detallePagos)
                {
                    venta.ven4_cuenta = "";//No se, creo es la referencia
                    venta.ven4_fecreg = "GETDATE()";
                    venta.ven4_formapago = "'Contado'";
                    venta.ven4_importe = det.Monto.ToString();
                    venta.ven4_keyven = venta.ven_keyven;
                    venta.ven4_metododet = det.ClaveMetodoPago;
                    venta.ven4_metodopago = det.ClaveMetodoPago;
                    venta.ven4_cuenta = "NULL";
                    venta.ven4_numpago = "NULL";
                    venta.ven4_terminal = "NULL";
                    venta.GuardarDetallePagos();

                }

                Ticket ticket = new Ticket();
                ticket.Articulos = listaArticulosVenta;
                ticket.Cajero = Sesion.Usuario;
                ticket.Descuento = descuentoTotal;
                ticket.FechaVenta = DateTime.Now;
                ticket.NumeroTicket = venta.ven_keyven;
                ticket.Tienda = Sesion.Empresa;
                ticket.Efectivo = efectivo;
                ticket.IVA = (total * Sesion.Impuesto).ToString("0.00");
                ticket.Cambio = txtCambio.Text;
                ticket.Direccion = Sesion.DireccionEmpresa;

                ticket.print();
                MessageBox.Show("Venta realizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(venta.mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Limpiar();
        }

        List<ArticuloVenta> ObtenerListaArticulosAGuardar(ref decimal diferenciaPrecio)
        {
            List<ArticuloVenta> listaSinPaquetes = (from art in listaArticulosVenta where !art.EsPaquete select art).ToList();
            decimal totalDetallePaquete = 0;
            decimal totalPaquete = 0;
            var consultaPaquete = from art in listaArticulosVenta where art.EsPaquete select art;
            clsPaquete cPaquete = new clsPaquete();
            foreach(ArticuloVenta pqte in consultaPaquete)
            {
                cPaquete.pqt_codigo = pqte.CodigoArticulo;
                var detalles = cPaquete.TraerDetallePaquetes();
                totalPaquete += pqte.Precio;
                if (detalles == null)
                    continue;

                foreach(DataRow r in detalles.Tables[0].Rows)
                {
                    int cantidad = int.Parse(r.ItemArray[3].ToString());
                    string claveArt = r.ItemArray[0].ToString();
                    clsArticulos cArticulo = new clsArticulos();
                    DataSet articulo = cArticulo.leerArticulosUnicoPorClave(claveArt);
                    decimal precio = decimal.Parse(articulo.Tables[0].Rows[0][10].ToString());
                    string descripcionArt = articulo.Tables[0].Rows[0][1].ToString();
                    AgregarArticuloALista(claveArt, descripcionArt, cantidad, precio, false,ref listaSinPaquetes);
                    totalDetallePaquete += (precio * cantidad);
                }

            }
            diferenciaPrecio = totalDetallePaquete - totalPaquete;
            return listaSinPaquetes;
        }

        private void frmVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        {
                            Vender();
                        }
                        break;
                    case Keys.Delete:
                        {
                            Limpiar();
                        }
                        break;
                    default:
                        var consulta = from m in atajosMetodoPago where ((Keys)Enum.Parse(typeof(Keys), m.Letra)) == e.KeyCode select m;

                        if (consulta.Count() > 0)
                        {
                            string claveMetodo = consulta.First().ClaveMetodo;
                            mdlDetallMetodoPago detalleMetodo = new mdlDetallMetodoPago();
                            detalleMetodo.ClaveMetodoPago = claveMetodo;

                            DialogResult resultado = detalleMetodo.ShowDialog();
                            if (resultado == DialogResult.OK)
                            {
                                DetalleMetodoPago nuevoDetalle = new DetalleMetodoPago();
                                nuevoDetalle.ClaveMetodoPago = claveMetodo;
                                nuevoDetalle.Monto = detalleMetodo.Monto;
                                nuevoDetalle.Detalle = detalleMetodo.Detalle;

                                detallePagos.Add(nuevoDetalle);
                                pagosVenta += nuevoDetalle.Monto;
                                CalcularMontos();
                            }
                        }
                        break;
                }

            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        {
                            MostrarAyuda();
                        }
                        break;
                    case Keys.F2:
                        {
                            MostrarBusquedaProducto();
                        }
                        break;
                    case Keys.F3:
                        {
                            MostrarFormaDePago();
                        }
                        break;
                    case Keys.F4:
                        {
                            MostrarDolares();
                        }
                        break;
                    case Keys.F5:
                        {
                            //Facturar
                        }
                        break;

                }
            }


        }

        void CalcularMontos()
        {
            decimal efectivoVenta = 0;
            if (decimal.TryParse(txtEfectivo.Text, out efectivoVenta))
            {
                if (efectivoVenta < 0)
                {
                    efectivoVenta = 0;
                }
            }

            decimal pagoTotal = pagosVenta + efectivoVenta;

            txtOtrosPagos.Text = pagosVenta.ToString("0.00");

            decimal totalVenta = 0;
            decimal.TryParse(txtTotal.Text, out totalVenta);

            decimal faltaPagar = totalVenta - pagoTotal;
            if (faltaPagar <= 0)
            {
                txtFaltaPAgar.Text = "0.00";
                decimal cambio = faltaPagar * -1;
                decimal efectivoTotal = dolaresEnPesosVenta + efectivoVenta;
                if (efectivoTotal >= cambio)
                {
                    txtCambio.Text = cambio.ToString("0.00");
                }
                else
                {
                    txtCambio.Text = efectivoTotal.ToString("0.00");
                }
            }
            else
            {
                txtCambio.Text = "0.00";
                txtFaltaPAgar.Text = faltaPagar.ToString("0.00");
            }

        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            CalcularMontos();
        }

        void CargarConfiguracionMetodosPago()
        {
            clsConfMetodo metodosPago = new clsConfMetodo();
            DataSet respuesta = metodosPago.leerConfiguracionMetodoPago();
            if (respuesta != null && respuesta.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow met in respuesta.Tables[0].Rows)
                {
                    ConfMetodo otroMetodo = new ConfMetodo();
                    otroMetodo.ClaveMetodo = met.ItemArray[1].ToString();
                    otroMetodo.Letra = met.ItemArray[2].ToString();
                    atajosMetodoPago.Add(otroMetodo);
                }
            }
        }

        #region Pantallas externas
        void MostrarAyuda()
        {
            mdlAyuda modalAyuda = new mdlAyuda();
            modalAyuda.ShowDialog();
        }

        void MostrarBusquedaProducto()
        {
            mdlBusquedaProducto modalBusquedaProducto = new mdlBusquedaProducto();

            DialogResult respuesta = modalBusquedaProducto.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                txtClaveProducto.Text += modalBusquedaProducto.CodigoArticulo;
                BuscarProducto();
            }
        }

        void MostrarFormaDePago()
        {
            mdlFormaPago modalFormaPago = new mdlFormaPago();
            modalFormaPago.CargarFormas(atajosMetodoPago);
            DialogResult respuesta = modalFormaPago.ShowDialog();
        }

        void MostrarDolares()
        {
            mdlDolares modalDolares = new mdlDolares();
            DialogResult respuesta = modalDolares.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                pagosVenta -= dolaresEnPesosVenta;
                dolaresEnPesosVenta = modalDolares.CantidadDolares;
                pagosVenta += dolaresEnPesosVenta;
                CalcularMontos();
            }
        }

        private void txtClaveProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Promociones

        Entidades.Promocion RevisarPromocionesBD(string codigoArticulo)
        {
            Entidades.Promocion promocion = null;
            var consulta = from prom in Sesion.Promociones where prom.Detalles.Where(dp => dp.CodigoArticulo == codigoArticulo).Count() > 0 select prom;
            if (consulta.Count() > 0)
                promocion = consulta.First();

            return promocion;
        }

        void BuscarYAgregarPromocion(string codigoArticulo, string nombreArticulo, int cantidad, decimal precio)
        {
            Entidades.Promocion promocionBD = RevisarPromocionesBD(codigoArticulo);

            if (promocionBD == null || cantidad <= 0)
                return;

            for (int disponible = cantidad; disponible > 0; disponible--)
            {
                Entidades.PromocionAplicada promoA;
                IEnumerable<PromocionAplicada> promocionPrendiente = from prom in promocionesEnEspera where !prom.cumplida && prom.promocion.Detalles.Where(d => d.CodigoArticulo == codigoArticulo).Count() > 0 select prom;
                Entidades.ComplementoPromocion complemento = null;

                if (promocionBD.TipoPromocion.ToUpper() == "PRODUCTO REGALO")
                {
                    List<Entidades.PromocionAplicada> promocionesFalanNecesarios = new List<Entidades.PromocionAplicada>();
                    List<Entidades.PromocionAplicada> promocionesFalanRegalos = new List<Entidades.PromocionAplicada>();

                    if (promocionPrendiente.Count() > 0)
                    {
                        promocionesFalanNecesarios = (from prom in promocionPrendiente where prom.promocion.Detalles.Where(d => d.CodigoArticulo == codigoArticulo && d.EsNecesario).Count() > 0 && (prom.promocion.CantidadRequerida > prom.articulos.Where(a => !a.EsRegalo).Count()) select prom).ToList();
                        promocionesFalanRegalos = (from prom in promocionPrendiente where prom.promocion.Detalles.Where(d => d.CodigoArticulo == codigoArticulo && d.EsRegalo).Count() > 0 && (prom.promocion.CantidadARegalar > prom.articulos.Where(a => a.EsRegalo).Count()) select prom).ToList();
                    }

                    bool complementesNecesariosListos = false;
                    bool complementesRegalosListos = false;

                    if (promocionesFalanNecesarios.Count() > 0)
                    {
                        promoA = promocionesFalanNecesarios.First();
                        complemento = new Entidades.ComplementoPromocion();
                        complemento.Articulo = new Producto()
                        {
                            Codigo = codigoArticulo,
                            NombreArticulo = nombreArticulo,
                            Precio = precio
                        };
                        complemento.EsRegalo = false;
                        complemento.PrecioPorArticulo = precio;
                        promoA.articulos.Add(complemento);

                        complementesNecesariosListos = promoA.promocion.CantidadRequerida <= promoA.articulos.Where(a => !a.EsRegalo).Count();
                        complementesRegalosListos = promoA.promocion.CantidadARegalar <= promoA.articulos.Where(a => a.EsRegalo).Count();


                        if (complementesNecesariosListos && complementesRegalosListos)
                        {
                            promoA.cumplida = true;
                            promoA.descuento = promoA.articulos.Sum(art => art.Articulo.Precio) - promoA.articulos.Sum(art => art.PrecioPorArticulo);
                        }
                    }
                    else if (promocionesFalanRegalos.Count() > 0)
                    {
                        promoA = promocionesFalanRegalos.First();
                        complemento = new Entidades.ComplementoPromocion();
                        complemento.Articulo = new Producto()
                        {
                            Codigo = codigoArticulo,
                            NombreArticulo = nombreArticulo,
                            Precio = precio
                        };
                        complemento.EsRegalo = true;
                        float aRegalar = promoA.promocion.CantidadARegalar - promoA.articulos.Where(a => a.EsRegalo).Count();
                        complemento.PrecioPorArticulo = aRegalar >= 1 ? 0 : (precio - (precio * (decimal)aRegalar));
                        promoA.articulos.Add(complemento);

                        complementesNecesariosListos = promoA.promocion.CantidadRequerida <= promoA.articulos.Where(a => !a.EsRegalo).Count();
                        complementesRegalosListos = promoA.promocion.CantidadARegalar <= promoA.articulos.Where(a => a.EsRegalo).Count();

                        if (complementesNecesariosListos && complementesRegalosListos)
                        {
                            promoA.cumplida = true;
                            promoA.descuento = promoA.articulos.Sum(art => art.Articulo.Precio) - promoA.articulos.Sum(art => art.PrecioPorArticulo);
                        }
                    }
                    else
                    {
                        promoA = new Entidades.PromocionAplicada();
                        promoA.promocion = promocionBD;
                        promoA.cumplida = false;
                        promoA.descuento = 0;
                        promoA.articulos = new List<Entidades.ComplementoPromocion>();
                        promocionesEnEspera.Add(promoA);

                        complemento = new Entidades.ComplementoPromocion();
                        complemento.Articulo = new Producto()
                        {
                            Codigo = codigoArticulo,
                            NombreArticulo = nombreArticulo,
                            Precio = precio
                        };

                        bool esNecesario = promoA.promocion.Detalles.Where(d => d.CodigoArticulo == codigoArticulo && d.EsNecesario).Count() > 0;
                        //bool esRegalo = promoA.promocion.Detalles.Where(d => d.CodigoArticulo == codigoArticulo && d.EsRegalo).Count() > 0;

                        if (esNecesario)
                        {
                            complemento.EsRegalo = false;
                            complemento.PrecioPorArticulo = precio;
                        }
                        else
                        {
                            complemento.EsRegalo = true;
                            float aRegalar = promoA.promocion.CantidadARegalar - promoA.articulos.Where(a => a.EsRegalo).Count();
                            complemento.PrecioPorArticulo = aRegalar >= 1 ? 0 : (precio - (precio * (decimal)aRegalar));
                        }

                        promoA.articulos.Add(complemento);

                        complementesNecesariosListos = promoA.promocion.CantidadRequerida <= promoA.articulos.Where(a => !a.EsRegalo).Count();
                        complementesRegalosListos = promoA.promocion.CantidadARegalar <= promoA.articulos.Where(a => a.EsRegalo).Count();

                        if (complementesNecesariosListos && complementesRegalosListos)
                        {
                            promoA.cumplida = true;
                            promoA.descuento = promoA.articulos.Sum(art => art.Articulo.Precio) - promoA.articulos.Sum(art => art.PrecioPorArticulo);
                        }
                    }
                }
                else
                {
                    if (promocionPrendiente.Count() > 0)
                    {
                        promoA = promocionPrendiente.First();
                    }
                    else
                    {
                        promoA = new Entidades.PromocionAplicada();
                        promoA.promocion = promocionBD;
                        promoA.cumplida = false;
                        promoA.descuento = 0;
                        promoA.articulos = new List<Entidades.ComplementoPromocion>();
                        promocionesEnEspera.Add(promoA);
                    }
                    switch (promocionBD.TipoPromocion.ToUpper())
                    {
                        case "CANTIDAD X CANTIDAD":
                            complemento = new Entidades.ComplementoPromocion();
                            complemento.Articulo = new Producto()
                            {
                                Codigo = codigoArticulo,
                                NombreArticulo = nombreArticulo
                            };
                            complemento.EsRegalo = false;
                            complemento.PrecioPorArticulo = precio * (decimal)(promoA.promocion.CantidadARegalar / promoA.promocion.CantidadRequerida);
                            promoA.articulos.Add(complemento);

                            if (promoA.promocion.CantidadRequerida == promoA.articulos.Count())
                            {
                                promoA.cumplida = true;
                                int totalProductos = promoA.articulos.Count();
                                promoA.descuento = (precio - promoA.articulos.First().PrecioPorArticulo) * totalProductos;
                                break;
                            }
                            break;
                        case "DESCUENTO %":
                            complemento = new Entidades.ComplementoPromocion();
                            complemento.Articulo = new Producto()
                            {
                                Codigo = codigoArticulo,
                                NombreArticulo = nombreArticulo
                            };

                            complemento.EsRegalo = false;
                            complemento.PrecioPorArticulo = precio - (precio * ((decimal)promoA.promocion.Detalles.First().PorcentajeDescuento / 100));
                            promoA.articulos.Add(complemento);
                            promoA.cumplida = true;
                            promoA.descuento = precio * ((decimal)promoA.promocion.Detalles.First().PorcentajeDescuento / 100);
                            break;
                        case "DESCUENTO $":
                            complemento = new Entidades.ComplementoPromocion();
                            complemento.Articulo = new Producto()
                            {
                                Codigo = codigoArticulo,
                                NombreArticulo = nombreArticulo
                            };
                            complemento.EsRegalo = false;
                            complemento.PrecioPorArticulo = precio - promoA.promocion.Detalles.First().ImporteDescuento;
                            promoA.articulos.Add(complemento);
                            promoA.cumplida = true;
                            promoA.descuento = promoA.promocion.Detalles.First().ImporteDescuento;
                            break;
                        case "PRECIO FIJO":
                            complemento = new Entidades.ComplementoPromocion();
                            complemento.Articulo = new Producto()
                            {
                                Codigo = codigoArticulo,
                                NombreArticulo = nombreArticulo
                            };

                            complemento.EsRegalo = false;
                            complemento.PrecioPorArticulo = promoA.promocion.Detalles.First().Precio;
                            promoA.articulos.Add(complemento);
                            promoA.cumplida = true;
                            promoA.descuento = precio - promoA.promocion.Detalles.First().Precio;
                            break;
                    }
                }
            }
        }

        void BuscarYRestarPromocion(string codigoArticulo, string nombreArticulo, int cantidad, decimal precio)
        {
            Entidades.Promocion promocionBD = RevisarPromocionesBD(codigoArticulo);

            if (promocionBD == null || cantidad >= 0)
                return;

            for (int disponible = cantidad; disponible < 0; disponible++)
            {
                Entidades.PromocionAplicada promoA;
                IEnumerable<Entidades.PromocionAplicada> promocionPrendiente = from prom in promocionesEnEspera where !prom.cumplida && prom.articulos.Where(a => a.Articulo.Codigo == codigoArticulo).Count() > 0 select prom;
                IEnumerable<Entidades.PromocionAplicada> promocionCumplidas = from prom in promocionesEnEspera where prom.cumplida && prom.articulos.Where(a => a.Articulo.Codigo == codigoArticulo).Count() > 0 select prom;
                int indice = -1;

                if (promocionPrendiente.Count() > 0)
                    promoA = promocionPrendiente.Last();
                else if (promocionCumplidas.Count() > 0)
                    promoA = promocionCumplidas.Last();
                else
                    return;

                var consultaNecesarios = (from a in promoA.articulos where !a.EsRegalo && a.Articulo.Codigo == codigoArticulo select a);
                var consultaRegalo = (from a in promoA.articulos where a.EsRegalo && a.Articulo.Codigo == codigoArticulo select a);

                if (consultaRegalo.Count() > 0)
                    indice = promoA.articulos.IndexOf(consultaRegalo.First());
                else
                    indice = promoA.articulos.IndexOf(consultaNecesarios.First());

                promoA.articulos.RemoveAt(indice);
                promoA.cumplida = false;
                if (promoA.articulos.Count == 0)
                {
                    indice = promocionesEnEspera.IndexOf(promoA);
                    promocionesEnEspera.RemoveAt(indice);
                }
            }
        }
        #endregion

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }
    }
}





