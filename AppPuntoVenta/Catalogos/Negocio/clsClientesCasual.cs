using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppPuntoVenta.Catalogos.Negocio
{
    class clsClientes
    {
        private string _mensaje;
        private int _clc_id;
        private string _clc_nomb;
        private string _clc_direc;
        private string _clc_corr;
        private string _clc_tel;
        private string _clc_rfc;
        private bool _clc_enviado;
        public bool clc_enviado
        {
            get { return _clc_enviado; }
            set { _clc_enviado = value; }
        }

        public string clc_rfc
        {
            get { return _clc_rfc; }
            set { _clc_rfc = value; }
        }

        public string clc_tel
        {
            get { return _clc_tel; }
            set { _clc_tel = value; }
        }

        public string clc_corr
        {
            get { return _clc_corr; }
            set { _clc_corr = value; }
        }

        public string clc_direc
        {
            get { return _clc_direc; }
            set { _clc_direc = value; }
        }

        public string clc_nomb
        {
            get { return _clc_nomb; }
            set { _clc_nomb = value; }
        }

        public int clc_id
        {
            get { return _clc_id; }
            set { _clc_id = value; }
        }

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }


        public DataSet leerCliente(string rfc)
        {
            BD Objeto = new BD();
            DataSet Usuario = new DataSet();
            Objeto.sentenciaSQL = "SELECT * FROM [cataclicas] WHERE [clc_rfc] = '" + rfc + "'";
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

        public bool guardarCliente()
        {
            BD Objeto = new BD();

            Objeto.sentenciaSQL = "INSERT INTO [cataclicas] ([clc_nomb],[clc_direc],[clc_corr],[clc_tel],[clc_rfc],[clc_enviado]) " +
                                  "VALUES(" +
                                   "'" + clc_nomb + "',"+
                                   "'" + clc_direc + "'," + 
                                   "'" + clc_corr + "'," +
                                   "'" + clc_tel + "'," +
                                   "'" + clc_rfc + "'," +
                                   (clc_enviado? "1":"0") + ")";
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

        public bool ActualizarCliente()
        {
            BD Objeto = new BD();

            Objeto.sentenciaSQL = "UPDATE [cataclicas] " +
                                  "SET " +
                                   "[clc_nomb] = '" + clc_nomb + "'," +
                                   "[clc_direc] = '" + clc_direc + "'," +
                                   "[clc_corr] = '" + clc_corr + "'," +
                                   "[clc_tel] = '" + clc_tel + "'," +
                                   "[clc_rfc] = '" + clc_rfc + "'," +
                                   "[clc_enviado] = " + (clc_enviado ? "1" : "0") +
                                   "WHERE [clc_id] = " + clc_id.ToString();
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
    }

}
