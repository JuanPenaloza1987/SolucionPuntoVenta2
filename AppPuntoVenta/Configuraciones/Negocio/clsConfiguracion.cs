
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPuntoVenta.Configuraciones.Negocio
{
    class clsConfiguracion
    {
        #region Caja
        private string _caj_descrip;
        private string _caj_impres;
        private string _caj_ipMaq;
        private string _caj_macAdd;

        public string caj_descrip
        {
            get { return _caj_descrip; }
            set { _caj_descrip = value; }
        }


        public string caj_impres
        {
            get { return _caj_impres; }
            set { _caj_impres = value; }
        }


        public string caj_ipMaq
        {
            get { return _caj_ipMaq; }
            set { _caj_ipMaq = value; }
        }


        public string caj_macAdd
        {
            get { return _caj_macAdd; }
            set { _caj_macAdd = value; }
        }

        private string _mensaje;

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        #endregion

        #region Empresa
        private string _par_nomemp;
        private string _par_decicosto;
        private string _par_deciimporte;
        private string _par_deciprecios;
        private string _par_decicantid;
        private string _par_impuesto;
        private string _par_tipoCambio;
        private string _par_logoEmp;
        private bool _par_conexionlinea;
        private string _par_giroNegocio;
        private string _par_publicogrl;
        private string _par_dircalle;
        private string _par_dirnumero;
        private string _par_dircolonia;
        private string _par_direstado;
        private string _par_dirciudad;
        private string _par_dircodposta;
        private string _par_dirtelefono;
        private string _par_dirrfc;
        private string _par_ieps;

        public string par_nomemp
        {
            get { return _par_nomemp; }
            set { _par_nomemp = value; }
        }
        public string par_decicosto
        {
            get { return _par_decicosto; }
            set { _par_decicosto = value; }
        }
        public string par_deciimporte
        {
            get { return _par_deciimporte; }
            set { _par_deciimporte = value; }
        }
        public string par_deciprecios
        {
            get { return _par_deciprecios; }
            set { _par_deciprecios = value; }
        }
        public string par_decicantid
        {
            get { return _par_decicantid; }
            set { _par_decicantid = value; }
        }
        public string par_impuesto
        {
            get { return _par_impuesto; }
            set { _par_impuesto = value; }
        }
        public string par_tipoCambio
        {
            get { return _par_tipoCambio; }
            set { _par_tipoCambio = value; }
        }
        public string par_logoEmp
        {
            get { return _par_logoEmp; }
            set { _par_logoEmp = value; }
        }
        public bool par_conexionlinea
        {
            get { return _par_conexionlinea; }
            set { _par_conexionlinea = value; }
        }
        public string par_giroNegocio
        {
            get { return _par_giroNegocio; }
            set { _par_giroNegocio = value; }
        }
        public string par_publicogrl
        {
            get { return _par_publicogrl; }
            set { _par_publicogrl = value; }
        }
        public string par_dircalle
        {
            get { return _par_dircalle; }
            set { _par_dircalle = value; }
        }
        public string par_dirnumero
        {
            get { return _par_dirnumero; }
            set { _par_dirnumero = value; }
        }
        public string par_dircolonia
        {
            get { return _par_dircolonia; }
            set { _par_dircolonia = value; }
        }
        public string par_direstado
        {
            get { return _par_direstado; }
            set { _par_direstado = value; }
        }
        public string par_dirciudad
        {
            get { return _par_dirciudad; }
            set { _par_dirciudad = value; }
        }
        public string par_dircodposta
        {
            get { return _par_dircodposta; }
            set { _par_dircodposta = value; }
        }
        public string par_dirtelefono
        {
            get { return _par_dirtelefono; }
            set { _par_dirtelefono = value; }
        }
        public string par_dirrfc
        {
            get { return _par_dirrfc; }
            set { _par_dirrfc = value; }
        }
        public string par_ieps
        {
            get { return _par_ieps; }
            set { _par_ieps = value; }
        }
        #endregion

        public bool GuardarConfiguracion()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = string.Format("INSERT INTO confcaja(caj_descrip, caj_impres, caj_ipMaq, caj_macAdd) VALUES('{0}', '{1}', '{2}', '{3}')",
                caj_descrip,
                caj_impres,
                caj_ipMaq,
                caj_macAdd);

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

        public bool ActualizaConfiguracion(string cajaAModificar)
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = string.Format("UPDATE confcaja set " +
                "caj_descrip = '" + caj_descrip + "', " + 
                "caj_impres = '" + caj_impres + "', " +
                "caj_ipMaq = '" + caj_ipMaq + "', " +
                "caj_macAdd = '" + caj_macAdd + "' WHERE caj_descrip = '" + cajaAModificar + "'");

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

        public DataSet ObtenerConfiguracionCaja()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM confcaja";
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

        public DataSet ObtenerConfiguracionEmpresa()
        {
            BD Objeto = new BD();
            DataSet Data = new DataSet();
            
            Objeto.sentenciaSQL = "SELECT * FROM confpara";
            Data = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                return Data;
            }
            else
            {
                
                _mensaje = Objeto.mensaje;
                return null;
            }
        }

    }
}
