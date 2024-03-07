using Proyecto.Controladores;
using System;
using System.Windows.Forms;

namespace Proyecto.Vistas
{
    public partial class FormListaPartidosDB : Form
    {
        public FormListaPartidosDB()
        {
            InitializeComponent();
            PartidosDAO db = new PartidosDAO();
            dataGridView1.DataSource = db.obtenerPartidos();
        }

        private void elim_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            rowIndex += 1;
            MessageBox.Show(rowIndex.ToString());

            PartidosDAO db = new PartidosDAO();
            db.eliminarPartido(rowIndex);
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
