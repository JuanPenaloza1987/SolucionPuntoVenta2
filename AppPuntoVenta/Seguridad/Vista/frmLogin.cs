using SRATAPV.Seguridad.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPuntoVenta.Seguridad.Vista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            leerAlmacenes();
            leerCuentaContableCentroCostos();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (cmbAlmacen.SelectedIndex == -1)
            {
                MessageBox.Show("Se debe seleccionar un Almacen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Sesion.Almacen = cmbAlmacen.SelectedValue.ToString();
                clsLogin cLogin = new clsLogin();
                cLogin.usuario = txtUsuario.Text;
                cLogin.pwd = txtContrasena.Text;

                string mensaje = "";
                try
                {
                    if (cLogin.autentificar())
                    {
                        clsUsuarios cUsuario = new clsUsuarios();
                        DataTable usuario = cUsuario.leerUnicoUsuario(txtUsuario.Text).Tables[0];
                        Sesion.Usuario = usuario.Rows[0][0].ToString();
                        Sesion.NombreUsuario = usuario.Rows[0][2].ToString();

                        Sesion.Permisos = cLogin.leerPermisosPorUsuario(txtUsuario.Text);
                        DialogResult = DialogResult.OK;
                        if (Sesion.Permisos.Count == 0)
                        {
                            MessageBox.Show("El usuario no tiene permisos asignados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El usuario y/o contraseña son incorrectos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public class valAlmacenes {
            public string val { get;  set; }
            public string nom { get; set; }
        }

        void leerAlmacenes()
        {
            clsLogin almacen = new clsLogin();
            DataSet datos = new DataSet();
            datos = almacen.leerAlmacenes();

            if (datos != null && datos.Tables.Count > 0)
            {
                cmbAlmacen.ValueMember = "alm_keyalm";
                cmbAlmacen.DisplayMember = "alm_nombre";
                cmbAlmacen.DataSource = datos.Tables[0].DefaultView;
                cmbAlmacen.SelectedValue = -1;
            }
            else if (!string.IsNullOrEmpty(almacen.mensaje))
                MessageBox.Show(almacen.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void leerCuentaContableCentroCostos()
        {
            clsLogin dat = new clsLogin();
            DataSet datos = new DataSet();
            datos = dat.leerCuentaContableCentroCostos();

            if (datos != null && datos.Tables.Count > 0)
            {
                foreach (DataRow item in datos.Tables[0].Rows)
                {
                    Sesion.CuentaContable = item["par_cuenta"].ToString();
                    Sesion.CentroCostos = item["par_PrcCode"].ToString();
                    Sesion.Serie = item["par_serie"].ToString();
                }
            }
            else if (!string.IsNullOrEmpty(dat.mensaje))
                MessageBox.Show(dat.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
