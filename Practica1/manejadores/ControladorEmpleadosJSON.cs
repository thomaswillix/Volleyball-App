using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dependencias
using System.Text.Json;
using System.IO;

namespace Practica1.manejadores
{
    //Para este controlador tendremos que crear antes el documento .Json en la ruta Proyecto/bin/Debug/
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
        public static void cargarEmpleados()
        {
            DateTime d = new DateTime(2002, 2, 3, 13, 0, 0);
            Empleado e = new Empleado(1, "Juan", "Rodriguez", "Perez", "programador", d);
            listaEmpleados.Add(e);
            d = new DateTime(2000, 9, 4, 22, 0, 0);
            e = new Empleado(1, "Pablo", "Hernandez", "Ortiz", "becario", d);
            listaEmpleados.Add(e);
            d = new DateTime(2005, 6, 2, 7, 0, 0);
            e = new Empleado(1, "Juana", "Martin", "Soler", "programador", d);
            listaEmpleados.Add(e);
            d = new DateTime(1997, 8, 2, 12, 0, 0);
            e = new Empleado(1, "Maria", "Pinar", "Dueñas", "jefe", d);
            listaEmpleados.Add(e);
        }
    }
}
