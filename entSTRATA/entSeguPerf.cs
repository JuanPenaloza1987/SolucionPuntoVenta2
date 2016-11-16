using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
    public class entSeguPerf
    {
        #region propieties
        public string per_keyperf { get; set; }
        public string per_nombre { get; set; }
        public bool per_activo { get; set; }
        public DateTime per_fecalt { get; set; }
        public DateTime per_fecmod { get; set; }
        public string per_usumod { get; set; }
        #endregion

        #region methods
        public entSeguPerf()
        { }
        public entSeguPerf
        (string per_keyperf, string per_nombre, bool per_activo, DateTime per_fecalt, DateTime per_fecmod, string per_usumod
        )
        {
            this.per_keyperf = per_keyperf;
            this.per_nombre = per_nombre;
            this.per_activo = per_activo;
            this.per_fecalt = per_fecalt;
            this.per_fecmod = per_fecmod;
            this.per_usumod = per_usumod;
        }
        #endregion
    }
}
