using AppPuntoVenta.Promocion.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppPuntoVenta.Promocion.Vista
{
    public partial class frmPromocion : Form
    {

        public frmPromocion()
        {
            InitializeComponent();
            CargarTipoPromocion();
            
            CargarPromociones();
            cmbTipoPromocion.SelectedIndex = -1;
        }

        private int tipoAccion = 0;

        void CargarTipoPromocion()
        {
            clsTipoPromocion tipoPromocion = new clsTipoPromocion();
            DataSet tipos = tipoPromocion.TraerTipoPromocion();
            if (tipos.Tables[0].Rows.Count > 0)
            {
                cmbTipoPromocion.DataSource = tipos.Tables[0];
                cmbTipoPromocion.ValueMember = "tpr_nombre";
                cmbTipoPromocion.DisplayMember = "tpr_nombre";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ( tipoAccion == 0)
            {
                GuardarPromocion();
            }
            else {
                ActualizarPromocion();
            }           
        }

        void CargarPromociones()
        {
            clsPromocion cPromocion = new clsPromocion();
            dgvPromocion.AutoGenerateColumns = false;
            DataSet consulta = cPromocion.TraerPromociones();
            if (consulta != null && consulta.Tables.Count > 0)
                dgvPromocion.DataSource = consulta.Tables[0];
            else if (!string.IsNullOrEmpty(cPromocion.mensaje))
                MessageBox.Show(cPromocion.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void ActualizarPromocion()
        {
            if (!CamposValidos())
            {
                return;
            }

            clsPromocion cPromocion = new clsPromocion();
            cPromocion.prom_codigo = string.Format("'{0}'", txtCodigoPromocion.Text);
            cPromocion.prom_descrip = string.Format("'{0}'", txtDescripcion.Text);
            cPromocion.prom_fini = dtpFechaInicio.Value;
            cPromocion.prom_ffin = dtpfechaFin.Value;
            cPromocion.prom_lun = chkLunes.Checked;
            cPromocion.prom_mar = chkMartes.Checked;
            cPromocion.prom_mie = chkMiercoles.Checked;
            cPromocion.prom_jue = chkJueves.Checked;
            cPromocion.prom_vie = chkViernes.Checked;
            cPromocion.prom_sab = chkSabado.Checked;
            cPromocion.prom_dom = chkDomingo.Checked;
            cPromocion.prom_tpromo = string.Format("'{0}'", cmbTipoPromocion.SelectedValue.ToString());

            float compra = 0, gratis = 0;
            cPromocion.prom_canta = float.TryParse(txtGratis.Text, out gratis) ? gratis : 0;
            cPromocion.prom_cantr = float.TryParse(txtCompra.Text, out compra) ? compra : 0;

            if (cPromocion.Actualizar())
            {
                //MostrarMensajeInformacion("Promoción guardada");
                AbrirDetallePromocion(txtCodigoPromocion.Text, cmbTipoPromocion.SelectedValue.ToString(), "No");
                this.Enabled = false;
                CargarPromociones();                
                Limpiar();
            }
            else
            {
                MostrarMensajeInformacion("Algo salio mal: " + cPromocion.mensaje);
                Limpiar();
            }
            tipoAccion = 0;
        }

        void GuardarPromocion()
        {
            if (!CamposValidos())
            {
                return;
            }

            clsPromocion cPromocion = new clsPromocion();
            cPromocion.prom_codigo = string.Format("'{0}'", txtCodigoPromocion.Text);
            cPromocion.prom_descrip = string.Format("'{0}'", txtDescripcion.Text);
            cPromocion.prom_fini = dtpFechaInicio.Value;
            cPromocion.prom_ffin = dtpfechaFin.Value;
            cPromocion.prom_lun = chkLunes.Checked;
            cPromocion.prom_mar = chkMartes.Checked;
            cPromocion.prom_mie = chkMiercoles.Checked;
            cPromocion.prom_jue = chkJueves.Checked;
            cPromocion.prom_vie = chkViernes.Checked;
            cPromocion.prom_sab = chkSabado.Checked;
            cPromocion.prom_dom = chkDomingo.Checked;
            cPromocion.prom_tpromo = string.Format("'{0}'", cmbTipoPromocion.SelectedValue.ToString());
            

            

            float compra = 0, gratis = 0;
            cPromocion.prom_canta = float.TryParse(txtGratis.Text, out gratis) ? gratis : 0;
            cPromocion.prom_cantr = float.TryParse(txtCompra.Text, out compra) ? compra : 0;

            if (cPromocion.Guardar())
            {
                //MostrarMensajeInformacion("Promoción guardada");
                AbrirDetallePromocion(txtCodigoPromocion.Text, cmbTipoPromocion.SelectedValue.ToString(), "No");
                this.Enabled = false;
                CargarPromociones();
                tipoAccion = 0;
            }
            else
            {
                MostrarMensajeInformacion("Algo salio mal: " + cPromocion.mensaje);
            }

        }

        void AbrirDetallePromocion(string codigo, string tipo, string ver)
        {
            frmDetallePromocion detalle = new frmDetallePromocion(ver);
            detalle.MdiParent = this.MdiParent;
            detalle.CodigoPromocion = codigo;
            detalle.TipoPromocion = tipo;
            detalle._tipoAccion = tipoAccion;
            detalle.FormClosed += new FormClosedEventHandler(DetalleCerrado);
            detalle.Show();
        }

        private void DetalleCerrado(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            Form detalle = sender as Form;
            if (detalle.DialogResult == DialogResult.OK)
            {
                Limpiar();
            }
        }

        bool CamposValidos()
        {
            bool validos = true;
            if (cmbTipoPromocion.SelectedIndex == -1)
            {
                MostrarMensajeInformacion("Se debe seleccionar un tipo de promoción");
                validos = false;
            }
            if (string.IsNullOrEmpty(txtCodigoPromocion.Text))
            {
                MostrarMensajeInformacion("Hace falta asignar un código de promoción");
                validos = false;
            }

            DateTime hoy = DateTime.Today;
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpfechaFin.Value;
            int b = DateTime.Compare(fechaInicio, hoy);
            if (b < 0)
            {
                MostrarMensajeInformacion("La fecha de inicio no debe ser anterior a la de hoy");
                validos = false;
            }

            b = DateTime.Compare(fechaFin, hoy);
            if (b < 0)
            {
                MostrarMensajeInformacion("La fecha fin no debe ser anterior a la de hoy");
                validos = false;
            }

            b = DateTime.Compare(fechaFin, fechaInicio);
            if (b < 0)
            {
                MostrarMensajeInformacion("La fecha de fin no debe ser anterior a la de inicio");
                validos = false;
            }
            
            return validos;
        }

        void MostrarMensajeInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar()
        {
            txtCodigoPromocion.Text = "";
            txtCodigoPromocion.ReadOnly = false;
            dtpFechaInicio.Value = DateTime.Now;
            dtpfechaFin.Value = DateTime.Now.AddMonths(1);
            txtDescripcion.Text = "";
            cmbTipoPromocion.SelectedIndex = -1;
            chkDomingo.Checked = true;
            chkJueves.Checked = true;
            chkLunes.Checked = true;
            chkMartes.Checked = true;
            chkMiercoles.Checked = true;
            chkSabado.Checked = true;
            chkViernes.Checked = true;
            dgvPromocion.ClearSelection();
            txtCompra.Text = "";
            txtGratis.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EliminarPromocion();
        }

        void EliminarPromocion()
        {
            clsPromocion cPromocion = new clsPromocion();
            if (dgvPromocion.SelectedRows.Count > 0)
            {
                if (dgvPromocion.SelectedRows[0].Cells[0].Value != null)
                {
                    cPromocion.prom_codigo =  dgvPromocion.SelectedRows[0].Cells[0].Value.ToString();
                    if (cPromocion.EliminarPromocion())
                    {
                        CargarPromociones();
                    }
                    else
                    {
                        MostrarMensajeInformacion("No se pudo eliminar la promoción");
                    }
                }
            }
        }

        private void cmbTipoPromocion_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarTipoPromocion();
        }

        void SeleccionarTipoPromocion()
        {
            switch (cmbTipoPromocion.Text.ToUpper())
            {
                case "CANTIDAD X CANTIDAD":
                    lblCompra.Visible = false;
                    lblGratis.Text = "X";
                    lblGratis.Visible = true;
                    txtCompra.Visible = true;
                    txtGratis.Visible = true;
                    txtGratis.Location = new System.Drawing.Point(363, txtGratis.Location.Y);
                    break;
                case "DESCUENTO %":
                    lblCompra.Visible = false;
                    lblGratis.Visible = false;
                    txtCompra.Visible = false;
                    txtGratis.Visible = false;
                    break;
                case "DESCUENTO $":
                    lblCompra.Visible = false;
                    lblGratis.Visible = false;
                    txtCompra.Visible = false;
                    txtGratis.Visible = false;
                    break;
                case "PRECIO FIJO":
                    lblCompra.Visible = false;
                    lblGratis.Visible = false;
                    txtCompra.Visible = false;
                    txtGratis.Visible = false;
                    break;
                case "PRODUCTO REGALO":
                    lblCompra.Visible = true;
                    lblGratis.Visible = true;
                    lblGratis.Text = "Regalo";
                    txtCompra.Visible = true;
                    txtGratis.Visible = true;
                    txtGratis.Location = new System.Drawing.Point(386, txtGratis.Location.Y);
                    break;
                default:
                    lblCompra.Visible = false;
                    lblGratis.Visible = false;
                    txtCompra.Visible = false;
                    txtGratis.Visible = false;
                    break;
            }
            txtGratis.Text = "";
            txtCompra.Text = "";
        }

        private void dgvPromocion_DoubleClick(object sender, EventArgs e)
        {
            tipoAccion = 0;
            if (dgvPromocion.SelectedRows.Count > 0)
            {
                if (dgvPromocion.SelectedRows[0].Cells[0].Value != null)
                {
                    AbrirDetallePromocion(dgvPromocion.SelectedRows[0].Cells[0].Value.ToString(), dgvPromocion.SelectedRows[0].Cells[1].Value.ToString(), "Si");
                    this.Enabled = false;
                    CargarPromociones();                
                    Limpiar();
                }
                else
                {
                    dgvPromocion.ClearSelection();
                }
            }
        }

        private void dgvPromocion_Click(object sender, EventArgs e)
        {
            if (dgvPromocion.SelectedRows.Count > 0)
            {
                if (dgvPromocion.SelectedRows[0].Cells[0].Value != null)
                {
                    tipoAccion = 1;
                    //AbrirDetallePromocion(dgvPromocion.SelectedRows[0].Cells[0].Value.ToString(), dgvPromocion.SelectedRows[0].Cells[1].Value.ToString());
                    clsPromocion cPromocion = new clsPromocion();
                    cPromocion.prar_codprom = dgvPromocion.SelectedRows[0].Cells[0].Value.ToString();
                    DataSet consulta = cPromocion.TraerPromocion();
                    if (consulta != null && consulta.Tables.Count > 0)
                    {
                        DataTable prom = new DataTable();
                        prom = consulta.Tables[0];
                        DataRow row = prom.Rows[0];
                        string prom_codigo = row["prom_codigo"].ToString();
                        string prom_descrip = row["prom_descrip"].ToString();
                        string prom_fini = row["prom_fini"].ToString();
                        string prom_ffin = row["prom_ffin"].ToString();
                        string prom_tpromo = row["prom_tpromo"].ToString();
                        bool prom_lun = Convert.ToBoolean(row["prom_lun"].ToString());
                        bool prom_mar = Convert.ToBoolean(row["prom_mar"].ToString());
                        bool prom_mie = Convert.ToBoolean(row["prom_mie"].ToString());
                        bool prom_jue = Convert.ToBoolean(row["prom_jue"].ToString());
                        bool prom_vie = Convert.ToBoolean(row["prom_vie"].ToString());
                        bool prom_sab = Convert.ToBoolean(row["prom_sab"].ToString());
                        bool prom_dom = Convert.ToBoolean(row["prom_dom"].ToString());
                        string prom_cantr = row["prom_cantr"].ToString();
                        string prom_canta = row["prom_canta"].ToString();

                        cmbTipoPromocion.Text = prom_tpromo;
                        txtCodigoPromocion.Text = prom_codigo;
                        txtCodigoPromocion.ReadOnly = true;
                        txtDescripcion.Text = prom_descrip;
                        dtpFechaInicio.Value = Convert.ToDateTime(prom_fini);
                        dtpfechaFin.Value = Convert.ToDateTime(prom_ffin);
                        SeleccionarTipoPromocion();
                        chkLunes.Checked = prom_lun;
                        chkMartes.Checked = prom_mar;
                        chkMiercoles.Checked = prom_mie;
                        chkJueves.Checked = prom_jue;
                        chkViernes.Checked = prom_vie;
                        chkSabado.Checked = prom_sab;
                        chkDomingo.Checked = prom_dom;
                        txtCompra.Text = prom_canta;
                        txtGratis.Text = prom_cantr;                        
                    }
                    else if (!string.IsNullOrEmpty(cPromocion.mensaje))
                        MessageBox.Show(cPromocion.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvPromocion.ClearSelection();
                }
            }
        }

    }
}
