using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using STRATA.Entities;
using System.Data.SqlClient;
using AppPuntoVenta;
using STRATA.wfaDBs;



namespace wfaDBs
{
    public partial class frmPpal : Form
    {

        public List<entProcVent> lstVnl = new List<entProcVent>();
        public List<entProcVent> lstVns = new List<entProcVent>();
        public List<entProcVent1> lstDvl = new List<entProcVent1>();
        public List<entProcVent1> lstDvs = new List<entProcVent1>();
        public List<entProcVent4> lstVnl4 = new List<entProcVent4>();
        public List<entProcVentP> lstVnsP = new List<entProcVentP>();
        public List<int> lstKey;
        public List<entPerfPerm> lstPERFPERM = new List<entPerfPerm>();
        public List<entSeguUsua> lstSEGUUSUA = new List<entSeguUsua>();
        public List<entUsuaPerf> lstUSUAPERF = new List<entUsuaPerf>();
        public List<entCataMeto> lstCATAMETO = new List<entCataMeto>();
        public List<entSeguPerf> lstSEGUPERF = new List<entSeguPerf>();
        public List<entCataAlma> lstCATAALMA = new List<entCataAlma>();
        public List<entCataMeto1> lstCATAMETO1 = new List<entCataMeto1>();
        public List<entProcVentP> lstPROCVENTP = new List<entProcVentP>();

        public entProcVent entVnl;
        public entProcVent entVns;

        public entProcVent1 entDvl;
        public entProcVent1 entDvs;
        public entPerfPerm entPERF;
        public entUsuaPerf entUSUA;
        public entSeguUsua entSEGU;
        public entCataMeto entCATA;
        public entSeguPerf entSEPE;
        public entCataAlma entCALM;
        public entCataMeto1 entCMET1;
        public entProcVentP entPVP;
        public entProcVent4 entVnl4;

        public bool envio = false;

        public TimeSpan horaenvio;
        public DateTime horaconfg;

        public frmPpal()
        {
            InitializeComponent();

        }

