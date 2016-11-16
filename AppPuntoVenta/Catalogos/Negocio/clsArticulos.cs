using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace AppPuntoVenta.Catalogos.Negocio
{
    class clsArticulos
    {
        private string _mensaje;
        private string _art_keyart;
        private string _art_descripc;
        private string _art_grupar;
        private bool _art_esInvent;
        private bool _art_esVenta;
        private bool _art_esCompr;
        private bool _art_esFictici;
        private string _art_nombrextran;
        private string _art_claseArt;
        private decimal _art_precioCompra;
        private decimal _at_precioventa;
        private bool _art_sujImpuest;
        private bool _art_sujRetenImpuest;
        private string _art_almacen;
        private string _art_NomunidCompr;
        private string _art_NomunidVenta;
        private bool _art_existesap;
        private bool _art_escompues;

        private string _alm_keyalm;
	    private string _alm_nombre;
	    private bool _alm_activo;
        private string _alm_estado;

         private string _grp_keygpo;
         private string _grp_nombre;

         private string _ensa_keyart;
		 private string	_ensa_keyartensa;
		 private string	_ensa_unidmed;
		 private string	_ensa_cantid;
		 private string	_ensa_costo;
         private string _ensa_precio;
         private string _ensa_orden;

        private string _art_codbar;

         private bool _art_enviadoBita;


        public string art_keyart
        {
            get { return _art_keyart; }
            set { _art_keyart = value; }
        }
        public string art_descripc
        {
            get { return _art_descripc; }
            set { _art_descripc = value; }
        }
        public string art_grupar
        {
            get { return _art_grupar; }
            set { _art_grupar = value; }
        }
        public bool art_esInvent
        {
            get { return _art_esInvent; }
            set { _art_esInvent = value; }
        }
        public bool art_esVenta
        {
            get { return _art_esVenta; }
            set { _art_esVenta = value; }
        }
        public bool art_esCompr
        {
            get { return _art_esCompr; }
            set { _art_esCompr = value; }
        }
        public bool art_esFictici
        {
            get { return _art_esFictici; }
            set { _art_esFictici = value; }
        }
        public string art_nombrextran
        {
            get { return _art_nombrextran; }
            set { _art_nombrextran = value; }
        }
        public string art_claseArt
        {
            get { return _art_claseArt; }
            set { _art_claseArt = value; }
        }
        public decimal art_precioCompra
        {
            get { return _art_precioCompra; }
            set { _art_precioCompra = value; }
        }
        public decimal at_precioventa
        {
            get { return _at_precioventa; }
            set { _at_precioventa = value; }
        }
        public bool art_sujImpuest
        {
            get { return _art_sujImpuest; }
            set { _art_sujImpuest = value; }
        }
        public bool art_sujRetenImpuest
        {
            get { return _art_sujRetenImpuest; }
            set { _art_sujRetenImpuest = value; }
        }
        public string art_almacen
        {
            get { return _art_almacen; }
            set { _art_almacen = value; }
        }
        public string art_NomunidCompr
        {
            get { return _art_NomunidCompr; }
            set { _art_NomunidCompr = value; }
        }
        public string art_NomunidVenta
        {
            get { return _art_NomunidVenta; }
            set { _art_NomunidVenta = value; }
        }
        public bool art_existesap
        {
            get { return _art_existesap; }
            set { _art_existesap = value; }
        }

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        public string alm_keyalm
        {
            get { return _alm_keyalm; }
            set { _alm_keyalm = value; }
        }
        public string alm_nombre
        {
            get { return _alm_nombre; }
            set { _alm_nombre = value; }
        }
        public bool alm_activo
        {
            get { return _alm_activo; }
            set { _alm_activo = value; }
        }
        public string alm_estado
        {
            get { return _alm_estado; }
            set { _alm_estado = value; }
        }

        public string grp_keygpo
        {
            get { return _grp_keygpo; }
            set { _grp_keygpo = value; }
        }
        public string grp_nombre
        {
            get { return _grp_nombre; }
            set { _grp_nombre = value; }
        }


        public string ensa_keyart
        {
            get { return _ensa_keyart; }
            set { _ensa_keyart = value; }
        }
        public string ensa_keyartensa
        {
            get { return _ensa_keyartensa; }
            set { _ensa_keyartensa = value; }
        }
        public string ensa_unidmed
        {
            get { return _ensa_unidmed; }
            set { _ensa_unidmed = value; }
        }
        public string ensa_cantid
        {
            get { return _ensa_cantid; }
            set { _ensa_cantid = value; }
        }
        public string ensa_costo
        {
            get { return _ensa_costo; }
            set { _ensa_costo = value; }
        }
        public string ensa_precio
        {
            get { return _ensa_precio; }
            set { _ensa_precio = value; }
        }
        public string ensa_orden
        {
            get { return _ensa_orden; }
            set { _ensa_orden = value; }
        }
        public bool art_escompues
        {
            get { return _art_escompues; }
            set { _art_escompues = value; }
        }
        public bool art_enviadoBita
        {
            get { return _art_enviadoBita; }
            set { _art_enviadoBita = value; }
        }

        public string art_codbar
        {
            get { return _art_codbar; }
            set { _art_codbar = value; }
        }


        public bool guardarArticulos()
        {
            BD Objeto = new BD();

            Objeto.sentenciaSQL = "exec [spguar_cataarti] " + "'" + _art_keyart + "'," +
                                                             "'" + _art_descripc + "'," +
                                                             "'" + _art_grupar + "'," +
                                                             "'" + _art_esInvent + "'," +
                                                             "'" + _art_esVenta + "'," +
                                                             "'" + _art_esCompr + "'," +
                                                             "'" + _art_esFictici + "'," +
                                                             "'" + _art_nombrextran + "'," +
                                                             "'" + _art_claseArt + "'," +
                                                             "'" + _art_precioCompra + "'," +
                                                             "'" + _at_precioventa + "'," +
                                                             "'" + _art_sujImpuest + "'," +
                                                             "'" + _art_sujRetenImpuest + "'," +
                                                             "'" + _art_almacen + "'," +
                                                             "'" + _art_NomunidCompr + "'," +
                                                             "'" + _art_NomunidVenta + "'," +
                                                             "'" + _art_existesap + "',"+
                                                              "'" + _art_escompues + "',"+
                                                             "'" + _art_enviadoBita + "'";
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
        public bool guardarArticulosDesdeSAP()
        {

            BD Objeto = new BD();
            

            Objeto.sentenciaSQL = "exec [spguar_cataarti_desdeSAP] " + "'" + _art_keyart + "'," +
                                                             "'" + _art_descripc + "'," +
                                                             "'" + _art_grupar + "'," +
                                                             "'" + _art_esInvent + "'," +
                                                             "'" + _art_esVenta + "'," +
                                                             "'" + _art_esCompr + "'," +
                                                             "'" + _art_esFictici + "'," +
                                                             "'" + _art_nombrextran + "'," +
                                                             "'" + _art_claseArt + "'," +
                                                             "'" + _art_precioCompra + "'," +
                                                             "'" + _at_precioventa + "'," +
                                                             "'" + _art_sujImpuest + "'," +
                                                             "'" + _art_sujRetenImpuest + "'," +
                                                             "'" + _art_almacen + "'," +
                                                             "'" + _art_NomunidCompr + "'," +
                                                             "'" + _art_NomunidVenta + "'," +
                                                             "'" + _art_existesap + "'," +
                                                              "'" + _art_escompues + "'," +
                                                             "'" + _art_enviadoBita + "'";
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
        public DataSet leerArticulos()
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT art_keyart, art_descripc FROM cataarti ORDER BY art_keyart DESC";
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
        public DataSet leerArticulosSinEnviarSAP()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_cataarti_sinenviar]";
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
        public DataSet leerArticulosEnBitacora()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_cataarti_EnBitacora]";
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
        public DataSet leerArticulosEnviadosSAP()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_cataarti_EnviadosSAP]";
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

        public bool guardarAlmacenes()
        {

            BD Objeto = new BD();
            

            Objeto.sentenciaSQL = "exec [spguar_cataalma] " + "'" + _alm_keyalm + "'," +
                                                             "'" + _alm_nombre + "'," +
                                                             "'" + _alm_activo + "'," +
                                                             "'" + _alm_estado  + "'";
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
        public DataSet leerAlmacenes()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_cataalma]";
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

        public bool guardarGrupos()
        {

            BD Objeto = new BD();
            

            Objeto.sentenciaSQL = "exec [spguar_catagrup] " + "'" + _grp_keygpo + "'," +
                                                             "'" + _grp_nombre + "'";
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
        public DataSet leerGrupos()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_catagrup]";
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
        public DataSet leerArticulosNombres()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_cataarti_nombres]";
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
        public DataSet leerComponentesDeArticulos()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_cataensa] '" + _art_keyart + "'";
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
        public bool guardarComponentesDeArticulos()
        {
            BD Objeto = new BD();
            

            Objeto.sentenciaSQL = "exec [spguar_cataensa] '" + _ensa_keyart + "'," +
                                                         "'" + _ensa_keyartensa + "',"+
                                                         "'" + _ensa_unidmed + "',"+
                                                         "'" + _ensa_cantid + "',"+
                                                         "'" + _ensa_costo + "',"+
                                                         "'" + _ensa_precio + "'," +
                                                         "'" + _ensa_orden + "'";
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
        public bool EliminarComponentesDeArticulos()
        {

            BD Objeto = new BD();
            

            Objeto.sentenciaSQL = "exec [spborr_cataensa] " + "'" + _ensa_keyart + "'";
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

        public DataSet leerDetallePaquete()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_cataensa_unico_detalle] '" + _art_keyart + "'";
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

        public DataSet leerArticulosGrupo()
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_cataarti_grupo] '" + _art_grupar + "'";
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

        public DataSet leerArticulosFicticios()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_cataarti_ficticio] '" + _art_esFictici + "'";
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

        public DataSet leerArticulosUnico()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT	* FROM cataarti WHERE art_keyart = " + _art_keyart;
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

        public DataSet leerArticulosUnicoPorCodigoBarras()
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM cataarti WHERE art_codbar = '" + _art_codbar + "'";
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

        public DataSet leerArticulosUnicoPorClave(string key)
        {
            BD Objeto = new BD();
            DataSet ds = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM cataarti WHERE art_keyart = '" + key + "'";
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

        /// <summary>
        /// Solo regresa "clave" y "descripcion(nombre)"
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public DataSet BuscarArticulos(string dato)
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT art_keyart, art_descripc FROM cataarti WHERE art_keyart LIKE '%" + dato + "%' OR art_descripc LIKE '%" + dato + "%' ORDER BY art_keyart DESC";
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
