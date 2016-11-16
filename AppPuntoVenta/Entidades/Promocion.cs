using System;
using System.Collections.Generic;
using System.Data;

namespace AppPuntoVenta.Entidades
{
    public class Promocion
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string TipoPromocion { get; set; }
        public float CantidadRequerida { get; set; }
        public float CantidadARegalar { get; set; }
        public List<DetallePromocion> Detalles { get; set; }

        public static List<Promocion> ConvertirDataSetPromocion(DataSet datos)
        {
            List<Promocion> listaPromocion = new List<Promocion>();
            foreach (DataRow r in datos.Tables[0].Rows)
            {
                listaPromocion.Add(new Promocion() { Codigo = r.ItemArray[0].ToString(), Descripcion = r.ItemArray[1].ToString(), TipoPromocion = r.ItemArray[2].ToString() , CantidadRequerida = float.Parse(r.ItemArray[3].ToString()), CantidadARegalar = float.Parse(r.ItemArray[4].ToString()) });
            }
            return listaPromocion;
        }
    }

    public class DetallePromocion
    {
        public string CodigoArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public decimal Precio { get; set; }
        public int PorcentajeDescuento { get; set; }
        public decimal ImporteDescuento { get; set; }
        public bool EsNecesario { get; set; }
        public bool EsRegalo { get; set; }

        public static List<DetallePromocion> ConvertirDataSetDetallePromocion(DataSet datos)
        {
            List<DetallePromocion> listaDetallePromocion = new List<DetallePromocion>();
            foreach (DataRow r in datos.Tables[0].Rows)
            {
                listaDetallePromocion.Add(new DetallePromocion() { CodigoArticulo = r.ItemArray[0].ToString(), NombreArticulo = r.ItemArray[1].ToString(), Precio = decimal.Parse(r.ItemArray[2].ToString()), PorcentajeDescuento = int.Parse(r.ItemArray[3].ToString()), ImporteDescuento = decimal.Parse(r.ItemArray[4].ToString()), EsNecesario = Boolean.Parse(r.ItemArray[5].ToString()), EsRegalo = Boolean.Parse(r.ItemArray[5].ToString()) });
            }
            return listaDetallePromocion;
        }
    }

    public class PromocionAplicada
    {
        public Promocion promocion { get; set; }
        public List<ComplementoPromocion> articulos { get; set; }
        public bool cumplida { get; set; }
        public decimal descuento { get; set; }
    }

    public class ComplementoPromocion
    {
        public Producto Articulo { get; set; }
        public decimal PrecioPorArticulo { get; set; }
        public bool EsRegalo { get; set; }
    }

}
