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
    public partial class PrincipalEntr : Form
    {
        public PrincipalEntr()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
        private void Principal_FormClosing(object sender,FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            ListaJugadores listaJ= new ListaJugadores();
            listaJ.ShowDialog();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NuevoPartido part = new NuevoPartido();
            part.ShowDialog();
        }

        private void listadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*
            FrmEmpleados listaEmpl = new FrmEmpleados();
            listaEmpl.ShowDialog();*/
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaJugadores listaJug= new ListaJugadores();
            listaJug.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }

}
