using Proyecto.Controladores;
using Proyecto.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Proyecto.Vistas
{
    public partial class VistaPerfil : Form
    {
        public VistaPerfil()
        {
            InitializeComponent();
        }

        DateTime fechaActual = new DateTime();
        double edadAnios;

        private void VistaPerfil_Load(object sender, EventArgs e)
        {
            ControladorEntrenadoresXML.cargarEntrenadoresXML();
            ControladorJugadoresXML.cargarJugadoresXML();
            vistaNormal();
            string nom = Usuario.u.Nombre.ToString();
            ImagenDAO imagenDAO = new ImagenDAO();
            Image imagen = Image.FromFile(imagenDAO.obtenerImagen(nom));

            pfp.BackgroundImage = imagen;
        }

        public void rellenarCampos()
        {
            if (Usuario.u.EsJugador)
            {
                foreach (Jugador j in ControladorJugadoresXML.listaJugadores)
                {
                    if (j.Nombre == Usuario.u.Nombre)
                    {
                        nombre.Text += ": " + j.Nombre;
                        apell.Text += " " + j.Apellido1;
                        dateBir.Text += " " + j.FechaNac.Day + "/" + j.FechaNac.Month + "/" + j.FechaNac.Year;
                    }
                }
            }
            else
            {
                foreach (Entrenador p in ControladorEntrenadoresXML.listaEntrenadores)
                {
                    if (p.Nombre == Usuario.u.Nombre || Usuario.u.Nombre == "Ze")
                    {
                        nombre.Text += " " + p.Nombre;
                        apell.Text += " " + p.Apellido1;
                        dateBir.Text += " " + p.FechaNac.Day + "/" + p.FechaNac.Month + "/" + p.FechaNac.Year;
                    }
                }
            }
        }
        public void vistaNormal()
        {
            rellenarCampos();
            btEdit.Show();
            textBox1.Hide();
            textBox2.Hide();
            dateTimePicker1.Hide();
            btCancel.Hide();
            btSave.Hide();

        }

        public void vistaEditar()
        {
            nombre.Text = "Nombre";
            apell.Text = "Apellidos";
            dateBir.Text = "Fecha de Nacimiento";
            textBox1.Show();
            textBox2.Show();
            dateTimePicker1.Show();
            btCancel.Show();
            btSave.Show();
            btEdit.Hide();
        }




        private void btEdit_Click(object sender, EventArgs e)
        {
            vistaEditar();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            vistaNormal();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                actualizarCampos();
                MessageBox.Show("Campos actualizados, ahora su nombre de usuario es " + textBox1.Text);
                vistaNormal();
            }

        }
        private void actualizarCampos()
        {
            if (Usuario.u.EsJugador)
            {
                foreach (Jugador item in ControladorJugadoresXML.listaJugadores)
                {
                    if (item.Nombre == Usuario.u.Nombre)
                    {
                        item.Nombre = textBox1.Text;
                        item.Apellido1 = textBox2.Text;
                        item.FechaNac = dateTimePicker1.Value;
                    }
                    ControladorUsuariosBin.escribirUsuariosBin();
                }
            }
        }
        public void calcularEdad()
        {
            fechaActual = DateTime.Now;
            TimeSpan ts = new TimeSpan(fechaActual.Ticks - dateTimePicker1.Value.Ticks);
            edadAnios = (long)(ts.Days / 365);
        }
        private bool validar()
        {
            calcularEdad();

            List<string> errores = new List<string>();

            // Realiza todas las validaciones y recopila los mensajes de error
            if (!Validator.validateTextBox(textBox1))
            {
                errores.Add("El nombre está vacío.");
            }
            if (!Validator.validateTextBox(textBox2))
            {
                errores.Add("El apellido está vacío.");
            }
            if (edadAnios < 18)
            {
                errores.Add("El jugador no es mayor de edad.");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCambiarFotoPerfil cambiarFoto = new FormCambiarFotoPerfil();
            cambiarFoto.Show();
        }

    }
}
