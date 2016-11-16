using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace SRATAPV.Ventas.Negocio
{
    class clsCorte
    {
        private string _cor_keycor;
        private string _cor_keyusr;
        private string _cor_fondocaj;
        private DateTime _cor_fechInic;
        private DateTime _cor_fechFin;
        private string _cor_totVentas;
        private string _cor_totVtasReg;
        private string _cor_estado;
        private string _mensaje;
        private string _cor1_keycor;
		private string _cor1_moneda;
		private string _cor1_veinte;
		private string _cor1_cincuenta;
		private string _cor1_cien;
		private string _cor1_doscientos;
		private string _cor1_quinientos;
		private string _cor1_mil;

        public string cor_keycor
        {
            get { return _cor_keycor; }
            set { _cor_keycor = value; }
        }
        public string cor_keyusr
        {
            get { return _cor_keyusr; }
            set { _cor_keyusr = value; }
        }
        public string cor_fondocaj
        {
            get { return _cor_fondocaj; }
            set { _cor_fondocaj = value; }
        }
        public DateTime cor_fechInic
        {
            get { return _cor_fechInic; }
            set { _cor_fechInic = value; }
        }
        public DateTime cor_fechFin
        {
            get { return _cor_fechFin; }
            set { _cor_fechFin = value; }
        }
        public string cor_totVentas
        {
            get { return _cor_totVentas; }
            set { _cor_totVentas = value; }
        }
        public string cor_totVtasReg
        {
            get { return _cor_totVtasReg; }
            set { _cor_totVtasReg = value; }
        }
        public string cor_estado
        {
            get { return _cor_estado; }
            set { _cor_estado = value; }
        }
        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public string cor1_keycor
        {
            get { return _cor1_keycor; }
            set { _cor1_keycor = value; }
        }
        public string cor1_moneda
        {
            get { return _cor1_moneda; }
            set { _cor1_moneda = value; }
        }
        public string cor1_veinte
        {
            get { return _cor1_veinte; }
            set { _cor1_veinte = value; }
        }
        public string cor1_cincuenta
        {
            get { return _cor1_cincuenta; }
            set { _cor1_cincuenta = value; }
        }
        public string cor1_cien
        {
            get { return _cor1_cien; }
            set { _cor1_cien = value; }
        }
        public string cor1_doscientos
        {
            get { return _cor1_doscientos; }
            set { _cor1_doscientos = value; }
        }
        public string cor1_quinientos
        {
            get { return _cor1_quinientos; }
            set { _cor1_quinientos = value; }
        }
        public string cor1_mil
        {
            get { return _cor1_mil; }
            set { _cor1_mil = value; }
        }

        public bool GuardarCorte()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "INSERT INTO [proccort] (cor_keyusr,cor_fondocaj,cor_fechInic,cor_estado) " +
                "VALUES ('" + cor_keyusr + "','" + cor_fondocaj + "','" + cor_fechInic.ToString("yyyyMMdd") + "','" + cor_estado + "')";

            Objeto.ejecutaTransaccion();
            cor_keycor = leerUltimoCorte();
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

        public string leerUltimoCorte()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            Objeto.sentenciaSQL = "SELECT cor_keycor FROM proccort ORDER BY cor_keycor desc";
            consulta = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                if (consulta != null && consulta.Tables[0].Rows.Count > 0)
                {
                    return consulta.Tables[0].Rows[0][0].ToString();
                }
                return null;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public string leerCorteUsuario(string ven_usrven)
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            Objeto.sentenciaSQL = "SELECT cor_keycor FROM proccort WHERE cor_keyusr = '" + ven_usrven + "' and cor_estado = 'Abierto'";
            consulta = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                if (consulta != null && consulta.Tables[0].Rows.Count > 0)
                {
                    return consulta.Tables[0].Rows[0][0].ToString();
                }
                return null;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public bool leerExisteCorte(string ven_usrven)
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            Objeto.sentenciaSQL = "SELECT cor_keycor FROM proccort WHERE cor_keyusr = '" + ven_usrven + "' and cor_estado = 'Abierto'";
            consulta = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                if (consulta != null && consulta.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public bool ModificarCorte()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "UPDATE proccort SET  cor_fechFin = '" + cor_fechFin + "'," +
                         "cor_totVentas = '" + cor_totVentas + "'," +
                        "cor_totVtasReg = '" + cor_totVtasReg + "'," +
                        "cor_estado = '" + cor_estado + "' WHERE cor_keycor = '" + cor_keycor + "'";
                   
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
        public DataSet leerCorte()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM proccort WHERE cor_keycor = '" + _cor_keycor + "'";
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

        public bool GuardarDetalleCorte()//No se usa
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "exec [spguar_proccort1] '" + _cor1_keycor + "'," +
                                                          "'" + _cor1_moneda + "'," +
                                                          "'" + _cor1_veinte + "'," +
                                                          "'" + _cor1_cincuenta + "'," +
                                                          "'" + _cor1_cien + "'," +
                                                          "'" + _cor1_doscientos + "'," +
                                                          "'" + _cor1_quinientos + "'," +
                                                          "'" + _cor1_mil + "'";
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
        public DataSet leerVentasDelCorte()//No se usa
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "exec [spleer_proccort_ventas] '" + _cor_keycor + "'";
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
