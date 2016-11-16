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
    public partial class mdlDolares : Form
    {
        public mdlDolares()
        {
            InitializeComponent();
            lblTipoCambio.Text = Sesion.CambioDolar.ToString("0.00");
        }

        public decimal CantidadDolares
        {
            get
            {
                decimal d = 0;
                if(decimal.TryParse(txtDolares.Text, out d))
                {
                    if(d < 0)
                    {
                        d = 0;
                    }
                }
                return d * decimal.Parse(lblTipoCambio.Text);
            }
        }

        private void mdlDolares_KeyUp(object sender, KeyEventArgs e)
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
