using System;
using System.Windows.Forms;
using SRATAPV.Seguridad.Negocio;
using System.Linq;
using AppPuntoVenta.Seguridad.Vista;

namespace AppPuntoVenta.Venta.Vista.Modal
{
    public partial class mdlCambiarPrecio : Form
    {
        public mdlCambiarPrecio()
        {
            InitializeComponent();
           
        }

        public decimal Precio { get; set; }
        public string ClaveProducto { get { return txtClaveArticulo.Text;} }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            MostrarBusquedaProducto();
        }

        void MostrarBusquedaProducto()
        {
            mdlBusquedaProducto modalBusquedaProducto = new mdlBusquedaProducto();

            DialogResult respuesta = modalBusquedaProducto.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                txtClaveArticulo.Text += modalBusquedaProducto.CodigoArticulo;
            }
        }

        bool VerificarPermisos()
        {
            bool tienePermisos = false;
            var consultaPermiso = from ele in Sesion.Permisos where ele.ppe_keypan == "mdlCambiarPrecio" select ele;
            if (consultaPermiso.Count() > 0)
            {
                tienePermisos = true;
            }
            else
            {
                frmFirmaUsuario fUsuario = new frmFirmaUsuario();
                DialogResult respuesta =  fUsuario.ShowDialog();
                if(respuesta == DialogResult.OK)
                {
                    consultaPermiso = from ele in fUsuario.Permisos where ele.ppe_keypan == "mdlCambiarPrecio" select ele;
                    if (consultaPermiso.Count() > 0)
                        tienePermisos = true;
                }
            }
            return tienePermisos;
        }

        private void txtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AsignarPrecio();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            AsignarPrecio();
        }

        void AsignarPrecio()
        {

            bool camposListos = true;
            if (string.IsNullOrEmpty(txtClaveArticulo.Text))
            {
                MessageBox.Show("Debe seleccionar un artículo","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                camposListos = false;
            }

            decimal precio = 0;
            if(!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("El precio no es válido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                camposListos = false;
            }

            if (!camposListos)
                return;

            Precio = precio;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void mdlCambiarPrecio_Load(object sender, EventArgs e)
        {
            if (!VerificarPermisos())
            {
                MessageBox.Show("El usuario no cuenta con los permisos necesarios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        
    }
}
