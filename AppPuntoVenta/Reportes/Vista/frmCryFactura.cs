using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRATAPV.Reportes.Reporte;

namespace SRATAPV.Reportes.Vista
{
    public partial class frmCryFactura : Form
    {
        public frmCryFactura()
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

        private void frmCryFactura_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = _dsFactura;
            cryFactura _reporte = new cryFactura();
            _reporte.SetDataSource(ds);
            crvFactura.ReportSource = _reporte;
            if (ruta != "")
            {
                _reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, ruta + uuid + "T.pdf");
            }
        }
    }
}
