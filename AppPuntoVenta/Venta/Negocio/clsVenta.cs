using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SRATAPV.Utilerias;

namespace AppPuntoVenta.Ventas.Negocio
{
    class clsVenta
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
        private string _ven_referencia;
        private string _ven_groupnum;
        private string _ven_serie;
        private string _ven_keycor;

        private string _sucursal;

        private string _ven_rfccas;
        #endregion

        #region//Detalle
        private string _ven1_keyven;
        private string _ven1_numlin;
        private string _ven1_articulo;
        private string _ven1_artdes;
        private string _ven1_cantidad;
        private decimal _ven1_precio;
        private decimal _ven1_totallinea;
        private string _ven1_moneda;
        private decimal _ven1_iva;
        private decimal _ven1_ieps;
        private decimal _ven1_tipocambio;
        private bool _ven1_escompues;
        private string _ven1_idpaquete;
        private decimal _ven1_porcdesc;
        private decimal _ven1_descuento;
        private string _ven1_keyalm;
        private string _ven1_keypro;
        private string _ven1_OcrCode;
        #endregion

        #region Detalle de Paquete
        private string _venp_keyven;
        private string _venp_NumLin;
        private string _venp_articulo;
        private string _venp_artdes;
        private string _venp_cantidad;
        private decimal _venp_precio;
        private decimal _venp_totallinea;
        private string _venp_moneda;
        private decimal _venp_iva;
        private decimal _venp_ieps;
        private decimal _venp_tipocambio;
        private bool _venp_escompues;
        private string _venp_idpaquete;
        private decimal _venp_porcdesc;
        private decimal _venp_descuento;
        private string _venp_keyalm;
        private string _venp_keypro;
        private string _venp_OcrCode;
        #endregion
        #region//Pagos
        private string _ven4_formapago;
        private string _ven4_keyven;
        private string _ven4_metodopago;
        private string _ven4_metododet;
        private string _ven4_metodoref;
        private string _ven4_importe;
        private string _ven4_fecreg;
        private string _ven4_terminal;
        private string _ven4_cuenta;
        private string _ven4_numpago;

        #endregion

        #region //Paquetes
        private string _ven3_keyven;
        private string _ven3_paquete;
        private string _ven3_numlin;
        private string _ven3_articulo;
        private string _ven3_artdes;
        private string _ven3_cantidad;
        private decimal _ven3_precio;
        private decimal _ven3_iva;
        private decimal _ven3_totallinea;
        private string _ven3_moneda;
        private decimal _ven3_tipocambio;
        private bool _ven3_escompues;
        private string _ven3_keygpo;
        private string _ven3_idpaquete;
        #endregion

        #region  //CamposExtras
        private string _ven6_keyven;
        private string _ven6_numCampo;
        private string _ven6_valorCampo;
        private string _ven6_etiqueta;

        #endregion 

        #region //TerminosPago

        private string _vent7_keyven;
        private string _ven7_numInst;
        private string _ven7_fecha;
        private string _ven7_Porcent;
        private string _ven7_importe;
        private string _ven7_nodias;
        private string _ven7_termCode;

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
        public string ven_groupnum
        {
            get { return _ven_groupnum; }
            set { _ven_groupnum = value; }
        }
        public string sucursal
        {
            get { return _sucursal; }
            set { _sucursal = value; }
        }

        public string ven_keycor
        {
            get { return _ven_keycor; }
            set { _ven_keycor = value; }
        }

        public string ven_serie
        {
            get { return _ven_serie; }
            set { _ven_serie = value; }
        }

        public string ven_rfccas
        {
            get { return _ven_rfccas; }
            set { _ven_rfccas = value; }
        }
        #endregion

