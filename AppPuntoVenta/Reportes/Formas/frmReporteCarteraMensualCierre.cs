using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRATAPV.Reportes.Negocio;
using SRATAPV.Configuracion.Negocio;
using SRATAPV.Reportes.Vista;

namespace SRATAPV.Reportes.Formas
{
    public partial class frmReporteCarteraMensualCierre : Form
    {
        public frmReporteCarteraMensualCierre()
        {
            InitializeComponent();
        }

        private void frmReporteCarteraMensualCierre_Load(object sender, EventArgs e)
        {
            cmbMes.SelectedIndex = DateTime.Now.Month - 2;
            txtAnio.Text = DateTime.Now.Year.ToString();
            cargarCentrosCosto();
        }

        private void cargarCentrosCosto()
        {
            DataSet ds = new DataSet();
            clsReportesCalidadCartera consulta = new clsReportesCalidadCartera();
            consulta.active = "Y";
            try
            {
                ds = consulta.leerCentrosCosto();
                if (ds != null)
                {
                    cmbCentroCosto.DisplayMember = "PrcName";
                    cmbCentroCosto.ValueMember = "PrcCode";
                    cmbCentroCosto.DataSource = ds.Tables[0].DefaultView;
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("No se pudieron mostrar los centros de costo - " + consulta.mensaje);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            cmbCentroCosto.SelectedIndex = 0;
            cmbMes.SelectedIndex = DateTime.Now.Month - 2;
            txtAnio.Text = DateTime.Now.Year.ToString();
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAnio_Leave(object sender, EventArgs e)
        {
            if (txtAnio.Text.Trim() != "")
            {
                if (Convert.ToDecimal(txtAnio.Text.Trim()) <= 2000 || Convert.ToDecimal(txtAnio.Text.Trim()) >= 2200)
                {
                    txtAnio.Text = DateTime.Now.Year.ToString();
                }
            }
            else
            {
                txtAnio.Text = DateTime.Now.Year.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar() 
        {
            bool usaExtra;
            string extra = "";
            clsConfiguracion conf = new clsConfiguracion();
            DataSet configuracion = new DataSet();
            configuracion = conf.LeerConfiguracion();
            if (configuracion != null)
            {
                if (configuracion.Tables.Count > 0)
                {
                    usaExtra = Convert.ToBoolean(configuracion.Tables[0].Rows[0]["par_sapDbExtra"].ToString());
                    if (usaExtra)
                    {
                        extra = configuracion.Tables[0].Rows[0]["par_sapDbNombre"].ToString();
                    }
                }
            }

            frmCryReporteCarteraMensualCierre reporte = new frmCryReporteCarteraMensualCierre();
            reporte.centroCosto = cmbCentroCosto.SelectedValue.ToString();
            reporte.mes = (cmbMes.SelectedIndex + 1).ToString();
            reporte.anio = txtAnio.Text;
            reporte.extra = extra;

            reporte.Show();
        }
    }
}
