using Proyecto.Controladores;
using System;
using System.Windows.Forms;

namespace Proyecto.Vistas
{
    public partial class FormListaJugadoresDB : Form
    {
        public FormListaJugadoresDB()
        {
            InitializeComponent();
        }

        private void FormListaJugadoresDB_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseDataSet.Jugadores' Puede moverla o quitarla según sea necesario.
            this.jugadoresTableAdapter.Fill(this.databaseDataSet.Jugadores);

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void elim_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            string nomCami = dataGridView2.Rows[rowIndex].Cells[4].Value.ToString();

            MessageBox.Show(nomCami);

            JugadoresDAO db = new JugadoresDAO();
            db.eliminarJugador(nomCami);
            dataGridView2.Rows.RemoveAt(rowIndex);
        }
    }
}
