using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
   public  class entCataAlma
    {
        #region propieties
        public string alm_keyalm { get; set; }
        public string alm_nombre { get; set; }
        public bool alm_activo { get; set; }
        public string alm_estado { get; set; }
        public string alm_PrcCode { get; set; }
        #endregion

        #region methods
        public entCataAlma()
        { }
        public entCataAlma
        (string alm_keyalm, string alm_nombre, bool alm_activo, string alm_estado, string upe_keyperf
        )
        {
            this.alm_keyalm = alm_keyalm;
            this.alm_nombre = alm_nombre;
            this.alm_activo = alm_activo;
            this.alm_estado = alm_estado;
            this.alm_PrcCode = alm_PrcCode;
        }
        #endregion
    }
}
