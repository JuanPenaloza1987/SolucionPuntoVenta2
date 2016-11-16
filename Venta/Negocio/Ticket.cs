using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPuntoVenta.Entidades;
using System.Drawing.Printing;
using System.Drawing;

namespace AppPuntoVenta
{
    public class Ticket
    {
        PrintDocument pdoc = null;
        string _numeroTicket;
        DateTime _fechaVenta;
        string _cajero;
        string _tienda;
        private string _dirección;
        decimal _descuento;
        private List<ArticuloVenta> _articulos;
        private string _cambio;
        private decimal _efectivo;
        private string _iva;

        public string Tienda
        {
            //set the person name
            set { this._tienda = value; }
            //get the person name 
            get { return this._tienda; }
        }

        public string Direccion
        {
            get { return _dirección; }
            set { _dirección = value; }
        }

        public string NumeroTicket
        {
            //set the person name
            set { this._numeroTicket = value; }
            //get the person name 
            get { return this._numeroTicket; }
        }

        public DateTime FechaVenta
        {
            //set the person name
            set { this._fechaVenta = value; }
            //get the person name 
            get { return this._fechaVenta; }
        }

        public string Cajero
        {
            //set the person name
            set { this._cajero = value; }
            //get the person name 
            get { return this._cajero; }
        }

        public decimal Descuento
        {
            //set the person name
            set { this._descuento = value; }
            //get the person name 
            get { return this._descuento; }
        }

        public List<ArticuloVenta> Articulos
        {
            get { return _articulos; }
            set { _articulos = value; }
        }

        public decimal Efectivo
        {
            get { return _efectivo; }
            set { _efectivo = value; }
        }

        public string Cambio
        {
            get { return _cambio; }
            set { _cambio = value; }
        }

        public string IVA
        {
            get { return _iva; }
            set { _iva = value; }
        }



        public Ticket()
        {

        }
        public Ticket(string numeroTicket, DateTime fechaVenta, string cajero, decimal descuento)
        {
            NumeroTicket = numeroTicket;
            FechaVenta = fechaVenta;
        }
        public void print()
        {
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
            pdoc.Print();
        }

        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font fontEmpresa = new Font("Courier New", 12, FontStyle.Bold);
            Font fontCabecera = new Font("Courier New", 8);
            Font fontProductos = new Font("Courier New", 7);

            int cantLineaTotales = 39;
            int cantiLineaCabecera = 40;
            int cantColumnaTotales = 8;

            int startX = 10;
            int startY = 0;
            int Offset = 0;

