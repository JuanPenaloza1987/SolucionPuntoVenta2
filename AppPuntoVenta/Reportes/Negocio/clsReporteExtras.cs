using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using STRATAPV.DAL;

namespace SRATAPV.Reportes.Negocio
{
    class clsReporteExtras
    {
        private string _mensaje;
        private string _tipoExtra;
        private string _extra;
        private string _cliente;
        private string _fecdesde;
        private string _fechasta;
        private string _estado;
        
        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public string tipoExtra
        {
            get { return _tipoExtra; }
            set { _tipoExtra = value; }
        }
        public string extra
        {
            get { return _extra; }
            set { _extra = value; }
        }
        public string cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        public string fecdesde
        {
            get { return _fecdesde; }
            set { _fecdesde = value; }
        }
        public string fechasta
        {
            get { return _fechasta; }
            set { _fechasta = value; }
        }
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public DataSet leerReporte()
        {
            DAL_BD Objeto = new DAL_BD();
            DataSet consulta = new DataSet();
            Objeto.bd = "conn";
            Objeto.sentenciaSQL = "exec [spleer_procvent2_reporte] '" + _tipoExtra + "', " +
                                                                  "'" + _extra + "', " +
                                                                  "'" + _cliente + "', " +
                                                                  "'" + _fecdesde + "', " +
                                                                  "'" + _fechasta + "', " +
                                                                  "'" + _estado + "'";
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
