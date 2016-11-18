using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
    public class entProcVent
    {
        #region propieties
        public int ven_keyven { get; set; }
        public string ven_caja { get; set; }
        public string ven_usrven { get; set; }
        public string ven_cliente { get; set; }
        public string ven_estado { get; set; }
        public DateTime ven_fecdoc { get; set; }
        public DateTime ven_fecreg { get; set; }
        public DateTime ven_fecmod { get; set; }
        public DateTime ven_feccan { get; set; }
        public decimal ven_iva { get; set; }
        public decimal ven_ieps { get; set; }
        public decimal ven_retencion { get; set; }
        public decimal ven_descue { get; set; }
        public decimal ven_subtot { get; set; }
        public decimal ven_total { get; set; }
        public decimal ven_porcdesc { get; set; }
        public decimal ven_porciva { get; set; }
        public decimal ven_porcieps { get; set; }
        public decimal ven_porcretencion { get; set; }
        public string ven_almace { get; set; }
        public string ven_usrmod { get; set; }
        public string ven_usrcan { get; set; }
        public string ven_motcan { get; set; }
        public string ven_coment { get; set; }
        public string ven_webIde { get; set; }
        public int ven_docsap { get; set; }
        public string ven_msjErr { get; set; }
        public string ven_eqenvi { get; set; }
        public string ven_macadd { get; set; }
        public string ven_ipenvi { get; set; }
        public bool ven_enviad { get; set; }
        public DateTime ven_fecenv { get; set; }
        public int ven_keycot { get; set; }
        public string ven_formapago { get; set; }
        public string ven_metodopago { get; set; }
        public int ven_metododet { get; set; }
        public string ven_metodoref { get; set; }
        public int ven_keycor { get; set; }
        public bool ven_enviadobita { get; set; }
        public string ven_xml { get; set; }
        public string ven_pac { get; set; }
        public string ven_timacuse { get; set; }
        public DateTime ven_timfeccan { get; set; }
        public string ven_timusrcan { get; set; }
        public string ven_keyser { get; set; }
        public string ven_nomser { get; set; }
        public string ven_keyase { get; set; }
        public string ven_referencia { get; set; }
        public int ven_docnumsap { get; set; }
        public string ven_groupnum { get; set; }
        public int ven_keypos { get; set; }
        public string ven_serie { get; set; }
        #endregion

        #region methods
        public entProcVent()
        { }
        public entProcVent (int ven_keyven, string ven_caja, string ven_usrven, string ven_cliente, string ven_estado, DateTime ven_fecdoc, DateTime ven_fecreg,
            DateTime ven_fecmod, DateTime ven_feccan, decimal ven_iva, decimal ven_ieps, decimal ven_retencion, decimal ven_descue, decimal ven_subtot, decimal ven_total,
            decimal ven_porcdesc, decimal ven_porciva, decimal ven_porcieps, decimal ven_porcretencion, string ven_almace, string ven_usrmod, string ven_usrcan,
            string ven_motcan, string ven_coment, string ven_webIde, int ven_docsap, string ven_msjErr, string ven_eqenvi, string ven_macadd, string ven_ipenvi, bool ven_enviad,
            DateTime ven_fecenv, int ven_keycot, string ven_formapago, string ven_metodopago, int ven_metododet, string ven_metodoref, int ven_keycor, bool ven_enviadobita,
            string ven_xml, string ven_pac, string ven_timacuse, DateTime ven_timfeccan, string ven_timusrcan, string ven_keyser, string ven_nomser, string ven_keyase,
            string ven_referencia, int ven_docnumsap, string ven_groupnum, int ven_keypos,string ven_serie)
        {
            this.ven_keyven = ven_keyven;
            this.ven_caja = ven_caja;
            this.ven_usrven = ven_usrven;
            this.ven_cliente = ven_cliente;
            this.ven_estado = ven_estado;
            this.ven_fecdoc = ven_fecdoc;
            this.ven_fecreg = ven_fecreg;
            this.ven_fecmod = ven_fecmod;
            this.ven_feccan = ven_feccan;
            this.ven_iva = ven_iva;
            this.ven_ieps = ven_ieps;
            this.ven_retencion = ven_retencion;
            this.ven_descue = ven_descue;
            this.ven_subtot = ven_subtot;
            this.ven_total = ven_total;
            this.ven_porcdesc = ven_porcdesc;
            this.ven_porciva = ven_porciva;
            this.ven_porcieps = ven_porcieps;
            this.ven_porcretencion = ven_porcretencion;
            this.ven_almace = ven_almace;
            this.ven_usrmod = ven_usrmod;
            this.ven_usrcan = ven_usrcan;
            this.ven_motcan = ven_motcan;
            this.ven_coment = ven_coment;
            this.ven_webIde = ven_webIde;
            this.ven_docsap = ven_docsap;
            this.ven_msjErr = ven_msjErr;
            this.ven_eqenvi = ven_eqenvi;
            this.ven_macadd = ven_macadd;
            this.ven_ipenvi = ven_ipenvi;
            this.ven_enviad = ven_enviad;
            this.ven_fecenv = ven_fecenv;
            this.ven_keycot = ven_keycot;
            this.ven_formapago = ven_formapago;
            this.ven_metodopago = ven_metodopago;
            this.ven_metododet = ven_metododet;
            this.ven_metodoref = ven_metodoref;
            this.ven_keycor = ven_keycor;
            this.ven_enviadobita = ven_enviadobita;
            this.ven_xml = ven_xml;
            this.ven_pac = ven_pac;
            this.ven_timacuse = ven_timacuse;
            this.ven_timfeccan = ven_timfeccan;
            this.ven_timusrcan = ven_timusrcan;
            this.ven_keyser = ven_keyser;
            this.ven_nomser = ven_nomser;
            this.ven_keyase = ven_keyase;
            this.ven_referencia = ven_referencia;
            this.ven_docnumsap = ven_docnumsap;
            this.ven_groupnum = ven_groupnum;
            this.ven_keypos = ven_keypos;
            this.ven_serie = ven_serie;
        }
        #endregion
    }
}
