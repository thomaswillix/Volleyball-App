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
using Proyecto.Vistas;
using Proyecto.Controladores;

namespace Proyecto
{
    public partial class FormLogin : Form
    {
        private int intentos = 0;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

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
            ControladorUsuariosBin.crearUsuarios();
            ControladorUsuariosBin.escribirUsuariosBin();
            ControladorUsuariosBin.cargarUsuariosBin();
        }
        /* Método en el que se determina la siguiente ventana que se abrirá y
         cuando se cierre se volverá a poner el foco en esta. */
        private void clasePrincipal(string usuario, string contrasena)
        {
            if (ControladorUsuariosBin.validaLogin(ref usuario, ref contrasena) == true)
            {
                cuadroUsu.Clear();
                cuadroCont.Clear();
                Usuario.u = ControladorUsuariosBin.buscarUsuario(usuario, contrasena);
                if (Usuario.u.EsJugador == true)
                {
                    this.Hide();
                    VistaPrincipalJug jug = new VistaPrincipalJug();
                    jug.ShowDialog();
                    jug.Dispose();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    VistaPrincipalEntr entr = new VistaPrincipalEntr();
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

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNuevoUsuario registro = new FormNuevoUsuario();
            registro.ShowDialog();
        }
    }
}
