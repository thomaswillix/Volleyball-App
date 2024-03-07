using Proyecto.Controladores;
using Proyecto.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto.Vistas
{
    public partial class FormNuevoUsuario : Form
    {
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }
        private bool validar()
        {
            List<string> errores = new List<string>();

            // Realiza todas las validaciones y recopila los mensajes de error
            if (!Validator.validateTextBox(user) || user.Text.Length < 4)
            {
                errores.Add("El usuario está vacío o no cumple la longitud mínima.");
            }

            if (!Validator.validateTextBox(pass) || pass.Text.Length < 4)
            {
                errores.Add("La contraseña está vacía o no cumple la longitud mínima.");
            }
            // Si hay mensajes de error, imprímelos y devuelve false
            if (errores.Count > 0)
            {
                foreach (var error in errores)
                {
                    Console.WriteLine(error);
                }
                return false;
            }
            // Si no hay errores, devuelve true
            return true;
        }
        private void vaciarCampos()
        {
            user.Text = "";
            pass.Text = "";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aniadirUsu();
                vaciarCampos();
            }
            else
            {
                MessageBox.Show("Revisa los campos, hay algún dato erróneo");
            }
        }
        private void aniadirUsu()
        {
            Usuario u = new Usuario();

            /*if (ControladorUsuariosBin.listaUsuarios.Contains(ControladorUsuariosBin.validaLogin(user.Text, pass.Text)))
            {
                MessageBox.Show("Ese usuario ya existe");
            }
            else
            {
                u.Nombre = user.Text;
                u.Contrasenia = pass.Text;
                ControladorUsuariosBin.listaUsuarios.Add(u);
                ControladorUsuariosBin.cargarUsuariosBin();
                MessageBox.Show("Usuario registrado con éxito.");
            }*/
        }

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
