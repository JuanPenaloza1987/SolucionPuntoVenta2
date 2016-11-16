using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
    public class entUsuaPerf
    {
        #region propieties
        public string upe_keyusu { get; set; }
        public string upe_keyperf { get; set; }
        #endregion

        #region methods
        public entUsuaPerf()
        { }
        public entUsuaPerf
        (string upe_keyusu, string upe_keyperf
        )
        {
            this.upe_keyusu = upe_keyusu;
            this.upe_keyperf = upe_keyperf;
        }
        #endregion
    }
}
