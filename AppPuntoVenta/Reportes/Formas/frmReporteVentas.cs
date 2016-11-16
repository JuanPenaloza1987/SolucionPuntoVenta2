using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRATAPV.Busquedas.Vista;
using SRATAPV.Ventas.Negocio;
using SRATAPV.Utilerias;
using SRATAPV.Catalogos.Negocio;
using SRATAPV.Reportes.Negocio;

namespace SRATAPV.Reportes.Formas
{
    public partial class frmReporteVentas : Form
    {
        public frmReporteVentas()
        {
            InitializeComponent();
        }

        DataSet dsCliente = new DataSet();
        DataSet dsBusqueda = new DataSet();

        int GlobalDecImporte = Convert.ToInt32(Globals.Instance.DecimalesImporte);

        string codigoCliente;

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-7);
            cmbEstado.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtVenta.Text = string.Empty;
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
            clsReporteVentas cls = new clsReporteVentas();
            string venta = "", cliente = "", fechaDesde = "", fechaHasta = "";

            if (rdbVenta.Checked)
            {
                venta = txtVenta.Text;
                cliente = "";
                fechaDesde = "";
                fechaHasta = "";
            }
            else if (rdbCliente.Checked) 
            {
                venta = "";
                cliente = txtCliente.Text.Trim();
                fechaDesde = "";
                fechaHasta = "";
            }
            else if (rdbFecha.Checked) 
            {
                venta = "";
                cliente = "";
                fechaDesde = dtpDesde.Value.ToShortDateString();
                fechaHasta = dtpHasta.Value.AddDays(1).ToShortDateString();
            }

            cls.ven_keyven = venta;
            cls.ven_cliente = cliente;
            cls.ven_fecreg = fechaDesde;
            cls.ven_fecmod = fechaHasta;
            cls.ven_estado = cmbEstado.Text;

            dsBusqueda = cls.leerVentaReporte();

            if (venta == "" && cliente == "" & fechaDesde == "" && fechaHasta == "") 
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
            //dgvVentas.DataSource = dsBusqueda.Tables[0];
        }

        private void cargaConsultaGrid(DataSet vent)
        {
            foreach (DataRow row in vent.Tables[0].Rows)
            {
                dgvVentas.Rows.Add();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Venta"].Value = row["Venta"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Usuario"].Value = row["Usuario"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Cliente"].Value = row["Cliente"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Estado"].Value = row["Estado"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["FechaDeDocumento"].Value = row["Fecha de documento"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["FechaDeRegistro"].Value = row["Fecha de registro"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["FechaDeModificacion"].Value = row["Fecha de modificacion"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["UsuarioModifica"].Value = row["Usuario modifica"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Subtotal"].Value = deciImporte(row["Subtotal"].ToString());
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["PorcentajeDescuento"].Value = deciImporte(row["Procentaje descuento"].ToString());
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Descuento"].Value = deciImporte(row["Descuento"].ToString());
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["IVA"].Value = deciImporte(row["IVA"].ToString());
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Total"].Value = deciImporte(row["Total"].ToString());
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Comentarios"].Value = row["Comentarios"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Cotizacion"].Value = row["Cotización"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Corte"].Value = row["Corte"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["MetodoDePago"].Value = row["Método de pago"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Detalle"].Value = row["Detalle"].ToString();
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Referencia"].Value = row["Referencia"].ToString();
                if (row["Pago"].ToString() == null || row["Pago"].ToString() == string.Empty)
                {
                    dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Pago"].Value = deciImporte("0.000000");
                }
                else
                {
                    dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["Pago"].Value = deciImporte(row["Pago"].ToString());
                }
                dgvVentas.Rows[dgvVentas.Rows.Count - 1].Cells["UUID"].Value = row["UUID"].ToString();
            }
        }

        private void rdbVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVenta.Checked) 
            {
                limpiar();
                txtVenta.ReadOnly = false;
                btnBuscaCliente.Enabled = false;
                txtCliente.ReadOnly = true;
                txtNombre.ReadOnly = true;
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
                txtVenta.Focus();
            }
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                limpiar();
                txtVenta.ReadOnly = true;
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
                txtVenta.ReadOnly = true;
                btnBuscaCliente.Enabled = false;
                txtCliente.ReadOnly = true;
                txtNombre.ReadOnly = true;
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
            }
        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)(Keys.Enter) && txtVenta.ReadOnly == false)
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
