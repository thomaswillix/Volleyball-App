using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Manejadores;
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
            if (Usuario.u.EsJugador)
            {
                foreach (Jugador j in ControladorJugadoresXML.listaJugadores)
                {
                    if (j.Nombre == Usuario.u.Nombre)
                    {
                        nombre.Text +=": " + j.Nombre;
                        apell.Text +=" " + j.Apellido1;

                    }
                }
            }
            else
            {
                foreach (Entrenador p in ControladorEntrenadoresXML.listaEntrenadores)
                {
                    if (p.Nombre == Usuario.u.Nombre)
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
            textBox1.Hide();
            textBox2.Hide();
            dateTimePicker1.Hide();

        }

        public void vistaEditar()
        {
            nombre.Hide();
            apell.Hide();
            dateBir.Hide();
            textBox1.Show();
            textBox2.Show();
            dateTimePicker1.Show();
        }




        private void btEdit_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
