using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using SRATAPV.Reportes.Reporte;
using CrystalDecisions.CrystalReports.Engine;
using SRATAPV.Configuracion.Negocio;

namespace SRATAPV.Reportes.Vista
{
    public partial class frmCryReporteCarteraSemanal : Form
    {
        public frmCryReporteCarteraSemanal()
        {
            InitializeComponent();
        }

        private string _centroCosto;
        private string _coordinadorD;
        private string _coordinadorH;
        private string _fechaD;
        private string _fechaH;
        private string _extra;

        public string centroCosto
        {
            get { return _centroCosto; }
            set { _centroCosto = value; }
        }
        public string coordinadorD
        {
            get { return _coordinadorD; }
            set { _coordinadorD = value; }
        }
        public string coordinadorH
        {
            get { return _coordinadorH; }
            set { _coordinadorH = value; }
        }
        public string fechaD
        {
            get { return _fechaD; }
            set { _fechaD = value; }
        }
        public string fechaH
        {
            get { return _fechaH; }
            set { _fechaH = value; }
        }
        public string extra
        {
            get { return _extra; }
            set { _extra = value; }
        }

        private void SetDBLogonForReport(ConnectionInfo connectionInfo)
        {
            TableLogOnInfos tableLogOnInfos = crvReporte.LogOnInfo;

            foreach (TableLogOnInfo tableLogOnInfo in tableLogOnInfos)
            {
                tableLogOnInfo.ConnectionInfo = connectionInfo;
            }
        }

        private void frmCryReporteCarteraSemanal_Load(object sender, EventArgs e)
        {
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

                    cryReporteCarteraSemanal cryRpt = new cryReporteCarteraSemanal();
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
                    cryRpt.SetParameterValue("coordinadorD", coordinadorD);
                    cryRpt.SetParameterValue("coordinadorH", coordinadorH);
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
