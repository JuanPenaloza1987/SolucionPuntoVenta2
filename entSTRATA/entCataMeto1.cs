using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
   public class entCataMeto1
    {
        #region propieties
        public string met1_keymet { get; set; }
        public int met1_identi { get; set; }
        public string met1_descripc { get; set; }
        public DateTime met1_fecalt { get; set; }
        public DateTime met1_fecmod { get; set; }
        public string met1_usrmod { get; set; }
        public bool met1_activo { get; set; }

        #endregion

        #region methods
        public entCataMeto1()
        { }
        public entCataMeto1
        (string met1_keymet, string met1_descripc, int met1_identi, DateTime met1_fecalt, DateTime met1_fecmod, string met1_usrmod, bool met1_activo
        )
        {
            this.met1_keymet = met1_keymet;
            this.met1_identi = met1_identi;
            this.met1_descripc = met1_descripc;
            this.met1_fecalt = met1_fecalt;
            this.met1_fecmod = met1_fecmod;
            this.met1_usrmod = met1_usrmod;
            this.met1_activo = met1_activo;

        }
        #endregion
    }
}
