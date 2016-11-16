
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AppPuntoVenta.Venta.Negocio
{
    class clsConfMetodo
    {
        private int _cmeto_id;
        private string _cmeto_tec;
        private string _met_keymet;
        private string _mensaje;

        public int cmeto_id
        {
            get { return _cmeto_id; }
            set { _cmeto_id = value; }
        }


        public string cmeto_tec
        {
            get { return _cmeto_tec; }
            set { _cmeto_tec = value; }
        }


        public string met_keymet
        {
            get { return _met_keymet; }
            set { _met_keymet = value; }
        }


        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }


        public DataSet leerConfiguracionMetodoPago()
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM confmeto";
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
