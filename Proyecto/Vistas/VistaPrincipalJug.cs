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
using Proyecto.Modelo;
using Proyecto.Vistas;

namespace Proyecto
{
    public partial class VistaPrincipalJug : Form
    {
        public VistaPrincipalJug()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            string nom = Usuario.u.Nombre.ToString();
            bienv.Text += " " + nom;
            switch (nom)
            {
                case "Bruno":
                    pfp.BackgroundImage = Image.FromFile("../Pics/Bruno.jpeg");
                    break;
                case "Natalia":
                    pfp.BackgroundImage = Image.FromFile("../Pics/Natalia.jpg");
                    break;
            }
        }
        private void Principal_FormClosing(object sender,FormClosingEventArgs e)
        {
            Usuario.u = null;
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarConvocatorias consulta = new ConsultarConvocatorias();
            consulta.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void escudo_Click(object sender, EventArgs e)
        {

        }

        private void pfp_Click(object sender, EventArgs e)
        {
            VistaPerfil vistaPerfil =  new VistaPerfil();
            vistaPerfil.ShowDialog();
        }
    }
}