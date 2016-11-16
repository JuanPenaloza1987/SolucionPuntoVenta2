
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AppPuntoVenta.Paquete.Negocio
{
    class clsPaquete
    {
        private string _mensaje;
        private DateTime _pqt_ffin;
        private string _pqt_descrip;
        private string _pqt_codigo;
        private int _pqt_id;
        private DateTime _pqt_fini;

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        #region Cabecera Paquete
        public string pqt_codigo
        {
            get { return _pqt_codigo; }
            set { _pqt_codigo = value; }
        }

        public int pqt_id
        {
            get { return _pqt_id; }
            set { _pqt_id = value; }
        }

        public DateTime pqt_fini
        {
            get { return _pqt_fini; }
            set { _pqt_fini = value; }
        }

        public DateTime pqt_ffin
        {
            get { return _pqt_ffin; }
            set { _pqt_ffin = value; }
        }

        public string pqt_descrip
        {
            get { return _pqt_descrip; }
            set { _pqt_descrip = value; }
        }

        private decimal _pqt_precio;    

        public decimal pqt_precio
        {
            get { return _pqt_precio; }
            set { _pqt_precio = value; }
        }

        #endregion

        #region Detalle de paquete
        private int __part_id;

        public int part_id
        {
            get { return __part_id; }
            set { __part_id = value; }
        }

        private string _part_codpqte;

        public string part_codpqte
        {
            get { return _part_codpqte; }
            set { _part_codpqte = value; }
        }

        private int _part_cantidad;

        public int part_cantidad
        {
            get { return _part_cantidad; }
            set { _part_cantidad = value; }
        }

        private string _part_keyart;

        public string part_keyart
        {
            get { return _part_keyart; }
            set { _part_keyart = value; }
        }
        #endregion

        public bool GuardarPaquete()
        {

            BD Objeto1 = new BD();
            DataSet consulta = new DataSet();
            
            Objeto1.sentenciaSQL = string.Format("SELECT  COUNT(*) AS existe FROM procpqtes WHERE pqt_codigo = '"+ pqt_codigo +"'");
            consulta = Objeto1.ejecutaConsulta();

            BD Objeto = new BD();
            

            if (Convert.ToInt32(consulta.Tables[0].Rows[0].ItemArray[0].ToString()) == 0)
            {
                Objeto.sentenciaSQL = string.Format("INSERT INTO procpqtes(pqt_codigo, pqt_fini, pqt_ffin, pqt_descrip, pqt_precio) VALUES('{0}', '{1}', '{2}', '{3}', {4})",
                    pqt_codigo,
                    pqt_fini.ToString("yyyyMMdd"),
                    pqt_ffin.ToString("yyyyMMdd"),
                    pqt_descrip, pqt_precio);
            }
            else
            {

                Objeto.sentenciaSQL = string.Format("UPDATE procpqtes SET pqt_fini ='"+ pqt_fini.ToString("yyyyMMdd") + "', pqt_ffin ='"+ pqt_ffin.ToString("yyyyMMdd") + "', pqt_descrip ='"+ pqt_descrip + "', pqt_precio='"+ pqt_precio + "' WHERE pqt_codigo= '" + pqt_codigo + "' ;");
            }

            Objeto.ejecutaTransaccion();


            if (!Objeto.hayError)
            {
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public DataSet TraerPaquetes()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM procpqtes ORDER BY pqt_id DESC";
            consulta = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {

                return consulta;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public DataSet BuscarPaquetes(string dato)
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM procpqtes WHERE pqt_codigo LIKE '%" + dato + "%' OR pqt_descrip LIKE '%" + dato + "%' ORDER BY pqt_id DESC";
            consulta = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {

                return consulta;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public bool GuardarDetallePaquete()
        {

            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "INSERT INTO [pqtearti]([part_codpqte],[part_keyart],[part_cantidad])" +
            "VALUES(" +
            part_codpqte +
           "," + part_keyart +
           "," + part_cantidad + ")";
            Objeto.ejecutaTransaccion();

            if (!Objeto.hayError)
            {
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public DataSet TraerDetallePaquetes()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT  [part_keyart],[art_descripc],[part_codpqte],[part_cantidad] FROM [pqtearti] JOIN [cataarti] ON part_keyart = art_keyart WHERE [part_codpqte] = '" + pqt_codigo +"'";
            consulta = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return consulta;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public DataSet TraerPaqueteUnicoPorClave(string codigo)
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM procpqtes WHERE pqt_codigo = '" + codigo + "'";
            ds = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return ds;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public bool EliminarPaquete(string codigo)
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "DELETE FROM procpqtes WHERE pqt_codigo ='" + codigo + "' ;";
            Objeto.ejecutaTransaccion();

            if (!Objeto.hayError)
            {
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public bool EliminarDetallePaquete(string codigo , string art)
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "DELETE FROM pqtearti WHERE part_codpqte = '" + codigo + "' AND part_keyart= '"+ art + "' ;";
            Objeto.ejecutaTransaccion();

            if (!Objeto.hayError)
            {
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public bool EliminarTodoDetallePaquete()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "DELETE FROM pqtearti WHERE part_codpqte = " + part_codpqte + " ;";
            Objeto.ejecutaTransaccion();

            if (!Objeto.hayError)
            {
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public DataSet TraerPaquete()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();

            Objeto.sentenciaSQL = "SELECT * FROM[procpqtes] WHERE pqt_codigo = '" + pqt_codigo + "'";
            consulta = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return consulta;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }
    }
}
