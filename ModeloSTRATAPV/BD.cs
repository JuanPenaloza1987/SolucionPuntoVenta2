using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;
using System.Data;

namespace ModeloSTRATAPV
{
    public class BD
    {
        //Variables locales
        private string _sentenciaSQL;
        private string _tagConn = "cnPOS";
        private string _mensaje;
        private Boolean _hayError = false;
        private int _numeroFilasAfectadas = 0;
        private string _identity = "-1";
        //private string _cadenaConexion = "DataSource =\'STRATA_LOCAL.sdf\'; Password = 'local123'";
        private string _nombreBD = "STRATA_LOCAL.sdf";
        private string _rutaBD;
        private string _contrasenaBD;

        public string NombreBD
        {
            get { return _nombreBD; }
            set { _nombreBD = value; } }


    /// <summary>
    /// Carpeta en donde se encuentra la base de datos
    /// </summary>
        public string RutaBD
        {
            get { return _rutaBD; }
            set { _rutaBD = value; }
        }


        public string ContrasenaBD
        {
            get { return _contrasenaBD; }
            set { _contrasenaBD = value; }
        }


        public string CadenaConexion
        {
            get { return string.Format("DataSource ={0}{1}; Password = '{2}'", RutaBD, NombreBD, ContrasenaBD); }
        }


        public string identity
        {
            get { return _identity; }
        }

        //Encapsulamiento de variables Getters y Setters
        public string sentenciaSQL
        {
            set
            {
                _sentenciaSQL = value;
            }
        }

        public string bd
        {
            set
            {
                _tagConn = value;
            }
        }


        public string mensaje
        {
            get
            {
                return _mensaje;
            }
        }

        public Boolean hayError
        {
            get
            {
                return _hayError;
            }
        }

        public int numeroFilasAfectadas
        {
            get
            {
                return _numeroFilasAfectadas;
            }
        }

        public DataSet ejecutaConsulta()
        {
            SqlCeDataAdapter adaptador;
            DataSet ds = new DataSet();
            
            try
            {
                adaptador = new SqlCeDataAdapter(_sentenciaSQL, CadenaConexion);
                adaptador.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count <= 0)
                    {
                        this._mensaje = "No hay información para mostrar";
                    }
                }
                else
                {
                    this._mensaje = "No hay información para mostrar";
                }
            }
            catch (SqlCeException ex)
            {
                this._mensaje = ex.Message.ToString();
                this._hayError = true;
                StreamWriter archivo = new StreamWriter(@"C:\Sistemas\Errores.txt", true);
                archivo.WriteLine("Error: " + ex.Message.ToString() + " el dia: " + DateTime.Now);
                archivo.Close();
            }

