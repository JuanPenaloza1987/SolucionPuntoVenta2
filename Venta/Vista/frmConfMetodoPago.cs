using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppPuntoVenta.Venta.Vista
{
    public partial class frmConfMetodoPago : Form
    {
        public frmConfMetodoPago()
        {
            InitializeComponent();
        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {
            if(txtLetra.Text.Length > 1)
            {
                txtLetra.Text = txtLetra.Text[0].ToString();
            }
        }

        void CargarMetodoPago()
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        void Limpiar()
        {
            txtLetra.Text = "";
            cmbMEtodoPAgo.SelectedIndex = -1;
            dgvAtajo.ClearSelection();
        }

    }
}
