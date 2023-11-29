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

namespace Proyecto
{
    public partial class PrincipalEntr : Form
    {
        public PrincipalEntr()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
            string nom = Usuario.u.Nombre.ToString();
            bienv.Text += " " + nom;
        }
        private void Principal_FormClosing(object sender,FormClosingEventArgs e)
        {
            Usuario.u = null;            
        }
        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            /*ListaJugadores listaJ= new ListaJugadores();
            listaJ.ShowDialog();*/
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NuevoPartido part = new NuevoPartido();
            part.ShowDialog();
        }

        private void listadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaJugadores listaJ = new ListaJugadores();
            listaJ.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*Vista de Convocar a Jugadores para X partidos.*/
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
