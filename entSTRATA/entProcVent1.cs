using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
    public class entProcVent1
    {
        #region propieties
        public int ven1_keyven { get; set; }
        public int ven1_numlin { get; set; }
        public string ven1_articulo { get; set; }
        public string ven1_artdes { get; set; }
        public decimal ven1_cantidad { get; set; }
        public decimal ven1_precio { get; set; }
        public decimal ven1_iva { get; set; }
        public decimal ven1_ieps { get; set; }
        public decimal ven1_totallinea { get; set; }
        public string ven1_moneda { get; set; }
        public decimal ven1_tipocambio { get; set; }
        public bool ven1_escompues { get; set; }
        public string ven1_idpaquete { get; set; }
        public decimal ven1_porcdesc { get; set; }
        public decimal ven1_descuento { get; set; }
        public string ven1_keyalm { get; set; }
        public string ven1_keypro { get; set; }
        public string ven1_OcrCode { get; set; }
        #endregion

        #region methods
        public entProcVent1()
        { }
        public entProcVent1 (int ven1_keyven, int ven1_numlin, string ven1_articulo, string ven1_artdes, decimal ven1_cantidad, decimal ven1_precio, decimal ven1_iva,
            decimal ven1_ieps, decimal ven1_totallinea, string ven1_moneda, decimal ven1_tipocambio, bool ven1_escompues, string ven1_idpaquete, decimal ven1_porcdesc,
            decimal ven1_descuento, string ven1_keyalm, string ven1_keypro, string ven1_OcrCode)
        {
            this.ven1_keyven = ven1_keyven;
            this.ven1_numlin = ven1_numlin;
            this.ven1_articulo = ven1_articulo;
            this.ven1_artdes = ven1_artdes;
            this.ven1_cantidad = ven1_cantidad;
            this.ven1_precio = ven1_precio;
            this.ven1_iva = ven1_iva;
            this.ven1_ieps = ven1_ieps;
            this.ven1_totallinea = ven1_totallinea;
            this.ven1_moneda = ven1_moneda;
            this.ven1_tipocambio = ven1_tipocambio;
            this.ven1_escompues = ven1_escompues;
            this.ven1_idpaquete = ven1_idpaquete;
            this.ven1_porcdesc = ven1_porcdesc;
            this.ven1_descuento = ven1_descuento;
            this.ven1_keyalm = ven1_keyalm;
            this.ven1_keypro = ven1_keypro;
            this.ven1_OcrCode = ven1_OcrCode;
        }
        #endregion
    }
}
