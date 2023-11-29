using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Proyecto.Modelo;

namespace Proyecto.Manejadores
{
    public static class ControladorUsuarios
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();

        public static void escribirUsuariosXML()
        {
            try
            {
                using (var writer = new StreamWriter("usuarios.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaUsuarios.GetType());
                    serializer.Serialize(writer, listaUsuarios, namespaces);
                }
            }
            catch (Exception e) {
                
            }
        }

        public static void leerUsuariosXML()
        {
            try
            {
                string xml = File.ReadAllText("usuarios.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaUsuarios.GetType());
                    listaUsuarios = (List<Usuario>) serializer.Deserialize(reader);
                }
            }

            catch (Exception)
            {
                
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

        /*public static void cargarUsuarios()
        {
            Usuario u = new Usuario("Renan", "1234", false, 'H');
            ControladorUsuarios.listaUsuarios.Add(u);
            u = new Usuario("Bruno", "4321", true, 'H');
            ControladorUsuarios.listaUsuarios.Add(u);
            u = new Usuario("Ze", "1111", false, 'H');
            ControladorUsuarios.listaUsuarios.Add(u);
            u = new Usuario("Natalia", "2222", true, 'M');
            ControladorUsuarios.listaUsuarios.Add(u);
            u = new Usuario("Jacqueline", "3333", true, 'M');
            listaUsuarios.Add(u);
        }*/
    }
}
