using AppPuntoVenta.Configuraciones;
using AppPuntoVenta.Configuraciones.Negocio;
using AppPuntoVenta.Promocion.Negocio;
using AppPuntoVenta.Promocion.Vista;
using AppPuntoVenta.Seguridad.Vista;
using AppPuntoVenta.Venta.Vista;
using SRATAPV.Ventas.Negocio;
using SRATAPV.Ventas.Vista;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppPuntoVenta
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-MX");
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        void Inicializar()
        {
            if (!HayInformacionEmpresa())
            {
                Close();
                return;
            }
            if (!UsuarioListo())
            {
                Close();
                return;
            }
            if (!ConfiguracionLista())
            {
                Close();
                return;
            }
            TraerConfiguracion();
            menuPrincipal.Visible = true;
            CargaMenu();
            TraerPromocionesVigentes(); 
            tmrReloj.Start();
            tlblibre.Text = string.Empty;
            tlblVersion.Text = this.ProductVersion;
            tlblUsuario.Text = Sesion.NombreUsuario;
            ConsultarCorte();
        }

        void TraerConfiguracion()
        {
            clsConfiguracion cconfig = new clsConfiguracion();
            DataSet con = cconfig.ObtenerConfiguracionCaja();
            Sesion.Caja = con.Tables[0].Rows[0][0].ToString();
        }

        bool UsuarioListo()
        {
            frmLogin login = new frmLogin();            
            var d = login.ShowDialog();
            if (d == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        bool HayInformacionEmpresa()
        {
            clsConfiguracion cConfiguracion = new clsConfiguracion();

            BD bd = new BD();
            bd.ExportarCadenaDeConexion();

            bool hayInformacion = false;
            DialogResult respuestaMensaje = DialogResult.None;

            do
            {
                DataSet datos = cConfiguracion.ObtenerConfiguracionEmpresa();
                if (datos.Tables[0].Rows.Count > 0)
                {
                    DataRow r = datos.Tables[0].Rows[0];
                    decimal tipCambio = 0;
                    decimal.TryParse(r[7].ToString(), out tipCambio);
                    Sesion.CambioDolar = tipCambio;
                    decimal impuesto = 0;
                    decimal.TryParse(r[5].ToString(), out impuesto);
                    Sesion.Impuesto = impuesto;
                    Sesion.RFCEmpresa = r[14].ToString();
                    Sesion.DireccionEmpresa = string.Format("{0} {1} {2}", r[15].ToString(), r[16].ToString(), r[17].ToString());
                    Sesion.Empresa = r[0].ToString();
                    Text = Text + " - " + r[0].ToString();
                    hayInformacion = true;
                }
                else
                {
                    respuestaMensaje = MessageBox.Show("No se encontro información de la empresa." + Environment.NewLine + "Asegurate que la aplicación de sincronización se esté ejecutando", "Información", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            } while (hayInformacion == false && respuestaMensaje == DialogResult.Retry);
            return hayInformacion;
        }

        void ConsultarCorte()
        {
            clsCorte cCorte = new clsCorte();
            Sesion.CodigoCorte = cCorte.leerCorteUsuario(Sesion.Usuario);
        }

        bool ConfiguracionLista()
        {
            clsConfiguracion conf = new clsConfiguracion();
            DataSet datos = conf.ObtenerConfiguracionCaja();
            if (datos == null || datos.Tables[0].Rows.Count == 0)
            {
                frmConfiguracion frmConf = new frmConfiguracion();
                //frmConf.ControlBox = false;
                frmConf.Text = "Punto de venta";
                if (frmConf.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
            }
            return true;
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            tlblFecha.Text = DateTime.Now.ToString();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acerca = new frmAcercaDe();
            acerca.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayCorte())
                return;

            AbrirVenta();
        }

        void AbrirVenta()
        {
            if (VentanaAbierta(typeof(frmCorteCaja), true))
            {
                MessageBox.Show("No es posible acceder a la VENTA mientras el CORTE esté abierto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (VentanaAbierta(typeof(frmVenta), true))
                return;
            frmVenta venta = new frmVenta();
            venta.MdiParent = this;
            venta.WindowState = FormWindowState.Maximized;
            venta.Show();
        }

        bool HayCorte()
        {
            if (string.IsNullOrEmpty(Sesion.CodigoCorte))
            {
                AbrirApertura(true);
                return false;
            }
            return true;
        }

        void AbrirApertura(bool pasarAVenta = false)
        {
            if (VentanaAbierta(typeof(frmAperturaCaja), true))
                CerrarVenta(typeof(frmAperturaCaja));
            frmAperturaCaja caja = new frmAperturaCaja();
            caja.MdiParent = this;
            caja.WindowState = FormWindowState.Normal;
            ModificarEstadoVentas(FormWindowState.Normal);
            if (pasarAVenta)
            {
                caja.FormClosed += new FormClosedEventHandler(AperturaCajaCerrado);
            }
            caja.Show();
        }

        private void AperturaCajaCerrado(object sender, FormClosedEventArgs e)
        {
            frmAperturaCaja caja = sender as frmAperturaCaja;
            if (caja.DialogResult == DialogResult.OK)
            {
                AbrirVenta();
            }
        }

        void ModificarEstadoVentas(FormWindowState estado)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (Form ventana in this.MdiChildren)
                {
                    ventana.WindowState = estado;
                }
            }
        }

        void TraerPromocionesVigentes()
        {
            clsPromocion cPromocion = new clsPromocion();
            Sesion.Promociones = Entidades.Promocion.ConvertirDataSetPromocion(cPromocion.TraerPromocionesVigentes());
            foreach (Entidades.Promocion promo in Sesion.Promociones)
            {
                cPromocion.prar_codprom = promo.Codigo;
                promo.Detalles = Entidades.DetallePromocion.ConvertirDataSetDetallePromocion(cPromocion.TraerDetallePromociones());
            }
        }

        void Prueba()
        {
            //ModeloAppPuntoVenta.BD.CrearBaseDeDatos("STRATA_LOCAL.sdf", "local123");
            //ModeloAppPuntoVenta.BD.EjecutarScript("STRATA_LOCAL.sdf", "local123", @"C:\Users\alann\Documents\CREATEGA\BD\AppPuntoVenta.sql");
            //ModeloAppPuntoVenta.BD.PruebaInsercion("STRATA_LOCAL.sdf", "local123");
            //MessageBox.Show(ModeloAppPuntoVenta.BD.PruebaSeleccion("STRATA_LOCAL.sdf", "local123"));
            //Directory.GetCurrentDirectory();
        }
        
        private void métodosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VentanaAbierta(typeof(frmConfMetodoPago), true))
                return;
            frmConfMetodoPago conf = new frmConfMetodoPago();
            conf.MdiParent = this;
            conf.WindowState = FormWindowState.Normal;
            ModificarEstadoVentas(FormWindowState.Normal);
            conf.Show();
        }

        private void aperturaDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirApertura();
        }

        public void CargaMenu()
        {
            
            int x = 0;
             foreach (ToolStripMenuItem item in menuPrincipal.Items)
            {
                if (item.DropDownItems.Count > 0)
                {
                    x = inhabilitarOpcionesMenu(item.DropDownItems);
                }
                if (x == 0)
                {
                    item.Visible = false;
                }
            }
        }

        public int inhabilitarOpcionesMenu(ToolStripItemCollection colOpcionesMenu)
        {
            int cont = 0;
            foreach (ToolStripItem item in colOpcionesMenu)
            {
                if (!Sesion.TienePermiso(item.AccessibleName))
                {
                    item.Visible = false;
                }
                else
                {
                    cont++;
                }
            }
            return cont;
        }

        private void promocionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VentanaAbierta(typeof(frmPromocion),true))
                return;
            frmPromocion promocion = new frmPromocion();
            promocion.MdiParent = this;
            promocion.WindowState = FormWindowState.Normal;
            ModificarEstadoVentas(FormWindowState.Normal);
            promocion.Show();
        }

        private void paqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VentanaAbierta(typeof(frmPaquete), true))
                return;
            frmPaquete paquetes = new frmPaquete();
            paquetes.MdiParent = this;
            paquetes.WindowState = FormWindowState.Normal;
            ModificarEstadoVentas(FormWindowState.Normal);
            paquetes.Show();
        }

        private void configruaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VentanaAbierta(typeof(frmConfiguracion), true))
                   return;
            frmConfiguracion frmConf = new frmConfiguracion();
            frmConf.MdiParent = this;
            frmConf.WindowState = FormWindowState.Normal;
            ModificarEstadoVentas(FormWindowState.Normal);
            frmConf.Show();
        }

        private void corteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VentanaAbierta(typeof(frmVenta), true))
            {
                DialogResult respuesta = MessageBox.Show("La pantalla de VENTA se cerrara. ¿Desea continuar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                    return;
                else
                    CerrarVenta(typeof(frmVenta));
            }
            if (VentanaAbierta(typeof(frmCorteCaja), true))
                return;
            frmCorteCaja fCorte = new frmCorteCaja();
            fCorte.MdiParent = this;
            fCorte.WindowState = FormWindowState.Normal;
            fCorte.Show();
        }

        bool VentanaAbierta(Type tipoDeForma, bool activar = false)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == tipoDeForma)
                {
                    if(activar)
                        form.Activate();
                    return true;
                }
            }
            return false;
        }

        void CerrarVenta(Type tipoDeForma)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == tipoDeForma)
                {
                    form.Close();
                    break;
                }
            }
        }
        
    }
}
