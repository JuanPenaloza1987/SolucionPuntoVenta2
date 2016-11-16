using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using STRATAPV.DAL;

namespace SRATAPV.Reportes.Negocio
{
    class clsReporteVentas
    {
        #region//Cabecera
        private string _mensaje;
        private string _ven_keyven;
        private string _ven_caja;
        private string _ven_usrven;
        private string _ven_cliente;
        private string _ven_estado;
        private string _ven_fecdoc;
        private string _ven_fecreg;
        private string _ven_fecmod;
        private string _ven_feccan;
        private decimal _ven_iva;
        private decimal _ven_ieps;
        private decimal _ven_retencion;
        private decimal _ven_descue;
        private decimal _ven_subtot;
        private decimal _ven_total;
        private decimal _ven_porcdesc;
        private decimal _ven_porciva;
        private decimal _ven_porcieps;
        private decimal _ven_porcretencion;
        private string _ven_almace;
        private string _ven_usrmod;
        private string _ven_usrcan;
        private string _ven_motcan;
        private string _ven_coment;
        private string _ven_webIde;
        private string _ven_docsap;
        private string _ven_msjErr;
        private string _ven_eqenvi;
        private string _ven_macadd;
        private string _ven_ipenvi;
        private string _ven_enviad;
        private string _ven_fecenv;
        private string _ven_keycot;
        private string _ven_formapago;
        private string _ven_metodopago;
        private string _ven_metododet;
        private string _ven_metodoref;
        private string _ven_xml;
        private string _ven_pac;
        private string _ven_timacuse;
        private string _ven_timfeccan;
        private string _ven_timusrcan;
        private string _tipo;
        private bool _usaCorteCaja;
        private string _ven_keyser;
        private string _ven_nomser;
        private string _ven_keyase;

        #endregion

