using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Proyecto.Controladores
{
    public class ConnectionDB
    {

        public static string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            // A diferencia de la anterior versión, forzamos a que coja la ruta relativa con el
            // Path.GetFullPath
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Database.mdf"));
            //string databaseFileName = "Database.mdf";
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;
        }

    }
}