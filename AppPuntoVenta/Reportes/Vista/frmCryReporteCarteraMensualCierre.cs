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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SRATAPV.Reportes.Vista
{
    public partial class frmCryReporteCarteraMensualCierre : Form
    {
        public frmCryReporteCarteraMensualCierre()
        {
            InitializeComponent();
        }
        
        private string _centroCosto;
        private string _mes;
        private string _anio;
        private string _extra;

        public string centroCosto
        {
            get { return _centroCosto; }
            set { _centroCosto = value; }
        }
        public string mes
        {
            get { return _mes; }
            set { _mes = value; }
        }
        public string anio
        {
            get { return _anio; }
            set { _anio = value; }
        }
        public string extra
        {
            get { return _extra; }
            set { _extra = value; }
        }

        string fechaD, fechaH; 

        private void frmCryReporteCarteraMensualCierre_Load(object sender, EventArgs e)
        {
            if (mes == "1")
            {
                fechaD = "01/01/" + anio;
                fechaH = "31/01/" + anio;
            }
            else if (mes == "2")
            {
                fechaD = "01/02/" + anio;
                fechaH = Convert.ToDateTime("31/03/" + anio).AddMonths(-1).ToShortDateString();
            }
            else if (mes == "3")
            {
                fechaD = "01/03/" + anio;
                fechaH = "31/03/" + anio;
            }
            else if (mes == "4")
            {
                fechaD = "01/04/" + anio;
                fechaH = "30/04/" + anio;
            }
            else if (mes == "5")
            {
                fechaD = "01/05/" + anio;
                fechaH = "31/05/" + anio;
            }
            else if (mes == "6")
            {
                fechaD = "01/06/" + anio;
                fechaH = "30/06/" + anio;
            }
            else if (mes == "7")
            {
                fechaD = "01/07/" + anio;
                fechaH = "31/07/" + anio;
            }
            else if (mes == "8")
            {
                fechaD = "01/08/" + anio;
                fechaH = "31/08/" + anio;
            }
            else if (mes == "9")
            {
                fechaD = "01/09/" + anio;
                fechaH = "30/09/" + anio;
            }
            else if (mes == "10")
            {
                fechaD = "01/10/" + anio;
                fechaH = "31/10/" + anio;
            }
            else if (mes == "11")
            {
                fechaD = "01/11/" + anio;
                fechaH = "30/11/" + anio;
            }
            else if (mes == "12")
            {
                fechaD = "01/12/" + anio;
                fechaH = "31/12/" + anio;
            }

            reporte();
        }

        private void reporte()
        {
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

                    cryReporteCarteraMensualCierre cryRpt = new cryReporteCarteraMensualCierre();
                    TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                    ConnectionInfo crConnectionInfo = new ConnectionInfo();
                    Tables CrTables;

                    crConnectionInfo.ServerName = serverName;
                    crConnectionInfo.DatabaseName = databaseName;
                    crConnectionInfo.UserID = userId;
                    crConnectionInfo.Password = password;

                    CrTables = cryRpt.Database.Tables;
                    foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                    {
                        crtableLogoninfo = CrTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        CrTable.ApplyLogOnInfo(crtableLogoninfo);
                    }

                    cryRpt.SetParameterValue("centroCosto", centroCosto);
                    cryRpt.SetParameterValue("fechaD", fechaD);
                    cryRpt.SetParameterValue("fechaH", fechaH);
                    cryRpt.SetParameterValue("bdExtra", extra);

                    crvReporte.ReportSource = cryRpt;
                    crvReporte.Refresh();
                }
            }
        }
    }
}
