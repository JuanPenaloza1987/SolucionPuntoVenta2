using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppPuntoVenta.Venta.Negocio;

namespace AppPuntoVenta.Venta.Vista
{
    public partial class frmConfMetodoPago : Form
    {
        public frmConfMetodoPago()
        {
            InitializeComponent();
            leerleerDetalleMetodoPago();
            MetodosConfigurados();
        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {
            if(txtLetra.Text.Length > 1)
            {
                txtLetra.Text = txtLetra.Text[0].ToString();
            }
        }

        void CargarMetodoPago()
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string metodo = cmbMEtodoPAgo.Text;
            string letra = txtLetra.Text;
            int hacer = 0;
            if (metodo != "Efectivo" && letra.ToUpper() == "E")
            {
                MessageBox.Show("La letra E ya esta configurada por default para efectivo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(metodo))
            {
                MessageBox.Show("Seleccione un metodo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(letra))
            {
                MessageBox.Show("Ingrese una letra.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hacer = 1;
            }

            if (hacer == 1)
            {
                clsMetodoPago metodoPag = new clsMetodoPago();
                if (metodoPag.GuardarMetodo(metodo,letra))
                {
                    MetodosConfigurados();
                    Limpiar();
                    MessageBox.Show("Metodo Guardado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(metodoPag.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }        

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvAtajo.SelectedRows.Count > 0)
            {
                if (dgvAtajo.SelectedRows[0].Cells[0].Value != null)
                {
                    clsMetodoPago paquete = new clsMetodoPago();
                    string codigo = dgvAtajo.SelectedRows[0].Cells[0].Value.ToString();
                    if (paquete.EliminarMetodo(codigo))
                    {
                        MetodosConfigurados();
                    }
                    else
                    {
                        MessageBox.Show(paquete.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dgvAtajo.ClearSelection();
                }
            }
        }

        void leerleerDetalleMetodoPago() {
            clsMetodoPago metodoPago = new clsMetodoPago();
            DataSet datos = new DataSet();
            datos = metodoPago.leerMetodoPagoEstado();
            if (datos != null && datos.Tables.Count > 0)
            {
                for (int x = 0; x < datos.Tables[0].Rows.Count; x++)
                {
                    cmbMEtodoPAgo.Items.Add(datos.Tables[0].Rows[x][0].ToString());
                }
            }
            else if (!string.IsNullOrEmpty(metodoPago.mensaje))
                MessageBox.Show(metodoPago.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        void MetodosConfigurados()
        {
            clsMetodoPago clsMetodoPago = new clsMetodoPago();
            DataSet consulta = clsMetodoPago.MetodosConfigurados();
            //dgvAtajo.AutoGenerateColumns= false;
            if (consulta != null && consulta.Tables.Count > 0)
                dgvAtajo.DataSource = consulta.Tables[0];
            else if (!string.IsNullOrEmpty(clsMetodoPago.mensaje))
                MessageBox.Show(clsMetodoPago.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void Limpiar()
        {
            txtLetra.Text = "";
            cmbMEtodoPAgo.SelectedIndex = -1;
            dgvAtajo.ClearSelection();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cnx = (ContextMenuStrip)(sender as ToolStripMenuItem).Owner;
            DataGridView gridSeleccionado = cnx.SourceControl as DataGridView;
            clsMetodoPago metodo = new clsMetodoPago();
            if (dgvAtajo.SelectedRows.Count > 0)
            {
                if (dgvAtajo.SelectedRows[0].Cells[0].Value != null)
                {
                    string m = dgvAtajo.SelectedRows[0].Cells[0].Value.ToString();
                    string m2 = dgvAtajo.SelectedRows[0].Cells[1].Value.ToString();
                    string m3 = dgvAtajo.SelectedRows[0].Cells[2].Value.ToString();
                    DataSet met =  metodo.leerDetalleMetodoConf(m);
                    if (met != null && met.Tables.Count > 0)
                    {
                        cmbMEtodoPAgo.Text = met.Tables[0].Rows[0].ItemArray[1].ToString();
                        txtLetra.Text = met.Tables[0].Rows[0].ItemArray[2].ToString();
                    }
                     else if (!string.IsNullOrEmpty(metodo.mensaje))
                    {
                        MessageBox.Show(metodo.mensaje, "¡Ocurrio un error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                                        
                }
                else
                {
                    dgvAtajo.ClearSelection();
                }
            }
        }
    }
}
