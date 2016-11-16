using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPuntoVenta.Entidades
{
    class ConfMetodo
    {
        public string ClaveMetodo { get; set; }
        public string Prefijo { get { return "Ctrl + "; }}
        public string Letra { get; set; }
    }
}
