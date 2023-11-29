using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importamos estas dependencias
using System.Xml.Serialization;
using System.IO;

namespace Practica1.manejadores
{
    //Importante que los métodos de las clases controladoras y las clases sean public y static
    public static class ControladorUsuariosXML
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
                if ((usuario == listaUsuarios[i].User.ToLower())
                    && (clave == listaUsuarios[i].Pass))
                {
                    return true;
                }
                else if ((usuario != listaUsuarios[i].User.ToLower())
                    || (clave != listaUsuarios[i].Pass.ToLower()))
                {
                    continue;
                }
            }
            MessageBox.Show("Usuario o contraseña incorrectos");
            return false;
        }

        public static  Usuario buscarUsuario(string usuario, string pass)
        {
            Usuario u = new Usuario();
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuario == listaUsuarios[i].User.ToLower())
                {
                    u = listaUsuarios[i];
                    MessageBox.Show("El usuario " + usuario + " se ha encontrado");
                    if (pass == listaUsuarios[i].Pass)
                    {
                        MessageBox.Show("La contraseña " + pass + " es correcta");
                        return u;
                    }
                    MessageBox.Show("La contraseña " + pass + " no es correcta");
                }
            }
            MessageBox.Show("El usuario " + usuario + " no se ha encontrado");
            return u;
        }
        public static void cargarUsuarios()
        {
            Usuario u = new Usuario("root", "1234");
            listaUsuarios.Add(u);
            u = new Usuario("jorge", "4321");
            listaUsuarios.Add(u);
            u = new Usuario("jaime", "4444");
            listaUsuarios.Add(u);
            u = new Usuario("jose", "1111");
            listaUsuarios.Add(u);
            u = new Usuario("javier", "2222");
            listaUsuarios.Add(u);
        }
    }
}
