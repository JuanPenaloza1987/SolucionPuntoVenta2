using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRATAPV.Reportes.Negocio;
using SRATAPV.Reportes.Vista;
using SRATAPV.Configuracion.Negocio;

namespace SRATAPV.Reportes.Formas
{
    public partial class frmReporteCarteraSemanal : Form
    {
        public frmReporteCarteraSemanal()
        {
            InitializeComponent();
        }

        private void frmReporteCarteraSemanal_Load(object sender, EventArgs e)
        {
            dtpHasta.Value = DateTime.Now.AddDays(6);
            cargarCentrosCosto();
            cargarCoordinadoresD();
            cargarCoordinadoresH();
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

        private void cargarCoordinadoresD()
        {
            DataSet ds = new DataSet();
            clsReportesCalidadCartera consulta = new clsReportesCalidadCartera();
            consulta.active = "Y";
            try
            {
                ds = consulta.leerCoordinadores();
                if (ds != null)
                {
                    cmbCoordinadorD.DisplayMember = "Memo";
                    cmbCoordinadorD.ValueMember = "Memo";
                    cmbCoordinadorD.DataSource = ds.Tables[0].DefaultView;
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("No se pudieron mostrar los coordinadores - " + consulta.mensaje);
            }
        }

        private void cargarCoordinadoresH()
        {
            DataSet ds = new DataSet();
            clsReportesCalidadCartera consulta = new clsReportesCalidadCartera();
            consulta.active = "Y";
            try
            {
                ds = consulta.leerCoordinadores();
                if (ds != null)
                {
                    cmbCoordinadorH.DisplayMember = "Memo";
                    cmbCoordinadorH.ValueMember = "Memo";
                    cmbCoordinadorH.DataSource = ds.Tables[0].DefaultView;
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("No se pudieron mostrar los coordinadores - " + consulta.mensaje);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now.AddDays(6);
            cmbCentroCosto.SelectedIndex = 0;
            cmbCoordinadorD.SelectedIndex = 0;
            cmbCoordinadorH.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
                    if(usaExtra)
                    {
                        extra = configuracion.Tables[0].Rows[0]["par_sapDbNombre"].ToString();
                    }
                }
            }
 
            frmCryReporteCarteraSemanal reporte = new frmCryReporteCarteraSemanal();
            reporte.centroCosto = cmbCentroCosto.SelectedValue.ToString();
            reporte.coordinadorD = cmbCoordinadorD.SelectedValue.ToString();
            reporte.coordinadorH = cmbCoordinadorH.SelectedValue.ToString();
            reporte.fechaD = dtpDesde.Value.ToString("dd/MM/yyyy");
            reporte.fechaH = dtpHasta.Value.ToString("dd/MM/yyyy");
            reporte.extra = extra;

            reporte.Show();
        }
    }
}
