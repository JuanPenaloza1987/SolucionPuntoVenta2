using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRATAPV.Reportes.Vista;
using System.Data.SqlClient;
using SRATAPV.Utilerias;

namespace SRATAPV.Reportes.Formas
{
    public partial class frmReporteCobranza : Form
    {
        public frmReporteCobranza()
        {
            InitializeComponent();
        }

        public static DataTable dt = null;
        public string sqlSeries = string.Empty;

        private void frmReporteCobranza_Load(object sender, EventArgs e)
        {
            #region anterior
            //llenadoCombos();
            //rdbResum.Checked = true;
            //rdbCobrz.Checked = true;
            #endregion 
            llenadoCombos();
            rdbResum.Checked = true;
            rdbCobrz.Checked = true;
            sqlSeries = "select U_NumSerie Series, U_NomSerie SeriesName from [@CONFIGURATIPO] where U_GeneraCobros = 'Y' union all select 0, 'Todos'";
            llenadoCombo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            #region anterior
            //int opcion = 0;
            //int formato = 0;

            //if (rdbImpts.Checked == true)
            //{
            //    opcion = 1;
            //}
            //if (rdbCobrz.Checked == true)
            //{
            //    opcion = 2;
            //}
            //if (rdbCancel.Checked == true)
            //{
            //    opcion = 3;
            //}

            //if (rdbDetal.Checked == true)
            //{
            //    formato = 2;
            //}
            //if (rdbResum.Checked == true)
            //{
            //    formato = 1;
            //}
            ////Generar reporte

            //frmCryReporteCobranza frmVistaReporte = new frmCryReporteCobranza();
            //frmVistaReporte.cntcst = cmbCntce.SelectedValue.ToString();
            //frmVistaReporte.series = Convert.ToInt32(cmbSerie.SelectedValue.ToString());
            //frmVistaReporte.tippag = cmbCobro.SelectedValue.ToString();
            //frmVistaReporte.opcion = opcion;
            //frmVistaReporte.formato = formato;
            //frmVistaReporte.fecgaCrte = dtpFecha.Value;
            //frmVistaReporte.fecgaCrte2 = dtpFecha2.Value;
            //frmVistaReporte.ShowDialog();
            #endregion

            int opcion = 0;
            int formato = 0;

            if (rdbImpts.Checked == true)
            {
                opcion = 1;
                sqlSeries = "select U_NumSerie Series, U_NomSerie SeriesName from [@CONFIGURATIPO] where U_GeneraImportes = 'Y' union all select 0, 'Todos'";
                llenadoCombo();
            }
            if (rdbCobrz.Checked == true)
            {
                opcion = 2;
                sqlSeries = "select U_NumSerie Series, U_NomSerie SeriesName from [@CONFIGURATIPO] where U_GeneraCobros = 'Y' union all select 0, 'Todos'";
                llenadoCombo();
            }
            if (rdbCancel.Checked == true)
            {
                opcion = 3;
                sqlSeries = "select U_NumSerie Series, U_NomSerie SeriesName from [@CONFIGURATIPO] where U_GeneraCancelados = 'Y' union all select 0, 'Todos'";
                llenadoCombo();
            }

            if (rdbDetal.Checked == true)
            {
                formato = 2;
            }
            if (rdbResum.Checked == true)
            {
                formato = 1;
            }
            //Generar reporte

            frmCryReporteCobranza frmVistaReporte = new frmCryReporteCobranza();
            frmVistaReporte.cntcst = cmbCntce.SelectedValue.ToString();
            frmVistaReporte.series = Convert.ToInt32(cmbSerie.SelectedValue.ToString());
            frmVistaReporte.tippag = cmbCobro.SelectedValue.ToString();
            frmVistaReporte.opcion = opcion;
            frmVistaReporte.formato = formato;
            frmVistaReporte.fecgaCrt1 = dtpFecha.Value;
            frmVistaReporte.fecgaCrt2 = dtpFecha2.Value;
            frmVistaReporte.ShowDialog();
        }

        public void llenadoCombos()
        {
            #region anterior
            //#region llenado de los centros de costos
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionSAP))
            //    {
            //        conn.Open();
            //        using (SqlDataAdapter da = new SqlDataAdapter("select PrcCode, PrcName from OPRC where Locked = 'N' union all select 'TodosCntCst', 'Todos'", conn))
            //        {
            //            dt = new DataTable();
            //            da.Fill(dt);
            //            cmbCntce.DataSource = dt;
            //            cmbCntce.ValueMember = "PrcCode";
            //            cmbCntce.DisplayMember = "PrcName";
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
            //#endregion

