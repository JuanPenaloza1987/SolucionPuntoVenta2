using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SRATAPV.Reportes.Vista
{
    public partial class frmRepCorte : Form
    {
        public frmRepCorte()
        {
            InitializeComponent();
        }
        private DataSet _dsCorteCaja = new DataSet();
        public DataSet dsCorteCaja
        {
            get { return _dsCorteCaja; }
            set { _dsCorteCaja = value; }
        }

        private void frmRepCorte_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = _dsCorteCaja;

                ReportDataSource reportDataSourceCorte = new ReportDataSource();
                reportDataSourceCorte.Name = "dtCorte";
                reportDataSourceCorte.Value = ds.Tables["dtCorte"];

                ReportDataSource reportDataSourceVentasCorte = new ReportDataSource();
                reportDataSourceVentasCorte.Name = "dtVentasCorte";
                reportDataSourceVentasCorte.Value = ds.Tables["dtVentasCorte"];

                reportViewer1.LocalReport.DataSources.Add(reportDataSourceVentasCorte);
                reportViewer1.LocalReport.DataSources.Add(reportDataSourceCorte);

                this.reportViewer1.RefreshReport();
            }
            catch { }
        }

    }
}
