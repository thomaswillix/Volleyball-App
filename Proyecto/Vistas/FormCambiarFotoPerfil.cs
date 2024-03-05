
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vistas
{
    public partial class FormCambiarFotoPerfil : Form
    {
        public FormCambiarFotoPerfil()
        {
            InitializeComponent();
        }

        private void FormCambiarFotoPerfil_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseDataSet.Imagenes' Puede moverla o quitarla según sea necesario.
            this.imagenesTableAdapter.Fill(this.databaseDataSet.Imagenes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
