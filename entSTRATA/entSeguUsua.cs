using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
    public class entSeguUsua
    {
        #region propieties
        public string usu_keyusu { get; set; }
        public string usu_passwo { get; set; }
        public string usu_nombre { get; set; }
        public string usu_correo { get; set; }
        public bool usu_activo { get; set; }
        public DateTime usu_fecalt { get; set; }
        public DateTime usu_fecmod { get; set; }
        public string usu_usumod { get; set; }
        #endregion

        #region methods
        public entSeguUsua()
        { }
        public entSeguUsua
        (string usu_keyusu, string usu_passwo, string usu_nombre, string usu_correo, bool usu_activo, DateTime usu_fecalt, DateTime usu_fecmod, string usu_usumod
        )
        {
            this.usu_keyusu = usu_keyusu;
            this.usu_passwo = usu_passwo;
            this.usu_nombre = usu_nombre;
            this.usu_correo = usu_correo;
            this.usu_activo = usu_activo;
            this.usu_fecalt = usu_fecalt;
            this.usu_fecmod = usu_fecmod;
            this.usu_usumod = usu_usumod;
        }
        #endregion
    }
}
