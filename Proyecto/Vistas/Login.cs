using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto;
using System.IO;
using System.Xml.Serialization;
using Proyecto.Modelo;
using Proyecto.Manejadores;

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

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
        //llamada a método estático del ControladorUsuarios
        private Usuario buscarUsuario(string usuario, string pass)
        {
            return ControladorUsuarios.buscarUsuario(usuario, pass);
        }
        //llamada a método estático del ControladorUsuarios
        private bool validaLogin(ref string usuario, ref string clave)
        {
            return ControladorUsuarios.validaLogin(ref usuario, ref clave);
        }
        
        private void button2_Click(object sender, System.EventArgs e)
        {
            cuadroUsu.Clear();
            cuadroCont.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void IblError_Click(object sender, System.EventArgs e)
        {

        }
        //Acción que se realiza al iniciar la aplicación
        private void Login_Load(object sender, System.EventArgs e)
        {
            //ControladorUsuarios.cargarUsuarios();
            //ControladorUsuarios.escribirUsuariosXML();
            ControladorUsuarios.leerUsuariosXML();
        }
        /* Método en el que se determina la siguiente ventana que se abrirá y
         cuando se cierre se volverá a poner el foco en esta. */
        private void clasePrincipal(string usuario, string contrasena)
        {
            if (validaLogin(ref usuario, ref contrasena) == true)
            {
                cuadroUsu.Clear();
                cuadroCont.Clear();
                Usuario.u = buscarUsuario(usuario, contrasena);
                if (Usuario.u.EsJugador == true)
                {
                    this.Hide();
                    PrincipalJug jug = new PrincipalJug();
                    jug.ShowDialog();
                    jug.Dispose();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    PrincipalEntr entr = new PrincipalEntr();
                    entr.ShowDialog();
                    entr.Dispose();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                intentos++;
                cuadroUsu.Clear();
                cuadroCont.Clear();
                cuadroUsu.Focus();
                if (intentos >= 3)
                {
                    MessageBox.Show("Llevas 3 intentos");
                    intentos = 0;
                    Application.Exit();
                }
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            string usuario = cuadroUsu.Text.ToLower();
            string contrasena = cuadroCont.Text.ToLower();
            clasePrincipal(usuario, contrasena);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void escudo_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
