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
using Proyecto.Vistas.LecturaBBDD;
using Proyecto.Vistas;

namespace Proyecto
{
    public partial class VistaPrincipalEntr : Form
    {
        public VistaPrincipalEntr()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
            string nom = Usuario.u.Nombre.ToString();
            bienv.Text += " " + nom;
            switch (nom)
            {
                case "Ze":
                    pfp.BackgroundImage = Image.FromFile("../Pics/Ze.jpeg");
                    break;
                case "Renan":
                    pfp.BackgroundImage = Image.FromFile("../Pics/Renan.jpeg");
                    break;
            }
        }
        private void Principal_FormClosing(object sender,FormClosingEventArgs e)
        {
            Usuario.u = null;            
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vista de Modificación de Jugadores
        }

        private void modificaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Vista de Modificación de Partidos
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();                        
        }


        private void escudo_Click(object sender, EventArgs e)
        {
            VistaPerfil vistaPerfil = new VistaPerfil();
            vistaPerfil.ShowDialog();
        }

        private void jugadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListaJugadores listaJ = new FormListaJugadores();
            listaJ.ShowDialog();
        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaJugadoresDB listaJ = new FormListaJugadoresDB();
            listaJ.ShowDialog();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormNuevoPartido nuevoP =  new FormNuevoPartido();
            nuevoP.ShowDialog();
        }

        private void programarPersistenciaEnBBDDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
