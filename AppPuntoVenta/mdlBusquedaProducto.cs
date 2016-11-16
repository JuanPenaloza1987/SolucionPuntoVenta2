using AppPuntoVenta.Catalogos.Negocio;
using AppPuntoVenta.Paquete.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppPuntoVenta
{
    public partial class mdlBusquedaProducto : Form
    {
        public mdlBusquedaProducto()
        {
            InitializeComponent();
            TraerArticulos();
        }

        void TraerArticulos()
        {
            List<ArticuloVenta> articulosEncontrados = new List<ArticuloVenta>();
            string dato = txtDatoProducto.Text;

            clsArticulos artic = new clsArticulos();
            DataSet consultaArticulos = artic.leerArticulos();

            if (consultaArticulos != null && consultaArticulos.Tables.Count > 0)
            {
                foreach (DataRow r in consultaArticulos.Tables[0].Rows)
                {
                    articulosEncontrados.Add(ConvertirDataSetArticulo(r));
                }
            }

            clsPaquete paquete = new clsPaquete();
            DataSet consultaPaquetes = paquete.TraerDetallePaquetes();

            if (consultaPaquetes != null && consultaPaquetes.Tables.Count > 0)
            {
                foreach (DataRow r in consultaPaquetes.Tables[0].Rows)
                {
                    articulosEncontrados.Add(ConvertirDataSetPaquete(r));
                }
            }

            dgvProductos.AutoGenerateColumns = false;
            if (articulosEncontrados.Count > 0)
                dgvProductos.DataSource = articulosEncontrados;
            else if (!string.IsNullOrEmpty(artic.mensaje))
                MessageBox.Show(artic.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string _codigoArticulo = "";
        public string CodigoArticulo
        {
            get
            {
                return _codigoArticulo;
            }
        }

        private string _nombreArticulo = "";
        public string NombreArticulo
        {
            get
            {
                return _nombreArticulo;
            }
        }

        private void mldBusquedaProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvProductos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _codigoArticulo = dgvProductos.SelectedRows[0].Cells[0].Value.ToString();
                _nombreArticulo = dgvProductos.SelectedRows[0].Cells[1].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void mdlBusquedaProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        void BuscarArticulo()
        {
            List<ArticuloVenta> articulosEncontrados = new List<ArticuloVenta>();
            string dato = txtDatoProducto.Text;

            clsArticulos artic = new clsArticulos();
            DataSet consultaArticulos = artic.BuscarArticulos(dato);

            if (consultaArticulos != null && consultaArticulos.Tables.Count > 0)
            {
                foreach (DataRow r in consultaArticulos.Tables[0].Rows)
                {
                    articulosEncontrados.Add(ConvertirDataSetArticulo(r));
                }
            }

            clsPaquete paquete = new clsPaquete();
            DataSet consultaPaquetes = paquete.BuscarPaquetes(dato);

            if (consultaPaquetes != null && consultaPaquetes.Tables.Count > 0)
            {
                foreach (DataRow r in consultaPaquetes.Tables[0].Rows)
                {
                    articulosEncontrados.Add(ConvertirDataSetPaquete(r));
                }
            }

            dgvProductos.AutoGenerateColumns = false;
            if (articulosEncontrados.Count > 0)
                dgvProductos.DataSource = articulosEncontrados;
            else if (!string.IsNullOrEmpty(artic.mensaje))
                MessageBox.Show(artic.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        /// <summary>
        /// Solo funciona con la función de "BuscarPaquetes" de la clase clsPaquete
        /// </summary>
        /// <returns></returns>
        ArticuloVenta ConvertirDataSetPaquete(DataRow r)
        {
            ArticuloVenta nuevoArticulo = new ArticuloVenta();
            nuevoArticulo.ClaveArticulo = r.ItemArray[1].ToString();
            nuevoArticulo.NombreArticulo = r.ItemArray[4].ToString();

            return nuevoArticulo;
        }

        /// <summary>
        /// Solo funciona con la función de "BuscarArticulos" de la clase clsArticulos
        /// </summary>
        /// <returns></returns>
        ArticuloVenta ConvertirDataSetArticulo(DataRow r)
        {
            ArticuloVenta nuevoArticulo = new ArticuloVenta();
            nuevoArticulo.ClaveArticulo = r.ItemArray[0].ToString();
            nuevoArticulo.NombreArticulo = r.ItemArray[1].ToString();
            return nuevoArticulo;
        }

        private void txtDatoProducto_TextChanged(object sender, EventArgs e)
        {
            BuscarArticulo();
        }
    }
}
