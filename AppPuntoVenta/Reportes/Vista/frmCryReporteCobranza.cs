using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRATAPV.Configuracion.Negocio;
using SRATAPV.Reportes.Reporte;

namespace SRATAPV.Reportes.Vista
{
    public partial class frmCryReporteCobranza : Form
    {
        public frmCryReporteCobranza()
        {
            InitializeComponent();
        }

        public string cntcst = string.Empty;
        public string tippag = string.Empty;
        public int series = 0;
        public int opcion = 0;
        public int formato = 0;
        public DateTime fecgaCrt1;
        public DateTime fecgaCrt2;

        private void frmCryReporteCobranza_Load(object sender, EventArgs e)
        {

        }

        private void crvRptEdo_Load(object sender, EventArgs e)
        {
            //ReportDocument crpReporte = new ReportDocument();

            string serverName, databaseName, userId, password;
            clsSucursales conexion = new clsSucursales();
            DataSet configuracion = new DataSet();
            conexion.tipo = "Sap";
            configuracion = conexion.leerUnicaConexion();
            if (configuracion != null)
            {
                if (configuracion.Tables.Count > 0)
                {
                    serverName = configuracion.Tables[0].Rows[0]["sucu_LocalBdservi"].ToString();
                    databaseName = configuracion.Tables[0].Rows[0]["sucu_LocalBdnomb"].ToString();
                    userId = configuracion.Tables[0].Rows[0]["sucu_LocalBduser"].ToString();
                    password = configuracion.Tables[0].Rows[0]["sucu_LocalBdcontr"].ToString();

                    try
                    {
                        switch (opcion)
                        {
                            case 1:
                                if (formato == 1)
                                {
                                    //crpReporte.Load(Application.StartupPath.ToString() + @"\rptCbrImd.rpt", OpenReportMethod.OpenReportByTempCopy);
                                    rptCbrImp crpReporte = new rptCbrImp();
                                    crpReporte.DataSourceConnections[0].SetConnection(serverName, databaseName, false);
                                    crpReporte.DataSourceConnections[0].SetLogon(userId, password);
                                    crpReporte.SetParameterValue(0, cntcst);
                                    //crpReporte.SetParameterValue(1, series);
                                    crpReporte.SetParameterValue(1, tippag);
                                    crpReporte.SetParameterValue(2, fecgaCrt1.ToShortDateString());
                                    crpReporte.SetParameterValue(3, fecgaCrt2.ToShortDateString());
                                    crvRptEdo.ReportSource = crpReporte; // @"D:\rpttest.rpt";
                                }
                                else
                                {
                                    //crpReporte.Load(Application.StartupPath.ToString() + @"\rptCbrImd.rpt", OpenReportMethod.OpenReportByTempCopy);
                                    rptCbrImd crpReporte = new rptCbrImd();
                                    crpReporte.DataSourceConnections[0].SetConnection(serverName, databaseName, false);
                                    crpReporte.DataSourceConnections[0].SetLogon(userId, password);
                                    crpReporte.SetParameterValue(0, cntcst);
                                    //crpReporte.SetParameterValue(1, series);
                                    crpReporte.SetParameterValue(1, tippag);
                                    crpReporte.SetParameterValue(2, fecgaCrt1.ToShortDateString());
                                    crpReporte.SetParameterValue(3, fecgaCrt2.ToShortDateString());
                                    crvRptEdo.ReportSource = crpReporte; // @"D:\rpttest.rpt";
                                }
                                break;
                            case 2:
                                if (formato == 1)
                                {
                                    //crpReporte.Load(Application.StartupPath.ToString() + @"\rptCbrRes.rpt", OpenReportMethod.OpenReportByTempCopy);
                                    rptCbrRes crpReporte = new rptCbrRes();
                                    crpReporte.DataSourceConnections[0].SetConnection(serverName, databaseName, false);
                                    crpReporte.DataSourceConnections[0].SetLogon(userId, password);
                                    crpReporte.SetParameterValue(0, cntcst);
                                    //crpReporte.SetParameterValue(1, series);
                                    crpReporte.SetParameterValue(1, tippag);
                                    crpReporte.SetParameterValue(2, fecgaCrt1.ToShortDateString());
                                    crpReporte.SetParameterValue(3, fecgaCrt2.ToShortDateString());
                                    crvRptEdo.ReportSource = crpReporte; // @"D:\rpttest.rpt";
                                }
                                else
                                {
                                    //crpReporte.Load(Application.StartupPath.ToString() + @"\rptCbrRed.rpt", OpenReportMethod.OpenReportByTempCopy);
                                    rptCbrRed crpReporte = new rptCbrRed();
                                    crpReporte.DataSourceConnections[0].SetConnection(serverName, databaseName, false);
                                    crpReporte.DataSourceConnections[0].SetLogon(userId, password);
                                    crpReporte.SetParameterValue(0, cntcst);
                                    //crpReporte.SetParameterValue(1, series);
                                    crpReporte.SetParameterValue(1, tippag);
                                    crpReporte.SetParameterValue(2, fecgaCrt1.ToShortDateString());
                                    crpReporte.SetParameterValue(3, fecgaCrt2.ToShortDateString());
                                    crvRptEdo.ReportSource = crpReporte; // @"D:\rpttest.rpt";
                                }
                                break;
                            case 3:
                                if (formato == 1)
                                {
                                    //crpReporte.Load(Application.StartupPath.ToString() + @"\rptCanRes.rpt", OpenReportMethod.OpenReportByTempCopy);
                                    rptCanRes crpReporte = new rptCanRes();
                                    crpReporte.DataSourceConnections[0].SetConnection(serverName, databaseName, false);
                                    crpReporte.DataSourceConnections[0].SetLogon(userId, password);
                                    crpReporte.SetParameterValue(0, cntcst);
                                    //crpReporte.SetParameterValue(1, series);
                                    crpReporte.SetParameterValue(1, tippag);
                                    crpReporte.SetParameterValue(2, fecgaCrt1.ToShortDateString());
                                    crpReporte.SetParameterValue(3, fecgaCrt2.ToShortDateString());
                                    crvRptEdo.ReportSource = crpReporte; // @"D:\rpttest.rpt";
                                }
                                else
                                {
                                    //crpReporte.Load(Application.StartupPath.ToString() + @"\rptCanRed.rpt", OpenReportMethod.OpenReportByTempCopy);
                                    rptCanRed crpReporte = new rptCanRed();
                                    crpReporte.DataSourceConnections[0].SetConnection(serverName, databaseName, false);
                                    crpReporte.DataSourceConnections[0].SetLogon(userId, password);
                                    crpReporte.SetParameterValue(0, cntcst);
                                    //crpReporte.SetParameterValue(1, series);
                                    crpReporte.SetParameterValue(1, tippag);
                                    crpReporte.SetParameterValue(2, fecgaCrt1.ToShortDateString());
                                    crpReporte.SetParameterValue(3, fecgaCrt2.ToShortDateString());
                                    crvRptEdo.ReportSource = crpReporte; // @"D:\rpttest.rpt";
                                }
                                break;
                        }
                        //crpReporte.DataSourceConnections[0].SetConnection(serverName, databaseName, false);
                        //crpReporte.DataSourceConnections[0].SetLogon(userId, password);
                        //crpReporte.SetParameterValue(0, cntcst);
                        //crpReporte.SetParameterValue(1, series);
                        //crpReporte.SetParameterValue(2, tippag);
                        //crpReporte.SetParameterValue(3, fecgaCrte.ToShortDateString());
                        //crvRptEdo.ReportSource = crpReporte; // @"D:\rpttest.rpt";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

    }
}