            graphics.DrawString(CentrarTexto(Tienda, 27), fontEmpresa, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(CentrarTexto(Direccion, cantiLineaCabecera), fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 30;
            graphics.DrawString("Folio:" + NumeroTicket, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 10;
            graphics.DrawString("Fecha:" + this.FechaVenta, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 10;
            graphics.DrawString("Atendió: " + Cajero, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 10;
            string underLine = "------------------------------------------";
            graphics.DrawString(underLine, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            foreach (ArticuloVenta articulo in Articulos)
            {
                Offset = Offset + 10;
                graphics.DrawString(RegistarElementoTicket(articulo.Cantidad.ToString(), articulo.NombreArticulo, "",AlinearTexto(articulo.Monto.ToString("0.00"), true, 11)), fontProductos, new SolidBrush(Color.Black), startX, startY + Offset);
            }

            Offset = Offset + 20;
            string subtotal =  AlinearTexto(("Subtotal = " + AlinearTexto((Articulos.Sum(a=> a.Monto) - decimal.Parse(IVA)).ToString("0.00"), true, cantColumnaTotales)), true, cantLineaTotales);
            graphics.DrawString(subtotal, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 10;
            string iva = AlinearTexto("IVA = " + AlinearTexto(IVA,true, cantColumnaTotales), true, cantLineaTotales);
            graphics.DrawString(iva, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 10;
            string descuento = AlinearTexto("Descuento = " + AlinearTexto(Descuento.ToString("0.00"), true, cantColumnaTotales), true, cantLineaTotales);
            graphics.DrawString(descuento, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 10;

            string montoTotal = AlinearTexto((Articulos.Sum(a => a.Monto) - Descuento).ToString("0.00"), true, cantColumnaTotales);
            string total = AlinearTexto("Total = " + montoTotal, true, cantLineaTotales);
            graphics.DrawString(total, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            string totalLetra = CentrarTexto(string.Format("({0})", Enletras(montoTotal)), cantiLineaCabecera);
            graphics.DrawString(totalLetra, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 30;
            string pagos = "Efectivo: " + Efectivo.ToString("0.00") + "   Cambio: " + Cambio.ToString();
            graphics.DrawString(pagos, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 10;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 10;
            graphics.DrawString(CentrarTexto("GRACIAS POR SU COMPRA", cantiLineaCabecera), fontCabecera, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 10;

        }

        static string RegistarElementoTicket(string piezas, string producto, string PUnit, string importe)
        {
            StringBuilder texto = new StringBuilder();
            bool excede = false;
            int maxPiezas = 3, maxProducto = 26, maxPUnit = 0, maxImporte = 11;
            string piezasE = "", productoE = "", punitE = "", importeE = "";
            piezas = piezas.PadRight(maxPiezas);
            producto = producto.PadRight(maxProducto);
            PUnit = PUnit.PadRight(maxPUnit);
            importe = importe.PadRight(maxImporte);
            if (piezas.Length > maxPiezas)
            {
                int l = piezas.Length - maxPiezas;
                int cortar = l > maxPiezas ? maxPUnit : l;
                piezasE = piezas.Substring(piezas.Length - cortar);
                piezasE = piezasE.PadLeft(maxPiezas);
                piezas = piezas.Substring(0, maxPiezas);
                excede = true;
            }
            if (producto.Length > maxProducto)
            {
                int l = producto.Length - maxProducto;
                int cortar = l > maxProducto ? (maxProducto - 2) : l;
                productoE = producto.Substring(producto.Length - cortar);
                productoE = l > maxProducto ? (".." + productoE) : productoE.PadLeft(maxProducto);
                producto = producto.Substring(0, maxProducto);
                excede = true;
            }
            if (PUnit.Length > maxPUnit)
            {
                int l = PUnit.Length - maxPUnit;
                int cortar = l > maxPUnit ? maxPUnit : l;
                punitE = PUnit.Substring(PUnit.Length - cortar);
                punitE = punitE.PadLeft(maxPUnit);
                PUnit = PUnit.Substring(0, maxPUnit);
                excede = true;
            }
            if (importe.Length > maxImporte)
            {
                int l = importe.Length - maxImporte;
                int cortar = l > maxImporte ? maxImporte : l;
                importeE = importe.Substring(importe.Length - cortar);
                importeE = importeE.PadLeft(maxImporte);
                importe = importe.Substring(0, maxImporte);
                excede = true;
            }

            texto.AppendFormat("{0," + maxPiezas + "}  {1," + maxProducto + "}  {2," + maxPUnit + "} {3," + maxImporte + "}", piezas, producto, PUnit, importe);
            if (excede)
            {
                texto.AppendFormat("{0," + maxPiezas + "}  {1," + maxProducto + "}  {2," + maxPUnit + "} {3," + maxImporte + "}", piezasE, productoE, punitE, importeE);
            }
            return texto.ToString();
        }

        public static string CentrarTexto(string textoACentrar, int ancho)
        {
            StringBuilder textoCentrado = new StringBuilder();
            bool excede;
            string textoCortado = "";
            do
            {
                excede = textoACentrar.Length > ancho ? true : false;
                if (excede)
                {
                    textoCortado = textoACentrar.Substring(0, ancho);
                    textoACentrar = textoACentrar.Substring(ancho - 1);
                    textoCentrado.Append(textoCortado + Environment.NewLine);
                }
                else
                {
                    int leftPadding = (ancho - textoACentrar.Length) / 2;
                    int rightPadding = ancho - textoACentrar.Length - leftPadding;

                    textoCentrado.Append
                        (
                        new string(' ', leftPadding) +
                        textoACentrar +
                        new string(' ', rightPadding) +
                        Environment.NewLine
                        );
                }
            } while (excede);
            return textoCentrado.ToString();
        }

        public static string AlinearTexto(string textoAAlinear, bool aLaDerecha, int ancho)
        {
            StringBuilder textoAlineado = new StringBuilder();
            bool excede;
            string textoCortado = "";
            do
            {
                excede = textoAAlinear.Length > ancho ? true : false;
                if (excede)
                {
                    textoCortado = textoAAlinear.Substring(0, ancho);
                    textoAAlinear = textoAAlinear.Substring(ancho - 1);
                    textoAlineado.Append(textoCortado + Environment.NewLine);
                }
                else
                {
                    if (aLaDerecha)
                    {
                        textoAlineado.Append(textoAAlinear.PadLeft(ancho));
                    }
                    else
                    {
                        textoAlineado.Append(textoAAlinear.PadRight(ancho));
                    }
                }
            } while (excede);
            return textoAlineado.ToString();
        }

        public static string Enletras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }
            res = toText(Convert.ToDouble(entero)) + " PESOS" + dec;
            return res;
        }

        private static string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;
        }


    }

}
