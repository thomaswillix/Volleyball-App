using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Practica1.manejadores
{
    public static class ControladorUsuariosJSON
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();

        public static void leerUsuarios()
        {
            try
            {
                if (File.Exists("usuarios.Json"))
                {
                    string jsonString = File.ReadAllText("usuarios.Json");
                    listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonString);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void escribirUsuarios()
        {
            try
            {
                if (File.Exists("usuarios.Json"))
                {
                    string jsonString = JsonSerializer.Serialize(listaUsuarios);
                    File.WriteAllText("usuarios.Json", jsonString);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
