
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace AppPuntoVenta
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //MessageBox.Show(string.Join(" ", args)); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        
        }
    }
}
