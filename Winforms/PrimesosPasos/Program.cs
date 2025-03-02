using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesosPasos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new Form1());//LE PASA UNA INSTANCIA de un objeto llamado FORM1
            // x eso cuando ejecuta, vemos el Form1

            // Application.Run(new FrmVentana2());

            //Application.Run(new ControlesVarios_OperadorTernario());
            Application.Run(new ControlesVarios_OperadorTernario());
        }
    }
}
