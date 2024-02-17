using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecto.Manejadores
{

    public static class ControladorPartidosJSON
    {
        public static List<Partido> listaPartidos = new List<Partido>();

        public static void cargarPartidos()
        {
            try
            {
                if (File.Exists("partidos.Json"))
                {
                    string jsonString = File.ReadAllText("partidos.Json");
                    listaPartidos = JsonSerializer.Deserialize<List<Partido>>(jsonString);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void escribirPartidos()
        {
            try
            {
                if (File.Exists("partidos.Json"))
                {
                    string jsonString = JsonSerializer.Serialize(listaPartidos);
                    File.WriteAllText("partidos.Json", jsonString);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