        #region //Cabecera
        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        public string ven_keyven
        {
            get { return _ven_keyven; }
            set { _ven_keyven = value; }
        }
        public string ven_caja
        {
            get { return _ven_caja; }
            set { _ven_caja = value; }
        }
        public string ven_usrven
        {
            get { return _ven_usrven; }
            set { _ven_usrven = value; }
        }
        public string ven_cliente
        {
            get { return _ven_cliente; }
            set { _ven_cliente = value; }
        }
        public string ven_estado
        {
            get { return _ven_estado; }
            set { _ven_estado = value; }
        }
        public string ven_fecdoc
        {
            get { return _ven_fecdoc; }
            set { _ven_fecdoc = value; }
        }
        public string ven_fecreg
        {
            get { return _ven_fecreg; }
            set { _ven_fecreg = value; }
        }
        public string ven_fecmod
        {
            get { return _ven_fecmod; }
            set { _ven_fecmod = value; }
        }
        public string ven_feccan
        {
            get { return _ven_feccan; }
            set { _ven_feccan = value; }
        }
        public decimal ven_iva
        {
            get { return _ven_iva; }
            set { _ven_iva = value; }
        }
        public decimal ven_ieps
        {
            get { return _ven_ieps; }
            set { _ven_ieps = value; }
        }
        public decimal ven_retencion
        {
            get { return _ven_retencion; }
            set { _ven_retencion = value; }
        }
        public decimal ven_descue
        {
            get { return _ven_descue; }
            set { _ven_descue = value; }
        }
        public decimal ven_subtot
        {
            get { return _ven_subtot; }
            set { _ven_subtot = value; }
        }
        public decimal ven_total
        {
            get { return _ven_total; }
            set { _ven_total = value; }
        }
        public decimal ven_porcdesc
        {
            get { return _ven_porcdesc; }
            set { _ven_porcdesc = value; }
        }
        public decimal ven_porciva
        {
            get { return _ven_porciva; }
            set { _ven_porciva = value; }
        }
        public decimal ven_porcieps
        {
            get { return _ven_porcieps; }
            set { _ven_porcieps = value; }
        }
        public decimal ven_porcretencion
        {
            get { return _ven_porcretencion; }
            set { _ven_porcretencion = value; }
        }
        public string ven_almace
        {
            get { return _ven_almace; }
            set { _ven_almace = value; }
        }
        public string ven_usrmod
        {
            get { return _ven_usrmod; }
            set { _ven_usrmod = value; }
        }
        public string ven_usrcan
        {
            get { return _ven_usrcan; }
            set { _ven_usrcan = value; }
        }
        public string ven_motcan
        {
            get { return _ven_motcan; }
            set { _ven_motcan = value; }
        }
        public string ven_coment
        {
            get { return _ven_coment; }
            set { _ven_coment = value; }
        }
        public string ven_webIde
        {
            get { return _ven_webIde; }
            set { _ven_webIde = value; }
        }
        public string ven_docsap
        {
            get { return _ven_docsap; }
            set { _ven_docsap = value; }
        }
        public string ven_msjErr
        {
            get { return _ven_msjErr; }
            set { _ven_msjErr = value; }
        }
        public string ven_eqenvi
        {
            get { return _ven_eqenvi; }
            set { _ven_eqenvi = value; }
        }
        public string ven_macadd
        {
            get { return _ven_macadd; }
            set { _ven_macadd = value; }
        }
        public string ven_ipenvi
        {
            get { return _ven_ipenvi; }
            set { _ven_ipenvi = value; }
        }
        public string ven_enviad
        {
            get { return _ven_enviad; }
            set { _ven_enviad = value; }
        }
        public string ven_fecenv
        {
            get { return _ven_fecenv; }
            set { _ven_fecenv = value; }
        }
        public string ven_keycot
        {
            get { return _ven_keycot; }
            set { _ven_keycot = value; }
        }
        public string ven_formapago
        {
            get { return _ven_formapago; }
            set { _ven_formapago = value; }
        }
        public string ven_metodopago
        {
            get { return _ven_metodopago; }
            set { _ven_metodopago = value; }
        }
        public string ven_metododet
        {
            get { return _ven_metododet; }
            set { _ven_metododet = value; }
        }
        public string ven_metodoref
        {
            get { return _ven_metodoref; }
            set { _ven_metodoref = value; }
        }
        public string ven_xml
        {
            get { return _ven_xml; }
            set { _ven_xml = value; }
        }
        public string ven_pac
        {
            get { return _ven_pac; }
            set { _ven_pac = value; }
        }
        public string ven_timacuse
        {
            get { return _ven_timacuse; }
            set { _ven_timacuse = value; }
        }
        public string ven_timfeccan
        {
            get { return _ven_timfeccan; }
            set { _ven_timfeccan = value; }
        }
        public string ven_timusrcan
        {
            get { return _ven_timusrcan; }
            set { _ven_timusrcan = value; }
        }
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public bool usaCorteCaja
        {
            get { return _usaCorteCaja; }
            set { _usaCorteCaja = value; }
        }
        public string ven_keyser
        {
            get { return _ven_keyser; }
            set { _ven_keyser = value; }
        }
        public string ven_nomser
        {
            get { return _ven_nomser; }
            set { _ven_nomser = value; }
        }
        public string ven_keyase
        {
            get { return _ven_keyase; }
            set { _ven_keyase = value; }
        }

        #endregion

        public DataSet leerVentaReporte()
        {
            DAL_BD Objeto = new DAL_BD();
            DataSet consulta = new DataSet();
            Objeto.bd = "conn";
            Objeto.sentenciaSQL = "exec [spleer_procvent_reporte] '" + _ven_keyven + "', " +
                                                                 "'" + _ven_cliente + "', " +
                                                                 "'" + _ven_fecreg + "', " +
                                                                 "'" + _ven_fecmod + "', " +
                                                                 "'" + _ven_estado + "'";
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
