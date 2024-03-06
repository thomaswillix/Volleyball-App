using Proyecto.Controladores;
using Proyecto.Modelo;

using System;
using System.Drawing;
using System.Windows.Forms;
namespace Proyecto.Vistas
{
    public partial class FormCambiarFotoPerfil : Form
    {
        public FormCambiarFotoPerfil()
        {
            InitializeComponent();
            openFileDialog1.Title = "Change logo image";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
        }

        private void FormCambiarFotoPerfil_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            startTimer();
        }
        private void startTimer()
        {
            progressBar1.Show();
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 200;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                progressBar1.Hide();
                try
                {
                    Image newLogo = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = newLogo;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine("Archivo no encontrado");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImagenDAO imagenes = new ImagenDAO();

            if (imagenes.existeUsu(Usuario.u.Nombre))
            {
                imagenes.actualizarImagenes(Usuario.u.Nombre, openFileDialog1.FileName);
            }
        }
    }
}
