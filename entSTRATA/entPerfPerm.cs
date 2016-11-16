using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
    public class entPerfPerm
    {
        #region propieties
        public string ppe_keyperf { get; set; }
        public string ppe_keymod { get; set; }
        public string ppe_keypan { get; set; }
        #endregion

        #region methods
        public entPerfPerm()
        { }
        public entPerfPerm
        (string ppe_keyperf, string ppe_keymod, string ppe_keypan
        )
        {
            this.ppe_keyperf = ppe_keyperf;
            this.ppe_keymod = ppe_keymod;
            this.ppe_keypan = ppe_keypan;
        }
        #endregion
    }
}
