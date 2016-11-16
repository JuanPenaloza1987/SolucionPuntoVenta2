using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRATAPV.Utilerias.Negocio;


namespace SRATAPV.Utilerias
{
    public sealed class Globals
    {
        private static Globals instance = new Globals();
        public static Globals Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Globals();
                }
                return instance;
            }
        }

        private Globals()
        {

        }

        //Variables globales a utilizar
        private string _usuario;
        private string _nombreUsuario;
        private List<clsPermisos> _listaPermisos;
        private decimal _porcIva;
        private decimal _porcIeps;
        private decimal _porcRetencion;
        private decimal _TipoCambio;

        private string _NombreEmpresa;
        private string _PublicoGral;
        

        private decimal _DecimalesCosto;
        private decimal _DecimalesPrecio;
        private decimal _DecimalesImporte;
        private decimal _DecimalesCantidad;
        private string _sucursal;
        private string _CadenaConexionLocal;
        private string _CadenaConexionSAP;
        private string _CadenaConexionBitacora;
        private Boolean _proyectoPorCompañia;
        private Boolean _proyectoPorArticulo;
        private Boolean _proyectoPorFactura;
        private Boolean _proyectoSinProyecto;
        private string _proyectoGlobal;
        private string _almacen;
        private string _listaPrecios;

        private Boolean _usaCorteCaja;
        private Boolean _usaSeries;
        private Boolean _usaAsesor;

        private Boolean _stockNegativo;
        private Boolean _cuentasPorCobrar;

        private string _BdStrata;

        public string almacen
        {
            get { return instance._almacen; }
            set { instance._almacen = value; }
        }
        public string listaPrecios
        {
            get { return instance._listaPrecios; }
            set { instance._listaPrecios = value; }
        }
        public string usuario
        {
            get { return instance._usuario; }
            set { instance._usuario = value; }
        }

        public string nombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }
        public string sucursal
        {
            get { return _sucursal; }
            set { _sucursal = value; }
        }

        public List<clsPermisos> permisos
        {
            get { return _listaPermisos; }
        }

        public decimal porcIva
        {
            get { return _porcIva; }
            set { _porcIva = value; }
        }

        public decimal porcIeps
        {
            get { return _porcIeps; }
            set { _porcIeps = value; }
        }

        public decimal porcRetencion
        {
            get { return _porcRetencion; }
            set { _porcRetencion = value; }
        }

        public decimal TipoCambio
        {
            get { return _TipoCambio; }
            set { _TipoCambio = value; }
        }

        public decimal DecimalesCosto
        {
            get { return _DecimalesCosto; }
            set { _DecimalesCosto = value; }
        }
        public decimal DecimalesPrecio
        {
            get { return _DecimalesPrecio; }
            set { _DecimalesPrecio = value; }
        }
        public decimal DecimalesImporte
        {
            get { return _DecimalesImporte; }
            set { _DecimalesImporte = value; }
        }
        public decimal DecimalesCantidad
        {
            get { return _DecimalesCantidad; }
            set { _DecimalesCantidad = value; }

        }
        public string NombreEmpresa
        {
            get { return _NombreEmpresa; }
            set { _NombreEmpresa = value; }

        }
        public string PublicoGral
        {
            get { return _PublicoGral; }
            set { _PublicoGral = value; }

        }

        public string CadenaConexionLocal
        {
            get { return _CadenaConexionLocal; }
            set { _CadenaConexionLocal = value; }

        }
        public string CadenaConexionSAP
        {
            get { return _CadenaConexionSAP; }
            set { _CadenaConexionSAP = value; }

        }
        public string CadenaConexionBitacora
        {
            get { return _CadenaConexionBitacora; }
            set { _CadenaConexionBitacora = value; }

        }
        public Boolean proyectoPorCompañia
        {
            get { return _proyectoPorCompañia; }
            set { _proyectoPorCompañia = value; }

        }
        public Boolean proyectoPorArticulo
        {
            get { return _proyectoPorArticulo; }
            set { _proyectoPorArticulo = value; }

        }
        public Boolean proyectoPorFactura
        {
            get { return _proyectoPorFactura; }
            set { _proyectoPorFactura = value; }

        }
        public Boolean proyectoSinProyecto
        {
            get { return _proyectoSinProyecto; }
            set { _proyectoSinProyecto = value; }
        }
        public string proyectoGlobal
        {
            get { return _proyectoGlobal; }
            set { _proyectoGlobal = value; }
        }
        public Boolean usaCorteCaja
        {
            get { return _usaCorteCaja; }
            set { _usaCorteCaja = value; }
        }
        public Boolean usaSeries
        {
            get { return _usaSeries; }
            set { _usaSeries = value; }
        }
        public Boolean usaAsesor
        {
            get { return _usaAsesor; }
            set { _usaAsesor = value; }
        }
        public Boolean stockNegativo
        {
            get { return _stockNegativo; }
            set { _stockNegativo = value; }
        }
        public Boolean cuentasPorCobrar
        {
            get { return _cuentasPorCobrar; }
            set { _cuentasPorCobrar = value; }
        }
        public string BdStrata
        {
            get { return _BdStrata; }
            set { _BdStrata = value; }
        }


        public Boolean tienePermiso(String pantalla_id)
        {
            try
            {
                clsPermisos objeto;
                objeto = _listaPermisos.Find(x => x.ppe_keypan.Equals(pantalla_id));
                if (objeto != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        //public void leerPermisos()
        //{
        //    try
        //    {
        //        clsLogin login = new clsLogin();
        //        _listaPermisos = login.leerPermisosPorUsuario(_usuario);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

    }
}
