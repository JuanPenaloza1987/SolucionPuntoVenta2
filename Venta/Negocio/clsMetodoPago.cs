
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AppPuntoVenta.Venta.Negocio
{
    class clsMetodoPago
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

        public DataSet leerMetodoPagoEstado()
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM catameto WHERE met_activo = 1";
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

        public DataSet leerDetalleMetodoPago(string claveMetodoPago)
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM catameto1 WHERE met_keymet = '" + claveMetodoPago + "'";
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
