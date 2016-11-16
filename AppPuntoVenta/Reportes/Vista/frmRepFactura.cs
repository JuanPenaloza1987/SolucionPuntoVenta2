using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SRATAPV.Reportes.Vista
{
    public partial class frmRepFactura : Form
    {
        public frmRepFactura()
        {
            InitializeComponent();
        }

        private DataSet _dsFactura = new DataSet();
        public DataSet dsFactura
        {
            get { return _dsFactura; }
            set { _dsFactura = value; }
        }

        private string _ruta;
        public string ruta
        {
            get { return _ruta; }
            set { _ruta = value; }
        }

        private string _uuid;
        public string uuid
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        private void frmRepFactura_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = _dsFactura;

            ReportDataSource reportDataSourceFactura = new ReportDataSource();
            reportDataSourceFactura.Name = "Factura";
            reportDataSourceFactura.Value = ds.Tables["Factura"];

            ReportDataSource reportDataSourceCliente = new ReportDataSource();
            reportDataSourceCliente.Name = "Cliente";
            reportDataSourceCliente.Value = ds.Tables["Cliente"];

            ReportDataSource reportDataSourceEmpresa = new ReportDataSource();
            reportDataSourceEmpresa.Name = "Empresa";
            reportDataSourceEmpresa.Value = ds.Tables["Empresa"];

            ReportDataSource reportDataSourceDetalleFactura = new ReportDataSource();
            reportDataSourceDetalleFactura.Name = "DetalleFactura";
            reportDataSourceDetalleFactura.Value = ds.Tables["DetalleFactura"];
            
            rvwFactura.LocalReport.DataSources.Add(reportDataSourceFactura);
            rvwFactura.LocalReport.DataSources.Add(reportDataSourceCliente);
            rvwFactura.LocalReport.DataSources.Add(reportDataSourceEmpresa);
            rvwFactura.LocalReport.DataSources.Add(reportDataSourceDetalleFactura);
            
            //creadPDF();
            this.rvwFactura.RefreshReport();
        }

        private void creadPDF()
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = rvwFactura.LocalReport.Render("PDF", 
                                                          null,
                                                          out mimeType, 
                                                          out encoding, 
                                                          out filenameExtension,
                                                          out streamids, 
                                                          out warnings);

            using (FileStream fs = new FileStream(ruta + uuid + "T.pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }





    }
}
