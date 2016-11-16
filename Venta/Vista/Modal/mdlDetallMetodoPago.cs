using AppPuntoVenta.Venta.Negocio;
using System.Data;
using System.Windows.Forms;

namespace AppPuntoVenta.Venta.Vista.Modal
{
    public partial class mdlDetallMetodoPago : Form
    {
        public mdlDetallMetodoPago()
        {
            InitializeComponent();
        }

        public string Detalle { get; set; }
        public decimal Monto { get; set; }
        TipoDetalle tipoDetalle = TipoDetalle.NoAplica;

        public string ClaveMetodoPago { get { return lblMetodoPago.Text; } set { lblMetodoPago.Text = value; } }

        private void mdlDetallMetodoPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if(e.KeyCode == Keys.Enter)
            {
                if(tipoDetalle == TipoDetalle.Multiple)
                {
                    Detalle = cmbDetalle.SelectedText.ToString();
                }
                else if(tipoDetalle == TipoDetalle.Sencillo)
                {
                    Detalle = txtDetalle.Text;
                }
                else
                {
                    Detalle = "";
                }

                this.DialogResult = DialogResult.OK;
                decimal monto = 0;
                decimal.TryParse(txtMonto.Text, out monto);
                Monto = monto;
                this.Close();
            }
        }

        void CargarDetalleMetodoPago()
        {
            clsMetodoPago metodo = new clsMetodoPago();
            DataSet detalles = metodo.leerDetalleMetodoPago(ClaveMetodoPago);
            if(detalles != null && detalles.Tables[0].Rows.Count > 0)
            {
                DataTable tabla = detalles.Tables[0];
                if (tabla.Rows.Count > 2)
                {
                    cmbDetalle.Visible = true;
                    cmbDetalle.DataSource = tabla;
                    cmbDetalle.ValueMember = "met1_identi";
                    cmbDetalle.DisplayMember = "met1_descipc";
                    tipoDetalle = TipoDetalle.Multiple;
                    
                }
                else if (tabla.Rows.Count > 1)
                {
                    txtDetalle.Visible = true;
                    lblTituloDetalle.Text = tabla.Rows[2].ToString();
                    tipoDetalle = TipoDetalle.Sencillo;
                }
            }
        }

        enum TipoDetalle
        {
            Multiple,
            Sencillo,
            NoAplica
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
    }
}
