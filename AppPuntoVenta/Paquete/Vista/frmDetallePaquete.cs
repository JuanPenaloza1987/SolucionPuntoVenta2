using AppPuntoVenta.Paquete.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppPuntoVenta
{
    public partial class frmDetallePaquete : Form
    {
        public frmDetallePaquete(string ver)
        {
            InitializeComponent();
            productos = new List<Producto>();
            productosRegalo = new List<Producto>();
            productosValidos = new List<Producto>();
            txtCodigoPaquete.Text = CodigoPaquete;
            articulos = new List<ArticuloPaquete>();
            if (ver.Equals("Si"))
            {
                btnAgregar.Enabled = false;
                btnBuscarProducto.Enabled = false;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = false;
                txtArticulo.Enabled = false;
                txtCantidad.Enabled = false;
                txtCodigoPaquete.Enabled = false;
                dgvArticulos.Enabled = false;
            }
        }

        List<ArticuloPaquete> articulos;
        List<Producto> productos;
        List<Producto> productosRegalo;// esta lista solo se utiliza para la promoción de regalo
        List<Producto> productosValidos;

        string codigoArticulo = "";
        string nombreArticulo = "";

        public string CodigoPaquete { get { return txtCodigoPaquete.Text; } set { txtCodigoPaquete.Text = value; CargarDetallesPaquete(); } }

        void CargarDetallesPaquete()
        {
           
            clsPaquete cPaquete = new clsPaquete();
            dgvArticulos.AutoGenerateColumns = false;
            cPaquete.pqt_codigo = CodigoPaquete;
            DataSet consulta = cPaquete.TraerDetallePaquetes();
            if (consulta != null && consulta.Tables.Count > 0)
            {
                dgvArticulos.DataSource = null;
                articulos = ArticuloPaquete.ConvertirDataSetProducto(consulta);
                dgvArticulos.DataSource = articulos;                
            }
            else if (!string.IsNullOrEmpty(cPaquete.mensaje))
                MessageBox.Show(cPaquete.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (articulos.Count == 0)
            {
                MostrarMensajeInformacion("Se debe seleccionar al menos un artículo");
                return;
            }

            if(txtCantidad.Equals(""))
            {
                MostrarMensajeInformacion("Debe especificar una cantidad");
                return;
            }

            string errores = "";
            int veces = 1;

            foreach (ArticuloPaquete art in articulos)
            {
                clsPaquete paquete = new clsPaquete();
                paquete.part_codpqte = string.Format("'{0}'", CodigoPaquete);
                paquete.part_cantidad = art.Cantidad;
                paquete.part_keyart = string.Format("'{0}'", art.Codigo);

                if (veces == 1)
                {
                    if (paquete.EliminarTodoDetallePaquete())
                    {

                    }
                }

                veces++;

                if (!paquete.GuardarDetallePaquete())
                {
                    errores = errores + art.NombreArticulo + " " + paquete.mensaje + Environment.NewLine;
                }
            }

            if (!string.IsNullOrEmpty(errores))
            {
                MostrarMensajeInformacion("Paquete guardado pero con errores: " + Environment.NewLine + errores);
            }
            else
            {
                MostrarMensajeInformacion("Paquete guardado");
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                if (dgvArticulos.SelectedRows[0].Cells[0].Value != null)
                {
                    clsPaquete paquete = new clsPaquete();
                    if (paquete.EliminarDetallePaquete(txtCodigoPaquete.Text,dgvArticulos.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        CargarDetallesPaquete();
                    }
                    else
                    {
                        MessageBox.Show(paquete.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dgvArticulos.ClearSelection();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar()
        {
            LimpiarArticulo();
            articulos = new List<ArticuloPaquete>();
            dgvArticulos.DataSource = null;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            mdlBusquedaProducto modalProducto = new mdlBusquedaProducto();
            DialogResult resultado = modalProducto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                codigoArticulo = modalProducto.CodigoArticulo;
                nombreArticulo = modalProducto.NombreArticulo;
                txtArticulo.Text = codigoArticulo + " " + nombreArticulo;
                txtCantidad.Focus();
            }
        }


        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                if (dgvArticulos.SelectedRows[0].Cells[0].Value == null)
                    dgvArticulos.ClearSelection();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!CamposValidos())
            {
                return;
            }
            if (articulos.Count > 0)
            {
                int indexArticulo = -1;
                var consulta = from ar in articulos where ar.Codigo == codigoArticulo select ar;
                if (consulta.Count() > 0)
                {
                    indexArticulo = articulos.IndexOf(consulta.First());
                }
                if (indexArticulo >= 0)
                {
                    articulos.RemoveAt(indexArticulo);
                }
                articulos.Add(new ArticuloPaquete() { Cantidad = int.Parse(txtCantidad.Text), Codigo = codigoArticulo, NombreArticulo = nombreArticulo });
            }
            else
            {
                articulos.Add(new ArticuloPaquete() { Cantidad = int.Parse(txtCantidad.Text), Codigo = codigoArticulo, NombreArticulo = nombreArticulo });
            }
            articulos.ToList();
            dgvArticulos.DataSource = null;
            articulos = articulos.Concat(articulos).Distinct().ToList();
            dgvArticulos.DataSource = articulos;
            dgvArticulos.DataSource = articulos;
            LimpiarArticulo();

        }

        void LimpiarArticulo()
        {
            txtArticulo.Text = "";
            nombreArticulo = "";
            codigoArticulo = "";
            txtCantidad.Text = "";
        }

        bool CamposValidos()
        {
            bool validos = true;
            if (string.IsNullOrEmpty(codigoArticulo))
            {
                MostrarMensajeInformacion("Se debe seleccionar un artículo");
                validos = false;
            }
            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MostrarMensajeInformacion("La cantidad no es válida");
                validos = false;
            }
            return validos;
        }

        void MostrarMensajeInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvArticulos.SelectedRows)
            {
                var consultaArt = from art in articulos where art.Codigo == dgr.Cells[0].Value.ToString() select art;
                int index = articulos.IndexOf(consultaArt.First());
                articulos.RemoveAt(index);
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = articulos;

            dgvArticulos.ClearSelection();
        }


    }
}
