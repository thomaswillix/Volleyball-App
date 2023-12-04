using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }
    }
}
