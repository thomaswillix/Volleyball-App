using Proyecto.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto.Controladores
{
    public static class ControladorUsuariosBin
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();

        public static void cargarUsuariosBin()
        {
            try
            {
                Stream OpenFileStream = File.OpenRead("usuarios.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                listaUsuarios = (List<Usuario>)deserializer.Deserialize(OpenFileStream);
                OpenFileStream.Close();
            }
            catch (Exception)
            {
            }
        }

        public static bool escribirUsuariosBin()
        {
            try
            {
                Stream SaveFileStream = File.Create("usuarios.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, listaUsuarios);
                SaveFileStream.Close();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool validaLogin(ref string usuario, ref string clave)
        {
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if ((usuario == listaUsuarios[i].Nombre.ToLower())
                    && (clave == listaUsuarios[i].Contrasenia))
                {
                    return true;
                }
                else if ((usuario != listaUsuarios[i].Nombre.ToLower())
                    || (clave != listaUsuarios[i].Contrasenia))
                {
                    continue;
                }
            }
            return false;
        }

        public static Usuario buscarUsuario(string usuario, string pass)
        {
            Usuario u = new Usuario();
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuario == listaUsuarios[i].Nombre.ToLower())
                {
                    u = listaUsuarios[i];
                    if (pass == listaUsuarios[i].Contrasenia)
                    {
                        return u;
                    }
                }
            }
            return u;
        }

        public static void crearUsuarios()
        {
            Usuario u = new Usuario("Renan", "1234", false, 'H');
            listaUsuarios.Add(u);
            u = new Usuario("Bruno", "4321", true, 'H');
            listaUsuarios.Add(u);
            u = new Usuario("Ze", "1111", false, 'H');
            listaUsuarios.Add(u);
            u = new Usuario("Natalia", "2222", true, 'M');
            listaUsuarios.Add(u);
            u = new Usuario("Jacqueline", "3333", true, 'M');
            listaUsuarios.Add(u);
        }
    }
}
