using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
    public class entProcVentP
    {
        #region propieties
        public int venp_keyven { get; set; }
        public int venp_NumLin { get; set; }
        public string venp_articulo { get; set; }
        public string venp_artdes { get; set; }
        public decimal venp_cantidad { get; set; }
        public decimal venp_precio { get; set; }
        public decimal venp_iva { get; set; }
        public decimal venp_ieps { get; set; }
        public decimal venp_totallinea { get; set; }
        public string venp_moneda { get; set; }
        public decimal venp_tipocambio { get; set; }
        public bool venp_escompues { get; set; }
        public string venp_idpaquete { get; set; }
        public decimal venp_porcdesc { get; set; }
        public decimal venp_descuento { get; set; }
        public string venp_keyalm { get; set; }
        public string venp_keypro { get; set; }
        public string venp_OcrCode { get; set; }
        #endregion

        #region methods
        public entProcVentP()
        { }
        public entProcVentP(int venp_keyven, int venp_NumLin, string venp_articulo, string venp_artdes, decimal venp_cantidad, decimal venp_precio, decimal venp_iva,
            decimal venp_ieps, decimal venp_totallinea, string venp_moneda, decimal venp_tipocambio, bool venp_escompues, string venp_idpaquete, decimal venp_porcdesc,
            decimal venp_descuento, string venp_keyalm, string venp_keypro, string venp_OcrCode)
        {
            this.venp_keyven = venp_keyven;
            this.venp_NumLin = venp_NumLin;
            this.venp_articulo = venp_articulo;
            this.venp_artdes = venp_artdes;
            this.venp_cantidad = venp_cantidad;
            this.venp_precio = venp_precio;
            this.venp_iva = venp_iva;
            this.venp_ieps = venp_ieps;
            this.venp_totallinea = venp_totallinea;
            this.venp_moneda = venp_moneda;
            this.venp_tipocambio = venp_tipocambio;
            this.venp_escompues = venp_escompues;
            this.venp_idpaquete = venp_idpaquete;
            this.venp_porcdesc = venp_porcdesc;
            this.venp_descuento = venp_descuento;
            this.venp_keyalm = venp_keyalm;
            this.venp_keypro = venp_keypro;
            this.venp_OcrCode = venp_OcrCode;
        }
        #endregion
    }
}
