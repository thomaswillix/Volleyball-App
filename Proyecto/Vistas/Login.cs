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
            private int intentos = 0;

            public Login()
            {
                InitializeComponent();
            }

            private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
            {

            }

            public static List<Usuario> listaUsuarios = new List<Usuario>();
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

            private void cargarUsuarios()
            {
                listaUsuarios.Add(new Usuario("renan", "1234", false));
                listaUsuarios.Add(new Usuario("bruno", "4321", true));
                listaUsuarios.Add(new Usuario("giovane", "4444", true));
                listaUsuarios.Add(new Usuario("ze", "1111", false));
                listaUsuarios.Add(new Usuario("natalia", "2222", true));
                listaUsuarios.Add(new Usuario("jacqueline", "3333", true));
            }

            private void button1_Click(object sender, System.EventArgs e)
            {

            }

            bool validaLogin(ref string usuario, ref string clave)
            {
            foreach (Usuario u in listaUsuarios)
            {
                if((usuario == u.Nombre.ToLower()) &&(clave == u.Contrasenia.ToLower()))
                {
                    return true;
                }
                else if((usuario != u.Nombre.ToLower()) || (clave != u.Contrasenia.ToLower()))
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    return false;
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
        {
            MessageBox.Show("Has pulsado Aceptar");
            string usuario = cuadroUsu.Text.ToLower();
            string contrasena = cuadroCont.Text.ToLower();
            if (validaLogin(ref usuario, ref contrasena) == true)
            {
                cuadroUsu.Clear();
                cuadroCont.Clear();
                foreach (Usuario u in listaUsuarios)
                {
                    if (u.EsJugador == false)
                    {
                        PrincipalEntr entr = new PrincipalEntr();
                        entr.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        PrincipalJug jug =  new PrincipalJug();
                        jug.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
