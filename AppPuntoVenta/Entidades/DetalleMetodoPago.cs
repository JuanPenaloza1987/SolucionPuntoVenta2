using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPuntoVenta.Entidades
{
    public class DetalleMetodoPago
    {
        public string ClaveMetodoPago { get; set; }
        public string IdDetalle { get; set; }
        public string Referencia { get; set; }
        public decimal Monto { get; set; }
        public string NombreDetalle { get; set; }
    }
}
