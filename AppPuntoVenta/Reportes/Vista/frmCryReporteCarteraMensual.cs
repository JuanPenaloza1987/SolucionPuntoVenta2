using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using SRATAPV.Configuracion.Negocio;
using CrystalDecisions.CrystalReports.Engine;
using SRATAPV.Reportes.Reporte;

namespace SRATAPV.Reportes.Vista
{
    public partial class frmCryReporteCarteraMensual : Form
    {
        public frmCryReporteCarteraMensual()
        {
            InitializeComponent();
        }

        private string _centroCosto;
        private string _coordinadorD;
        private string _coordinadorH;
        private string _mes;
        private string _anio;
        private string _tipo;
        private string _extra;
        private string _tipoDesglose;

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
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string extra
        {
            get { return _extra; }
            set { _extra = value; }
        }
        public string tipoDesglose
        {
            get { return _tipoDesglose; }
            set { _tipoDesglose = value; }
        }

        string fechaD, fechaH;        

        private void frmCryReporteCarteraMensual_Load(object sender, EventArgs e)
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

            //-----------------------------------------

            if (tipo == "Desglose")
            {
                crvDesglose.Visible = true;
                crvDesglose.Dock = DockStyle.Fill;
                if (tipoDesglose == "Agrupado")
                {
                    reporteDesglose();
                }
                else 
                {
                    reporteDesglose();
                }
            }
            else if (tipo == "Mes")
            {
                crvMes.Visible = true;
                crvMes.Dock = DockStyle.Fill;
                reporteMensual();
            }
            else if (tipo == "Coordinador")
            {
                crvCoordinador.Visible = true;
                crvCoordinador.Dock = DockStyle.Fill;
                reporteCoordinador();
            }
        }

        private void reporteDesglose() 
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

                    cryReporteCarteraMensualDesglose cryRpt = new cryReporteCarteraMensualDesglose();
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

                    crvDesglose.ReportSource = cryRpt;
                    crvDesglose.Refresh();
                }
            }
        }
        
        private void reporteDesglosePorMes()
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

                    cryReporteCarteraMensualDesglose cryRpt = new cryReporteCarteraMensualDesglose();
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

                    crvDesglose.ReportSource = cryRpt;
                    crvDesglose.Refresh();
                }
            }
        }
        private void reporteMensual() 
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

                    cryReporteCarteraMensualMes cryRpt = new cryReporteCarteraMensualMes();
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

                    crvMes.ReportSource = cryRpt;
                    crvMes.Refresh();
                }
            }
        }

        private void reporteCoordinador() 
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

                    cryReporteCarteraMensualCoordinador cryRpt = new cryReporteCarteraMensualCoordinador();
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

                    crvCoordinador.ReportSource = cryRpt;
                    crvCoordinador.Refresh();
                }
            }
        }
    }
}
