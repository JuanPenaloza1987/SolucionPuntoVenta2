using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using STRATAPV.DAL;

namespace SRATAPV.Reportes.Negocio
{
    class clsReportesCalidadCartera
    {
        #region //Variables
        private string _mensaje;
        private string _active;
        private string _coordinador1;
        private string _coordinador2;
        private string _fecha1;
        private string _fecha2;
        private string _centroCosto;
        #endregion

        #region //
        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public string active
        {
            get { return _active; }
            set { _active = value; }
        }
        public string coordinador1
        {
            get { return _coordinador1; }
            set { _coordinador1 = value; }
        }
        public string coordinador2
        {
            get { return _coordinador2; }
            set { _coordinador2 = value; }
        }
        public string fecha1
        {
            get { return _fecha1; }
            set { _fecha1 = value; }
        }
        public string fecha2
        {
            get { return _fecha2; }
            set { _fecha2 = value; }
        }
        public string centroCosto
        {
            get { return _centroCosto; }
            set { _centroCosto = value; }
        }
        #endregion

        public DataSet leerCentrosCosto()
        {
            DAL_BD Objeto = new DAL_BD();
            DataSet consulta = new DataSet();
            Objeto.bd = "csap";
            Objeto.sentenciaSQL = "exec [spleer_centroscosto] '" + _active + "'";
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

        public DataSet leerCoordinadores()
        {
            DAL_BD Objeto = new DAL_BD();
            DataSet consulta = new DataSet();
            Objeto.bd = "csap";
            Objeto.sentenciaSQL = "exec [spleer_coordinadores] ";
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
