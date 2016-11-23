using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRATA.wfaDBs
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            tmrInicio.Start();
        }

        private void tmrInicio_Tick(object sender, EventArgs e)
        {            
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                terminarTimer();
            }
        }

        public void terminarTimer() {
            tmrInicio.Stop();
            Close();
        }

    }
}