        #region //Detalle
        public string ven1_keyven
        {
            get { return _ven1_keyven; }
            set { _ven1_keyven = value; }
        }
        public string ven1_numlin
        {
            get { return _ven1_numlin; }
            set { _ven1_numlin = value; }
        }
        public string ven1_articulo
        {
            get { return _ven1_articulo; }
            set { _ven1_articulo = value; }
        }
        public string ven1_artdes
        {
            get { return _ven1_artdes; }
            set { _ven1_artdes = value; }
        }
        public string ven1_cantidad
        {
            get { return _ven1_cantidad; }
            set { _ven1_cantidad = value; }
        }
        public decimal ven1_precio
        {
            get { return _ven1_precio; }
            set { _ven1_precio = value; }
        }
        public decimal ven1_totallinea
        {
            get { return _ven1_totallinea; }
            set { _ven1_totallinea = value; }
        }
        public string ven1_moneda
        {
            get { return _ven1_moneda; }
            set { _ven1_moneda = value; }
        }
        public decimal ven1_iva
        {
            get { return _ven1_iva; }
            set { _ven1_iva = value; }
        }
        public decimal ven1_ieps
        {
            get { return _ven1_ieps; }
            set { _ven1_ieps = value; }
        }
        public decimal ven1_tipocambio
        {
            get { return _ven1_tipocambio; }
            set { _ven1_tipocambio = value; }
        }
        public bool ven1_escompues
        {
            get { return _ven1_escompues; }
            set { _ven1_escompues = value; }
        }
        public string ven1_idpaquete
        {
            get { return _ven1_idpaquete; }
            set { _ven1_idpaquete = value; }
        }
        public decimal ven1_porcdesc
        {
            get { return _ven1_porcdesc; }
            set { _ven1_porcdesc = value; }
        }
        public decimal ven1_descuento
        {
            get { return _ven1_descuento; }
            set { _ven1_descuento = value; }
        }
        public string ven1_keyalm
        {
            get { return _ven1_keyalm; }
            set { _ven1_keyalm = value; }
        }
        public string ven1_keypro
        {
            get { return _ven1_keypro; }
            set { _ven1_keypro = value; }
        }
        public string ven1_OcrCode
        {
            get { return _ven1_OcrCode; }
            set { _ven1_OcrCode = value; }
        }
        
        #endregion

        #region //Detalle
        public string venp_keyven
        {
            get { return _venp_keyven; }
            set { _venp_keyven = value; }
        }
        public string venp_numlin
        {
            get { return _venp_NumLin; }
            set { _venp_NumLin = value; }
        }
        public string venp_articulo
        {
            get { return _venp_articulo; }
            set { _venp_articulo = value; }
        }
        public string venp_artdes
        {
            get { return _venp_artdes; }
            set { _venp_artdes = value; }
        }
        public string venp_cantidad
        {
            get { return _venp_cantidad; }
            set { _venp_cantidad = value; }
        }
        public decimal venp_precio
        {
            get { return _venp_precio; }
            set { _venp_precio = value; }
        }
        public decimal venp_totallinea
        {
            get { return _venp_totallinea; }
            set { _venp_totallinea = value; }
        }
        public string venp_moneda
        {
            get { return _venp_moneda; }
            set { _venp_moneda = value; }
        }
        public decimal venp_iva
        {
            get { return _venp_iva; }
            set { _venp_iva = value; }
        }
        public decimal venp_ieps
        {
            get { return _venp_ieps; }
            set { _venp_ieps = value; }
        }
        public decimal venp_tipocambio
        {
            get { return _venp_tipocambio; }
            set { _venp_tipocambio = value; }
        }
        public bool venp_escompues
        {
            get { return _venp_escompues; }
            set { _venp_escompues = value; }
        }
        public string venp_idpaquete
        {
            get { return _venp_idpaquete; }
            set { _venp_idpaquete = value; }
        }
        public decimal venp_porcdesc
        {
            get { return _venp_porcdesc; }
            set { _venp_porcdesc = value; }
        }
        public decimal venp_descuento
        {
            get { return _venp_descuento; }
            set { _venp_descuento = value; }
        }
        public string venp_keyalm
        {
            get { return _venp_keyalm; }
            set { _venp_keyalm = value; }
        }
        public string venp_keypro
        {
            get { return _venp_keypro; }
            set { _venp_keypro = value; }
        }
        public string venp_OcrCode
        {
            get { return _venp_OcrCode; }
            set { _venp_OcrCode = value; }
        }
        #endregion

        #region //Pagos
        public string ven4_formapago
        {
            get { return _ven4_formapago; }
            set { _ven4_formapago = value; }
        }
        public string ven4_keyven
        {
            get { return _ven4_keyven; }
            set { _ven4_keyven = value; }
        }
        public string ven4_metodopago
        {
            get { return _ven4_metodopago; }
            set { _ven4_metodopago = value; }
        }
        public string ven4_metododet
        {
            get { return _ven4_metododet; }
            set { _ven4_metododet = value; }
        }
        public string ven4_metodoref
        {
            get { return _ven4_metodoref; }
            set { _ven4_metodoref = value; }
        }
        public string ven4_importe
        {
            get { return _ven4_importe; }
            set { _ven4_importe = value; }
        }
        public string ven4_fecreg
        {
            get { return _ven4_fecreg; }
            set { _ven4_fecreg = value; }
        }
        public string ven4_terminal
        {
            get { return _ven4_terminal; }
            set { _ven4_terminal = value; }
        }
        public string ven4_numpago
        {
            get { return _ven4_numpago; }
            set { _ven4_numpago = value; }
        }
        public string ven4_cuenta
        {
            get { return _ven4_cuenta; }
            set { _ven4_cuenta = value; }
        }
        #endregion

