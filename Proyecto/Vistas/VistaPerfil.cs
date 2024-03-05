using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Controladores;
using Proyecto.Modelo;

namespace Proyecto.Vistas
{
    public partial class VistaPerfil : Form
    {
        public VistaPerfil()
        {
            InitializeComponent();
        }

        private void VistaPerfil_Load(object sender, EventArgs e)
        {
            ControladorEntrenadoresXML.cargarEntrenadoresXML();
            ControladorJugadoresXML.cargarJugadoresXML();
            vistaNormal();
            string nom = Usuario.u.Nombre.ToString();
            switch (nom)
            {
                case "Bruno":
                    pfp.BackgroundImage = Image.FromFile("../Pics/Bruno.jpeg");
                    break;
                case "Natalia":
                    pfp.BackgroundImage = Image.FromFile("../Pics/Natalia.jpg");
                    break;
                case "Ze":
                    pfp.BackgroundImage = Image.FromFile("../Pics/Ze.jpeg");
                    break;
                case "Renan":
                    pfp.BackgroundImage = Image.FromFile("../Pics/Renan.jpeg");
                    break;
            }
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
            if (Usuario.u.EsJugador) 
            {
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCambiarFotoPerfil cambiarFoto = new FormCambiarFotoPerfil();
            cambiarFoto.Show();
        }
    }
}
