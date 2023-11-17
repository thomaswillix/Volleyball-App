using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1;
using System.IO;
using System.Xml.Serialization;
using Proyecto.Modelo;

namespace Proyecto
{
    
        public partial class Login : Form
        {
            private string[,] matrizUsuarios = new string[6, 2];
            private int intentos = 0;

            private void escribirUsuariosXML()
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
            catch (Exception e) { }
        }


            public Login()
            {
                InitializeComponent();
            }

            private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
            {

            }

            public static List<Usuario> listaUsuarios = new List<Usuario>();

            private void cargarUsuarios()
            {

            listaUsuarios.Add(new Usuario("renan", "1234"));
            listaUsuarios.Add(new Usuario("bruno", "4321"));
            listaUsuarios.Add(new Usuario("giovane", "4444"));
            listaUsuarios.Add(new Usuario("ze", "1111"));
            listaUsuarios.Add(new Usuario("natalia", "2222"));
            listaUsuarios.Add(new Usuario("jacqueline", "3333"));

            /*
            //Seleccion masculina
            matrizUsuarios[0, 0] = "renan";
                matrizUsuarios[1, 0] = "bruno";
                matrizUsuarios[2, 0] = "giovane";

                //Seleccion femenina
                matrizUsuarios[3, 0] = "ze";
                matrizUsuarios[4, 0] = "natalia";
                matrizUsuarios[5, 0] = "jacqueline";

                //Contraseñas
                matrizUsuarios[0, 1] = "1234";
                matrizUsuarios[1, 1] = "4321";
                matrizUsuarios[2, 1] = "4444";
                matrizUsuarios[3, 1] = "1111";
                matrizUsuarios[4, 1] = "2222";
                matrizUsuarios[5, 1] = "3333";

            */
            }
            private void button1_Click(object sender, System.EventArgs e)
            {

        }

        bool validaLogin(ref string usuario, ref string clave)
            {
                for (int i = 0; i <= matrizUsuarios.GetUpperBound(0); i++)
                // el método GetUpperBound devuelve la última posición 
                // ocupada de una dimensión, en este caso quiero la primera, 
                // es decir la 0 y devolverá 5
                {
                    if (matrizUsuarios[i, 0] == usuario.ToLower())
                    {
                        if (matrizUsuarios[i, 1] == clave)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                            return false;
                        }
                    }
                }
                return false;

            }
            private void button2_Click(object sender, System.EventArgs e)
            {
                MessageBox.Show("Has pulsado Cancelar");
            }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {

            }

            private void IblError_Click(object sender, System.EventArgs e)
            {

            }

            private void Login_Load(object sender, System.EventArgs e)
            {
                cargarUsuarios();
                escribirUsuariosXML();
            }

        private void accept_Click(object sender, EventArgs e)
        {/*
            MessageBox.Show("Has pulsado Aceptar");
            string usuario = cuadroUsu.Text.ToLower();
            string contrasena = cuadroCont.Text.ToLower();
            if (validaLogin(ref usuario, ref contrasena) == true)
            {
                cuadroUsu.Clear();
                cuadroCont.Clear();
                foreach (var item in contrasena)
                {
                    
                }
                else
                {
                    PrincipalJug jug = new PrincipalJug();
                    jug.Show();
                }
                this.Close();
            }*/
        }
    }
}
