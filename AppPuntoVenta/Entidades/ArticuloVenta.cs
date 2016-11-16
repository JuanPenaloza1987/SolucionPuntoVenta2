using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPuntoVenta
{
    public class ArticuloVenta
    {

        private string _claveArticulo;

        public string ClaveArticulo
        {
            get { return _claveArticulo; }
            set { _claveArticulo = value; }
        }


        private string _codigoArticulo;

        public string CodigoArticulo
        {
            get { return _codigoArticulo; }
            set { _codigoArticulo = value; }
        }

        private string _nombreArticulo;

        public string NombreArticulo
        {
            get { return _nombreArticulo; }
            set { _nombreArticulo = value; }
        }

        private decimal _cantidad;

        public decimal Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private decimal _monto;

        public decimal Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        private decimal _precio;

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private bool _esPaquete;

        public bool EsPaquete
        {
            get { return _esPaquete; }
            set { _esPaquete = value; }
        }
        

        private bool _hayPromocion;

        public bool HayPromocion
        {
            get { return _hayPromocion; }
            set { _hayPromocion = value; }
        }

    }
}
