using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SRATAPV.Utilerias;
using SRATAPV.Reportes.Vista;

namespace SRATAPV.Reportes.Formas
{
    public partial class frmReporteEstadisticas : Form
    {
        public frmReporteEstadisticas()
        {
            InitializeComponent();
        }

        public static DataTable dt = null;

        private void frmReporteEstadisticas_Load(object sender, EventArgs e)
        {
            llenadoCombos();
        }

        public void llenadoCombos()
        {
            //"GCBDEVELOPER\\GCBDEV", "MLECH_SPI_TEST"
            #region llenado de los centros de costos
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionSAP))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select PrcCode, PrcName from OPRC where Locked = 'N' union all select 'Todos', 'Todos'", conn))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                        cmbCntce.DataSource = dt;
                        cmbCntce.ValueMember = "PrcCode";
                        cmbCntce.DisplayMember = "PrcName";
                    }
                }
            }
            catch (Exception ex)
            {

            }
            #endregion
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbCntce.Text == "" || cmbMeses.Text == "" || cmbAñoss.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos para poder continuar.");
            }
            else
            {
                //Generar reporte
                frmCryReporteEstadisticas frmVistaReporte = new frmCryReporteEstadisticas();
                frmVistaReporte.cdgCntCos = cmbCntce.SelectedValue.ToString();
                frmVistaReporte.numMes = Convert.ToInt32(cmbMeses.SelectedIndex + 1);
                frmVistaReporte.numAño = Convert.ToInt32(cmbAñoss.SelectedItem);
                frmVistaReporte.ShowDialog();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cmbCntce.SelectedIndex = 0;
            cmbMeses.SelectedIndex = 0;
            cmbAñoss.SelectedIndex = 0;
        }
    }
}