            return ds;
        }

        public void ejecutaTransaccion()
        {
            SqlCeConnection cnn;
            SqlCeCommand sqlCmd;
            
            cnn = new SqlCeConnection(CadenaConexion);
            sqlCmd = new SqlCeCommand(this._sentenciaSQL, cnn);
            sqlCmd.CommandType = CommandType.Text;

            //transaccion = cnn.BeginTransaction();

            try
            {
                cnn.Open();
                this._numeroFilasAfectadas = sqlCmd.ExecuteNonQuery();

                //transaccion.Commit();
            }
            catch (SqlCeException ex)
            {
                this._mensaje = ex.Message.ToString();
                try
                {
                    TextWriter tw;
                    string nomlog = Environment.CurrentDirectory + @"\Error_.txt";
                    tw = new StreamWriter(nomlog, true);
                    tw.WriteLine("Error: " + mensaje + "Cadena de conexión: " + cnn);
                    tw.Close();
                }
                catch (Exception et)
                {
                    System.Diagnostics.EventLog.WriteEntry("Aplicación", "Ocurrio el siguiente error " + et.Message);
                }
                this._hayError = true;
            }
            finally
            {
                if (cnn != null && cnn.State != ConnectionState.Closed)
                {
                    cnn.Close();
                }
            }
        }

        public void ejecutaTransaccionConIdentity()
        {
            SqlCeDataAdapter adaptador;
            DataSet ds = new DataSet();
            
            _identity = "-1";

            try
            {
                adaptador = new SqlCeDataAdapter(this._sentenciaSQL, CadenaConexion);
                adaptador.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count <= 0)
                    {
                        this._mensaje = "No hay información para mostrar";
                        _identity = "-1";
                    }
                    else
                    {
                        _identity = ds.Tables[0].Rows[0][0].ToString();
                    }
                }
                else
                {
                    this._mensaje = "No hay información para mostrar";
                    _identity = "-1";
                }
            }
            catch (SqlCeException ex)
            {

                this._mensaje = ex.Message.ToString();
                this._hayError = true;
                _identity = "-1";
            }
        }

        public void ejecutaTransaccionConIdentityCE()
        {
            SqlCeDataAdapter adaptador;
            DataSet ds = new DataSet();
            
            _identity = "-1";

            try
            {
                adaptador = new SqlCeDataAdapter(this._sentenciaSQL, CadenaConexion);
                adaptador.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count <= 0)
                    {
                        this._mensaje = "No hay información para mostrar";
                        _identity = "-1";
                    }
                    else
                    {
                        _identity = ds.Tables[0].Rows[0][0].ToString();
                    }
                }
                else
                {
                    this._mensaje = "No hay información para mostrar";
                    _identity = "-1";
                }
            }
            catch (SqlCeException ex)
            {

                this._mensaje = ex.Message.ToString();
                this._hayError = true;
                _identity = "-1";
            }
        }

        #region Prueba
        public static bool CrearBaseDeDatos(string ruta, string contrasena)
        {
            string connectionString;
            connectionString = string.Format("DataSource =\'{0}\'; Password = '{1}'", ruta, contrasena);
            SqlCeEngine motorsql = new SqlCeEngine(connectionString);
            try
            {
                motorsql.CreateDatabase();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool EjecutarScript(string rutaBD, string contrasena, string rutaScript)
        {
            string connectionString;
            connectionString = string.Format("DataSource =\'{0}\'; Password = '{1}'", rutaBD, contrasena);
            try
            {
                SqlCeConnection conexionSQL = new SqlCeConnection(connectionString);
                string script = "";
                using (StreamReader archivo = new StreamReader(rutaScript))
                {
                    script = archivo.ReadToEnd();
                }
                conexionSQL.Open();
                SqlCeCommand comandoSQL = new SqlCeCommand(script, conexionSQL);
                comandoSQL.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool PruebaInsercion(string rutaBD, string contrasena)
        {
            string connectionString;
            connectionString = string.Format("DataSource =\'{0}\'; Password = '{1}'", rutaBD, contrasena);
            try
            {
                SqlCeConnection conexionSQL = new SqlCeConnection(connectionString);
                string script = "insert into pqtearti(part_codpqte, part_keyart, part_cantidad) values ('x', 'x', 1);";

                conexionSQL.Open();
                SqlCeCommand comandoSQL = new SqlCeCommand(script, conexionSQL);
                comandoSQL.ExecuteNonQuery();
                conexionSQL.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string PruebaSeleccion(string rutaBD, string contrasena)
        {
            string connectionString;
            connectionString = string.Format("DataSource =\'{0}\'; Password = '{1}'", rutaBD, contrasena);
            try
            {
                SqlCeConnection conexionSQL = new SqlCeConnection(connectionString);
                string script = "select * from pqtearti";

                conexionSQL.Open();
                SqlCeCommand comandoSQL = new SqlCeCommand(script, conexionSQL);
                SqlCeDataAdapter adaptadorSQL = new SqlCeDataAdapter(comandoSQL);
                DataTable datos = new DataTable();
                adaptadorSQL.Fill(datos);

                conexionSQL.Close();
                return "Registros " + datos.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

    }
}
