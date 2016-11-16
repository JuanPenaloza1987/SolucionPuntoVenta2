using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRATAPV.Utilerias;
using SRATAPV.Busquedas.Vista;
using SRATAPV.Catalogos.Negocio;
using SRATAPV.Reportes.Negocio;

namespace SRATAPV.Reportes.Formas
{
    public partial class frmReporteExtras : Form
    {
        public frmReporteExtras()
        {
            InitializeComponent();
        }

        DataSet dsCliente = new DataSet();
        DataSet dsBusqueda = new DataSet();

        int GlobalDecImporte = Convert.ToInt32(Globals.Instance.DecimalesImporte);

        string codigoCliente;


        private void frmReportePlacas_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-7);
            comboExtras();
            cmbEstado.SelectedIndex = 0;
        }

        private void comboExtras()
        {
            clsClientes cabecerasExtra = new clsClientes();
            DataSet Cabeceras = new DataSet();
            Cabeceras = cabecerasExtra.leerCabecerasExtras();

            DataSet extra = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Cabecera");
            dt.Columns.Add("Descripcion");


            if (Cabeceras != null)
            {
                if (Cabeceras.Tables.Count > 0)
                {
                    for (int y = 0; y < Cabeceras.Tables[0].Columns.Count; y++)
                    {
                        if (Cabeceras.Tables[0].Rows[0][y].ToString().Trim() != "")
                        {
                            DataRow row = dt.NewRow();

                            row[0] = "ven2_extra" + (y + 1);
                            row[1] = Cabeceras.Tables[0].Rows[0][y].ToString().Trim();
                            dt.Rows.Add(row);
                        }
                        else 
                        {
                            dgvVentas.Columns["ven2_extra" + (y + 1)].Visible = false;
                        }
                    }
                    extra.Tables.Add(dt);

                    cmbExtra.DisplayMember = "Descripcion";
                    cmbExtra.ValueMember = "Cabecera";
                    cmbExtra.DataSource = extra.Tables[0].DefaultView;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtExtra.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            dtpDesde.Value = DateTime.Now.AddDays(-7);
            dtpHasta.Value = DateTime.Now;
            if (dsBusqueda.Tables.Count > 0)
            {
                dsBusqueda.Tables[0].Rows.Clear();
            }
            dgvVentas.Rows.Clear();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            frmBuscarClientes buscar = new frmBuscarClientes();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                limpiar();
                dsCliente = buscar.consulta;
                cargaDatosClientes();
            }  
        }

        private void cargaDatosClientes()
        {
            txtCliente.Text = dsCliente.Tables[0].Rows[0]["cli_keycli"].ToString();
            txtNombre.Text = dsCliente.Tables[0].Rows[0]["cli_nombfisc"].ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvVentas.Rows.Clear();
            buscar();
        }

        private void buscar()
        {
            clsReporteExtras cls = new clsReporteExtras();
            string tipoExtra = "", extra = "", cliente = "", fechaDesde = "", fechaHasta = "";

            if (rdbExtra.Checked)
            {
                tipoExtra = cmbExtra.SelectedValue.ToString();
                extra = txtExtra.Text;
                cliente = "";
                fechaDesde = "";
                fechaHasta = "";
            }
            else if (rdbCliente.Checked)
            {
                tipoExtra = "";
                extra = "";
                cliente = txtCliente.Text.Trim();
                fechaDesde = "";
                fechaHasta = "";
            }
            else if (rdbFecha.Checked)
            {
                tipoExtra = "";
                extra = "";
                cliente = "";
                fechaDesde = dtpDesde.Value.ToShortDateString();
                fechaHasta = dtpHasta.Value.AddDays(1).ToShortDateString();
            }

            cls.tipoExtra = tipoExtra;
            cls.extra = extra;
            cls.cliente = cliente;
            cls.fecdesde = fechaDesde;
            cls.fechasta = fechaHasta;
            cls.estado = cmbEstado.Text;

            dsBusqueda = cls.leerReporte();

            if (extra == "" && cliente == "" & fechaDesde == "" && fechaHasta == "")
            {
                MessageBox.Show("Debe llenar por lo menos un filtro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dsBusqueda.Tables[0].Rows.Count > 0)
                {
                    cargaConsultaGrid(dsBusqueda);
                }
            }
        }

        private void cargaConsultaGrid(DataSet vent)
        {
            foreach (DataRow row in vent.Tables[0].Rows)
            {
                dgvVentas.Rows.Add();

                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven_cliente"].Value = row["ven_cliente"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["cli_nombfisc"].Value = row["cli_nombfisc"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven_fecdoc"].Value = row["ven_fecdoc"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven_keyven"].Value = row["ven_keyven"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven_coment"].Value = row["ven_coment"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra1"].Value = row["ven2_extra1"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra2"].Value = row["ven2_extra2"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra3"].Value = row["ven2_extra3"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra4"].Value = row["ven2_extra4"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra5"].Value = row["ven2_extra5"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra6"].Value = row["ven2_extra6"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra7"].Value = row["ven2_extra7"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra8"].Value = row["ven2_extra8"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra9"].Value = row["ven2_extra9"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra10"].Value = row["ven2_extra10"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra11"].Value = row["ven2_extra11"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra12"].Value = row["ven2_extra12"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra13"].Value = row["ven2_extra13"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra14"].Value = row["ven2_extra14"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra15"].Value = row["ven2_extra15"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra16"].Value = row["ven2_extra16"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra17"].Value = row["ven2_extra17"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra18"].Value = row["ven2_extra18"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra19"].Value = row["ven2_extra19"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["ven2_extra20"].Value = row["ven2_extra20"].ToString();
            }
        }

        private void rdbExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbExtra.Checked)
            {
                limpiar();
                cmbExtra.Enabled = true;
                txtExtra.ReadOnly = false;
                btnBuscaCliente.Enabled = false;
                txtCliente.ReadOnly = true;
                txtNombre.ReadOnly = true;
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
                txtExtra.Focus();
            }
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                limpiar();
                cmbExtra.Enabled = false;
                txtExtra.ReadOnly = true;
                btnBuscaCliente.Enabled = true;
                txtCliente.ReadOnly = false;
                //txtNombre.ReadOnly = false;
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
                txtCliente.Focus();
            }
        }

        private void rdbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFecha.Checked)
            {
                limpiar();
                cmbExtra.Enabled = false;
                txtExtra.ReadOnly = true;
                btnBuscaCliente.Enabled = false;
                txtCliente.ReadOnly = true;
                txtNombre.ReadOnly = true;
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
            }
        }

        private void txtExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter) && txtExtra.ReadOnly == false)
            {
                e.Handled = true;
                buscar();
            }
        }

        private string deciImporte(string cadena)
        {
            string numero;
            numero = Math.Round(Convert.ToDecimal(cadena), GlobalDecImporte).ToString();
            return numero;
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter) && txtCliente.ReadOnly == false)
            {
                e.Handled = true;
                txtNombre.Focus();
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() != "")
            {
                clsClientes cliente = new clsClientes();
                cliente.cli_keycli = txtCliente.Text;
                DataSet consulta = cliente.leerUnicoClientes();

                if (consulta.Tables[0].Rows.Count > 0)
                {
                    limpiar();
                    dsCliente = consulta;
                    cargaDatosClientes();
                }
                else
                {
                    txtCliente.Text = codigoCliente;
                    txtCliente.Focus();
                }
            }
        }

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            codigoCliente = txtCliente.Text.Trim();
        }
    }
}
