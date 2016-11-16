using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRATAPV.Seguridad.Negocio;
using SRATAPV.Utilerias;
using SRATAPV.Ventas.Negocio;
//using SRATAPV.Reportes.Datos;
using AppPuntoVenta.Venta.Datos;
using AppPuntoVenta;

namespace SRATAPV.Ventas.Vista
{
    public partial class frmCorteCaja : Form
    {
        public frmCorteCaja()
        {
            InitializeComponent();
        }

        private string fechainicio = "";
        private string fechafin = "";
        // int decimalesGlobales = Convert.ToInt32(Globals.Instance.DecimalesImporte);
        int decimalesGlobales = 3;
        private void frmCorteCaja_Load(object sender, EventArgs e)
        {
            //cargaUsuarios();

            cmbUsuarios.SelectedValue = Sesion.Usuario;
            cmbUsuarios.SelectedText = Sesion.Usuario;
            dtp_corteCajero.Enabled = false;
            cmbUsuarios.Enabled = false;
            cmbCortes.Enabled = false;
            traerUltimoCorteAbierto();

        }

        
        private void llenarCorte()
        {
            clsCorte leerCorte = new clsCorte();
            leerCorte.cor_keyusr = cmbUsuarios.SelectedValue.ToString();
            leerCorte.cor_fechInic=dtp_corteCajero.Value;
            leerCorte.cor_keycor = cmbCortes.Text;
            DataSet datos = new DataSet();
            datos = leerCorte.leerCorte();
            double TotalEfectivo=0.00;
            double fondoCaja = 0;
            double totalCredito = 0;
            double totalTarjetaCredito = 0;
            double totalTarjetaDebito = 0;
            double totalTranseferencia = 0;
            string numeroCorte="";
            
            try
            {
                numeroCorte = datos.Tables[0].Rows[0]["cor_keycor"].ToString();
            }
            catch
            {
                totalCredito = 0.00;
            }
            try
            {
                totalCredito=Math.Round(Convert.ToDouble(datos.Tables[0].Rows[0]["VentasCredito"].ToString()), decimalesGlobales);
            }
            catch 
            {
                totalCredito = 0.00;
            }
            try
            {
                TotalEfectivo=Math.Round(Convert.ToDouble(datos.Tables[0].Rows[0]["EfectivoCaja"].ToString()), decimalesGlobales);
            }
            catch 
            {
                TotalEfectivo = 0.00;
            }
            try
            {
                fondoCaja= Math.Round(Convert.ToDouble(datos.Tables[0].Rows[0]["fondoCaja"].ToString()), decimalesGlobales);
            }
            catch
            {
                fondoCaja = 0.00;
            }
            try
            {
                totalTarjetaCredito = Math.Round(Convert.ToDouble(datos.Tables[0].Rows[0]["VentasTarjetaCredito"].ToString()), decimalesGlobales);
            }
            catch 
            {
                totalTarjetaCredito = 0.00;
            }
            try
            {
                totalTarjetaDebito = Math.Round(Convert.ToDouble(datos.Tables[0].Rows[0]["VentasTarjetaDebito"].ToString()), decimalesGlobales);
            }
            catch
            {
                totalTarjetaDebito = 0.00;
            }
            try
            {
                totalTranseferencia = Math.Round(Convert.ToDouble(datos.Tables[0].Rows[0]["VentasTransferencia"].ToString()), decimalesGlobales);
            }
            catch
            {
                totalTranseferencia = 0.00;
            }
            if (numeroCorte.Trim() != "")
            {
                lblCredito.Text = totalCredito.ToString("N");
                lblEfectivo.Text = TotalEfectivo.ToString("N");
                lblFondoCaja.Text = fondoCaja.ToString("N");
                lblGanancia.Text = "0.00";
                lblVentasEfectivo.Text = TotalEfectivo.ToString("N");
                lblTarjetaCredito.Text = totalTarjetaCredito.ToString("N");
                lblTarjetaDebito.Text = totalTarjetaDebito.ToString("N");
                lblTransferencia.Text = totalTranseferencia.ToString("N"); 
                lblTotalDineroCaja.Text = (TotalEfectivo + fondoCaja).ToString("N");
                lblVentasTotales.Text = (TotalEfectivo + totalCredito + totalTarjetaCredito + totalTranseferencia + totalTarjetaDebito).ToString("N");
                lblTotalVentas.Text = (TotalEfectivo + totalCredito + totalTarjetaCredito + totalTranseferencia + totalTarjetaDebito).ToString("N");
                //cmbCortes.Text = numeroCorte;
                lblEstado.Text = datos.Tables[0].Rows[0]["Estado"].ToString();
                if (datos.Tables[0].Rows[0]["Estado"].ToString() == "Abierto")
                {
                    lblFechas.Text = "Corte del " + datos.Tables[0].Rows[0]["FechaInicio"].ToString() + " al ...";
                }
                else
                {
                    lblFechas.Text = "Corte del " + datos.Tables[0].Rows[0]["FechaInicio"].ToString() + " al " + datos.Tables[0].Rows[0]["FechaFin"].ToString();
                }
                fechainicio = datos.Tables[0].Rows[0]["FechaInicio"].ToString();
                fechafin = datos.Tables[0].Rows[0]["FechaFin"].ToString();

            }

            //else
            //{
            //    MessageBox.Show("No se ha aperturado la caja.","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}
        }
        //private void cargaUsuarios()
        //{
        //    DataSet ds = new DataSet();
        //    clsUsuarios usuarios = new clsUsuarios();

