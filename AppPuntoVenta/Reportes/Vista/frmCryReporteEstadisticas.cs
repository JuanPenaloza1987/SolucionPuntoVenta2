﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using SRATAPV.Configuracion.Negocio;
using SRATAPV.Reportes.Reporte;

namespace SRATAPV.Reportes.Vista
{
    public partial class frmCryReporteEstadisticas : Form
    {
        public frmCryReporteEstadisticas()
        {
            InitializeComponent();
        }

        public string cdgCntCos = string.Empty;
        public int numMes = 0;
        public int numAño = 0;

        private void frmCryReporteEstadisticas_Load(object sender, EventArgs e)
        {

        }

        private void crvRptEdo_Load(object sender, EventArgs e)
        {
            //ReportDocument crpReporte = new ReportDocument();
            ////configurasecion();
            //crpReporte.Load(Application.StartupPath.ToString() + @"\rptEstCob.rpt", OpenReportMethod.OpenReportByTempCopy);

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

                    rptEstCob crpReporte = new rptEstCob();

                    //crpReporte.DataSourceConnections[0].SetConnection("DB_SRVR1\\SAP", "MLECJ_SFFJ_TEST_CREATEGA2", false);
                    //crpReporte.DataSourceConnections[0].SetLogon("Createga", "Cr34tGA_15");
                    crpReporte.SetParameterValue(0, cdgCntCos);
                    crpReporte.SetParameterValue(1, numMes);
                    crpReporte.SetParameterValue(2, numAño);
                    crvRptEdo.ReportSource = crpReporte; // @"D:\rpttest.rpt";
                }
            }
        }

        private void SetDBLogonForReport(ConnectionInfo connectionInfo)
        {
            TableLogOnInfos tableLogOnInfos = crvRptEdo.LogOnInfo;
            foreach (TableLogOnInfo tableLogOnInfo in tableLogOnInfos)
            {
                tableLogOnInfo.ConnectionInfo = connectionInfo;
            }
        }

        public void configurasecion()
        {
            ConnectionInfo con = new ConnectionInfo();
            con.ServerName = "DB_SRVR1\\SAP"; // "GCBDEVELOPER\\GCBDEV"; // 
            con.DatabaseName = "MLECJ_SFFJ_TEST_CREATEGA"; // "MLECH_SPI_TEST"; // 
            con.UserID = "Createga"; // "sa"; // 
            con.Password = "Cr34tGA_15"; // "gcbde"; // 
            con.Type = ConnectionInfoType.Query;
            con.IntegratedSecurity = false;
            SetDBLogonForReport(con);
        }
    }
}
