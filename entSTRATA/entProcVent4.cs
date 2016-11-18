using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
    public class entProcVent4
    {
        #region propieties
        public int ven4_keyven { get; set; }
        public string ven4_metodopago { get; set; }
        public int ven4_metododet { get; set; }
        public string ven4_metodoref { get; set; }
        public decimal ven4_importe { get; set; }
        public DateTime ven4_fecreg { get; set; }
        public string ven4_formapago { get; set; }
        public int ven4_terminal { get; set; }
        public string ven4_cuenta { get; set; }
        public int ven4_keyven4 { get; set; }
        public bool ven4_enviadobita { get; set; }
        public bool ven4_enviado { get; set; }
        public string ven4_msjError { get; set; }
        public int ven4_numpago { get; set; }
        public bool ven4_cancelado { get; set; }
        public int ven4_keyven8 { get; set; }
        #endregion

        #region methods
        public entProcVent4()
        { }
        public entProcVent4(int ven4_keyven, string ven4_metodopago, int ven4_metododet, string ven4_metodoref, decimal ven4_importe, DateTime ven4_fecreg, string ven4_formapago,
            int ven4_terminal, string ven4_cuenta, int ven4_keyven4, bool ven4_enviadobita, bool ven4_enviado, string ven4_msjError, int ven4_numpago,
            bool ven4_cancelado, int ven4_keyven8)
        {
            this.ven4_keyven = ven4_keyven;
            this.ven4_metodopago = ven4_metodopago;
            this.ven4_metododet = ven4_metododet;
            this.ven4_metodoref = ven4_metodoref;
            this.ven4_importe = ven4_importe;
            this.ven4_fecreg = ven4_fecreg;
            this.ven4_formapago = ven4_formapago;
            this.ven4_terminal = ven4_terminal;
            this.ven4_cuenta = ven4_cuenta;
            this.ven4_keyven4 = ven4_keyven4;
            this.ven4_enviadobita = false;
            this.ven4_enviado = false;
            this.ven4_msjError = ven4_msjError;
            this.ven4_numpago = 1;
            this.ven4_cancelado = false;
            this.ven4_keyven8 = 1;
        }
        #endregion
    }
}
