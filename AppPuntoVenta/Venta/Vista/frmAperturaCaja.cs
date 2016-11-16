using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using SRATAPV.Seguridad.Negocio;
using SRATAPV.Ventas.Negocio;
using SRATAPV.Seguridad.Negocio;
using AppPuntoVenta.Configuraciones.Negocio;
using AppPuntoVenta;

namespace SRATAPV.Ventas.Vista
{
    public partial class frmAperturaCaja : Form
    {
        public frmAperturaCaja()
        {
            InitializeComponent();
        }

        private void frmAperturaCaja_Load(object sender, EventArgs e)
        {
            txtCajero.Text = Sesion.Usuario;
            TraerCaja();
        }
      
        void TraerCaja()
        {
            clsConfiguracion conf = new clsConfiguracion();
            DataSet datos = conf.ObtenerConfiguracionCaja();
            if (datos != null && datos.Tables[0].Rows.Count > 0)
            {
                txtCaja.Text = datos.Tables[0].Rows[0][0].ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (valida())
            { 
                guardar(); 
            }
        }

        private void guardar()
        {
            clsCorte corte = new clsCorte();
            corte.cor_keyusr = txtCajero.Text;
            corte.cor_fechInic=DateTime.Now;
            corte.cor_fondocaj=txtFondoCaja.Text;
            corte.cor_estado="Abierto";
            if (corte.GuardarCorte())
            {
                MessageBox.Show("Apertura almacenada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Sesion.CodigoCorte = corte.cor_keycor;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error de almacenamiento: "+corte.mensaje,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private bool valida()
        {
            bool esvalido = true;
            string mensaje = "";
            if (txtCajero.Text == "")
            {
                mensaje += "Se debe de seleccionar un usuario. ";
                esvalido = false;
            }
            if(txtCaja.Text=="")
            {
                mensaje += "Se debe de seleccionar una caja. ";
                esvalido = false;
            }
            try
            {
                Convert.ToDecimal(txtFondoCaja.Text);
            }
            catch 
            {
                mensaje += "El fondo de caja debe ser valido. ";
                esvalido = false;

            }
            clsCorte existecorte = new clsCorte();
            existecorte.cor_keyusr = txtCajero.Text;
            if (existecorte.leerExisteCorte(Sesion.Usuario))
            {
                mensaje += "Existe un fondo de caja. ";
                esvalido = false;

            }
            if (!esvalido)
            {
                MessageBox.Show(mensaje,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            return esvalido;
            
        }
    }
}

