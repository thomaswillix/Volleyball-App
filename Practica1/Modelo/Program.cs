using System;
using System.Windows.Forms;

namespace Practica1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Importante que la config sea esta para poder configurar que no se
            cierre la app si se cierra el primer form.*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            login.Show();
            Application.Run();
        }
    }
}
