using AppPuntoVenta.Venta.Negocio;
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
    public partial class mdlFormaPago : Form
    {
        public mdlFormaPago()
        {
            InitializeComponent();
        }

        internal void CargarFormas(List<Entidades.ConfMetodo> AtajosMetodoPago)
        {
            dgvFormaPago.DataSource = AtajosMetodoPago;
            dgvFormaPago.ClearSelection();
        }

        public void mdlFormaPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            //Keys k = (Keys)Enum.Parse(typeof(Keys), "T");
            //if(e.Control && k == e.KeyCode)
            //{
            //   mdlDetallMetodoPago modalDetallePago = new mdlDetallMetodoPago();
            //   DialogResult resultado =  modalDetallePago.ShowDialog(); 
            //    if(resultado == DialogResult.OK)
            //    {
            //        //Agregar metodo y monto a la lista de metodos de pago de la venta.
            //    }
            //}

        }

        private string _teclaCtrl = "";
        public string TeclaCtrl
        {
            get
            {
                return _teclaCtrl;
            }
        }

        private string _teclaConfigurada = "";
        public string TeclaConfigurada
        {
            get
            {
                return _teclaConfigurada;
            }
        }

        private string _formaConfigurada = "";
        public string FormaConfigurada
        {
            get
            {
                return _formaConfigurada;
            }
        }

        private void dgvFormaPago_DoubleClick(object sender, EventArgs e)
        {
            _formaConfigurada = dgvFormaPago.SelectedRows[0].Cells[0].Value.ToString();
            _teclaCtrl = dgvFormaPago.SelectedRows[0].Cells[1].Value.ToString();
            _teclaConfigurada = dgvFormaPago.SelectedRows[0].Cells[2].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
         
        }
    }
}
