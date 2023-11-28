using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Practica1.manejadores
{
    public static class ControladorEmpleadosJSON
    {

        public static List<Empleado> listaEmpleados = new List<Empleado>();

        public static void leerEmpleados()
        {
            try
            {
                if (File.Exists("empleados.Json"))
                {
                    string jsonString = File.ReadAllText("empleados.Json");
                    listaEmpleados = JsonSerializer.Deserialize<List<Empleado>>(jsonString);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void escribirEmpleados()
        {
            try
            {
                if (File.Exists("empleados.Json"))
                {
                    string jsonString = JsonSerializer.Serialize(listaEmpleados);
                    File.WriteAllText("empleados.Json", jsonString);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