        #region //Paquetes
        public string ven3_keyven
        {
            get { return _ven3_keyven; }
            set { _ven3_keyven = value; }
        }
        public string ven3_paquete
        {
            get { return _ven3_paquete; }
            set { _ven3_paquete = value; }
        }
        public string ven3_numlin
        {
            get { return _ven3_numlin; }
            set { _ven3_numlin = value; }
        }
        public string ven3_articulo
        {
            get { return _ven3_articulo; }
            set { _ven3_articulo = value; }
        }
        public string ven3_artdes
        {
            get { return _ven3_artdes; }
            set { _ven3_artdes = value; }
        }
        public string ven3_cantidad
        {
            get { return _ven3_cantidad; }
            set { _ven3_cantidad = value; }
        }
        public decimal ven3_precio
        {
            get { return _ven3_precio; }
            set { _ven3_precio = value; }
        }
        public decimal ven3_totallinea
        {
            get { return _ven3_totallinea; }
            set { _ven3_totallinea = value; }
        }
        public string ven3_moneda
        {
            get { return _ven3_moneda; }
            set { _ven3_moneda = value; }
        }
        public decimal ven3_iva
        {
            get { return _ven3_iva; }
            set { _ven3_iva = value; }
        }
        public decimal ven3_tipocambio
        {
            get { return _ven3_tipocambio; }
            set { _ven3_tipocambio = value; }
        }
        public bool ven3_escompues
        {
            get { return _ven3_escompues; }
            set { _ven3_escompues = value; }
        }
        public string ven3_keygpo
        {
            get { return _ven3_keygpo; }
            set { _ven3_keygpo = value; }
        }
        public string ven3_idpaquete
        {
            get { return _ven3_idpaquete; }
            set { _ven3_idpaquete = value; }
        }
        public string ven_referencia
        {
            get { return _ven_referencia; }
            set { _ven_referencia = value; }
        }
        #endregion

        #region  //CamposExtras
        public string ven6_keyven
        {
            get { return _ven6_keyven; }
            set { _ven6_keyven = value; }
        }
        public string ven6_numCampo
        {
            get { return _ven6_numCampo; }
            set { _ven6_numCampo = value; }
        }
        public string ven6_valorCampo
        {
            get { return _ven6_valorCampo; }
            set { _ven6_valorCampo = value; }
        }
        public string ven6_etiqueta
        {
            get { return _ven6_etiqueta; }
            set { _ven6_etiqueta = value; }
        }

        #endregion 

        #region //TerminosPago

        public string vent7_keyven
        {
            get { return _vent7_keyven; }
            set { _vent7_keyven = value; }
        }
        public string ven7_numInst
        {
            get { return _ven7_numInst; }
            set { _ven7_numInst = value; }
        }
        public string ven7_fecha
        {
            get { return _ven7_fecha; }
            set { _ven7_fecha = value; }
        }
        public string ven7_Porcent
        {
            get { return _ven7_Porcent; }
            set { _ven7_Porcent = value; }
        }
        public string ven7_importe
        {
            get { return _ven7_importe; }
            set { _ven7_importe = value; }
        }
        public string ven7_nodias
        {
            get { return _ven7_nodias; }
            set { _ven7_nodias = value; }
        }
        public string ven7_termCode
        {
            get { return _ven7_termCode; }
            set { _ven7_termCode = value; }
        }

        #endregion

        #region Lotes
        private int _venl_keyven;
        private string _venl_articulo;
        private string _venl_artdes;
        private float _venl_cantidad;
        private string _venl_lote;
        private int _venl_numlin;
        public int venl_numlin
        {
            get { return _venl_numlin; }
            set { _venl_numlin = value; }
        }

        public string venl_lote
        {
            get { return _venl_lote; }
            set { _venl_lote = value; }
        }

        public float venl_cantidad
        {
            get { return _venl_cantidad; }
            set { _venl_cantidad = value; }
        }

        public string venl_artdes
        {
            get { return _venl_artdes; }
            set { _venl_artdes = value; }
        }