            //#region llenado de las series
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionSAP))
            //    {
            //        conn.Open();
            //        using (SqlDataAdapter da = new SqlDataAdapter("select Series, SeriesName from NNM1 where ObjectCode = 13 and Locked = 'N' union all select 0, 'Todos'", conn))
            //        {
            //            dt = new DataTable();
            //            da.Fill(dt);
            //            cmbSerie.DataSource = dt;
            //            cmbSerie.ValueMember = "Series";
            //            cmbSerie.DisplayMember = "SeriesName";
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
            //#endregion

            //#region llenado de los tipos de pago
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionSAP))
            //    {
            //        conn.Open();
            //        using (SqlDataAdapter da = new SqlDataAdapter("select 'Tarjeta' cdg, 'Tarjeta' nam union all select 'Oficina', 'Oficina'  union all select 'Cobrador', 'Cobrador' union all select 'Todos', 'Todos'", conn))
            //        {
            //            dt = new DataTable();
            //            da.Fill(dt);
            //            cmbCobro.DataSource = dt;
            //            cmbCobro.ValueMember = "cdg";
            //            cmbCobro.DisplayMember = "nam";
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
            //#endregion
            #endregion

            //"GCBDEVELOPER\\GCBDEV", "MLECH_SPI_TEST"
            #region llenado de los centros de costos
            try
            {
                //using (SqlConnection conn = new SqlConnection("uid=Createga;pwd=Cr34tGA_15;data source=DB_SRVR1\\SAP;database=MLECJ_SFFJ_TEST_CREATEGA"))
                using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionSAP))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select PrcCode, PrcName from OPRC where Locked = 'N' union all select 'TodosCntCst', 'Todos'", conn))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                        cmbCntce.DataSource = dt;
                        cmbCntce.ValueMember = "PrcCode";
                        cmbCntce.DisplayMember = "PrcName";
                    }
                }
            }
            catch (Exception ex)
            {

            }
            #endregion

            #region llenado de los tipos de pago
            try
            {
                //using (SqlConnection conn = new SqlConnection("uid=Createga;pwd=Cr34tGA_15;data source=DB_SRVR1\\SAP;database=MLECJ_SFFJ_TEST_CREATEGA"))
                using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionSAP))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select 'Tarjeta' cdg, 'Tarjeta' nam union all select 'Oficina', 'Oficina'  union all select 'Cobrador', 'Cobrador' union all select 'Todos', 'Todos'", conn))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                        cmbCobro.DataSource = dt;
                        cmbCobro.ValueMember = "cdg";
                        cmbCobro.DisplayMember = "nam";
                    }
                }
            }
            catch (Exception ex)
            {

            }
            #endregion
        }

        public void llenadoCombo()
        {
            #region llenado de las series
            try
            {
                //using (SqlConnection conn = new SqlConnection("uid=Createga;pwd=Cr34tGA_15;data source=DB_SRVR1\\SAP;database=MLECJ_SFFJ_TEST_CREATEGA"))
                using (SqlConnection conn = new SqlConnection(Globals.Instance.CadenaConexionSAP))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlSeries, conn))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                        cmbSerie.DataSource = dt;
                        cmbSerie.ValueMember = "Series";
                        cmbSerie.DisplayMember = "SeriesName";
                    }
                }
            }
            catch (Exception ex)
            {

            }
            #endregion
        }

        private void rdbCobrz_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCobrz.Checked == true)
            {
                sqlSeries = "select U_NumSerie Series, U_NomSerie SeriesName from [@CONFIGURATIPO] where U_GeneraCobros = 'Y' union all select 0, 'Todos'";
                llenadoCombo();
            }
        }

        private void rdbImpts_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbImpts.Checked == true)
            {
                sqlSeries = "select U_NumSerie Series, U_NomSerie SeriesName from [@CONFIGURATIPO] where U_GeneraImportes = 'Y' union all select 0, 'Todos'";
                llenadoCombo();
            }
        }

        private void rdbCancel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCancel.Checked == true)
            {
                sqlSeries = "select U_NumSerie Series, U_NomSerie SeriesName from [@CONFIGURATIPO] where U_GeneraCancelados = 'Y' union all select 0, 'Todos'";
                llenadoCombo();
            }
        }

        private void rdbResum_CheckedChanged(object sender, EventArgs e)
        {
            cambioFecha();
        }

        private void rdbDetal_CheckedChanged(object sender, EventArgs e)
        {
            cambioFecha();
        }

        private void cambioFecha() 
        {
            //if (rdbCancel.Checked == true && rdbDetal.Checked == true)
            //{
            //    dtpFecha.Size = new Size(99, 20);
            //    lblFecha.Visible = false;
            //}
            //else 
            //{
            //    dtpFecha.Size = new Size(224, 20);
            //    lblFecha.Visible = true;
            //}
        }
    }
}
