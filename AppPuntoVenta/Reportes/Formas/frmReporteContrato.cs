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
    public partial class frmReporteContrato : Form
    {
        public class clsSocNeg
        {
            public string scnCdgscn { get; set; }
            public string scnNomscn { get; set; }
        }

        public static DataTable dt = null;
        int numCon = 0;

        clsSocNeg claSocNeg = new clsSocNeg();

        List<clsSocNeg> lstSocNeg = new List<clsSocNeg>();

        public frmReporteContrato()
        {
            InitializeComponent();
        }

        private void frmReporteContrato_Load(object sender, EventArgs e)
        {
            //Cargar informacion
            cmbTipCnt.SelectedIndex = 0;
            carSocNeg();
            var lstScn = new List<string>();
            var lstNom = new List<string>();

            foreach (var items in lstSocNeg)
            {
                lstScn.Add(items.scnCdgscn);
                lstNom.Add(items.scnNomscn);
            }

            #region autocompletado por codigo de socio de negocio
            txtCdgScn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection lstCliUno = new AutoCompleteStringCollection();
            lstCliUno.AddRange(lstScn.ToArray());
            txtCdgScn.AutoCompleteCustomSource = lstCliUno;
            txtCdgScn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            #endregion

            #region autocompletado por nombre de socio de negocio
            txtNomScn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection lstNomUno = new AutoCompleteStringCollection();
            lstNomUno.AddRange(lstNom.ToArray());
            txtNomScn.AutoCompleteCustomSource = lstNomUno;
            txtNomScn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            #endregion
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numContra = string.Empty;
            string numCdgScn = string.Empty;
            string tipContra = string.Empty;

            
            frmCryReporteContrato frmVistaReporte = new frmCryReporteContrato();

            tipContra = cmbTipCnt.SelectedItem.ToString();
            numContra = txtCdgCnt.Text;
            numCdgScn = txtCdgScn.Text;

            if (busCarCnt(numContra, numCdgScn) > 1)
            {
                this.Size = new System.Drawing.Size(560, 411); 
                dgvDatos.Visible = true;
                carDatCnt(numContra, numCdgScn);
            }
            else if (busCarCnt(numContra, numCdgScn) == 1)
            {
                this.Size = new System.Drawing.Size(560, 211);
                dgvDatos.Visible = false;
                frmVistaReporte.numConsec = numCon;
                frmVistaReporte.tipContra = tipContra;
                frmVistaReporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay registros que mostrar");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //
            this.Size = new System.Drawing.Size(560, 211);
            dgvDatos.Visible = false;
            cmbTipCnt.SelectedIndex = 0;
            txtCdgCnt.Text = "";
            txtCdgScn.Text = "";
            txtNomScn.Text = "";
            dgvDatos.DataSource = null;
            cmbTipCnt.Focus();
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            //Busqueda de los Socios de Negocio en el TextBox
            #region lista deplegable del codigo del socio de negocio
            if (this.ActiveControl == txtCdgScn)
            {
                string valor = txtCdgScn.Text;
                if (txtCdgScn.Text == "")
                {
                    txtNomScn.Text = "";
                }
                else
                {
                    txtNomScn.Text = busSocNeg(lstSocNeg, valor, 0); // "";// libFil.nomSocio(lstSoc, valorEjemplo);
                }
            }
            #endregion
            #region lista desplegable del nombre del socio de negocio
            else if (this.ActiveControl == txtNomScn)
            {
                string valor = txtNomScn.Text;
                if (txtNomScn.Text == "")
                {
                    txtCdgScn.Text = "";
                }
                else
                {
                    txtCdgScn.Text = busSocNeg(lstSocNeg, valor, 1); // ""; // libFil.cdgSocio(lstSoc, valorEjemplo);
                }
            }
            #endregion
        }

        public string busSocNeg(List<clsSocNeg> lstSocne, string valor, int busqueda)
        {
            string result = string.Empty;
            if (busqueda == 0)
            {
                foreach (var x in lstSocne.Where(x => (x.scnCdgscn.ToUpper().Contains(valor.ToUpper()))))
                {
                    result = x.scnNomscn;
                }
            }
            else if (busqueda == 1)
            {
                foreach (var x in lstSocne.Where(x => (x.scnNomscn.ToUpper().Contains(valor.ToUpper()))))
                {
                    result = x.scnCdgscn;
                }
            }
            return result;
        }

        public void carSocNeg()
        {
            try
            {
                #region llenado de las lista para los socios de negocio
                using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionLocal))
                //using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionSAP))
                //using (SqlConnection conn = new SqlConnection("uid=Createga;pwd=Cr34tGA_15;data source=DB_SRVR1\\SAP;database=MLECJ_SIPJ_TEST_CREATEGA"))
                //using (SqlConnection conn = new SqlConnection("uid=sa;pwd=gcbdes;data source=GCBDEVELOPER\\GCBDEV;database=MLECH_SPI_TEST"))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select cli_keycli scnCdgscn, cli_nombfisc scnNomscn from cataclie where cli_tipocli = 'C'", conn))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                        foreach (DataRow ro in dt.Rows)
                        {
                            claSocNeg = new clsSocNeg();
                            claSocNeg.scnCdgscn = ro[0].ToString();
                            claSocNeg.scnNomscn = ro[1].ToString();
                            lstSocNeg.Add(claSocNeg);
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {

            }
        }

        public void carDatCnt(string numContra, string numCdgScn)
        {
            int result = 0;
            try
            {
                #region cargar el grid con los datos repetidos
                using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionLocal))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(" exec spPedDat '" + numContra + "', '" + numCdgScn + "'", conn))
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

        public int busCarCnt(string numContra, string numCdgScn)
        {
            int result = 0;
            try
            {
                #region llenado de las lista para los socios de negocio
                using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionLocal))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(" exec spPedCua '" + numContra + "', '" + numCdgScn + "'", conn))
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

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tipContra = string.Empty;
            tipContra = cmbTipCnt.SelectedItem.ToString();

            frmCryReporteContrato frmVistaReporte = new frmCryReporteContrato();
            frmVistaReporte.tipContra = tipContra;
            frmVistaReporte.numConsec = Convert.ToInt32(dgvDatos.Rows[e.RowIndex].Cells["clmCon"].Value.ToString());
            frmVistaReporte.ShowDialog();
        }

    }
}
