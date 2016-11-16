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
    public partial class frmReporteEstadoCuenta : Form
    {
        public frmReporteEstadoCuenta()
        {
            InitializeComponent();
        }

        public class clsSocNeg
        {
            public string scnCdgscn { get; set; }
            public string scnNomscn { get; set; }
        }

        public static DataTable dt = null;

        clsSocNeg claSocNeg = new clsSocNeg();

        List<clsSocNeg> lstSocNeg = new List<clsSocNeg>(); 
        
        private void frmReporteEstadoCuenta_Load(object sender, EventArgs e)
        {
            //Cargar informacion
            carSocNeg();
            var lstScn = new List<string>();
            var lstNom = new List<string>();

            foreach (var items in lstSocNeg)
            {
                lstScn.Add(items.scnCdgscn);
                lstNom.Add(items.scnNomscn);
            }

            #region autocompletado por codigo de socio de negocio
            txtCdgUno.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection lstCliUno = new AutoCompleteStringCollection();
            lstCliUno.AddRange(lstScn.ToArray());
            txtCdgUno.AutoCompleteCustomSource = lstCliUno;
            txtCdgUno.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtCdgDos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection lstCliDos = new AutoCompleteStringCollection();
            lstCliDos.AddRange(lstScn.ToArray());
            txtCdgDos.AutoCompleteCustomSource = lstCliDos;
            txtCdgDos.AutoCompleteSource = AutoCompleteSource.CustomSource;
            #endregion

            #region autocompletado por nombre de socio de negocio
            txtNomUno.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection lstNomUno = new AutoCompleteStringCollection();
            lstNomUno.AddRange(lstNom.ToArray());
            txtNomUno.AutoCompleteCustomSource = lstNomUno;
            txtNomUno.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtNomDos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection lstNomDos = new AutoCompleteStringCollection();
            lstNomDos.AddRange(lstNom.ToArray());
            txtNomDos.AutoCompleteCustomSource = lstNomDos;
            txtNomDos.AutoCompleteSource = AutoCompleteSource.CustomSource;
            #endregion
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmCryReporteEstadoCuenta frmVistaReporte = new frmCryReporteEstadoCuenta();
            frmVistaReporte.cdgScnIni = txtCdgUno.Text;
            frmVistaReporte.cdgScnFin = txtCdgDos.Text;
            frmVistaReporte.fecgaCrte = dtpFecha.Value;
            frmVistaReporte.ShowDialog();
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            //Busqueda de los Socios de Negocio en el TextBox
            #region lista deplegable del codigo del socio de negocio
            if (this.ActiveControl == txtCdgUno)
            {
                string valor = txtCdgUno.Text;
                if (txtCdgUno.Text == "")
                {
                    txtNomUno.Text = "";
                }
                else
                {
                    txtNomUno.Text = busSocNeg(lstSocNeg, valor, 0); // "";// libFil.nomSocio(lstSoc, valorEjemplo);
                }
            }
            #endregion
            #region lista desplegable del nombre del socio de negocio
            else if (this.ActiveControl == txtNomUno)
            {
                string valor = txtNomUno.Text;
                if (txtNomUno.Text == "")
                {
                    txtCdgUno.Text = "";
                }
                else
                {
                    txtCdgUno.Text = busSocNeg(lstSocNeg, valor, 1); // ""; // libFil.cdgSocio(lstSoc, valorEjemplo);
                }
            }
            #endregion
            #region lista deplegable del codigo del socio de negocio
            if (this.ActiveControl == txtCdgDos)
            {
                string valor = txtCdgDos.Text;
                if (txtCdgDos.Text == "")
                {
                    txtNomDos.Text = "";
                }
                else
                {
                    txtNomDos.Text = busSocNeg(lstSocNeg, valor, 0); // "";// libFil.nomSocio(lstSoc, valorEjemplo);
                }
            }
            #endregion
            #region lista desplegable del nombre del socio de negocio
            else if (this.ActiveControl == txtNomDos)
            {
                string valor = txtNomDos.Text;
                if (txtNomDos.Text == "")
                {
                    txtCdgDos.Text = "";
                }
                else
                {
                    txtCdgDos.Text = busSocNeg(lstSocNeg, valor, 1); // ""; // libFil.cdgSocio(lstSoc, valorEjemplo);
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
                using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionSAP))
                //using (SqlConnection conn = new SqlConnection("uid=Createga;pwd=Cr34tGA_15;data source=DB_SRVR1\\SAP;database=MLECJ_SIPJ_TEST_CREATEGA"))
                //using (SqlConnection conn = new SqlConnection("uid=sa;pwd=gcbdes;data source=GCBDEVELOPER\\GCBDEV;database=MLECH_SPI_TEST"))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select CardCode scnCdgscn, CardName scnNomscn from OCRD where CardType = 'C' and validFor = 'Y'", conn))
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
    }
}
