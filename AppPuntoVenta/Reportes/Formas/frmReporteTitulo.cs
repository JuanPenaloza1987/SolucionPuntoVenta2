using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRATAPV.Reportes.Vista;
using System.Data.SqlClient;
using SRATAPV.Utilerias;


namespace SRATAPV.Reportes.Formas
{
    public partial class frmReporteTitulo : Form
    {
        public static DataTable dt = null;
        int numCon = 0;

        public frmReporteTitulo()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(560, 211);
            dgvDatos.Visible = false;
            txtCdgCnt.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numContra = string.Empty;

            frmCryReporteTitulo frmVistaReporte = new frmCryReporteTitulo();

            numContra = txtCdgCnt.Text;

            if (busCarCnt(numContra) > 1)
            {
                this.Size = new System.Drawing.Size(560, 411);
                dgvDatos.Visible = true;
                carDatCnt(numContra);
            }
            else if (busCarCnt(numContra) == 1)
            {
                this.Size = new System.Drawing.Size(560, 211);
                dgvDatos.Visible = false;
                frmVistaReporte.numConsec = numCon;
                frmVistaReporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay registros que mostrar");
            }
        }

        public int busCarCnt(string numContra)
        {
            int result = 0;
            try
            {
                #region llenado de las lista para los socios de negocio
                //using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionSAP))
                using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionLocal))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(" exec spTitCua '" + numContra + "' ", conn))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            foreach (DataRow ro in dt.Rows)
                            {
                                result = Convert.ToInt32(ro[1].ToString());
                                numCon = Convert.ToInt32(ro[3].ToString());
                            }
                        }
                        else if (dt.Rows.Count > 1)
                        {
                            result = dt.Rows.Count;
                            numCon = 0;
                        }
                        else
                        {
                            result = 0;
                            numCon = 0;
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public void carDatCnt(string numContra)
        {
            int result = 0;
            try
            {
                #region cargar el grid con los datos repetidos
                using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionLocal))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(" exec spTitDat '" + numContra + "' ", conn))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                        dgvDatos.AutoGenerateColumns = false;
                        dgvDatos.DataSource = dt;
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string numContra = string.Empty;
            numContra = txtCdgCnt.Text;
            //numContra = dgvDatos[e.ColumnIndex, e.RowIndex].Value;

            frmCryReporteTitulo frmVistaReporte = new frmCryReporteTitulo();
            frmVistaReporte.numConsec = Convert.ToInt32(dgvDatos[1, e.RowIndex].Value);
            frmVistaReporte.ShowDialog();
        }

        private void frmReporteTitulo_Load(object sender, EventArgs e)
        {

        }
    }
}
