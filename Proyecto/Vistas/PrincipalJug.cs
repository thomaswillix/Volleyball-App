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
    public partial class PrincipalJug : Form
    {
        public PrincipalJug()
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

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoJugador empl = new NuevoJugador();
            empl.ShowDialog();
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
    }
}