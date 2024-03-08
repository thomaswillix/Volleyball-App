using Proyecto.Controladores;
using Proyecto.Modelo;
using Proyecto.Vistas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class VistaPrincipalEntr : Form
    {
        public VistaPrincipalEntr()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            string nom = Usuario.u.Nombre.ToString();
            bienv.Text += " " + nom;
            ImagenDAO imagenDAO = new ImagenDAO();
            Image imagen = Image.FromFile(imagenDAO.obtenerImagen(nom));

            pfp.BackgroundImage = imagen;
            loopBackgroud();
        }
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Usuario.u = null;
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

        private void jugadoresXML_Click(object sender, EventArgs e)
        {
            FormListaJugadores listaJ = new FormListaJugadores();
            listaJ.ShowDialog();
        }

        private void jugadoresBBDD_Click(object sender, EventArgs e)
        {
            FormListaJugadoresDB listaJ = new FormListaJugadoresDB();
            listaJ.ShowDialog();
        }
        private void aniadirJugadorXML_Click(object sender, EventArgs e)
        {
            FormNuevoJugador nuevoJ = new FormNuevoJugador();
            nuevoJ.ShowDialog();
        }

        private void partidoJSON_Click(object sender, EventArgs e)
        {
            FormNuevoPartido nuevoP = new FormNuevoPartido();
            nuevoP.ShowDialog();
        }

        private void partidoBBDD_Click(object sender, EventArgs e)
        {
            FormNuevoPartidoDB nuevoP = new FormNuevoPartidoDB();
            nuevoP.ShowDialog();
        }

        private void loopBackgroud()
        {
            string executableFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string executableDirectoryPath = System.IO.Path.GetDirectoryName(executableFilePath);
            string videoFilePath = System.IO.Path.Combine(executableDirectoryPath, "background.mp4");
            axWindowsMediaPlayer1.URL = videoFilePath;
            axWindowsMediaPlayer1.settings.setMode("Loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void añadirBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoJugadorDB nuevoJugadorDB = new FormNuevoJugadorDB();
            nuevoJugadorDB.ShowDialog();
        }
    }

}