        private void frmPpal_Load(object sender, EventArgs e)
        {
            //
            #region variables del ping
            Ping pngfpr = new Ping();
            byte[] buffer = new byte[32];
            PingOptions pngopc = new PingOptions(64, true);
            PingReply pngrpl = null;
            #endregion

            horaconfg = Convert.ToDateTime("12:00:00");
            horaenvio = new TimeSpan(horaconfg.Hour, horaconfg.Minute, horaconfg.Second);

            int sincronizarPOS = 0;
            int sincronizarSRV = 0;
            ntiApp.Icon = this.Icon;
            ntiApp.Visible = true;

            fndIpaCpu();
            int registros = 0;
            #region conexcion local
            try
            {
                using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
                {
                    string SqlAction = "SELECT * FROM CPU";
                    using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                    {
                        SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        registros = dt.Rows.Count;
                        if (registros > 0)
                        {
                            objHabIna(false, 1);
                            btnAcpCpu.Text = "Actualizar";
                            sincronizarPOS = 2;
                        }
                        else
                        {
                            sincronizarPOS = 1;
                        }
                        foreach (DataRow dr in dt.Rows)
                        {

                            txtCdgCpu.Text = dr[1].ToString();
                            txtNamCpu.Text = dr[2].ToString();
                            txtPatCpu.Text = dr[3].ToString();
                            txtIpaCpu.Text = dr[4].ToString();
                            txtMacCpu.Text = dr[5].ToString();
                            txtDbsCpu.Text = dr[6].ToString();
                            chbStaCpu.Checked = Convert.ToInt32(dr[7].ToString()) == 1 ? true : false;

                            try
                            {
                                using (StreamReader sr = new StreamReader(@"C:\STRATA_POS\STRATA_conn.txt", false))
                                {
                                    string line;
                                    while ((line = sr.ReadLine()) != null)
                                    {
                                        txtPatCpu.Text = line;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                //MessageBox.Show("No se encontro el archivo necesario");
                            }
                        }
                    }
                }
            }
            catch
            {
                sincronizarPOS = -1;
            }
            #endregion

            registros = 0;
            #region coneexion servidor
            try
            {
                using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
                {
                    string SqlAction = "SELECT * FROM CNX";
                    using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                    {
                        SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        registros = dt.Rows.Count;
                        if (registros > 0)
                        {
                            objHabIna(false, 2);
                            btnAcpCnx.Text = "Actualizar";
                            sincronizarSRV = 2;
                        }
                        else
                        {
                            sincronizarSRV = 1;
                        }

                        foreach (DataRow dr in dt.Rows)
                        {
                            txtCdgCnx.Text = dr[1].ToString();
                            txtSerCnx.Text = dr[2].ToString();
                            txtIpaCnx.Text = dr[3].ToString();
                            txtMacCnx.Text = dr[4].ToString();
                            txtDbsCnx.Text = dr[5].ToString();
                            txtUsuCnx.Text = dr[6].ToString();
                            txtPwdCnx.Text = dr[7].ToString();
                        }
                    }
                }
            }
            catch
            {
                sincronizarSRV = -1;
            }
            #endregion

            if (sincronizarPOS == 2 && sincronizarSRV == 2)
            {
                pngrpl = pngfpr.Send(txtIpaCnx.Text, 1000, buffer, pngopc);
                if (pngrpl.Status == IPStatus.Success && pngrpl.RoundtripTime < 3000)
                {
                    SincronizarConfiguracion();
                    SincronizarArticulos();
                    SincronizarPerfPerm();
                    SincronizarUsuaPerf();
                    SincronizarSeguUsua();
                    SincronizarCataMeto();
                    SincronizarSeguPerf();
                    SincronizarCataMeto1();
                    SincronizarCataAlma();
                    SincronizarProcVentP();
                    /*====================*/
                    SincronizarProcPromo();
                    SincronizarPromArti();
                    SincronizarProcPQtes();
                    SincronizarPQteArti();
                    SincronizarDiaProm();
                    envio = true;
                }
                else
                {
                    envio = false;
                }
            }

            verificarDatosIniciales verDatIni = new verificarDatosIniciales();
            if (Convert.ToInt32(verDatIni.existenDatos()) == 1)
            {
                sincronizarPrimeraVez();
                btnEnviar.PerformClick();

                frmPrincipal frmPP = new frmPrincipal();
                frmPP.Show();
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //
            this.Close();
        }

        private void sincronizarPrimeraVez() {
            Ping pngfpr = new Ping();
            byte[] buffer = new byte[32];
            PingOptions pngopc = new PingOptions(64, true);
            PingReply pngrpl = null;

            pngrpl = pngfpr.Send(txtIpaCnx.Text, 1000, buffer, pngopc);
            if (pngrpl.Status == IPStatus.Success && pngrpl.RoundtripTime < 3000)
            {
                SincronizarConfiguracion();
                SincronizarArticulos();
                SincronizarPerfPerm();
                SincronizarUsuaPerf();
                SincronizarSeguUsua();
                SincronizarCataMeto();
                SincronizarSeguPerf();
                SincronizarCataMeto1();
                SincronizarCataAlma();
                SincronizarProcVentP();
                /*====================*/
                SincronizarProcPromo();
                SincronizarPromArti();
                SincronizarProcPQtes();
                SincronizarPQteArti();
                SincronizarDiaProm();

                envio = true;
            }
            else
            {
                envio = false;
            }

        }
        private void btnAcpCpu_Click(object sender, EventArgs e)
        {
            //Acpetar CPU
            int registros = 0;
            string serverIP = txtIpaCnx.Text; 
            using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
            {
                string SqlAction = "SELECT * FROM CPU";
                using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                {
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    registros = dt.Rows.Count;
                }
            }
            if (registros == 0)
            {
                objHabIna(true, 1);
                #region
                using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
                {
                    cnx.Open();
                    SqlCeTransaction tx = cnx.BeginTransaction(IsolationLevel.ReadCommitted);

                    string SqlAction = "insert into cpu (cpu_cdgcpu, cpu_namcpu, cpu_patcpu, cpu_ipacpu, cpu_maccpu, cpu_dbscpu, cpu_stacpu) " +
                                       "values " +
                                       "(" + Convert.ToInt32(txtCdgCpu.Text) + ", '" + txtNamCpu.Text + "', '" + txtPatCpu.Text + "', '" + txtIpaCpu.Text + "', " +
                                       "'" + txtMacCpu.Text + "', '" + txtDbsCpu.Text + "', '1')";
                    try
                    {
                        SqlCeCommand cmd = cnx.CreateCommand();
                        cmd.Transaction = tx;
                        cmd.CommandText = SqlAction;
                        cmd.ExecuteNonQuery();
                        tx.Commit(CommitMode.Deferred);
                    }
                    catch (Exception)
                    {
                        tx.Rollback();
                    }
                    finally
                    {
                        cnx.Close();
                    }
                }
                #endregion
                btnAcpCnx.PerformClick();

                MessageBox.Show("Informacion Guardada correctamente");
                

            }
            else
            {
                objHabIna(false, 1);
                #region
                using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
                {
                    cnx.Open();
                    SqlCeTransaction tx = cnx.BeginTransaction(IsolationLevel.ReadCommitted);

                    string SqlAction = "update cpu set cpu_namcpu = '" + txtNamCpu.Text + "', cpu_patcpu = '" + txtPatCpu.Text + "', cpu_ipacpu = '" + txtIpaCpu.Text + "', " +
                                             " cpu_maccpu = '" + txtMacCpu.Text + "', cpu_dbscpu = '" + txtDbsCpu.Text + "' " +
                                       "where " +
                                       " cpu_cdgcpu = " + Convert.ToInt32(txtCdgCpu.Text) + "";
                    try
                    {
                        SqlCeCommand cmd = cnx.CreateCommand();
                        cmd.Transaction = tx;
                        cmd.CommandText = SqlAction;
                        cmd.ExecuteNonQuery();
                        tx.Commit(CommitMode.Deferred);
                    }
                    catch (Exception)
                    {
                        tx.Rollback();
                    }
                    finally
                    {
                        cnx.Close();
                    }
                }
                #endregion
                MessageBox.Show("Informacion Actualizada correctamente");
                btnAcpCnx.PerformClick();
               
            }

            guardarCNX();
            sincronizarPrimeraVez();
            btnEnviar.PerformClick();

            frmPrincipal frmPP = new frmPrincipal();
            frmPP.Show();
           
            //this.Close();
            //frmPrincipal frmPP = new frmPrincipal();
            //frmPP.Show();
        }

        private void trabajoBack() {
            this.Hide();
        }

        private void btnCncCpu_Click(object sender, EventArgs e)
        {
            //Cancelar CPU
        }

        private void btnBscCpu_Click(object sender, EventArgs e)
        {
            //Buscar CPU
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\STRATA_POS\STRATA_conn.txt", false))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        txtPatCpu.Text = line;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro el archivo necesario");
            }
        }

        private void guardarCNX() {
            int registros = 0;
            using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
            {
                string SqlAction = "SELECT * FROM CNX";
                using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                {
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    registros = dt.Rows.Count;
                }
            }
            if (registros == 0)
            {
                #region
                using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
                {
                    cnx.Open();
                    SqlCeTransaction tx = cnx.BeginTransaction(IsolationLevel.ReadCommitted);

                    string SqlAction = "INSERT INTO CNX (cnx_cdgcnx, cnx_sercnx, cnx_ipacnx, cnx_maccnx, cnx_dbscnx, cnx_usucnx, cnx_pwdcnx, cnx_stacnx) " +
                                       "VALUES " +
                                       "(" + Convert.ToInt32(txtCdgCnx.Text) + ", '" + txtSerCnx.Text + "', '" + txtIpaCnx.Text + "', '" + txtMacCnx.Text + "', " +
                                       "'" + txtDbsCnx.Text + "', '" + txtUsuCnx.Text + "', '" + txtPwdCnx.Text + "', '1')";
                    try
                    {
                        SqlCeCommand cmd = cnx.CreateCommand();
                        cmd.Transaction = tx;
                        cmd.CommandText = SqlAction;
                        cmd.ExecuteNonQuery();
                        tx.Commit(CommitMode.Deferred);
                    }
                    catch (Exception)
                    {
                        tx.Rollback();
                    }
                    finally
                    {
                        cnx.Close();
                    }
                }
                #endregion
               // MessageBox.Show("Informacion Guardada correctamente");
            }
            else
            {
                #region
                using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
                {
                    cnx.Open();
                    SqlCeTransaction tx = cnx.BeginTransaction(IsolationLevel.ReadCommitted);

                    string SqlAction = "update cpu set cnx_sercnx = '" + txtSerCnx.Text + "', cnx_ipacnx = '" + txtIpaCnx + "', cnx_maccnx = '" + txtMacCnx.Text + "', " +
                                             " cnx_dbscnx = '" + txtDbsCnx.Text + "', cnx_usucnx = '" + txtUsuCnx.Text + "', cnx_pwdcnx = '" + txtPwdCnx.Text + "' " +
                                       "where " +
                                       " cnx_cdgcnx = " + Convert.ToInt32(txtCdgCnx.Text) + "";
                    try
                    {
                        SqlCeCommand cmd = cnx.CreateCommand();
                        cmd.Transaction = tx;
                        cmd.CommandText = SqlAction;
                        cmd.ExecuteNonQuery();
                        tx.Commit(CommitMode.Deferred);
                    }
                    catch (Exception)
                    {
                        tx.Rollback();
                    }
                    finally
                    {
                        cnx.Close();
                    }
                }
                #endregion
               // MessageBox.Show("Informacion Actualizada correctamente");
            }
        }

        private void btnAcpCnx_Click(object sender, EventArgs e)
        {
            //Acpetar CNX
            int registros = 0;
            using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
            {
                string SqlAction = "SELECT * FROM CNX";
                using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                {
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    registros = dt.Rows.Count;
                }
            }
            if (registros == 0)
            {
                objHabIna(true, 2);
                #region
                using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
                {
                    cnx.Open();
                    SqlCeTransaction tx = cnx.BeginTransaction(IsolationLevel.ReadCommitted);

                    string SqlAction = "INSERT INTO CNX (cnx_cdgcnx, cnx_sercnx, cnx_ipacnx, cnx_maccnx, cnx_dbscnx, cnx_usucnx, cnx_pwdcnx, cnx_stacnx) " +
                                       "VALUES " +
                                       "(" + Convert.ToInt32(txtCdgCnx.Text) + ", '" + txtSerCnx.Text + "', '" + txtIpaCnx.Text + "', '" + txtMacCnx.Text + "', " +
                                       "'" + txtDbsCnx.Text + "', '" + txtUsuCnx.Text + "', '" + txtPwdCnx.Text + "', '1')";
                    try
                    {
                        SqlCeCommand cmd = cnx.CreateCommand();
                        cmd.Transaction = tx;
                        cmd.CommandText = SqlAction;
                        cmd.ExecuteNonQuery();
                        tx.Commit(CommitMode.Deferred);
                    }
                    catch (Exception)
                    {
                        tx.Rollback();
                    }
                    finally
                    {
                        cnx.Close();
                    }
                }
                #endregion
                MessageBox.Show("Informacion Guardada correctamente");
            }
            else
            {
                objHabIna(false, 2);
                #region
                using (SqlCeConnection cnx = new SqlCeConnection(ConfigurationManager.ConnectionStrings["wfaDBs"].ToString()))
                {
                    cnx.Open();
                    SqlCeTransaction tx = cnx.BeginTransaction(IsolationLevel.ReadCommitted);

                    string SqlAction = "update cpu set cnx_sercnx = '" + txtSerCnx.Text + "', cnx_ipacnx = '" + txtIpaCnx + "', cnx_maccnx = '" + txtMacCnx.Text + "', " +
                                             " cnx_dbscnx = '" + txtDbsCnx.Text + "', cnx_usucnx = '" + txtUsuCnx.Text + "', cnx_pwdcnx = '" + txtPwdCnx.Text + "' " +
                                       "where " +
                                       " cnx_cdgcnx = " + Convert.ToInt32(txtCdgCnx.Text) + "";
                    try
                    {
                        SqlCeCommand cmd = cnx.CreateCommand();
                        cmd.Transaction = tx;
                        cmd.CommandText = SqlAction;
                        cmd.ExecuteNonQuery();
                        tx.Commit(CommitMode.Deferred);
                    }
                    catch (Exception)
                    {
                        tx.Rollback();
                    }
                    finally
                    {
                        cnx.Close();
                    }
                }
                #endregion
                MessageBox.Show("Informacion Actualizada correctamente");
            }
        }

        private void btnCncCnx_Click(object sender, EventArgs e)
        {
            //Cancelar CNX
        }

        #region funciones de operacion
        public string fndIpaCpu()
        {
            int i = 0;
            ArrayList DireccionesMAC = new ArrayList();
            NetworkInterface[] interfaces = null;
            interfaces = NetworkInterface.GetAllNetworkInterfaces();
            if (interfaces != null && interfaces.Length > 0)
            {
                // Recorrer todas las interfaces de red
                foreach (NetworkInterface adaptador in interfaces)
                {
                    if (rdbEthCpu.Checked)
                    {
                        if (adaptador.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                        {
                            PhysicalAddress direccion = adaptador.GetPhysicalAddress();
                            byte[] bytes = direccion.GetAddressBytes();
                            string mac_address = string.Empty;
                            for (i = 0; i < bytes.Length; i++)
                            {
                                mac_address += bytes[i].ToString("X2");
                                if (i != bytes.Length - 1)
                                {
                                    mac_address += "-";
                                }

                            }
                            string strHostName = string.Empty;
                            strHostName = Dns.GetHostName();
                            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
                            IPAddress[] addr = ipEntry.AddressList;
                            string localIP = "";
                            foreach (IPAddress ip in ipEntry.AddressList)
                            {
                                if (ip.AddressFamily.ToString() == "InterNetwork")
                                {
                                    localIP = ip.ToString();
                                    txtMacCpu.Text = mac_address;
                                    txtIpaCpu.Text = localIP;
                                    break;
                                }
                            }
                        }
                    }
                    else if (rdbWfiCpu.Checked)
                    {
                        if (adaptador.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                        {
                            PhysicalAddress direccion = adaptador.GetPhysicalAddress();
                            byte[] bytes = direccion.GetAddressBytes();
                            string mac_address = string.Empty;
                            for (i = 0; i < bytes.Length; i++)
                            {
                                mac_address += bytes[i].ToString("X2");
                                if (i != bytes.Length - 1)
                                {
                                    mac_address += "-";
                                }

                            }
                            string strHostName = string.Empty;
                            strHostName = Dns.GetHostName();
                            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
                            IPAddress[] addr = ipEntry.AddressList;
                            string localIP = "";
                            foreach (IPAddress ip in ipEntry.AddressList)
                            {
                                if (ip.AddressFamily.ToString() == "InterNetwork")
                                {
                                    localIP = ip.ToString();
                                    txtMacCpu.Text = mac_address;
                                    txtIpaCpu.Text = localIP;
                                    break;
                                }
                            }
                        }
                    }

                    // Agregar la direccion MAC a la lista
                    //DireccionesMAC.Add(mac_address);
                }
            }
            return "";
        }

        public void objHabIna(bool habIna, int Opcion)
        {
            if (Opcion == 1)
            {
                txtCdgCpu.Enabled = habIna;
            }
            else if (Opcion == 2)
            {
                txtCdgCnx.Enabled = habIna;
            }
        }

        private void SincronizarConfiguracion()
        {
            string con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;";
            //string con = @"Server=.;Database=STRATA_PV;uid=sa;pwd=Createga2016;";

            try
            {
                DataSet dt = new DataSet();
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM confpara";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        sda.Fill(dt);
                    }
                }

                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";

                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        cnx.Open();
                        string SqlAction = "DELETE FROM confpara";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            int res = cmd.ExecuteNonQuery();
                        }
                        DataRow dr = dt.Tables[0].Rows[0];
                        SqlAction = "INSERT INTO [confpara] ([par_nomemp],[par_impuesto],[par_ieps],[par_tipoCambio],[par_keysuc],[par_dirrfc],[par_dircalle]," +
                            "[par_dirnumero],[par_dircolonia],[par_dirciudad],[par_direstado],[par_dirpais],[par_dircodposta],[par_dirtelefono],[par_expecalle],[par_expenumero],[par_expecolonia],[par_expemunicipio],[par_expeestado],[par_expepais],[par_cuenta],[par_PrcCode],[par_serie])" +
                          "VALUES (" +
                          "'" + dr["par_nomemp"].ToString() + "'" +
                          ",'" + dr["par_impuesto"].ToString() + "'" +
                         ",'" + dr["par_ieps"].ToString() + "'" +
                         ",'" + dr["par_tipoCambio"].ToString() + "'" +
                         ",'" + dr["par_keysuc"].ToString() + "'" +
                         ",'" + dr["par_dirrfc"].ToString() + "'" +
                         ",'" + dr["par_keysuc"].ToString() + "'" +
                         ",'" + dr["par_dircalle"].ToString() + "'" +
                         ",'" + dr["par_dirnumero"].ToString() + "'" +
                         ",'" + dr["par_dircolonia"].ToString() + "'" +
                         ",'" + dr["par_direstado"].ToString() + "'" +
                         ",'" + dr["par_dirpais"].ToString() + "'" +
                         ",'" + dr["par_dircodposta"].ToString() + "'" +
                         ",'" + dr["par_dirtelefono"].ToString() + "'" +
                         ",'" + dr["par_expecalle"].ToString() + "'" +
                         ",'" + dr["par_expenumero"].ToString() + "'" +
                         ",'" + dr["par_expecolonia"].ToString() + "'" +
                         ",'" + dr["par_expemunicipio"].ToString() + "'" +
                         ",'" + dr["par_expeestado"].ToString() + "'" +
                         ",'" + dr["par_expepais"].ToString() + "'" +
                         ",'" + dr["par_cuenta"].ToString() + "'" +
                         ",'" + dr["par_PrcCode"].ToString() + "'"+
                        ",'" + dr["par_serie"].ToString() + "')";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        if (dr["par_logore"] != null && !(dr["par_logore"] is System.DBNull))
                        {
                            string carpeta = "C:/STRATA_POS";
                            string rutaArchivoCadena = carpeta + "/Logo.jpg";

                            if (!Directory.Exists(carpeta))
                            {
                                System.IO.Directory.CreateDirectory(carpeta);
                            }
                            byte[] logo = (byte[])dr["par_logore"];
                            using (MemoryStream m = new MemoryStream(logo))
                            using (FileStream fm = new FileStream(rutaArchivoCadena, FileMode.Create))
                            {
                                m.CopyTo(fm);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SincronizarCataAlma()
        {
            string con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;";
            //string con = @"Server=.;Database=STRATA_PV;uid=sa;pwd=Createga2016;";

            try
            {
                DataSet dt = new DataSet();
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM cataalma WHERE alm_PrcCode = (SELECT par_PrcCode FROM confpara) AND alm_activo = 1";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        sda.Fill(dt);
                    }
                }

                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";

                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        cnx.Open();
                        string SqlAction = "DELETE FROM cataalma";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            int res = cmd.ExecuteNonQuery();
                        }

                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            SqlAction = "INSERT INTO [cataalma] ([alm_keyalm],[alm_nombre],[alm_activo],[alm_estado],[alm_PrcCode]) "+
                                        " VALUES (" +
                                        "'" + dr["alm_keyalm"].ToString() + "'" +
                                        ",'" + dr["alm_nombre"].ToString() + "'" +
                                        ",'" + dr["alm_activo"].ToString() + "'" +
                                        ",'" + dr["alm_estado"].ToString() + "'" +
                                        ",'" + dr["alm_PrcCode"].ToString() + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        //DataRow dr = dt.Tables[0].Rows[0];

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*==========================================*/
        private void SincronizarProcPromo()
        {
            string con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;";
            //string con = @"Server=.;Database=STRATA_PV;uid=sa;pwd=Createga2016;";

            try
            {
                DataSet dt = new DataSet();
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM procpromo";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        sda.Fill(dt);
                    }
                }

                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";

                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        cnx.Open();
                        string SqlAction = "DELETE FROM procpromo";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            int res = cmd.ExecuteNonQuery();
                        }

                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            SqlAction = "INSERT INTO [procpromo] ([prom_codigo],[prom_descrip],[prom_fini],[prom_ffin],[prom_tpromo],[prom_lun],[prom_mar],[prom_mie],[prom_jue],[prom_vie],[prom_sab],[prom_dom],[prom_cantr],[prom_canta]) " +
                                        " VALUES (" +
                                        "'" + dr["prom_codigo"].ToString() + "'" +
                                        ",'" + dr["prom_descrip"].ToString() + "'" +
                                        ",'" + Convert.ToDateTime(dr["prom_fini"].ToString()).ToString("yyyyMMdd") + "'" +
                                        ",'" + Convert.ToDateTime(dr["prom_ffin"].ToString()).ToString("yyyyMMdd") + "'" +
                                        ",'" + dr["prom_tpromo"].ToString() + "'" +
                                        ",'" + dr["prom_lun"].ToString() + "'" +
                                        ",'" + dr["prom_mar"].ToString() + "'" +
                                        ",'" + dr["prom_mie"].ToString() + "'" +
                                        ",'" + dr["prom_jue"].ToString() + "'" +
                                        ",'" + dr["prom_vie"].ToString() + "'" +
                                        ",'" + dr["prom_sab"].ToString() + "'" +
                                        ",'" + dr["prom_dom"].ToString() + "'" +
                                        ",'" + dr["prom_cantr"].ToString() + "'" +
                                        ",'" + dr["prom_canta"].ToString() + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        //DataRow dr = dt.Tables[0].Rows[0];

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*==========================================*/
        private void SincronizarPromArti()
        {
            string con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;";
            //string con = @"Server=.;Database=STRATA_PV;uid=sa;pwd=Createga2016;";

            try
            {
                DataSet dt = new DataSet();
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM promarti";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        sda.Fill(dt);
                    }
                }

                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";

                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        cnx.Open();
                        string SqlAction = "DELETE FROM promarti";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            int res = cmd.ExecuteNonQuery();
                        }

                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            SqlAction = "INSERT INTO [promarti]([prar_codprom],[prar_keyart],[prar_precio],[prar_porcdesc],[prar_predesc],[prar_esnec],[prar_esreg]) " +
                                        " VALUES (" +
                                        "'" + dr["prar_codprom"].ToString() + "'" +
                                        ",'" + dr["prar_keyart"].ToString() + "'" +
                                        ",'" + dr["prar_precio"].ToString() + "'" +
                                        ",'" + dr["prar_porcdesc"].ToString() + "'" +
                                        ",'" + dr["prar_predesc"].ToString() + "'" +
                                        ",'" + dr["prar_esnec"].ToString() + "'" +
                                        ",'" + dr["prar_esreg"].ToString() + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        //DataRow dr = dt.Tables[0].Rows[0];

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*==========================================*/
        private void SincronizarProcPQtes()
        {
            string con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;";
            //string con = @"Server=.;Database=STRATA_PV;uid=sa;pwd=Createga2016;";

            try
            {
                DataSet dt = new DataSet();
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM procpqtes";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        sda.Fill(dt);
                    }
                }

                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";

                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        cnx.Open();
                        string SqlAction = "DELETE FROM procpqtes";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            int res = cmd.ExecuteNonQuery();
                        }

                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            SqlAction = "INSERT INTO [procpqtes]([pqt_codigo],[pqt_fini],[pqt_ffin],[pqt_descrip],[pqt_precio]) " +
                                        " VALUES (" +
                                        "'" + dr["pqt_codigo"].ToString() + "'" +
                                        ",'" + Convert.ToDateTime(dr["pqt_fini"].ToString()).ToString("yyyyMMdd") + "'" +
                                        ",'" + Convert.ToDateTime(dr["pqt_ffin"].ToString()).ToString("yyyyMMdd") + "'" +
                                        ",'" + dr["pqt_descrip"].ToString() + "'" +
                                        ",'" + dr["pqt_precio"].ToString() + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        //DataRow dr = dt.Tables[0].Rows[0];

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*==========================================*/
        private void SincronizarPQteArti()
        {
            string con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;";
            //string con = @"Server=.;Database=STRATA_PV;uid=sa;pwd=Createga2016;";

            try
            {
                DataSet dt = new DataSet();
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM pqtearti";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        sda.Fill(dt);
                    }
                }

                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";

                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        cnx.Open();
                        string SqlAction = "DELETE FROM pqtearti";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            int res = cmd.ExecuteNonQuery();
                        }

                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            SqlAction = "INSERT INTO [pqtearti]([part_codpqte],[part_keyart],[part_cantidad]) " +
                                        " VALUES (" +
                                        "'" + dr["part_codpqte"].ToString() + "'" +
                                        ",'" + dr["part_keyart"].ToString() + "'" +
                                        ",'" + dr["part_cantidad"].ToString() + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        //DataRow dr = dt.Tables[0].Rows[0];

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*==========================================*/
        private void SincronizarDiaProm()
        {
            string con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;";
            //string con = @"Server=.;Database=STRATA_PV;uid=sa;pwd=Createga2016;";

            try
            {
                DataSet dt = new DataSet();
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM diaprom";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        sda.Fill(dt);
                    }
                }

                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";

                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        cnx.Open();
                        string SqlAction = "DELETE FROM diaprom";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            int res = cmd.ExecuteNonQuery();
                        }

                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            SqlAction = "INSERT INTO [diaprom]([diap_id],[diap_codprom],[diap_diaaplica],[diap_diadescrip]) " +
                                        " VALUES (" +
                                        "'" + dr["diap_id"].ToString() + "'" +
                                        ",'" + dr["diap_codprom"].ToString() + "'" +
                                         "'" + dr["diap_diaaplica"].ToString() + "'" +
                                        ",'" + dr["diap_diadescrip"].ToString() + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        //DataRow dr = dt.Tables[0].Rows[0];

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void SincronizarCataMeto1()
        {
            string con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;";
            //string con = @"Server=.;Database=STRATA_PV;uid=sa;pwd=Createga2016;";

            try
            {
                DataSet dt = new DataSet();
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM catameto1";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        sda.Fill(dt);
                    }
                }

                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";

                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        cnx.Open();
                        string SqlAction = "DELETE FROM catameto1";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            int res = cmd.ExecuteNonQuery();
                        }

                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            SqlAction = "INSERT INTO [catameto1] ([met1_keymet],[met1_identi],[met1_descripc],[met1_fecalt],[met1_fecmod],[met1_usrmod],[met1_activo]) " +
                                        " VALUES (" +
                                        "'" + dr["met1_keymet"].ToString() + "'" +
                                        ",'" + dr["met1_identi"].ToString() + "'" +
                                        ",'" + dr["met1_descripc"].ToString() + "'" +
                                        ",'" + Convert.ToDateTime(dr["met1_fecalt"].ToString()).ToString("yyyyMMdd") + "'" +
                                        ",'" + Convert.ToDateTime(dr["met1_fecmod"].ToString()).ToString("yyyyMMdd") + "'" +
                                        ",'" + dr["met1_usrmod"].ToString() + "'" +
                                        ",'" + dr["met1_activo"].ToString() + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void SincronizarProcVentP()
        {
            string con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;";
            //string con = @"Server=.;Database=STRATA_PV;uid=sa;pwd=Createga2016;";

            try
            {
                DataSet dt = new DataSet();
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM procventp";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        sda.Fill(dt);
                    }
                }

                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";

                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        cnx.Open();
                        string SqlAction = "DELETE FROM procventp";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            int res = cmd.ExecuteNonQuery();
                        }

                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {                            
                            SqlAction = "INSERT INTO [procventp] ([venp_keyven],[venp_NumLin],[venp_articulo],[venp_artdes],[venp_cantidad],[venp_precio],[venp_iva],[venp_ieps],[venp_totallinea],[venp_moneda],[venp_tipocambio],[venp_escompues],[venp_idpaquete],[venp_porcdesc],[venp_descuento],[venp_keyalm],[venp_keypro],[venp_OcrCode]) " +
                                        " VALUES (" +
                                        "'" + dr["venp_keyven"].ToString() + "'" +
                                        ",'" + dr["venp_NumLin"].ToString() + "'" +
                                        ",'" + dr["venp_articulo"].ToString() + "'" +
                                        ",'" + dr["venp_artdes"].ToString() + "'" +
                                        ",'" + dr["venp_cantidad"].ToString() + "'" +
                                        ",'" + dr["venp_precio"].ToString() + "'" +
                                        ",'" + dr["venp_iva"].ToString() + "'" +
                                        ",'" + dr["venp_ieps"].ToString() + "'" +
                                        ",'" + dr["venp_totallinea"].ToString() + "'" +
                                        ",'" + dr["venp_moneda"].ToString() + "'" +
                                        ",'" + dr["venp_tipocambio"].ToString() + "'" +
                                        ",'" + dr["venp_escompues"].ToString() + "'" +
                                        ",'" + dr["venp_idpaquete"].ToString() + "'" +
                                        ",'" + dr["venp_porcdesc"].ToString() + "'" +
                                        ",'" + dr["venp_descuento"].ToString() + "'" +
                                        ",'" + dr["venp_keyalm"].ToString() + "'" +
                                        ",'" + dr["venp_keypro"].ToString() + "'" +
                                        ",'" + dr["venp_OcrCode"].ToString() + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SincronizarArticulos()
        {
            string con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;";
            //string con = @"Server=.;Database=STRATA_PV;uid=sa;pwd=Createga2016;";

            try
            {
                DataSet dt = new DataSet();
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM cataarti WHERE art_esVenta = 1";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        sda.Fill(dt);
                    }
                }

                if (dt != null && dt.Tables[0].Rows.Count > 0)
                {
                    con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";

                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        cnx.Open();
                        string SqlAction = "delete from cataarti";
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            int res = cmd.ExecuteNonQuery();
                        }
                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            SqlAction = "INSERT INTO cataarti(art_keyart, art_descripc, at_precioventa, art_codbar)" +
                            " VALUES('" + dr[0].ToString() + "', '" + dr[1].ToString() + "', '" + dr[10].ToString() + "', '"+ dr["art_codBar"].ToString() + "');";//El código de barras se agregara en el futuro
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SincronizarPerfPerm()
        {
            lstPERFPERM = new List<entPerfPerm>();
            string con = txtPatCpu.Text;
            con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;"; //txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM perfperm";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        DataSet dt = new DataSet();
                        sda.Fill(dt);
                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            #region
                            entPERF = new entPerfPerm();
                            entPERF.ppe_keyperf = dr["ppe_keyperf"].ToString();
                            entPERF.ppe_keymod = dr["ppe_keymod"].ToString();
                            entPERF.ppe_keypan = dr["ppe_keypan"].ToString();
                            lstPERFPERM.Add(entPERF);
                            #endregion
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                string error = string.Empty;
                error = ex.Message;
                MessageBox.Show(error, "Error ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if (lstPERFPERM.Count > 0)
            {
                #region conexion local
                con = txtPatCpu.Text;
                using (SqlCeConnection cnx = new SqlCeConnection(con))
                {
                    cnx.Open();
                    string SqlAction = "DELETE FROM perfperm";
                    using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                    {
                        SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                    cnx.Close();
                }
                con = txtPatCpu.Text;
                int keyError = 0;
                try
                {
                    using (SqlCeConnection connection = new SqlCeConnection(con))
                    {
                        connection.Open();
                        foreach (entPerfPerm ent in lstPERFPERM)
                        {

                            string SqlAction = "INSERT INTO [perfperm] ([ppe_keyperf],[ppe_keymod],[ppe_keypan]) " +
                                               "VALUES " +
                                               "('" + ent.ppe_keyperf + "','" + ent.ppe_keymod + "','" + ent.ppe_keypan + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, connection))
                            {
                                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                                cmd.ExecuteNonQuery();
                            }
                            keyError++;
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    string error = string.Empty;
                    error = ex.Message;
                    MessageBox.Show(error,"Error " + keyError, MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
                #endregion
            }
        }

        private void SincronizarUsuaPerf()
        {
            lstUSUAPERF = new List<entUsuaPerf>();
            string con = txtPatCpu.Text;
            con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;"; //txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM usuaperf";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        DataSet dt = new DataSet();
                        sda.Fill(dt);
                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            #region
                            entUSUA = new entUsuaPerf();
                            entUSUA.upe_keyusu = dr["upe_keyusu"].ToString();
                            entUSUA.upe_keyperf = dr["upe_keyperf"].ToString();
                            lstUSUAPERF.Add(entUSUA);
                            #endregion
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                string error = string.Empty;
                error = ex.Message;
            }
            if (lstUSUAPERF.Count > 0)
            {
                #region conexion local
                con = txtPatCpu.Text;
                using (SqlCeConnection cnx = new SqlCeConnection(con))
                {
                    cnx.Open();
                    string SqlAction = "DELETE FROM usuaperf";
                    using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                    {
                        SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                    cnx.Close();
                }
                con = txtPatCpu.Text;
                try
                {
                    using (SqlCeConnection connection = new SqlCeConnection(con))
                    {
                        connection.Open();
                        foreach (entUsuaPerf ent in lstUSUAPERF)
                        {

                            string SqlAction = "INSERT INTO [usuaperf] ([upe_keyusu],[upe_keyperf]) " +
                                               "VALUES " +
                                               "('" + ent.upe_keyusu + "','" + ent.upe_keyperf + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, connection))
                            {
                                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    string error = string.Empty;
                    error = ex.Message;
                }
                #endregion
            }
        }

        private void SincronizarSeguPerf()
        {
            lstSEGUPERF = new List<entSeguPerf>();
            string con = txtPatCpu.Text;
            con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;"; //txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT per_keyperf, per_nombre, per_activo, isnull(per_fecalt, '19000101')per_fecalt, isnull(per_fecmod, '19000101') per_fecmod, per_usumod  FROM seguperf";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        DataSet dt = new DataSet();
                        sda.Fill(dt);
                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            #region
                            entSEPE = new entSeguPerf();
                            entSEPE.per_keyperf = dr["per_keyperf"].ToString();
                            entSEPE.per_nombre = dr["per_nombre"].ToString();
                            entSEPE.per_activo = Convert.ToBoolean(dr["per_activo"].ToString());
                            entSEPE.per_fecalt = Convert.ToDateTime(dr["per_fecalt"].ToString());
                            entSEPE.per_fecmod = Convert.ToDateTime(dr["per_fecmod"].ToString());
                            entSEPE.per_usumod = dr["per_usumod"].ToString();
                            lstSEGUPERF.Add(entSEPE);
                            #endregion
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                string error = string.Empty;
                error = ex.Message;
            }
            if (lstUSUAPERF.Count > 0)
            {
                #region conexion local
                con = txtPatCpu.Text;
                using (SqlCeConnection cnx = new SqlCeConnection(con))
                {
                    cnx.Open();
                    string SqlAction = "DELETE FROM seguperf";
                    using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                    {
                        SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                    cnx.Close();
                }
                con = txtPatCpu.Text;
                try
                {
                    using (SqlCeConnection connection = new SqlCeConnection(con))
                    {
                        connection.Open();
                        foreach (entSeguPerf ent in lstSEGUPERF)
                        {

                            string SqlAction = "INSERT INTO [seguperf] ([per_keyperf],[per_nombre],[per_activo],[per_fecalt],[per_fecmod],[per_usumod]) " +
                                               "VALUES " +
                                               "('" + ent.per_keyperf + "','" + ent.per_nombre + "', '" + ent.per_activo + "','" + ent.per_fecalt.ToString("yyyyMMdd") + "','" + ent.per_fecmod.ToString("yyyyMMdd") + "','" + ent.per_usumod + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, connection))
                            {
                                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    string error = string.Empty;
                    error = ex.Message;
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion
            }
        }

        private void SincronizarSeguUsua()
        {
            lstSEGUUSUA = new List<entSeguUsua>();
            string con = txtPatCpu.Text;
            con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;"; //txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM seguusua";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        DataSet dt = new DataSet();
                        sda.Fill(dt);
                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            #region
                            entSEGU = new entSeguUsua();
                            entSEGU.usu_keyusu = dr["usu_keyusu"].ToString();
                            entSEGU.usu_passwo = dr["usu_passwo"].ToString();
                            entSEGU.usu_nombre = dr["usu_nombre"].ToString();
                            entSEGU.usu_correo = dr["usu_correo"].ToString();
                            entSEGU.usu_activo = Convert.ToBoolean(dr["usu_activo"].ToString());
                            entSEGU.usu_fecalt = Convert.ToDateTime(dr["usu_fecalt"].ToString());
                            entSEGU.usu_fecmod = Convert.ToDateTime(dr["usu_fecmod"].ToString());
                            entSEGU.usu_usumod = dr["usu_usumod"].ToString();
                            lstSEGUUSUA.Add(entSEGU);
                            #endregion
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                string error = string.Empty;
                error = ex.Message;
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (lstSEGUUSUA.Count > 0)
            {
                #region conexion local
                con = txtPatCpu.Text;
                using (SqlCeConnection cnx = new SqlCeConnection(con))
                {
                    cnx.Open();
                    string SqlAction = "DELETE FROM seguusua";
                    using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                    {
                        SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                    cnx.Close();
                }
                con = txtPatCpu.Text;
                try
                {
                    using (SqlCeConnection connection = new SqlCeConnection(con))
                    {
                        connection.Open();
                        foreach (entSeguUsua ent in lstSEGUUSUA)
                        {

                            string SqlAction = "INSERT INTO [seguusua] ([usu_keyusu],[usu_passwo],[usu_nombre],[usu_correo],[usu_activo],[usu_fecalt],[usu_fecmod],[usu_usumod]) " +
                                               "VALUES " +
                                               "('" + ent.usu_keyusu + "','" + ent.usu_passwo + "','" + ent.usu_nombre + "','" + ent.usu_correo + "','" + ent.usu_activo + "','" + ent.usu_fecalt.ToString("yyyyMMdd") + "','" + ent.usu_fecmod.ToString("yyyyMMdd") + "','" + ent.usu_usumod + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, connection))
                            {
                                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    string error = string.Empty;
                    error = ex.Message;
                    MessageBox.Show(error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                #endregion
            }
        }

        private void SincronizarCataMeto()
        {
            lstCATAMETO = new List<entCataMeto>();
            string con = txtPatCpu.Text;
            con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;"; //txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM catameto";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        DataSet dt = new DataSet();
                        sda.Fill(dt);
                        foreach (DataRow dr in dt.Tables[0].Rows)
                        {
                            #region
                            entCATA = new entCataMeto();
                            entCATA.met_keymet = dr["met_keymet"].ToString();
                            entCATA.met_descripc = dr["met_descripc"].ToString();
                            entCATA.met_fecalt = (!string.IsNullOrEmpty(dr["met_fecalt"].ToString()) ? Convert.ToDateTime(dr["met_fecalt"].ToString()) : DateTime.Now);
                            entCATA.met_fecmod = (!string.IsNullOrEmpty(dr["met_fecmod"].ToString()) ? Convert.ToDateTime(dr["met_fecmod"].ToString()) : DateTime.Now); ;
                            entCATA.met_usrmod = dr["met_usrmod"].ToString();
                            entCATA.met_activo = Convert.ToBoolean(dr["met_activo"].ToString());
                            entCATA.met_codigo = dr["met_codigo"].ToString();
                            lstCATAMETO.Add(entCATA);
                            #endregion
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                string error = string.Empty;
                error = ex.Message;
            }
            if (lstCATAMETO.Count > 0)
            {
                #region conexion local
                con = txtPatCpu.Text;
                using (SqlCeConnection cnx = new SqlCeConnection(con))
                {
                    cnx.Open();
                    string SqlAction = "DELETE FROM catameto";
                    using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                    {
                        SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                    cnx.Close();
                }
                con = txtPatCpu.Text;
                try
                {
                    using (SqlCeConnection connection = new SqlCeConnection(con))
                    {
                        connection.Open();
                        foreach (entCataMeto ent in lstCATAMETO)
                        {

                            string SqlAction = "INSERT INTO [catameto] ([met_keymet],[met_descripc],[met_fecalt],[met_fecmod],[met_usrmod],[met_activo],[met_codigo]) " +
                                               "VALUES " +
                                               "('" + ent.met_keymet + "','" + ent.met_descripc + "','" + ent.met_fecalt.ToString("yyyyMMdd") + "','" + ent.met_fecmod.ToString("yyyyMMdd") + "','" + ent.met_usrmod + "','" + ent.met_activo + "','" + ent.met_codigo + "')";
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, connection))
                            {
                                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    string error = string.Empty;
                    error = ex.Message;
                }
                #endregion
            }
        }

        private void EnviarVentas()
        {
            lstVns = new List<entProcVent>();
            lstVnl = new List<entProcVent>();
            lstDvl = new List<entProcVent1>();
            lstDvs = new List<entProcVent1>();
            lstVnsP = new List<entProcVentP>();
            lstVnl4 = new List<entProcVent4>();
            DataSet procvent4 = new DataSet();
            DataSet procventp = new DataSet();

            #region conexion local
            int i = 0;
            string con = txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
            #region encabezado
            using (SqlCeConnection cnx = new SqlCeConnection(con))
            {
                string SqlAction = "SELECT * FROM procvent where ven_docnumsap is null";
                using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                {
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        #region
                        entVnl = new entProcVent();
                        entVnl.ven_keyven = Convert.ToInt32(dr["ven_keyven"].ToString());
                        entVnl.ven_caja = dr["ven_caja"].ToString();
                        entVnl.ven_usrven = dr["ven_usrven"].ToString();
                        entVnl.ven_cliente = dr["ven_cliente"].ToString();
                        entVnl.ven_estado = dr["ven_estado"].ToString();
                        entVnl.ven_fecreg = Convert.ToDateTime(dr["ven_fecreg"].ToString());
                        entVnl.ven_iva = Convert.ToDecimal(dr["ven_iva"].ToString());
                        entVnl.ven_ieps = Convert.ToDecimal(dr["ven_ieps"].ToString());
                        entVnl.ven_retencion = Convert.ToDecimal(dr["ven_retencion"].ToString());
                        entVnl.ven_descue = Convert.ToDecimal(dr["ven_descue"].ToString());
                        entVnl.ven_subtot = Convert.ToDecimal(dr["ven_subtot"].ToString());
                        entVnl.ven_total = Convert.ToDecimal(dr["ven_total"].ToString());
                        entVnl.ven_porcdesc = Convert.ToDecimal(dr["ven_porcdesc"].ToString());
                        entVnl.ven_porciva = Convert.ToDecimal(dr["ven_porciva"].ToString());
                        entVnl.ven_porcieps = Convert.ToDecimal(dr["ven_porcieps"].ToString());
                        entVnl.ven_porcretencion = Convert.ToDecimal(dr["ven_porcretencion"].ToString());
                        entVnl.ven_almace = dr["ven_almace"].ToString();
                        entVnl.ven_serie = dr["ven_serie"].ToString();
                        lstVnl.Add(entVnl);
                        #endregion
                    }
                }
            }
            #endregion
            /*======================================*/
            #region detalle de venta
            if (lstVnl.Count > 0)
            {
                foreach (entProcVent ent in lstVnl)
                {
                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        string SqlAction = "SELECT * FROM procvent1 where ven1_keyven = " + ent.ven_keyven;
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            int lin = 0;
                            foreach (DataRow dr in dt.Rows)
                            {
                                #region
                                entDvl = new entProcVent1();
                                entDvl.ven1_keyven = Convert.ToInt32(dr["ven1_keyven"].ToString());
                                entDvl.ven1_numlin = lin;
                                entDvl.ven1_articulo = dr["ven1_articulo"].ToString();
                                entDvl.ven1_artdes = dr["ven1_artdes"].ToString();
                                entDvl.ven1_cantidad = Convert.ToDecimal(dr["ven1_cantidad"].ToString());
                                entDvl.ven1_precio = Convert.ToDecimal(dr["ven1_precio"].ToString());
                                entDvl.ven1_iva = Convert.ToDecimal(dr["ven1_ieps"].ToString());
                                entDvl.ven1_ieps = Convert.ToDecimal(dr["ven1_ieps"].ToString());
                                entDvl.ven1_totallinea = Convert.ToDecimal(dr["ven1_totallinea"].ToString());
                                entDvl.ven1_moneda = dr["ven1_moneda"].ToString();
                                entDvl.ven1_tipocambio = Convert.ToDecimal(dr["ven1_tipocambio"].ToString());
                                entDvl.ven1_escompues = Convert.ToBoolean(dr["ven1_escompues"].ToString());
                                entDvl.ven1_idpaquete = dr["ven1_idpaquete"].ToString();
                                entDvl.ven1_porcdesc = Convert.ToDecimal(dr["ven1_porcdesc"].ToString());
                                entDvl.ven1_descuento = Convert.ToDecimal(dr["ven1_descuento"].ToString());
                                entDvl.ven1_keyalm = dr["ven1_keyalm"].ToString();
                                entDvl.ven1_keypro = dr["ven1_keypro"].ToString();
                                entDvl.ven1_OcrCode = dr["ven1_OcrCode"].ToString();
                                lstDvl.Add(entDvl);
                                #endregion
                                lin++;
                            }
                        }
                    }


                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        string SqlAction = "SELECT * FROM procventp WHERE venp_keyven = " + ent.ven_keyven;
                        using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                        {
                            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            int lin = 0;
                            foreach (DataRow dr in dt.Rows)
                            {
                                #region
                                entPVP = new entProcVentP();
                                entPVP.venp_keyven = Convert.ToInt32(dr["venp_keyven"].ToString());
                                entPVP.venp_NumLin = lin;
                                entPVP.venp_articulo = dr["venp_articulo"].ToString();
                                entPVP.venp_artdes = dr["venp_artdes"].ToString();
                                entPVP.venp_cantidad = Convert.ToDecimal(dr["venp_cantidad"].ToString());
                                entPVP.venp_precio = Convert.ToDecimal(dr["venp_precio"].ToString());
                                entPVP.venp_iva = Convert.ToDecimal(dr["venp_iva"].ToString());
                                entPVP.venp_ieps = Convert.ToDecimal(dr["venp_ieps"].ToString());
                                entPVP.venp_totallinea = Convert.ToDecimal(dr["venp_totallinea"].ToString());
                                entPVP.venp_moneda = dr["venp_moneda"].ToString();
                                entPVP.venp_tipocambio = Convert.ToDecimal(dr["venp_tipocambio"].ToString());
                                entPVP.venp_escompues = Convert.ToBoolean(dr["venp_escompues"].ToString());
                                entPVP.venp_idpaquete = dr["venp_idpaquete"].ToString();
                                entPVP.venp_porcdesc = Convert.ToDecimal(dr["venp_porcdesc"].ToString());
                                entPVP.venp_descuento = Convert.ToDecimal(dr["venp_descuento"].ToString());
                                entPVP.venp_keyalm = dr["venp_keyalm"].ToString();
                                entPVP.venp_keypro = dr["venp_keypro"].ToString();
                                entPVP.venp_OcrCode = dr["venp_OcrCode"].ToString();
                                lstVnsP.Add(entPVP);
                                #endregion
                                lin++;
                            }
                        }
                    }
                    try
                    {
                        using (SqlCeConnection cnx = new SqlCeConnection(con))
                        {
                            string SqlAction = "SELECT * FROM procvent4 WHERE ven4_keyven = " + ent.ven_keyven;
                            using (SqlCeCommand cmd = new SqlCeCommand(SqlAction, cnx))
                            {
                                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                foreach (DataRow dr in dt.Rows)
                                {
                                    #region
                                    entVnl4 = new entProcVent4();
                                    entVnl4.ven4_keyven = Convert.ToInt32(dr["ven4_keyven"].ToString());
                                    entVnl4.ven4_metodopago = dr["ven4_metodopago"].ToString();
                                    entVnl4.ven4_metododet = Convert.ToInt32(dr["ven4_metododet"].ToString());
                                    entVnl4.ven4_fecreg = Convert.ToDateTime(dr["ven4_fecreg"].ToString());
                                    entVnl4.ven4_importe = Convert.ToDecimal(dr["ven4_importe"].ToString());
                                    entVnl4.ven4_terminal = Convert.ToInt32(dr["ven4_terminal"].ToString());
                                    entVnl4.ven4_keyven4 = Convert.ToInt32(dr["ven4_keyven4"].ToString());
                                    //entVnl4.ven4_numpago = 1;
                                    //entVnl4.ven4_keyven8 = Convert.ToInt32(dr["ven4_keyven8"].ToString());
                                    entVnl4.ven4_metodoref = dr["ven4_metodoref"].ToString();
                                    entVnl4.ven4_cuenta = dr["ven4_cuenta"].ToString();
                                    entVnl4.ven4_formapago = dr["ven4_formapago"].ToString();
                                    entVnl4.ven4_msjError = dr["ven4_msjError"].ToString();
                                    //entVnl4.ven4_enviadobita = Convert.ToBoolean(dr["ven4_enviadobita"].ToString());
                                    //entVnl4.ven4_enviado = Convert.ToBoolean(dr["ven4_enviado"].ToString());
                                    //entVnl4.ven4_cancelado = Convert.ToBoolean(dr["ven4_cancelado"].ToString());
                                    lstVnl4.Add(entVnl4);
                                    #endregion
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string error = string.Empty;
                        error = ex.Message;
                        MessageBox.Show(error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }


            }
            #endregion
            #endregion
            #region conexion servidor
            con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;"; //txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                    conn.ConnectionString = con;
                    conn.Open();

                    string command = "SELECT * FROM procvent";

                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            #region
                            entVns = new entProcVent();
                            entVns.ven_keyven = Convert.ToInt32(dr["ven_keyven"].ToString());
                            entVns.ven_caja = dr["ven_caja"].ToString();
                            entVns.ven_usrven = dr["ven_usrven"].ToString();
                            entVns.ven_cliente = dr["ven_cliente"].ToString();
                            entVns.ven_estado = dr["ven_estado"].ToString();
                            entVns.ven_fecreg = Convert.ToDateTime(dr["ven_fecreg"].ToString());
                            entVns.ven_iva = Convert.ToDecimal(dr["ven_iva"].ToString());
                            entVns.ven_ieps = Convert.ToDecimal(dr["ven_ieps"].ToString());
                            entVns.ven_retencion = Convert.ToDecimal(dr["ven_retencion"].ToString());
                            entVns.ven_descue = Convert.ToDecimal(dr["ven_descue"].ToString());
                            entVns.ven_subtot = Convert.ToDecimal(dr["ven_subtot"].ToString());
                            entVns.ven_total = Convert.ToDecimal(dr["ven_total"].ToString());
                            entVns.ven_porcdesc = Convert.ToDecimal(dr["ven_porcdesc"].ToString());
                            entVns.ven_porciva = Convert.ToDecimal(dr["ven_porciva"].ToString());
                            entVns.ven_porcieps = Convert.ToDecimal(dr["ven_porcieps"].ToString());
                            entVns.ven_porcretencion = Convert.ToDecimal(dr["ven_porcretencion"].ToString());
                            entVns.ven_almace = dr["ven_almace"].ToString();
                            entVns.ven_keypos = Convert.ToInt32(dr["ven_keypos"].ToString());
                            entVns.ven_serie = dr["ven_serie"].ToString();
                            lstVns.Add(entVns);
                            #endregion
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = string.Empty;
                error = ex.Message;
            }
            #endregion

            #region validacion e inserccion
            if (lstVns.Count == 0)
            {
                int ventaFinal = 0;
                #region inserccion en el servidor
                try
                {
                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        SqlCommand cmd = new SqlCommand();

                        lstKey = new List<int>();
                        foreach (entProcVent ent in lstVnl)
                        {
                            cmd.CommandText = "INSERT INTO procvent (ven_caja,ven_usrven,ven_cliente,ven_estado,ven_fecreg,ven_iva,ven_ieps,ven_retencion,ven_descue,ven_subtot," +
                                               "ven_total,ven_porcdesc,ven_porciva,ven_porcieps,ven_porcretencion, ven_keypos,ven_serie) " +
                                               "VALUES " +
                                               "('" + ent.ven_caja + "','" + ent.ven_usrven + "','" + ent.ven_cliente + "','" + ent.ven_estado + "', " +
                                               "'" + ent.ven_fecreg.ToString("yyyyMMdd") + "'," + ent.ven_iva + "," + ent.ven_ieps + "," + ent.ven_retencion + "," + ent.ven_descue + ", " +
                                               "" + ent.ven_subtot + "," + ent.ven_total + "," + ent.ven_porcdesc + "," + ent.ven_porciva + "," + ent.ven_porcieps + ", " +
                                               "" + ent.ven_porcretencion + ", " + ent.ven_keyven + ", " + ent.ven_serie + ")";
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;

                            if (connection.State == ConnectionState.Closed)
                                connection.Open();
                            cmd.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    string error = string.Empty;
                    error = ex.Message;
                }
                #endregion
                #region conexion servidor
                con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;"; //txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                        conn.ConnectionString = con;
                        conn.Open();

                        string command = "SELECT max(ven_keyven) venta FROM procvent";

                        using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            foreach (DataRow dr in dt.Rows)
                            {
                                #region
                                ventaFinal = Convert.ToInt32(dr[0].ToString());
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string error = string.Empty;
                    error = ex.Message;
                }
                #endregion
                #region inserccion del detalle de la venta
                try
                {
                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        SqlCommand cmd = new SqlCommand();

                        foreach (entProcVent1 ent in lstDvl)
                        {
                            cmd.CommandText = "INSERT INTO procvent1(ven1_keyven, ven1_numlin, ven1_articulo, ven1_artdes, ven1_cantidad, ven1_precio, ven1_iva, ven1_ieps, " +
                                              "ven1_totallinea, ven1_moneda, ven1_tipocambio, ven1_escompues, ven1_idpaquete, ven1_porcdesc, ven1_descuento, ven1_keyalm, " +
                                              "ven1_keypro, ven1_OcrCode) " +
                                               "VALUES " +
                                               "(" + ventaFinal + ", " + ent.ven1_numlin + ", '" + ent.ven1_articulo + "', '" + ent.ven1_artdes + "', " + ent.ven1_cantidad + ", " +
                                               "" + ent.ven1_precio + ", " + ent.ven1_iva + ", " + ent.ven1_ieps + ", " + ent.ven1_totallinea + ", '" + ent.ven1_moneda + "', " +
                                               "" + ent.ven1_tipocambio + ", " + (ent.ven1_escompues == true ? 1 : 0) + ", '" + ent.ven1_idpaquete + "', " + ent.ven1_porcdesc + ", " +
                                               "" + ent.ven1_descuento + ", '" + ent.ven1_keyalm + "', '" + ent.ven1_keypro + "', '" + ent.ven1_OcrCode + "')";
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;

                            if (connection.State == ConnectionState.Closed)
                                connection.Open();
                            cmd.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    string error = string.Empty;
                    error = ex.Message;
                }
                #endregion
                #region conexion servidor
                con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;"; //txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                        conn.ConnectionString = con;
                        conn.Open();

                        string command = "SELECT * FROM procvent";

                        using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            lstVns = new List<entProcVent>();
                            foreach (DataRow dr in dt.Rows)
                            {
                                #region
                                entVns = new entProcVent();
                                entVns.ven_keyven = Convert.ToInt32(dr["ven_keyven"].ToString());
                                entVns.ven_caja = dr["ven_caja"].ToString();
                                entVns.ven_usrven = dr["ven_usrven"].ToString();
                                entVns.ven_cliente = dr["ven_cliente"].ToString();
                                entVns.ven_estado = dr["ven_estado"].ToString();
                                entVns.ven_fecreg = Convert.ToDateTime(dr["ven_fecreg"].ToString());
                                entVns.ven_iva = Convert.ToDecimal(dr["ven_iva"].ToString());
                                entVns.ven_ieps = Convert.ToDecimal(dr["ven_ieps"].ToString());
                                entVns.ven_retencion = Convert.ToDecimal(dr["ven_retencion"].ToString());
                                entVns.ven_descue = Convert.ToDecimal(dr["ven_descue"].ToString());
                                entVns.ven_subtot = Convert.ToDecimal(dr["ven_subtot"].ToString());
                                entVns.ven_total = Convert.ToDecimal(dr["ven_total"].ToString());
                                entVns.ven_porcdesc = Convert.ToDecimal(dr["ven_porcdesc"].ToString());
                                entVns.ven_porciva = Convert.ToDecimal(dr["ven_porciva"].ToString());
                                entVns.ven_porcieps = Convert.ToDecimal(dr["ven_porcieps"].ToString());
                                entVns.ven_porcretencion = Convert.ToDecimal(dr["ven_porcretencion"].ToString());
                                entVns.ven_almace = dr["ven_almace"].ToString();
                                entVns.ven_keypos = Convert.ToInt32(dr["ven_keypos"].ToString());
                                entVns.ven_serie = dr["ven_serie"].ToString();
                                lstVns.Add(entVns);
                                #endregion
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string error = string.Empty;
                    error = ex.Message;
                }
                #endregion
                #region actualización POS
                con = txtPatCpu.Text;
                using (SqlCeConnection cnx = new SqlCeConnection(con))
                {
                    foreach (entProcVent ent in lstVns)
                    {
                        cnx.Open();
                        SqlCeTransaction tx = cnx.BeginTransaction(IsolationLevel.ReadCommitted);

                        string SqlAction = "update procvent set ven_docnumsap = " + ent.ven_keyven + " " +
                                           "where " +
                                           " ven_keyven = " + ent.ven_keypos + "";
                        try
                        {
                            SqlCeCommand cmd = cnx.CreateCommand();
                            cmd.Transaction = tx;
                            cmd.CommandText = SqlAction;
                            cmd.ExecuteNonQuery();
                            tx.Commit(CommitMode.Deferred);
                        }
                        catch (Exception ex)
                        {
                            string error = string.Empty;
                            error = ex.Message;
                            tx.Rollback();
                        }
                        finally
                        {
                            cnx.Close();
                        }
                    }
                }
                #endregion
            }
            else
            {
                int ventaFinal = 0;
                if (lstVnl.Count > 0)
                {
                    #region inserccion en el servidor
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(con))
                        {
                            SqlCommand cmd = new SqlCommand();

                            lstKey = new List<int>();
                            foreach (entProcVent ent in lstVnl)
                            {
                                cmd.CommandText = "INSERT INTO procvent (ven_caja,ven_usrven,ven_cliente,ven_estado,ven_fecreg,ven_iva,ven_ieps,ven_retencion,ven_descue,ven_subtot," +
                                                   "ven_total,ven_porcdesc,ven_porciva,ven_porcieps,ven_porcretencion, ven_keypos,ven_serie) " +
                                                   "VALUES " +
                                                   "('" + ent.ven_caja + "','" + ent.ven_usrven + "','" + ent.ven_cliente + "','" + ent.ven_estado + "', " +
                                                   "'" + ent.ven_fecreg.ToString("yyyyMMdd") + "'," + ent.ven_iva + "," + ent.ven_ieps + "," + ent.ven_retencion + "," + ent.ven_descue + ", " +
                                                   "" + ent.ven_subtot + "," + ent.ven_total + "," + ent.ven_porcdesc + "," + ent.ven_porciva + "," + ent.ven_porcieps + ", " +
                                                   "" + ent.ven_porcretencion + ", " + ent.ven_keyven + ", " + ent.ven_serie  + ")";
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = connection;

                                if (connection.State == ConnectionState.Closed)
                                    connection.Open();
                                cmd.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        string error = string.Empty;
                        error = ex.Message;
                    }
                    #endregion
                    #region conexion servidor
                    con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;"; //txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
                    try
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {
                            //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                            conn.ConnectionString = con;
                            conn.Open();

                            string command = "SELECT max(ven_keyven) venta FROM procvent";

                            using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);
                                foreach (DataRow dr in dt.Rows)
                                {
                                    #region
                                    ventaFinal = Convert.ToInt32(dr[0].ToString());
                                    #endregion
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string error = string.Empty;
                        error = ex.Message;
                    }
                    #endregion
                    #region inserccion del detalle de la venta
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(con))
                        {
                            SqlCommand cmd = new SqlCommand();

                            foreach (entProcVent1 ent in lstDvl)
                            {
                                cmd.CommandText = "INSERT INTO procvent1(ven1_keyven, ven1_numlin, ven1_articulo, ven1_artdes, ven1_cantidad, ven1_precio, ven1_iva, ven1_ieps, " +
                                                  "ven1_totallinea, ven1_moneda, ven1_tipocambio, ven1_escompues, ven1_idpaquete, ven1_porcdesc, ven1_descuento, ven1_keyalm, " +
                                                  "ven1_keypro, ven1_OcrCode) " +
                                                   "VALUES " +
                                                   "(" + ventaFinal + ", " + ent.ven1_numlin + ", '" + ent.ven1_articulo + "', '" + ent.ven1_artdes + "', " + ent.ven1_cantidad + ", " +
                                                   "" + ent.ven1_precio + ", " + ent.ven1_iva + ", " + ent.ven1_ieps + ", " + ent.ven1_totallinea + ", '" + ent.ven1_moneda + "', " +
                                                   "" + ent.ven1_tipocambio + ", " + (ent.ven1_escompues == true ? 1 : 0) + ", '" + ent.ven1_idpaquete + "', " + ent.ven1_porcdesc + ", " +
                                                   "" + ent.ven1_descuento + ", '" + ent.ven1_keyalm + "', '" + ent.ven1_keypro + "', '" + ent.ven1_OcrCode + "')";
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = connection;

                                if (connection.State == ConnectionState.Closed)
                                    connection.Open();
                                cmd.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        string error = string.Empty;
                        error = ex.Message;
                    }
                    /*  detalle de paquetes procmociones */
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(con))
                        {
                            SqlCommand cmd = new SqlCommand();

                            foreach (entProcVentP ent in lstVnsP)
                            {
                                cmd.CommandText = "INSERT INTO procventp(venp_keyven, venp_NumLin, venp_articulo, venp_artdes, venp_cantidad, venp_precio, venp_iva, venp_ieps, " +
                                                  "venp_totallinea, venp_moneda, venp_tipocambio, venp_escompues, venp_idpaquete, venp_porcdesc, venp_descuento, venp_keyalm, " +
                                                  "venp_keypro, venp_OcrCode) " +
                                                   "VALUES " +
                                                   "(" + ventaFinal + ", " + ent.venp_NumLin + ", '" + ent.venp_articulo + "', '" + ent.venp_artdes + "', " + ent.venp_cantidad + ", " +
                                                   "" + ent.venp_precio + ", " + ent.venp_iva + ", " + ent.venp_ieps + ", " + ent.venp_totallinea + ", '" + ent.venp_moneda + "', " +
                                                   "" + ent.venp_tipocambio + ", " + (ent.venp_escompues == true ? 1 : 0) + ", '" + ent.venp_idpaquete + "', " + ent.venp_porcdesc + ", " +
                                                   "" + ent.venp_descuento + ", '" + ent.venp_keyalm + "', '" + ent.venp_keypro + "', '" + ent.venp_OcrCode + "')";
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = connection;

                                if (connection.State == ConnectionState.Closed)
                                    connection.Open();
                                cmd.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        string error = string.Empty;
                        error = ex.Message;
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(con))
                        {
                            SqlCommand cmd = new SqlCommand();

                            foreach (entProcVent4 ent in lstVnl4)
                            {
                                cmd.CommandText = "INSERT INTO procvent4 ([ven4_keyven],[ven4_metodopago],[ven4_metododet],[ven4_metodoref],[ven4_importe],[ven4_fecreg],[ven4_formapago],[ven4_terminal],[ven4_cuenta],[ven4_enviadobita],[ven4_enviado],[ven4_msjError],[ven4_numpago],[ven4_cancelado],[ven4_keyven8]) " +                                            
                                                    " VALUES " +
                                                   "(" + ventaFinal + ",'" + ent.ven4_metodopago + "', '" + ent.ven4_metododet + "', '" + ent.ven4_metodoref + "', '" + ent.ven4_importe + 
                                                   "','" +ent.ven4_fecreg.ToString("yyyyMMdd") + "', '" + ent.ven4_formapago + "', '" + ent.ven4_terminal + "', '" + ent.ven4_cuenta + 
                                                   "','" +ent.ven4_enviadobita + "', " + (ent.ven4_enviado == true ? 1 : 0) + ", '" + ent.ven4_msjError + "', '" + ent.ven4_numpago 
                                                   + "','" +ent.ven4_cancelado + "', '" + ent.ven4_keyven8 + "')";
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = connection;

                                if (connection.State == ConnectionState.Closed)
                                    connection.Open();
                                cmd.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        string error = string.Empty;
                        error = ex.Message;
                        MessageBox.Show(error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                    #endregion
                    #region conexion servidor
                    con = "Server=" + txtIpaCnx.Text + ";Database=" + txtDbsCnx.Text + ";uid=sa;pwd=sap@dmin625;"; //txtPatCpu.Text;// +"providerName='Microsoft.SqlServerCe.Client.4.0'";
                    try
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {
                            //conn.ConnectionString = "Server=172.16.0.8;Database=SBO_QFSCPRUEBAS;uid=sa;pwd=sap@dmin625;";
                            conn.ConnectionString = con;
                            conn.Open();

                            string command = "SELECT * FROM procvent";

                            using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);
                                lstVns = new List<entProcVent>();
                                foreach (DataRow dr in dt.Rows)
                                {
                                    #region
                                    entVns = new entProcVent();
                                    entVns.ven_keyven = Convert.ToInt32(dr["ven_keyven"].ToString());
                                    entVns.ven_caja = dr["ven_caja"].ToString();
                                    entVns.ven_usrven = dr["ven_usrven"].ToString();
                                    entVns.ven_cliente = dr["ven_cliente"].ToString();
                                    entVns.ven_estado = dr["ven_estado"].ToString();
                                    entVns.ven_fecreg = Convert.ToDateTime(dr["ven_fecreg"].ToString());
                                    entVns.ven_iva = Convert.ToDecimal(dr["ven_iva"].ToString());
                                    entVns.ven_ieps = Convert.ToDecimal(dr["ven_ieps"].ToString());
                                    entVns.ven_retencion = Convert.ToDecimal(dr["ven_retencion"].ToString());
                                    entVns.ven_descue = Convert.ToDecimal(dr["ven_descue"].ToString());
                                    entVns.ven_subtot = Convert.ToDecimal(dr["ven_subtot"].ToString());
                                    entVns.ven_total = Convert.ToDecimal(dr["ven_total"].ToString());
                                    entVns.ven_porcdesc = Convert.ToDecimal(dr["ven_porcdesc"].ToString());
                                    entVns.ven_porciva = Convert.ToDecimal(dr["ven_porciva"].ToString());
                                    entVns.ven_porcieps = Convert.ToDecimal(dr["ven_porcieps"].ToString());
                                    entVns.ven_porcretencion = Convert.ToDecimal(dr["ven_porcretencion"].ToString());
                                    entVns.ven_almace = dr["ven_almace"].ToString();
                                    entVns.ven_keypos = Convert.ToInt32(dr["ven_keypos"].ToString());
                                    entVns.ven_serie = dr["ven_serie"].ToString();
                                    lstVns.Add(entVns);
                                    #endregion
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string error = string.Empty;
                        error = ex.Message;
                    }
                    #endregion
                    #region actualización POS
                    con = txtPatCpu.Text;
                    using (SqlCeConnection cnx = new SqlCeConnection(con))
                    {
                        foreach (entProcVent ent in lstVns)
                        {
                            cnx.Open();
                            SqlCeTransaction tx = cnx.BeginTransaction(IsolationLevel.ReadCommitted);

                            string SqlAction = "update procvent set ven_docnumsap = " + ent.ven_keyven + " " +
                                               "where " +
                                               " ven_keyven = " + ent.ven_keypos + "";
                            try
                            {
                                SqlCeCommand cmd = cnx.CreateCommand();
                                cmd.Transaction = tx;
                                cmd.CommandText = SqlAction;
                                cmd.ExecuteNonQuery();
                                tx.Commit(CommitMode.Deferred);
                            }
                            catch (Exception ex)
                            {
                                string error = string.Empty;
                                error = ex.Message;
                                tx.Rollback();
                            }
                            finally
                            {
                                cnx.Close();
                            }
                        }
                    }
                    #endregion

                }
            }
            #endregion
        }
        #endregion

        private void rdbEthCpu_CheckedChanged(object sender, EventArgs e)
        {
            fndIpaCpu();
        }

        private void rdbWfiCpu_CheckedChanged(object sender, EventArgs e)
        {
            fndIpaCpu();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            tmrEnviar.Start();
        }

        private void frmPpal_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
        }

        private void tmrEnviar_Tick(object sender, EventArgs e)
        {
            // Iniciar la sincronizacion
            #region variables del ping
            Ping pngfpr = new Ping();
            byte[] buffer = new byte[32];
            PingOptions pngopc = new PingOptions(64, true);
            PingReply pngrpl = null;
            #endregion
            tmrEnviar.Stop();
            try
            {
                pngrpl = pngfpr.Send(txtIpaCnx.Text, 1000, buffer, pngopc);
                if (pngrpl.Status == IPStatus.Success && pngrpl.RoundtripTime < 3000)
                {
                    EnviarVentas();
                    TimeSpan hrs = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    //horaEnvio = hora.ToString();
                    if (hrs.Hours == horaenvio.Hours && hrs.Minutes == horaenvio.Minutes)
                    {
                        //horaEnvio = DateTime.Now.AddHours(4).ToShortTimeString();
                        horaconfg = horaconfg.AddHours(4);
                        horaenvio = new TimeSpan(horaconfg.Hour, horaconfg.Minute, horaconfg.Second);
                        SincronizarConfiguracion();
                        SincronizarArticulos();
                        SincronizarPerfPerm();
                        SincronizarSeguUsua();
                        SincronizarUsuaPerf();
                        SincronizarCataMeto();
                        SincronizarSeguPerf();
                        /*====================*/
                        SincronizarProcPromo();
                        SincronizarPromArti();
                        SincronizarProcPQtes();
                        SincronizarPQteArti();
                        SincronizarDiaProm();
                    }
                    else if (hrs.Hours == horaenvio.Hours && hrs.Minutes > horaenvio.Minutes)
                    {
                        //hora.Add(new TimeSpan(4, 0, 0));
                        horaconfg = horaconfg.AddHours(4);
                        horaenvio = new TimeSpan(horaconfg.Hour, horaconfg.Minute, horaconfg.Second);
                    }
                }
            }
            catch
            {
            }
            tmrEnviar.Start();

        }

        private void ntiApp_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void frmPpal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal frmPP = new frmPrincipal();
            frmPP.Show();
            
        }
    }
}
