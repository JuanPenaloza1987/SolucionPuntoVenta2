using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRATAPV.Reportes.Negocio;
using SRATAPV.Utilerias;

namespace SRATAPV.Reportes.Formas
{
    public partial class frmReporteVentasTotales : Form
    {
        public frmReporteVentasTotales()
        {
            InitializeComponent();
        }

        DataSet dsBusquedaSt = new DataSet();
        DataSet dsBusquedaSap = new DataSet();

        int GlobalDecImporte = Convert.ToInt32(Globals.Instance.DecimalesImporte);

        private void frmReporteVentasTotales_Load(object sender, EventArgs e)
        {
            DateTime fechatemp = DateTime.Today;
            dtpDesde.Value = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            dtpHasta.Value = new DateTime(fechatemp.Year, fechatemp.Month + 1, 1).AddDays(-1);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DateTime fechatemp = DateTime.Today;
            dtpDesde.Value = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            dtpHasta.Value = new DateTime(fechatemp.Year, fechatemp.Month + 1, 1).AddDays(-1);
            dgvVentasST.Rows.Clear();
            dgvVentasSAP.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvVentasST.Rows.Clear();
            buscarStrata();
            buscarSap();
        }

        private void buscarStrata()
        {
            clsReporteVentasTotales cls = new clsReporteVentasTotales();
            string fechaDesde = "", fechaHasta = "";

            fechaDesde = dtpDesde.Value.ToShortDateString();
            fechaHasta = dtpHasta.Value.ToShortDateString();
            
            cls.fechaDesde = fechaDesde;
            cls.fechaHasta = fechaHasta;
            cls.bdBitacora = Globals.Instance.CadenaConexionBitacora;
            cls.sucursal = Globals.Instance.sucursal;
            
            dsBusquedaSt = cls.leerVentaStrata();

            if (dsBusquedaSt != null)
            {
                if (dsBusquedaSt.Tables[0].Rows.Count > 0)
                {
                    cargaConsultaGridStrata(dsBusquedaSt);
                }
            }
        }

        private void cargaConsultaGridStrata(DataSet vent)
        {
            foreach (DataRow row in vent.Tables[0].Rows)
            {
                dgvVentasST.Rows.Add();
                dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["VentaST"].Value = row["VentaST"].ToString();
                dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["ClienteST"].Value = row["ClienteST"].ToString();
                dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["EstadoST"].Value = row["EstadoST"].ToString();
                dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["FechaST"].Value = row["FechaST"].ToString();

                if (row["TotalST"].ToString() == null || row["TotalST"].ToString() == string.Empty)
                {
                    dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["TotalST"].Value = deciImporte("0.000000");
                }
                else
                {
                    dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["TotalST"].Value = deciImporte(row["TotalST"].ToString());
                }

                if (row["TotalSinCanceladas"].ToString() == null || row["TotalSinCanceladas"].ToString() == string.Empty)
                {
                    dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["TotalSinCanceladas"].Value = deciImporte("0.000000");
                }
                else
                {
                    dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["TotalSinCanceladas"].Value = deciImporte(row["TotalSinCanceladas"].ToString());
                }

                dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["RefSAP"].Value = row["RefSAP"].ToString();

                if (row["Enviado"].ToString() == "1")
                {
                    dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["Enviado"].Value = true;
                }
                else
                {
                    dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["Enviado"].Value = false;
                }

                if (row["EnviadoBitacora"].ToString() == "1")
                {
                    dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["EnviadoBitacora"].Value = true;
                }
                else
                {
                    dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["EnviadoBitacora"].Value = false;
                }

                dgvVentasST.Rows[dgvVentasST.Rows.Count - 1].Cells["Sucursal"].Value = row["Sucursal"].ToString();                
            }
        }

        private void buscarSap()
        {
            clsReporteVentasTotales cls = new clsReporteVentasTotales();
            string fechaDesde = "", fechaHasta = "";

            fechaDesde = dtpDesde.Value.ToShortDateString();
            fechaHasta = dtpHasta.Value.ToShortDateString();

            cls.fechaDesde = fechaDesde;
            cls.fechaHasta = fechaHasta;
            cls.sucursal = Globals.Instance.sucursal;

            dsBusquedaSap = cls.leerVentaSap();

            if (dsBusquedaSap != null)
            {
                if (dsBusquedaSap.Tables[0].Rows.Count > 0)
                {
                    cargaConsultaGridSap(dsBusquedaSap);
                }
            }
        }

        private void cargaConsultaGridSap(DataSet vent)
        {
            foreach (DataRow row in vent.Tables[0].Rows)
            {
                dgvVentasSAP.Rows.Add();
                dgvVentasSAP.Rows[dgvVentasSAP.Rows.Count - 1].Cells["ReferenciaSap"].Value = row["ReferenciaSap"].ToString();
                dgvVentasSAP.Rows[dgvVentasSAP.Rows.Count - 1].Cells["FacturaSAP"].Value = row["FacturaSAP"].ToString();
                dgvVentasSAP.Rows[dgvVentasSAP.Rows.Count - 1].Cells["FechaSAP"].Value = row["FechaSAP"].ToString();


                if (row["TotalSAP"].ToString() == null || row["TotalSAP"].ToString() == string.Empty)
                {
                    dgvVentasSAP.Rows[dgvVentasSAP.Rows.Count - 1].Cells["TotalSAP"].Value = deciImporte("0.000000");
                }
                else
                {
                    dgvVentasSAP.Rows[dgvVentasSAP.Rows.Count - 1].Cells["TotalSAP"].Value = deciImporte(row["TotalSAP"].ToString());
                }

                dgvVentasSAP.Rows[dgvVentasSAP.Rows.Count - 1].Cells["RefST"].Value = row["RefST"].ToString();

                if (row["TotalNC_SAP"].ToString() == null || row["TotalNC_SAP"].ToString() == string.Empty)
                {
                    dgvVentasSAP.Rows[dgvVentasSAP.Rows.Count - 1].Cells["TotalNC_SAP"].Value = deciImporte("0.000000");
                }
                else
                {
                    dgvVentasSAP.Rows[dgvVentasSAP.Rows.Count - 1].Cells["TotalNC_SAP"].Value = deciImporte(row["TotalNC_SAP"].ToString());
                }

                if (row["TotalSinNota"].ToString() == null || row["TotalSinNota"].ToString() == string.Empty)
                {
                    dgvVentasSAP.Rows[dgvVentasSAP.Rows.Count - 1].Cells["TotalSinNota"].Value = deciImporte("0.000000");
                }
                else
                {
                    dgvVentasSAP.Rows[dgvVentasSAP.Rows.Count - 1].Cells["TotalSinNota"].Value = deciImporte(row["TotalSinNota"].ToString());
                }
            }
        }

        private string deciImporte(string cadena)
        {
            string numero;
            numero = Math.Round(Convert.ToDecimal(cadena), GlobalDecImporte).ToString();
            return numero;
        }

    }
}
