using AppPuntoVenta.Catalogos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPuntoVenta.Catalogos.Vista
{
    public partial class frmClienteCasual : Form
    {
        public frmClienteCasual()
        {
            InitializeComponent();
        }

        private bool _regresaRFC;

        public bool RegresaRFC
        {
            get { return _regresaRFC; }
            set { _regresaRFC = value; }
        }

        public string RFC
        {
            get { return txtrfc.Text; }
            set { txtrfc.Text = value; }
        }

        bool CamposValidos()
        {
            bool respuesta = true;
            if (string.IsNullOrEmpty(txtrfc.Text))
            {
                MessageBox.Show("El campo de RFC es obligatorio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                respuesta = false;
            }
            if (string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                MessageBox.Show("El campo de NOMBRE es obligatorio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                respuesta = false;
            }
            return respuesta;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!CamposValidos())
            {
                return;
            }
            clsClientes cCliente = new clsClientes();
            cCliente.clc_rfc = txtrfc.Text;
            cCliente.clc_tel = txtTelefono.Text;
            cCliente.clc_nomb = txtNombreCliente.Text;
            cCliente.clc_corr = txtCorreo.Text;
            cCliente.clc_direc = txtDireccion.Text;


            bool guardado = false;

            if (string.IsNullOrEmpty(lblIDCliente.Text))
            {
                guardado = cCliente.guardarCliente();
            }
            else
            {
                int idCliente = 0;
                int.TryParse(lblIDCliente.Text, out idCliente);
                cCliente.clc_id = idCliente;
                guardado = cCliente.ActualizarCliente();
            }
             
            if (guardado)
            {
                if (RegresaRFC)
                {
                    btnModificar.Enabled = true;
                    btnCrear.Visible = true;
                    CamposActivos(false);
                }
                else
                {
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Ocurrio un error", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            CamposActivos(true);
            btnModificar.Enabled = false;
            btnCrear.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CamposActivos(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        void Limpiar()
        {
            txtNombreCliente.Text = "";
            txtCorreo.Text = "";
            txtrfc.Text = "";
            txtTelefono.Text = "";
            lblIDCliente.Text = "";
            txtDireccion.Text = "";
            btnModificar.Enabled = false;
        }

        void CamposActivos(bool activos)
        {
            txtNombreCliente.Enabled = activos;
            txtCorreo.Enabled = activos;
            txtTelefono.Enabled = activos;
            txtDireccion.Enabled = activos;
        }

        private void txtrfc_Leave(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        void BuscarCliente()
        {
            if (!string.IsNullOrEmpty(txtrfc.Text))
            {
                clsClientes cCliente = new clsClientes();
                DataSet datos = cCliente.leerCliente(txtrfc.Text);
                if(datos != null && datos.Tables[0].Rows.Count > 0)
                {
                    DataRow cliente = datos.Tables[0].Rows[0];
                    txtNombreCliente.Text = cliente["clc_nomb"].ToString();
                    txtCorreo.Text = cliente["clc_corr"].ToString();
                    txtTelefono.Text = cliente["clc_tel"].ToString();
                    txtDireccion.Text = cliente["clc_direc"].ToString();
                    lblIDCliente.Text = cliente["clc_id"].ToString();
                    CamposActivos(false);
                    btnModificar.Enabled = RegresaRFC;
                    btnCrear.Visible = RegresaRFC;
                    //btnCancelar.Enabled = true;
                }
            }
        }
        
    }
}
