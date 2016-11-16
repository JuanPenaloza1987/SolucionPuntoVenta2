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

        public string Referencia { get; set; }
        public string IdDetalle { get; set; }
        public string NombreDetalle { get; set; }
        public decimal Monto { get; set; }
        TipoDetalle tipoDetalle = TipoDetalle.NoAplica;
        public string totS;
        public decimal tot;

        public string ClaveMetodoPago { get { return lblMetodoPago.Text; } set { lblMetodoPago.Text = value; } }

        private void mdlDetallMetodoPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if(e.KeyCode == Keys.Enter)
            {
                if(tipoDetalle == TipoDetalle.Multiple)
                {
                    Referencia = "0";
                    IdDetalle = cmbDetalle.SelectedValue.ToString();
                }
                else if(tipoDetalle == TipoDetalle.Sencillo)
                {
                    Referencia = txtDetalle.Text;
                }
                else
                {
                    Referencia = "";
                }

                
                decimal totText = decimal.Parse(txtMonto.Text);

                if (tot < totText)
                {
                    MessageBox.Show("EL monto debe ser menor o igual.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                } 
                this.DialogResult = DialogResult.OK;
                decimal monto = 0;
                decimal.TryParse(txtMonto.Text, out monto);
                Monto = monto;
                this.Close();
            }
        }

        public void CargarDetalleMetodoPago()
        {
            clsMetodoPago metodo = new clsMetodoPago();
            DataSet detalles = metodo.leerDetalleMetodoPago(ClaveMetodoPago);
            if(detalles != null && detalles.Tables[0].Rows.Count > 0)
            {
                DataTable tabla = detalles.Tables[0];
                if (tabla.Rows.Count > 1)
                {
                    cmbDetalle.Visible = true;
                    cmbDetalle.DataSource = tabla;
                    cmbDetalle.ValueMember = "met1_identi";
                    cmbDetalle.DisplayMember = "met1_descripc";
                    tipoDetalle = TipoDetalle.Multiple;
                    NombreDetalle = tabla.Rows[0][0].ToString();

                }
                else if (tabla.Rows.Count > 0)
                {
                    txtDetalle.Visible = true;
                    lblTituloDetalle.Text = tabla.Rows[0][2].ToString();
                    tipoDetalle = TipoDetalle.Sencillo;
                    IdDetalle = tabla.Rows[0][1].ToString();
                    NombreDetalle = tabla.Rows[0][0].ToString();
                }else
                {
                    IdDetalle = "0";
                    NombreDetalle = "0";
                    Referencia = "0";
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

        private void mdlDetallMetodoPago_Load(object sender, System.EventArgs e)
        {
            totS = Sesion.TotalS;
            tot = Sesion.Total;
        }

    }
}
