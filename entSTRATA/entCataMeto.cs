using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
    public class entCataMeto
    {
        #region propieties
        public string met_keymet { get; set; }
        public string met_descripc { get; set; }
        public DateTime met_fecalt { get; set; }
        public DateTime met_fecmod { get; set; }
        public string met_usrmod { get; set; }
        public bool met_activo { get; set; }
        public string met_codigo { get; set; }
        #endregion

        #region methods
        public entCataMeto()
        { }
        public entCataMeto
        (string met_keymet, string met_descripc, DateTime met_fecalt, DateTime met_fecmod, string met_usrmod, bool met_activo, string met_codigo
        )
        {
            this.met_keymet = met_keymet;
            this.met_descripc = met_descripc;
            this.met_fecalt = met_fecalt;
            this.met_fecmod = met_fecmod;
            this.met_usrmod = met_usrmod;
            this.met_activo = met_activo;
            this.met_codigo = met_codigo;
        }
        #endregion
    }
}
