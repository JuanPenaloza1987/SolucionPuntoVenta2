using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Reflection;
using System.Collections.Generic;

public class BD
{
    //Variables locales
    private string _sentenciaSQL;
    private string _mensaje;
    private Boolean _hayError = false;
    private int _numeroFilasAfectadas = 0;
    private string _identity = "-1";
    
    public string CadenaConexion
    {
        get { return string.Format(AppPuntoVenta.Properties.Settings.Default.ConexionPrueba, Application.UserAppDataPath); }
    }

    public string identity
    {
        get { return _identity; }
    }
    
    public string sentenciaSQL
    {
        set
        {
            _sentenciaSQL = value;
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

    public void ExportarCadenaDeConexion()
    {
        //string ProgramFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles); Se necesitan permisos de admin
        //string carpeta = System.IO.Path.Combine(ProgramFiles, "STRATA_POS");
        string carpeta = "C:/STRATA_POS";
        string rutaArchivoCadena = carpeta + "/STRATA_conn.txt";

        if (!Directory.Exists(carpeta))
        {
            System.IO.Directory.CreateDirectory(carpeta);
        }

        using (StreamWriter archivo = new StreamWriter(rutaArchivoCadena,false))
        {
            archivo.WriteLine(CadenaConexion);
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
public static class Conversiones
{

    public static List<T> convertirEnLista<T>(this DataTable tabla) where T : new()
    {
        Type t = typeof(T);
        // Crear la lista de las entidades que queremos devolver
        List<T> lista = new List<T>();

        foreach (DataRow dr in tabla.Rows)
        {
            // Convertir cada registro en la entidad y agregarlo a la lista
            T nuevoRegistro = convertirEnDTO<T>(dr);
            lista.Add(nuevoRegistro);
        }

        return lista;
    }

    public static T convertirEnDTO<T>(this DataRow tableRow) where T : new()
    {
        //Crear el nuevo tipo de entidad
        Type t = typeof(T);
        T objetoRetorno = new T();

        foreach (DataColumn col in tableRow.Table.Columns)
        {
            string nombreColumna = col.ColumnName;

            //Busca la propiedad del objeto con el nombre de columna
            PropertyInfo pInfo = t.GetProperty(nombreColumna.ToLower(),
                BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            // Se encontro la propiedad ?
            if (pInfo != null)
            {
                object val = tableRow[nombreColumna];

                // es un tipo Nullable<>
                bool IsNullable = (Nullable.GetUnderlyingType(pInfo.PropertyType) != null);
                if (IsNullable)
                {
                    if (val is System.DBNull)
                    {
                        val = null;
                    }
                    else
                    {
                        // Convertir el tipo db en el tipo T que tenemo en nuestro tipo Nullable<T>
                        val = Convert.ChangeType(val, Nullable.GetUnderlyingType(pInfo.PropertyType));
                    }
                }
                else
                {
                    // Convertir el tipo db en el tipo de la propiedad de nuetra entidad
                    val = Convert.ChangeType(val, pInfo.PropertyType);
                }
                // Asignar el valor de la propiedad con el valor de la base de datos
                pInfo.SetValue(objetoRetorno, val, null);
            }
        }

        // Regresa el objeto entidad en este cao DTO con los valores seteados
        return objetoRetorno;
    }


}