        //    try
        //    {
        //        ds = usuarios.leerUsuarios();

        //        if (ds != null)
        //        {
        //            cmbUsuarios.DisplayMember = "usu_keyusu";
        //            cmbUsuarios.ValueMember = "usu_keyusu";
        //            cmbUsuarios.DataSource = ds.Tables[0].DefaultView;

        //        }
        //        else
        //        {
        //            MessageBox.Show("No se ha seleccionado un usuario.", "Mensaje", MessageBoxButtons.OK);
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("No se pudieron mostrar los datos requeridos - " + usuarios.mensaje);
        //    }
        //    cmbUsuarios.Text = Globals.Instance.usuario;
        //}

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCortesDeusuario();
        }

        public void llenarUltimoCorte() {
            cmbCortes.Items.Clear();
            clsCorte corte = new clsCorte();
            corte.cor_keyusr = cmbUsuarios.SelectedValue.ToString();
            corte.cor_fechInic = dtp_corteCajero.Value;
            DataSet datos = new DataSet();
            datos = corte.leerUltimoCorteAbierto();
            for (int x = 0; x < datos.Tables[0].Rows.Count; x++)
            {

                cmbCortes.Items.Add(datos.Tables[0].Rows[x][0].ToString());
                if (x == 0)
                {
                    cmbCortes.Text = datos.Tables[0].Rows[x][0].ToString();
                }
            }
        }

        private void llenarCortesDeusuario()
        {
                
            /*cmbCortes.Items.Clear();
            clsCorte corte = new clsCorte();
            corte.cor_keyusr = cmbUsuarios.SelectedValue.ToString();
            corte.cor_fechInic = dtp_corteCajero.Value;
            DataSet datos = new DataSet();
            datos= corte.leerCortesUsuarios();
            for (int x = 0; x < datos.Tables[0].Rows.Count; x++)
            {
                
                cmbCortes.Items.Add(datos.Tables[0].Rows[x][0].ToString());
                if (x == 0) 
                {
                    cmbCortes.Text = datos.Tables[0].Rows[x][0].ToString();
                }
            }
            */
 
        }

