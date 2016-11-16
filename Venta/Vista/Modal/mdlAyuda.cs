using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppPuntoVenta.Venta.Vista.Modal
{
    public partial class mdlAyuda : Form
    {
        public mdlAyuda()
        {
            InitializeComponent();
        }

        private void mdlAyuda_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
            }
        }
    }
}
