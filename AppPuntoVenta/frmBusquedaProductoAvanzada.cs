using AppPuntoVenta.Catalogos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPuntoVenta
{
    public partial class frmBusquedaProductoAvanzada : Form
    {

        public frmBusquedaProductoAvanzada()
        {
            InitializeComponent();
            TraerArticulos();
            productos = new List<Producto>();
        }
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        void TraerArticulos()
        {
            clsArticulos artic = new clsArticulos();
            DataSet consulta = artic.leerArticulos();
            if (consulta != null && consulta.Tables.Count > 0){
                dgvProductos.DataSource = consulta.Tables[0];
                dt = consulta.Tables[0];
            }                
            else if (!string.IsNullOrEmpty(artic.mensaje))
                MessageBox.Show(artic.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public List<Producto> productos
        {
            get; set;
        }


        private void mldBusquedaProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
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

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            string dato = txtCodigo.Text;
            clsArticulos artic = new clsArticulos();
            DataSet consulta = artic.BuscarArticulos(dato);
            if (consulta != null && consulta.Tables.Count > 0)
                dgvProductos.DataSource = consulta.Tables[0];
            else if (!string.IsNullOrEmpty(artic.mensaje))
                MessageBox.Show(artic.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulos();
        }

        void AgregarArticulos()
        {
            foreach(DataGridViewRow dgr in dgvProductos.SelectedRows)
            {
                Producto articulo = new Producto();
                articulo.Codigo = dgr.Cells[0].Value.ToString();
                articulo.NombreArticulo = dgr.Cells[1].Value.ToString();
                productos.Add(articulo);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            string fieldName = string.Concat("[", dt.Columns[0].ColumnName, "]");
            dt.DefaultView.Sort = fieldName;
            DataView view = dt.DefaultView;
            view.RowFilter = string.Empty;
            if (!string.IsNullOrEmpty(this.txtCodigo.Text.ToUpper()))
                view.RowFilter = fieldName + " LIKE '%" + txtCodigo.Text.ToUpper() + "%'";
            dgvProductos.DataSource = view;
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
            dt.DefaultView.Sort = fieldName;
            DataView view = dt.DefaultView;
            view.RowFilter = string.Empty;
            if (!string.IsNullOrEmpty(this.txtNombre.Text.ToUpper()))
                view.RowFilter = fieldName + " LIKE '%" + txtNombre.Text.ToUpper() + "%'";
            dgvProductos.DataSource = view;
        }
    }
}
