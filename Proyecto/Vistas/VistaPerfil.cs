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

            textBox1.Hide();
            textBox2.Hide();
            dateTimePicker1.Hide();
            if (Usuario.u.EsJugador)
            {
                foreach (Jugador j in ControladorJugadoresXML.listaJugadores)
                {
                    if (j.Nombre == Usuario.u.Nombre)
                    {
                        nom = j.Nombre;
                        apes.Text = j.Apellido1;

                    }
                }
            }
            else
            {
                foreach (Entrenador e in ControladorEntrenadoresXML.listaEntrenadores)
                {
                    if (e.Nombre == Usuario.u.Nombre)
                    {
                        nom = e.Nombre;
                        apes.Text = e.Apellido1;
                    }
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            
        }
    }
}
