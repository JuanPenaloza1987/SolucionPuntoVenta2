using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SRATAPV.Utilerias;


namespace SRATAPV
{
    class clsMetodosPago
    {
        private string _mensaje;
        private string _met_keymet;
        private string _met_descripc;
        private string _met_usrmod;
        private bool _met_activo;
        private string _met_codigo;

        private string _met1_keymet;
        private string _met1_identi;
        private string _met1_descripc;
        private string _met1_usrmod;
        private bool _met1_activo;

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public string met_keymet
        {
            get { return _met_keymet; }
            set { _met_keymet = value; }
        }
        public string met_descripc
        {
            get { return _met_descripc; }
            set { _met_descripc = value; }
        }
        public string met_usrmod
        {
            get { return _met_usrmod; }
            set { _met_usrmod = value; }
        }
        public bool met_activo
        {
            get { return _met_activo; }
            set { _met_activo = value; }
        }
        public string met_codigo
        {
            get { return _met_codigo; }
            set { _met_codigo = value; }
        }
        public string met1_keymet
        {
            get { return _met1_keymet; }
            set { _met1_keymet = value; }
        }
        public string met1_identi
        {
            get { return _met1_identi; }
            set { _met1_identi = value; }
        }
        public string met1_descripc
        {
            get { return _met1_descripc; }
            set { _met1_descripc = value; }
        }
        public string met1_usrmod
        {
            get { return _met1_usrmod; }
            set { _met1_usrmod = value; }
        }
        public bool met1_activo
        {
            get { return _met1_activo; }
            set { _met1_activo = value; }
        }

        public DataSet leerMetodos()
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "select * 0";
            Usuario = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return Usuario;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public Boolean guardarMetodo()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "exec [spguar_catameto] '" + _met_keymet + "'," +
                                                         "'" + _met_descripc + "'," +
                                                         "'" + _met_activo + "'," +
                                                         "'" + Globals.Instance.usuario + "', "+
                                                         "'" + _met_codigo + "'";
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

        public DataSet leerDetalle()
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_catameto1] '" + _met_keymet + "'";
            Usuario = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return Usuario;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public Boolean guardarDetalle()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "exec [spguar_catameto1] '" + _met1_keymet + "'," +
                                                          "'" + _met1_identi + "'," +
                                                          "'" + _met1_descripc + "'," +
                                                          "'" + _met1_usrmod + "'," +
                                                          "'" + _met1_activo + "'";                

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


        public DataSet leerMetodoPagoEstado()
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_catameto_estado] '" + _met_activo + "'";
            Usuario = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return Usuario;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        

    }
}
