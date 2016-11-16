using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRATAPV.Utilerias.Negocio
{
    public class clsPermisos
    {
        private String _ppe_keypan;
        private String _ppe_keymod;
        private String _pan_nombre;

        public String ppe_keypan
        {
            get { return _ppe_keypan; }
            set { _ppe_keypan = value; }
        }

        public String ppe_keymod
        {
            get { return _ppe_keymod; }
            set { _ppe_keymod = value; }
        }

        public String pan_nombre
        {
            get { return _pan_nombre; }
            set { _pan_nombre = value; }
        }
    }
}
