using AppPuntoVenta.Configuraciones.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPuntoVenta.Configuraciones
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
            CargarInformacion();
        }

        string cajaSeleccionada = "";

        void CargarInformacion()
        {
            clsConfiguracion conf = new clsConfiguracion();
            DataSet datos = conf.ObtenerConfiguracionCaja();
            if (datos != null && datos.Tables[0].Rows.Count > 0)
            {
                txtCaja.Text = datos.Tables[0].Rows[0][0].ToString();
                txtImpresora.Text = datos.Tables[0].Rows[0][1].ToString();
                txtIp.Text = datos.Tables[0].Rows[0][2].ToString();
                txtMac.Text = datos.Tables[0].Rows[0][3].ToString();
                cajaSeleccionada = txtCaja.Text;
            }
            else
            {
                //var host = Dns.GetHostEntry(Dns.GetHostName());
                //var consultaIP = host.AddressList.Where(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                //if(consultaIP.Count() > 0)
                //{
                //    txtIp.Text = consultaIP.First().ToString();
                //}
                //else
                //{
                //    txtIp.Text = "";
                //}
            } 
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaja.Text))
            {
                MessageBox.Show("El campo de caja es obligatorio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool guardado = false;

            clsConfiguracion conf = new clsConfiguracion();
            conf.caj_descrip = txtCaja.Text;
            conf.caj_impres = txtImpresora.Text;
            conf.caj_ipMaq = txtIp.Text;
            conf.caj_macAdd = txtMac.Text;

            if (string.IsNullOrEmpty(cajaSeleccionada))
            {
                guardado = conf.GuardarConfiguracion();
            }
            else
            {
                guardado = conf.ActualizaConfiguracion(cajaSeleccionada);
            }

            if (!guardado)
            {
                MessageBox.Show("Ocurrio un error", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
