using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using STRATAPV.DAL;

namespace SRATAPV.Reportes.Negocio
{
    class clsReporteVentasTotales
    {

        #region//Cabecera
        private string _mensaje;
        private string _fechaDesde;
        private string _fechaHasta;
        private string _bdBitacora;
        private string _sucursal;

        #endregion

        #region //Cabecera
        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public string fechaDesde
        {
            get { return _fechaDesde; }
            set { _fechaDesde = value; }
        }
        public string fechaHasta
        {
            get { return _fechaHasta; }
            set { _fechaHasta = value; }
        }
        public string bdBitacora
        {
            get { return _bdBitacora; }
            set { _bdBitacora = value; }
        }
        public string sucursal
        {
            get { return _sucursal; }
            set { _sucursal = value; }
        }

        #endregion

        public DataSet leerVentaStrata()
        {
            DAL_BD Objeto = new DAL_BD();
            DataSet consulta = new DataSet();
            Objeto.bd = "conn";
            Objeto.sentenciaSQL = "exec [spleer_procventST] '" + _fechaDesde + "', " +
                                                           "'" + _fechaHasta + "', " +
                                                           "'" + _bdBitacora + "', " +
                                                           "'" + _sucursal + "'";
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

        public DataSet leerVentaSap()
        {
            DAL_BD Objeto = new DAL_BD();
            DataSet consulta = new DataSet();
            Objeto.bd = "csap";
            Objeto.sentenciaSQL = "exec [spleer_procventSAP] '" + _fechaDesde + "', " +
                                                            "'" + _fechaHasta + "', " +
                                                            "'" + _sucursal + "'";
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