        public string venl_articulo
        {
            get { return _venl_articulo; }
            set { _venl_articulo = value; }
        }

        public int venl_keyven
        {
            get { return _venl_keyven; }
            set { _venl_keyven = value; }
        }
        #endregion

        public DataSet leerClaveVenta()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();

            Objeto.sentenciaSQL = "exec [spleer_claveventa]";
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

        public DataSet leerVentas()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();

            Objeto.sentenciaSQL = "exec [spleer_procvent]";
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

        public DataSet leerUnicaVenta()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();

            Objeto.sentenciaSQL = "exec [spleer_procvent_unico] '" + _ven_keyven + "'";
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

        public DataSet leerSiVentaEnviadoSAP()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();

            Objeto.sentenciaSQL = "exec [spleer_procventEnviado] '" + _ven_keyven + "'";
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

        public DataSet leerVentasAbiertasCliente()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();

            Objeto.sentenciaSQL = "exec [spleer_procvent_AbiertasCliente] '" + _ven_cliente + "'";
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

        public string leerUltimaVenta()
        {
            BD Objeto = new BD();
            DataSet consulta = new DataSet();

            Objeto.sentenciaSQL = "SELECT ven_keyven From procvent ORDER BY ven_keyven DESC";
            consulta = Objeto.ejecutaConsulta();
            if (!Objeto.hayError)
            {
                if (consulta.Tables[0].Rows.Count > 0)
                {
                    return consulta.Tables[0].Rows[0][0].ToString();
                }
                return "-1";
            }
            else
            {
                mensaje = Objeto.mensaje;
                return null;
            }
        }

        public Boolean Guardar()
        {
            BD Objeto = new BD();

            Objeto.sentenciaSQL = "INSERT INTO procvent(ven_caja,ven_usrven,ven_cliente,ven_estado,ven_fecdoc,ven_fecreg,ven_iva,ven_ieps,ven_retencion,ven_descue,ven_subtot,ven_total,ven_porcdesc,ven_porciva,ven_porcieps,ven_porcretencion,ven_almace,ven_coment,ven_webIde,ven_docsap,ven_enviad,ven_keycot,ven_formapago,ven_metodopago,ven_metododet,ven_metodoref,ven_keycor,ven_enviadobita,ven_keyser,ven_nomser,ven_keyase,ven_referencia,ven_groupnum,ven_serie,ven_rfccas)" +
                " VALUES(" + ven_caja +
                "," + ven_usrven +
                "," + ven_cliente +
                "," + ven_estado +
                "," + ven_fecdoc +
                ", GETDATE()" +
                "," + ven_iva +
                "," + ven_ieps +
                "," + ven_retencion +
                "," + ven_descue +
                "," + ven_subtot +
                "," + ven_total +
                "," + ven_porcdesc +
                "," + ven_porciva +
                "," + ven_porcieps +
                "," + ven_porcretencion +
                "," + ven_almace +
                "," + ven_coment +
                "," + ven_webIde +
                ", NULL ,'false'," +
                ven_keycot +
                "," + ven_formapago +
                "," + ven_metodopago +
                "," + ven_metododet +
                "," + ven_metodoref +
                "," + ven_keycor +
                ",'false'," +
                ven_keyser +
                "," + ven_nomser +
                "," + ven_keyase +
                "," + ven_referencia +
                "," + ven_groupnum + 
                "," + ven_serie + 
                "," + ven_rfccas + ")";


            Objeto.ejecutaConsulta();

            if (!Objeto.hayError)
            {

                _ven_keyven = leerUltimaVenta();
                return true;
            }
            else
            {
                mensaje = Objeto.mensaje;
                return false;
            }
        }