        private void traerUltimoCorteAbierto() {
            try
            {
                clsCorte corteAbierto = new clsCorte();
                DataSet corte = new DataSet();
                decimal fondoCaja = 0;
                DataTable ventas = new DataTable();
                DataTable ventasDetalle = new DataTable();
                string idCorte = corteAbierto.leerCorteUsuario(Sesion.Usuario);
                string idVentas = "";
                decimal venTot = 0;
                decimal venTotEfectivo = 0;
                decimal efectivoCaja = 0;
                decimal tarCredito = 0;
                decimal tarDebito = 0;
                decimal transferencia = 0;
                decimal credito = 0;

                if (!string.IsNullOrEmpty(corteAbierto.mensaje))
                {
                    MessageBox.Show(corteAbierto.mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!string.IsNullOrEmpty(idCorte))
                {
                    corteAbierto.cor_keycor = idCorte;
                    fondoCaja = Convert.ToDecimal(corteAbierto.leerFondoCaja(idCorte));
                    if (!string.IsNullOrEmpty(corteAbierto.mensaje))
                    {
                        MessageBox.Show(corteAbierto.mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (fondoCaja > 0)
                    {
                        lblFondoCaja.Text = fondoCaja.ToString("N");
                    }

                    ventas = corteAbierto.leerVentasDelCorte().Tables[0];
                    if (!string.IsNullOrEmpty(corteAbierto.mensaje))
                    {
                        MessageBox.Show(corteAbierto.mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    foreach (DataRow item in ventas.Rows)
                    {
                        item[0].ToString();
                        idVentas +=  item[0].ToString() + ',';
                    
                    }
                    if (!string.IsNullOrEmpty(idVentas))
                    {
                        idVentas = idVentas.Substring(0, idVentas.Length - 1);                    
                    }                
                    ventasDetalle = corteAbierto.leerVentasDetalleDelCorte(idVentas).Tables[0];

                    if (!string.IsNullOrEmpty(corteAbierto.mensaje))
                    {
                        MessageBox.Show(corteAbierto.mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    foreach (DataRow item in ventasDetalle.Rows)
                    {
                        item[0].ToString();
                        venTot += Convert.ToDecimal(item[1].ToString());
                        switch (item[0].ToString())
                        {
                            case"Efectivo":                                
                                venTotEfectivo = Convert.ToDecimal(item[1].ToString());
                                break;
                            case "Tarjeta de crédito":
                                tarCredito = Convert.ToDecimal(item[1].ToString());
                                break;
                            case "Crédito":
                                credito = Convert.ToDecimal(item[1].ToString());

                                break;
                            case "Tarjeta de débito":
                                tarDebito = Convert.ToDecimal(item[1].ToString());                                
                                break;
                            case "Transferencia":
                                transferencia = Convert.ToDecimal(item[1].ToString());
                               
                                break;
                            default:
                                break;
                        }
                    }

                    lblEfectivo.Text = efectivoCaja.ToString("N");
                    lblTransferencia.Text = transferencia.ToString("N");
                    lblTarjetaDebito.Text = tarDebito.ToString("N");
                    lblCredito.Text = credito.ToString("N");
                    lblTarjetaCredito.Text = tarCredito.ToString("N");
                    lblEfectivo.Text = venTotEfectivo.ToString("N");
                    if (venTotEfectivo > 0)
                    {
                        lblVentasEfectivo.Text = venTotEfectivo.ToString("N");
                    }
                    if (venTot > 0)
                    {
                        lblTotalVentas.Text = venTot.ToString("N");
                        lblVentasTotales.Text = venTot.ToString("N");
                    }
                    efectivoCaja = venTotEfectivo + fondoCaja;
                    lblTotalDineroCaja.Text = efectivoCaja.ToString("N");

                    cmbCortes.SelectedText = idCorte;
                    cmbCortes.SelectedValue = idCorte;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }

        }

        private void btnRealizarCorte_Click(object sender, EventArgs e)
        {

            if (cmbCortes.Text != "")
            {
                if (lblEstado.Text == "Cerrado")
                {
                    MessageBox.Show("El corte se encuentra cerrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    clsCorte corte = new clsCorte();
                    corte.cor1_keycor = cmbCortes.Text;
                    corte.cor1_veinte = txt20.Text;
                    corte.cor1_mil = txt1000.Text;
                    corte.cor1_cien = txt100.Text;
                    corte.cor1_cincuenta = txt50.Text;
                    corte.cor1_doscientos = txt200.Text;
                    corte.cor1_moneda = txtMonedad.Text;
                    corte.cor1_quinientos = txt500.Text;
                    if (corte.GuardarDetalleCorte())
                    {
                        clsCorte modificarCorte = new clsCorte();
                        modificarCorte.cor_keycor = cmbCortes.Text;
                        modificarCorte.cor_fechFin = DateTime.Now;
                        modificarCorte.cor_totVentas = lblTotalDineroCaja.Text;
                        modificarCorte.cor_totVtasReg = lblTotalDenominaciones.Text;
                        modificarCorte.cor_estado = "Cerrado";
                        if (modificarCorte.ModificarCorte())
                        {
                            Sesion.CodigoCorte = null;
                            MessageBox.Show("Corte almacenado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            imprimir();
                            lblEstado.Text = "Cerrado";
                        }
                        else
                        {
                            MessageBox.Show("Error de almacenamiento del detalle", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }                        

                        //llenarCorte();
                    }
                    else
                    {
                        MessageBox.Show("Error de almacenamiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            else
            {
                MessageBox.Show("No existe un fondo de caja con este usuario y fecha abierto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void leerCorteDenominaciones()
        {
            /*clsCorte LeerCorte = new clsCorte();
            LeerCorte.cor_keycor = cmbCortes.Text;
            DataSet datosDenominaciones = new DataSet();
            datosDenominaciones = LeerCorte.leerCorteDenominaciones();
            txt100.Text = datosDenominaciones.Tables[0].Rows[0]["cor1_cien"].ToString();
            txt1000.Text = datosDenominaciones.Tables[0].Rows[0]["cor1_mil"].ToString();
            txt20.Text = datosDenominaciones.Tables[0].Rows[0]["cor1_veinte"].ToString();
            txt200.Text = datosDenominaciones.Tables[0].Rows[0]["cor1_doscientos"].ToString();
            txt50.Text = datosDenominaciones.Tables[0].Rows[0]["cor1_cincuenta"].ToString();
            txt500.Text = datosDenominaciones.Tables[0].Rows[0]["cor1_quinientos"].ToString();
            txtMonedad.Text = datosDenominaciones.Tables[0].Rows[0]["cor1_moneda"].ToString();
            habilitar(false);*/
        }
        private void habilitar(bool habilitado)
        {
            btnRealizarCorte.Enabled = habilitado;
            txt100.Enabled = habilitado;
            txt1000.Enabled = habilitado;
            txt20.Enabled = habilitado;
            txt200.Enabled = habilitado;
            txt50.Enabled = habilitado;
            txt500.Enabled = habilitado;
            txtMonedad.Enabled = habilitado;


        }

        private void sumarDenominaciones()
        {
            decimal suma=0;
            decimal b20 = 0;
            decimal b50 = 0;
            decimal b100 = 0;
            decimal b200 = 0;
            decimal b500 = 0;
            decimal b1000 = 0;

            suma+=Convert.ToDecimal(txtMonedad.Text);
            
            suma += decimal.TryParse(txt20.Text, out b20) ? b20*20:0;
            suma += decimal.TryParse(txt50.Text, out b50) ? b50*50:0;
            suma += decimal.TryParse(txt100.Text, out b100) ? b100 * 100 : 0;
            suma += decimal.TryParse(txt200.Text, out b200) ? b200 * 200 : 0;
            suma += decimal.TryParse(txt500.Text, out b500) ? b500 * 500 : 0;
            suma += decimal.TryParse(txt1000.Text, out b1000) ? b1000 * 1000 : 0;

            lblTotalDenominaciones.Text = suma.ToString("N");
        }

        private void txtMonedad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sumarDenominaciones();
            }
            catch { }
        }

        private void txtMonedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt20_TextChanged(object sender, EventArgs e)
        {
                sumarDenominaciones();            
        }

        private void txt50_TextChanged(object sender, EventArgs e)
        {
            sumarDenominaciones();
        }

        private void txt100_TextChanged(object sender, EventArgs e)
        {
            sumarDenominaciones();
        }

        private void txt200_TextChanged(object sender, EventArgs e)
        {
            sumarDenominaciones();
        }

        private void txt500_TextChanged(object sender, EventArgs e)
        {
            sumarDenominaciones();
        }

        private void txt1000_TextChanged(object sender, EventArgs e)
        {
            sumarDenominaciones();
        }

        private void txt20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt100_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt200_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt500_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void dtp_corteCajero_ValueChanged(object sender, EventArgs e)
        {
            llenarCortesDeusuario();
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblGanancia_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblVentasTotales_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();

        }
        private void imprimir()
        {
   /*         Reportes.Vista.frmRepCorte RepCorte = new Reportes.Vista.frmRepCorte();
            RepCorte.dsCorteCaja = ReporteCorte();
            RepCorte.ShowDialog();
 */
        }


        private dsCorte ReporteCorte()
        {
            dsCorte data = new dsCorte();
            dsCorte.dtCorteRow rowdtCorte = data.dtCorte.NewdtCorteRow();
            rowdtCorte.Cajero = cmbUsuarios.Text;
            rowdtCorte.Corte = cmbCortes.Text;
            rowdtCorte.FechaFin = fechafin;
            rowdtCorte.FechaInicio = fechainicio;
            rowdtCorte.FondoCaja = lblFondoCaja.Text;
            rowdtCorte.TotalCajeroVentas = lblTotalVentas.Text;
            rowdtCorte.TotalDineroCaja = lblTotalDineroCaja.Text;
            rowdtCorte.TotalRegistrado = lblTotalVentas.Text;
            rowdtCorte.TotalVentasCredito=lblCredito.Text;
            rowdtCorte.TotalVentasEfectivo = lblEfectivo.Text;
            rowdtCorte.TotalVentasTarjetaCrédito = lblTarjetaCredito.Text;
            rowdtCorte.Utilidad = lblGanancia.Text;
            rowdtCorte.VentasTotales = lblVentasTotales.Text;
            data.dtCorte.AdddtCorteRow(rowdtCorte);

            clsCorte LeerVentas = new clsCorte();

            LeerVentas.cor_keycor = cmbCortes.Text;
            DataSet datosVentas= new DataSet();
            datosVentas = LeerVentas.leerVentasDelCorte();
            for (int x = 0; x < datosVentas.Tables[0].Rows.Count; x++)
            {
                dsCorte.dtVentasCorteRow rowdtVenta = data.dtVentasCorte.NewdtVentasCorteRow();
                rowdtVenta.ven_cliente = datosVentas.Tables[0].Rows[x]["ven_cliente"].ToString();
                rowdtVenta.ven_fecreg = datosVentas.Tables[0].Rows[x]["ven_fecreg"].ToString();
                rowdtVenta.ven_iva = Math.Round(Convert.ToDecimal(datosVentas.Tables[0].Rows[x]["ven_iva"].ToString()), decimalesGlobales).ToString();
                rowdtVenta.ven_keyven = datosVentas.Tables[0].Rows[x]["ven_keyven"].ToString();
                rowdtVenta.ven_subtot = Math.Round(Convert.ToDecimal(datosVentas.Tables[0].Rows[x]["ven_subtot"].ToString()), decimalesGlobales).ToString();
                rowdtVenta.ven_total = Math.Round(Convert.ToDecimal(datosVentas.Tables[0].Rows[x]["ven_total"].ToString()), decimalesGlobales).ToString();
                rowdtVenta.ven_usrven = datosVentas.Tables[0].Rows[x]["ven_usrven"].ToString();
                data.dtVentasCorte.AdddtVentasCorteRow(rowdtVenta);
            }

            return data;
        }

        private void tabpage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCortes_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCorte();
        }












    }
}
