using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPuntoVenta
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string NombreArticulo { get; set; }
        public decimal Precio { get; set; }

        public static List<Producto> ConvertirDataSetProducto(DataSet datos)
        {
            List<Producto> listaProducto = new List<Producto>();
            foreach (DataRow r in datos.Tables[0].Rows)
            {
                listaProducto.Add(new Producto() { Codigo = r.ItemArray[0].ToString(), NombreArticulo = r.ItemArray[1].ToString() });
            }
            return listaProducto;
        }
    }

    public class ArticuloPaquete : Producto
    {
        public int Cantidad { get; set; }

        public new static List<ArticuloPaquete> ConvertirDataSetProducto(DataSet datos)
        {
            List<ArticuloPaquete> listaProducto = new List<ArticuloPaquete>();
            foreach (DataRow r in datos.Tables[0].Rows)
            {
                listaProducto.Add(new ArticuloPaquete() { Codigo = r.ItemArray[0].ToString(), NombreArticulo = r.ItemArray[1].ToString(), Cantidad = int.Parse(r.ItemArray[3].ToString()) });
            }
            return listaProducto;
        }
    }

}