        public Boolean GuardarDetalleOLD()
        {
            BD Objeto = new BD();

            Objeto.sentenciaSQL = "exec [spguar_procvent1] '" + _ven1_keyven + "'," +
                                                          "'" + _ven1_numlin + "'," +
                                                          "'" + _ven1_articulo + "'," +
                                                          "'" + _ven1_artdes + "'," +
                                                          "'" + _ven1_cantidad + "'," +
                                                          "'" + _ven1_precio + "'," +
                                                          "'" + _ven1_iva + "'," +
                                                          "'" + _ven1_ieps + "'," +
                                                          "'" + _ven1_totallinea + "'," +
                                                          "'" + _ven1_moneda + "'," +
                                                          "'" + _ven1_tipocambio + "'," +
                                                          "'" + _ven1_escompues + "'," +
                                                          "'" + _ven1_idpaquete + "'," +
                                                          "'" + _ven1_porcdesc + "'," +
                                                          "'" + _ven1_descuento + "'," +
                                                          "'" + _ven1_keyalm + "'," +
                                                          "'" + _ven1_keypro + "'," +
                                                          "'" + _ven1_OcrCode + "'";



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

        public Boolean GuardarDetalle()
        {
            BD Objeto = new BD();

            Objeto.sentenciaSQL = "INSERT INTO procvent1(ven1_keyven,ven1_numlin,ven1_articulo,ven1_artdes,ven1_cantidad,ven1_precio,ven1_iva,ven1_ieps,ven1_totallinea,ven1_moneda,ven1_tipocambio,ven1_escompues,ven1_idpaquete,ven1_porcdesc,ven1_descuento,ven1_keyalm,ven1_keypro,ven1_OcrCode) VALUES" +
                "(" +
                  ven1_keyven +
                  ", " + ven1_numlin +
                  ", " + ven1_articulo +
                  ", " + ven1_artdes +
                  ", " + ven1_cantidad +
                  ", " + ven1_precio +
                  ", " + ven1_iva +
                  ", " + ven1_ieps +
                  ", " + ven1_totallinea +
                  ", " + ven1_moneda +
                  ", " + ven1_tipocambio +
                  ", " + (ven1_escompues ? "1" : "2") +
                  ", " + ven1_idpaquete +
                  ", " + ven1_porcdesc +
                  ", " + ven1_descuento +
                  ", " + ven1_keyalm +
                  ", " + ven1_keypro +
                  ", " + ven1_OcrCode + ")";

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

        public Boolean GuardarDetalleLote()
        {
            BD Objeto = new BD();

            Objeto.sentenciaSQL = "INSERT INTO procventlote(venl_keyven,venl_articulo,venl_artdes,venl_cantidad,venl_lote,venl_numlin) VALUES" +
                "(" +
                  venl_keyven +
                  ", " + venl_articulo +
                  ", " + venl_artdes +
                  ", " + venl_cantidad +
                  ", " + venl_lote +
                  ", " + venl_numlin + ")";

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

        public Boolean GuardarDetallePaquetes()
        {
            BD Objeto = new BD();

            Objeto.sentenciaSQL = "INSERT INTO procventp(venp_keyven,venp_NumLin,venp_articulo,venp_artdes,venp_cantidad,venp_precio,venp_iva,venp_ieps,venp_totallinea,venp_moneda,venp_tipocambio,venp_escompues,venp_idpaquete,venp_porcdesc,venp_descuento,venp_keyalm,venp_keypro,venp_OcrCode) VALUES" +
                "(" +
                  venp_keyven +
                  ", " + venp_numlin +
                  ", " + venp_articulo +
                  ", " + venp_artdes +
                  ", " + venp_cantidad +
                  ", " + venp_precio +
                  ", " + venp_iva +
                  ", " + venp_ieps +
                  ", " + venp_totallinea +
                  ", " + venp_moneda +
                  ", " + venp_tipocambio +
                  ", " + (venp_escompues ? "1" : "2") +
                  ", " + venp_idpaquete +
                  ", " + venp_porcdesc +
                  ", " + venp_descuento +
                  ", " + venp_keyalm +
                  ", " + venp_keypro +
                  ", " + venp_OcrCode + ")";

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

        public Boolean GuardarDetallePagos()
        {
            BD Objeto = new BD();
            
            Objeto.sentenciaSQL = "INSERT INTO procvent4 ( ven4_keyven, ven4_metodopago, ven4_metododet, ven4_metodoref, ven4_importe, ven4_fecreg, ven4_formapago, ven4_terminal, ven4_cuenta, ven4_enviadobita, ven4_enviado, ven4_msjError, ven4_numpago, ven4_keyven8 )" +
                                    "VALUES(" +
                                     "'" + ven4_keyven + "'," +
                                     "'" + ven4_metodopago + "'," +
                                     "'" + ven4_metododet + "'," +
                                     "'" + ven4_metodoref + "'," +
                                     "'" + ven4_importe + "'," +
                                     "GETDATE()," +
                                     "'" + ven4_formapago + "'," +
                                     "'" + ven4_terminal + "'," +
                                     ""+ ven4_cuenta + "," +
                                        "NULL," +
		                                "NULL," +
		                                "NULL," +
		                                "NULL," +
                                        "NULL)";
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
