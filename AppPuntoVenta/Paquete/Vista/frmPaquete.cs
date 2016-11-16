using System;
using System.Windows.Forms;
using AppPuntoVenta.Paquete.Negocio;
using System.Data;

namespace AppPuntoVenta
{
    public partial class frmPaquete : Form
    {
        public frmPaquete()
        {
            InitializeComponent();
            CargarPaquetes();
        }

        private int tipoAccion = 0;

        void CargarPaquetes()
        {
            clsPaquete paquete = new clsPaquete();
            DataSet consulta = paquete.TraerPaquetes();
            if (consulta != null && consulta.Tables.Count > 0)
                dgvPaquete.DataSource = consulta.Tables[0];
            else if (!string.IsNullOrEmpty(paquete.mensaje))
                MessageBox.Show(paquete.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error); 

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar()
        {
            txtCodigo.Text = "";
            txtCodigo.ReadOnly = false;
            txtDescripcion.Text = "";
            dtpFin.Text = "";
            dtpInicio.Text = "";
            txtPrecio.Text = "";
            dgvPaquete.ClearSelection();
        }

        private void dgvPaquete_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPaquete.SelectedRows.Count > 0)
            {
                if (dgvPaquete.SelectedRows[0].Cells[0].Value == null)
                    dgvPaquete.ClearSelection();
            }
        }

