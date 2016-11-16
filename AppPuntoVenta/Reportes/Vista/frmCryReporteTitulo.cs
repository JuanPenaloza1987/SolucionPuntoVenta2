using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using SRATAPV.Reportes.Reporte;
using SRATAPV.Configuracion.Negocio;
using SRATAPV.Utilerias;


namespace SRATAPV.Reportes.Vista
{
    public partial class frmCryReporteTitulo : Form
    {
        public int numConsec = 0;

        public frmCryReporteTitulo()
        {
            InitializeComponent();
        }

        private void crvRptEdo_Load(object sender, System.EventArgs e)
        {
            //ReportDocument crpReporte = new ReportDocument();
            //configurasecion();
            //crpReporte.Load(Application.StartupPath.ToString() + @"\rptEdoCta.rpt", OpenReportMethod.OpenReportByTempCopy);
            string serverName, databaseName, userId, password;
            clsSucursales conexion = new clsSucursales();
            DataSet configuracion = new DataSet();
            conexion.tipo = "Local";
            configuracion = conexion.leerUnicaConexion();
            if (configuracion != null)
            {
                if (configuracion.Tables.Count > 0)
                {
                    serverName = configuracion.Tables[0].Rows[0]["sucu_LocalBdservi"].ToString();
                    databaseName = configuracion.Tables[0].Rows[0]["sucu_LocalBdnomb"].ToString();
                    userId = configuracion.Tables[0].Rows[0]["sucu_LocalBduser"].ToString();
                    password = configuracion.Tables[0].Rows[0]["sucu_LocalBdcontr"].ToString();
                    string xgh = Globals.Instance.sucursal;

                    rptTitulo crpReporte = new rptTitulo();

                    //crpReporte.DataSourceConnections[0].SetConnection("DB_SRVR1\\SAP", "MLECJ_SFFJ_TEST_CREATEGA", false);
                    //crpReporte.DataSourceConnections[0].SetLogon("Createga", "Cr34tGA_15");
                    crpReporte.DataSourceConnections[0].SetConnection(serverName, databaseName, false);
                    crpReporte.DataSourceConnections[0].SetLogon(userId, password);
                    crpReporte.SetParameterValue(0, numConsec);
                    //crpReporte.SetParameterValue(1, "");
                    crvRptEdo.ReportSource = crpReporte; // @"D:\rpttest.rpt";
                }
            }
        }
    }
}
