using Proyecto.Controladores;
using Proyecto.Modelo;
using Proyecto.Vistas;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            ImagenDAO imagenDAO = new ImagenDAO();
            Image imagen = Image.FromFile(imagenDAO.obtenerImagen(nom));

            pfp.BackgroundImage = imagen;

        }
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Usuario.u = null;
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListaPartidosDB consulta = new FormListaPartidosDB();
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
            VistaPerfil vistaPerfil = new VistaPerfil();
            vistaPerfil.ShowDialog();
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVistaEquipo vistaEquipo = new FormVistaEquipo();
            vistaEquipo.ShowDialog();
        }
    }
}