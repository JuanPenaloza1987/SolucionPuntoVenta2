using AppPuntoVenta.Promocion.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppPuntoVenta.Promocion.Vista
{
    public partial class frmDetallePromocion : Form
    {
        public frmDetallePromocion(string ver)
        {
            InitializeComponent();
            productos = new List<Producto>();
            productosRegalo = new List<Producto>();
            productosValidos = new List<Producto>();
            if(ver.Equals("Si")){
                btnGuardar.Enabled = false;
                btnBuscarProducto.Enabled = false;
                btnBuscarProductoFijo.Enabled = false;
                btnBuscarProductoImp.Enabled = false;
                btnBuscarProductoPor.Enabled = false;
                btnCancelar.Enabled = false;
                btnNuevo.Enabled = false;
                btnProductoNec.Enabled = false;
                btnProductoReg.Enabled = false;
                txtCodigoPromocion.Enabled = false;
                dgvArticulos.Enabled = false;
                dgvDescuentoImp.Enabled = false;
                dgvDescuentoPor.Enabled = false;
                dgvNecesarios.Enabled = false;
                dgvPrecioFijo.Enabled = false;
                dgvRegalo.Enabled = false;
                
            }
        }

        
        List<Producto> productos;
        List<Producto> productosRegalo;// esta lista solo se utiliza para la promoción de regalo
        List<Producto> productosValidos;

        private string _tipoPromocion;
        public int _tipoAccion = 0;

        public string TipoPromocion
        {
            get { return _tipoPromocion; }
            set
            {
                _tipoPromocion = value;
                SeleccionarTipoPromocion();
            }
        }

        public string CodigoPromocion {
            get
            {
                return txtCodigoPromocion.Text;
            }
            set
            {
                txtCodigoPromocion.Text = value;
            }
        }

        
        void SeleccionarTipoPromocion()
        {
            TabPage tabVisible = null;
            switch (TipoPromocion.ToUpper())
            {
                case "CANTIDAD X CANTIDAD":
                    tabVisible = tbPromociones.TabPages[0];
                    CargarDetallePromociones(dgvArticulos);
                    break;
                case "DESCUENTO %":
                    tabVisible = tbPromociones.TabPages[1];
                    CargarDetallePromociones(dgvDescuentoPor);
                    break;
                case "DESCUENTO $":
                    tabVisible = tbPromociones.TabPages[2];
                    CargarDetallePromociones(dgvDescuentoImp);
                    break;
                case "PRECIO FIJO":
                    tabVisible = tbPromociones.TabPages[3];
                    CargarDetallePromociones(dgvPrecioFijo);
                    break;
                case "PRODUCTO REGALO":
                    tabVisible = tbPromociones.TabPages[4];
                    CargarDetallePromociones(dgvNecesarios);
                    CargarDetallePromocionesRegalo(dgvRegalo);
                    break;
            }
            tbPromociones.TabPages.Clear();
            tbPromociones.TabPages.Add(tabVisible);
        }
 
        void CargarDetallePromociones(DataGridView dvgSeleccionado)
        {
            clsPromocion cPromocion = new clsPromocion();
            dvgSeleccionado.AutoGenerateColumns = false;
            cPromocion.prar_codprom = CodigoPromocion;
            DataSet consulta = cPromocion.TraerDetallePromociones();           
            if (consulta != null && consulta.Tables.Count > 0)      
            {//dvgSeleccionado.DataSource = Producto.ConvertirDataSetProducto(consulta);               
                productos = Producto.ConvertirDataSetProducto(consulta);
                CargarDescuentoPromocion(consulta);
                Console.WriteLine(productos);
                dvgSeleccionado.DataSource = productos;
            }                
            else if (!string.IsNullOrEmpty(cPromocion.mensaje))
                MessageBox.Show(cPromocion.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void CargarDescuentoPromocion(DataSet consulta ) {
            string precioFijo = "0";
            string descProcentaje = "0";
            string descValor = "0";
            foreach (DataRow r in consulta.Tables[0].Rows)
            {
                precioFijo = r.ItemArray[2].ToString();
                descProcentaje = r.ItemArray[3].ToString();
                descValor = r.ItemArray[4].ToString();
            }
            if (Convert.ToSingle(descProcentaje) > 0)
            {
                txtDescPor.Text = descProcentaje;
            }
            else if (Convert.ToSingle(descValor) > 0)
            {
                txtDescImp.Text = descValor;
            }
            else if (Convert.ToSingle(precioFijo) > 0)
            {
                txtPrecioFijo.Text = precioFijo;
            }
        }

        void CargarDetallePromocionesRegalo(DataGridView dvgSeleccionado)
        {
            clsPromocion cPromocion = new clsPromocion();
            dvgSeleccionado.AutoGenerateColumns = false;
            cPromocion.prar_codprom = CodigoPromocion;
            DataSet consulta = cPromocion.TraerDetallePromocionesRegalo();
            if (consulta != null && consulta.Tables.Count > 0)            
            {   //dvgSeleccionado.DataSource = Producto.ConvertirDataSetProducto(consulta);
                productosRegalo = Producto.ConvertirDataSetProducto(consulta);
                dvgSeleccionado.DataSource = productosRegalo;
            }
            else if (!string.IsNullOrEmpty(cPromocion.mensaje))
                MessageBox.Show(cPromocion.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void MostrarMensajeInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(productos.Count == 0)
            {
                MostrarMensajeInformacion("No se ha seleccionado ningún artículo");
                return;
            }
            
            if(productosRegalo.Count ==  0 && CodigoPromocion.ToUpper() == "PRODUCTO REGALO")
            {
                MostrarMensajeInformacion("No se ha seleccionado ningún artículo de regalo");
                return;
            }

            string errores = "";
            string errores1 = "";

            int veces = 1;
            foreach (Producto art in productos)
            {
                clsPromocion promocion = new clsPromocion();
                promocion.prar_codprom = string.Format("'{0}'", CodigoPromocion);
                promocion.prar_keyart = string.Format("'{0}'",art.Codigo);
                promocion.prom_codigo = string.Format("'{0}'", CodigoPromocion);
                switch (TipoPromocion.ToUpper())
                {
                    case "CANTIDAD X CANTIDAD":
                        break;
                    case "DESCUENTO %":
                        int porcentaje = 0; 
                        if(!int.TryParse(txtDescPor.Text, out porcentaje))
                        {
                            MostrarMensajeInformacion("El porcentaje no es válido");
                            return;
                        }
                        promocion.prar_porcdesc = porcentaje;
                        break;
                    case "DESCUENTO $":
                        decimal descuento = 0;
                        if (!decimal.TryParse(txtDescImp.Text, out descuento))
                        {
                            MostrarMensajeInformacion("El importe no es válido");
                            return;
                        }
                        promocion.prar_predesc = descuento;
                        break;
                    case "PRECIO FIJO":
                        decimal precio = 0;
                        if (!decimal.TryParse(txtPrecioFijo.Text, out precio))
                        {
                            MostrarMensajeInformacion("El precio no es válido");
                            return;
                        }
                        promocion.prar_precio = precio;
                        break;
                    case "PRODUCTO REGALO":
                        promocion.prar_esnec = true;
                        break;
                }

                DataSet consulta = promocion.ValidarActualizacion();
                var consSql = consulta.Tables[0].Rows;
                int artActivo = Convert.ToInt32(consSql[0].ItemArray[0].ToString());

                if (_tipoAccion == 0)
                {
                    if (artActivo == 0)
                    {
                        if (!promocion.GuardarDetalle())
                        {
                            errores = errores + art.NombreArticulo + " " + promocion.mensaje + Environment.NewLine;
                        }
                    }
                    else
                    {
                        errores = errores + art.NombreArticulo + " " + " Este artìculo pertenece a una promocion Activa.";
                    }
                }
                else
                {
                    if (veces == 1 )
                    {
                        if (promocion.EliminarDetallePromocion())
                        {
                            string erro = "Bien";
                        }                        
                    }
                    if (artActivo == 0)
                    {
                        if (!promocion.GuardarDetalle())
                        {
                            errores1 = errores1 + art.NombreArticulo + " " + promocion.mensaje + Environment.NewLine;
                        }
                    }
                    else
                    {
                        errores1 = errores1 + art.NombreArticulo + " " + " Este artìculo pertenece a una promocion Activa.";
                    }                      
                }
                veces++;
            }

            foreach (Producto art in productosRegalo)
            {
                clsPromocion promocion = new clsPromocion();
                promocion.prar_codprom = string.Format("'{0}'", CodigoPromocion);
                promocion.prar_keyart = string.Format("'{0}'", art.Codigo);
                promocion.prar_esreg = true;

                if (_tipoAccion == 0)
                {
                    if (!promocion.GuardarDetalle())
                    {
                        errores = errores + art.NombreArticulo + "(Regalo) " + promocion.mensaje + Environment.NewLine;
                    }
                }
                else
                {
                    if (!promocion.GuardarDetalle())
                    {
                        errores1 = errores1 + art.NombreArticulo + "(Regalo) " + promocion.mensaje + Environment.NewLine;
                    }
                }
            }

            if (_tipoAccion == 0)
            {
                if (!string.IsNullOrEmpty(errores))
                {
                    MostrarMensajeInformacion("Promoción guardada pero con errores: " + Environment.NewLine + errores);
                }
                else
                {
                    MostrarMensajeInformacion("Promoción guardada");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(errores1))
                {
                    MostrarMensajeInformacion("Promoción actualizada pero con errores: " + Environment.NewLine + errores1);
                }
                else
                {
                    MostrarMensajeInformacion("Promoción actualizada");
                }
            }

            Limpiar();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        void Limpiar()
        {
            txtCodigoPromocion.Text = "";
            foreach(Control c in this.Controls)
            {
                if(c.GetType() == typeof(TabControl)){
                    foreach(TabPage pg in (c as TabControl).TabPages)
                    {
                        foreach(Control c2  in pg.Controls)
                        {
                            if (c2.GetType() == typeof(DataGridView))
                            {
                                (c2 as DataGridView).DataSource = null;
                            }
                        }
                    }
                }
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
            productos = new List<Producto>();
            productosRegalo = new List<Producto>();
            txtCodigoPromocion.Text = _tipoPromocion;
        }

        void AgregarProducto(DataGridView dataGrid, bool esPromocionRegalo)
        {
            frmBusquedaProductoAvanzada busquedaProducto = new frmBusquedaProductoAvanzada();
            busquedaProducto.MdiParent = this.MdiParent.MdiParent;
            busquedaProducto.ShowDialog();

            if (busquedaProducto.DialogResult == DialogResult.OK)
            {
                if (!esPromocionRegalo)
                {
                    if (dataGrid.Rows.Count > 0)
                    {
                        dataGrid.DataSource = null;

                        foreach (var item in (IEnumerable<Producto>)busquedaProducto.productos)
                        {
                            var consutla = from p in productos where p.Codigo == item.Codigo select p;
                            if (consutla.Count() == 0)
                            {
                                productos.Add(item);
                            }
                        }
                        dataGrid.DataSource = productos.ToList();

                    }
                    else
                    {
                        productos = productos.Concat((IEnumerable<Producto>)busquedaProducto.productos).Distinct().ToList();
                        Console.WriteLine(productos);
                        dataGrid.DataSource = productos;
                    }
                }
                else
                {
                    if (dataGrid.Rows.Count > 0)
                    {

                        dataGrid.DataSource = null;

                        foreach (var item in (IEnumerable<Producto>)busquedaProducto.productos)
                        {
                            var consutla = from p in productosRegalo where p.Codigo == item.Codigo select p;
                            if (consutla.Count() == 0)
                            {
                                productosRegalo.Add(item);
                            }
                        }
                        dataGrid.DataSource = productosRegalo.ToList();
                        dataGrid.DataSource = productosRegalo;
                    }
                    else
                    {
                        productosRegalo = productosRegalo.Concat((IEnumerable<Producto>)busquedaProducto.productos).Distinct().ToList();
                        Console.WriteLine(productosRegalo);
                        dataGrid.DataSource = productosRegalo;
                    }

                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto(dgvArticulos, false);
        }

        private void btnBuscarProductoPor_Click(object sender, EventArgs e)
        {
            AgregarProducto(dgvDescuentoPor, false);
        }

        private void btnBuscarProductoImp_Click(object sender, EventArgs e)
        {
            AgregarProducto(dgvDescuentoImp, false);
        }

        private void btnBuscarProductoFijo_Click(object sender, EventArgs e)
        {
            AgregarProducto(dgvPrecioFijo, false);
        }

        private void btnProductoNec_Click(object sender, EventArgs e)
        {
            AgregarProducto(dgvNecesarios, false);
        }

        private void btnProductoReg_Click(object sender, EventArgs e)
        {
            AgregarProducto(dgvRegalo, true);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cnx = (ContextMenuStrip)(sender as ToolStripMenuItem).Owner;
            bool esPromocionRegalo = dgvRegalo.Equals(cnx.SourceControl);
            DataGridView gridSeleccionado = cnx.SourceControl as DataGridView;
            int tama = productos.Count();
            foreach (DataGridViewRow dgr in gridSeleccionado.SelectedRows)
            {
                if (esPromocionRegalo)
                {
                    var consultaArt = from art in productosRegalo where art.Codigo == dgr.Cells[0].Value.ToString() select art;
                    int index = productosRegalo.IndexOf(consultaArt.First());
                    productosRegalo.RemoveAt(index);
                }
                else
                {                        
                    if (tama > 0)
                    {
                        var consultaArt = from art in productos where art.Codigo == dgr.Cells[0].Value.ToString() select art;
                        int index = productos.IndexOf(consultaArt.First());
                        productos.RemoveAt(index);
                    }                    
                }

            }
            if (tama > 0)
            {
                gridSeleccionado.DataSource = null;
                gridSeleccionado.DataSource = esPromocionRegalo ? productosRegalo : productos;
                gridSeleccionado.ClearSelection();
            }else{
                dgvArticulos.Rows.RemoveAt(dgvArticulos.SelectedRows[0].Index);           
	        }

        }



    }
}