        private void dgvPaquete_Click(object sender, EventArgs e)
        {
            if (dgvPaquete.SelectedRows.Count > 0)
            {
                if (dgvPaquete.SelectedRows[0].Cells[0].Value != null)
                {
                    tipoAccion = 1;
                    clsPaquete cPaq = new clsPaquete();
                    cPaq.pqt_codigo = dgvPaquete.SelectedRows[0].Cells[1].Value.ToString();
                    DataSet consulta = cPaq.TraerPaquete();
                    if (consulta != null && consulta.Tables.Count > 0)
                    {
                        DataTable paq = new DataTable();
                        paq = consulta.Tables[0];
                        
                        DataRow row = paq.Rows[0];
                        string pqt_codigo = row["pqt_codigo"].ToString();
                        string pqt_fini = row["pqt_fini"].ToString();
                        string pqt_ffin = row["pqt_ffin"].ToString();
                        string pqt_descrip = row["pqt_descrip"].ToString();
                        string pqt_precio = row["pqt_precio"].ToString();

                        txtCodigo.Text = pqt_codigo;
                        txtDescripcion.Text = pqt_descrip;
                        txtPrecio.Text = pqt_precio;
                        dtpInicio.Text = pqt_fini;
                        dtpFin.Text = pqt_ffin;
                    }
                    else if (!string.IsNullOrEmpty(cPaq.mensaje))
                        MessageBox.Show(cPaq.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvPaquete.ClearSelection();
                }
            }
        }
        
        private void dgvPaquete_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPaquete.SelectedRows.Count > 0)
            {
                if (dgvPaquete.SelectedRows[0].Cells[0].Value != null)
                {
                    AbrirVentadaDetalle(dgvPaquete.SelectedRows[0].Cells[1].Value.ToString(), "Si");
                }
                else
                {
                    dgvPaquete.ClearSelection();
                }
            }
            
        }

        void AbrirVentadaDetalle(string codigoPaquete, string vista)
        {
            frmDetallePaquete detallep = new frmDetallePaquete(vista);
            detallep.CodigoPaquete = codigoPaquete;
            detallep.MdiParent = this.MdiParent;
            detallep.FormClosed += new FormClosedEventHandler(DetalleCerrado);            
            detallep.Show();
        }

        private void DetalleCerrado(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            Form detalle = sender as Form;
            if (detalle.DialogResult == DialogResult.OK)
            {
                Limpiar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            clsPaquete nuevoPaquete = new clsPaquete();
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El campo de código es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El campo de descripción es obligatorio");
                return;
            }

            decimal precio = 0;
            if(!decimal.TryParse(txtPrecio.Text, out precio)){
                MessageBox.Show("El campo de descripción es obligatorio");
                return;
            }

            nuevoPaquete.pqt_codigo = txtCodigo.Text;
            nuevoPaquete.pqt_descrip = txtDescripcion.Text;
            nuevoPaquete.pqt_fini = DateTime.Parse(dtpInicio.Text);
            nuevoPaquete.pqt_ffin = DateTime.Parse(dtpFin.Text);
            nuevoPaquete.pqt_precio = precio;
            int b = DateTime.Compare(nuevoPaquete.pqt_fini, hoy);
            if (b < 0)
            {
                MessageBox.Show("La fecha de inicio es anterior a la de hoy");
                return;
            }

            b = DateTime.Compare(nuevoPaquete.pqt_ffin, hoy);
            if (b < 0)
            {
                MessageBox.Show("La fecha de fin es anterior a la de hoy");
                return;
            }

            b = DateTime.Compare(nuevoPaquete.pqt_ffin, nuevoPaquete.pqt_fini);
            if (b < 0)
            {
                MessageBox.Show("La fecha de fin es anterior a la de inicio");
                return;
            }
            if (nuevoPaquete.GuardarPaquete())
            {
                AbrirVentadaDetalle(nuevoPaquete.pqt_codigo, "No");
                CargarPaquetes();
                Limpiar();
            }
            else
            {
                MessageBox.Show(nuevoPaquete.mensaje,"¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Al final del guardado abrir lla pantalla del detalle del paquete
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cnx = (ContextMenuStrip)(sender as ToolStripMenuItem).Owner;
           // bool esPromocionRegalo = dgvRegalo.Equals(cnx.SourceControl);
            DataGridView gridSeleccionado = cnx.SourceControl as DataGridView;
            clsPaquete paquete = new clsPaquete();

            if (dgvPaquete.SelectedRows.Count > 0)
            {
                if (dgvPaquete.SelectedRows[0].Cells[0].Value != null)
                {
                    DataSet paq = paquete.TraerPaqueteUnicoPorClave(dgvPaquete.SelectedRows[0].Cells[1].Value.ToString());
                    string fi = paq.Tables[0].Rows[0].ItemArray[2].ToString().Replace(" a.m.","");
                    fi.Replace(" p.m.", "");
                    string ff = paq.Tables[0].Rows[0].ItemArray[3].ToString().Replace(" a.m.", "");
                    ff.Replace(" p.m.", "");
                    DateTime fechIni = Convert.ToDateTime(DateTime.Parse(fi));
                    DateTime fechFin = DateTime.Parse(ff);
                    txtCodigo.Text = paq.Tables[0].Rows[0].ItemArray[1].ToString();
                    txtCodigo.ReadOnly = true;
                    txtDescripcion.Text = paq.Tables[0].Rows[0].ItemArray[4].ToString();
                    dtpInicio.Text = fi;
                    dtpFin.Text = ff;
                    txtPrecio.Text = paq.Tables[0].Rows[0].ItemArray[5].ToString(); 
                }
                else
                {
                    dgvPaquete.ClearSelection();
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvPaquete.SelectedRows.Count > 0)
            {
                if (dgvPaquete.SelectedRows[0].Cells[0].Value != null)
                {
                    clsPaquete paquete = new clsPaquete();    
                    string codigo = dgvPaquete.SelectedRows[0].Cells[1].Value.ToString();                
                    if (paquete.EliminarPaquete(codigo))
                    {
                        CargarPaquetes();
                    }
                    else
                    {
                        MessageBox.Show(paquete.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dgvPaquete.ClearSelection();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCodigo.Text.ToString()))
            {
                string codigo = "";
                string fechaIni = "";
                string fechaFin = "";
                string desc = "";
                string preci = "";
                int existe = 0;

                foreach (DataGridViewRow item in dgvPaquete.Rows)
                {
                    codigo = item.Cells[1].Value.ToString().ToUpper();
                    if (txtCodigo.Text.ToString().ToUpper() == codigo  || txtCodigo.Text.ToString().ToUpper().Contains(codigo) )
                    {
                        existe = 1;                         
                        fechaIni = item.Cells[2].Value.ToString();
                        fechaFin = item.Cells[3].Value.ToString();
                        desc = item.Cells[4].Value.ToString();
                        preci = item.Cells[5].Value.ToString();
                    }
                }

                if (existe > 0)
                {
                    txtDescripcion.Text = desc;
                    txtPrecio.Text = preci;
                    dtpInicio.Value = Convert.ToDateTime(fechaIni);
                    dtpFin.Value = Convert.ToDateTime(fechaFin);                      

                }
            }                
        }
    }
}
