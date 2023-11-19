using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class PrincipalJug : Form
    {
        public PrincipalJug()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
            bienv.Text += "";
        }
        private void Principal_FormClosing(object sender,FormClosingEventArgs e)
        {
        }
        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListaPartidos Form = new ListaPartidos();
            Form.ShowDialog();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NuevoPartido proy = new NuevoPartido();
            proy.ShowDialog();
        }

        private void listadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaJugadores listaEmpl = new ListaJugadores();
            listaEmpl.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoJugador empl = new NuevoJugador();
            empl.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}