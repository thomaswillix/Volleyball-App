using Proyecto.Controladores;
using System;
using System.Windows.Forms;

namespace Proyecto.Vistas
{
    public partial class FormVistaEquipo : Form
    {
        public FormVistaEquipo()
        {
            InitializeComponent();
        }

        private void FormVistaEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseDataSet.Jugadores' Puede moverla o quitarla según sea necesario.
            this.jugadoresTableAdapter.Fill(this.databaseDataSet.Jugadores);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            flowLayoutPanel1.Controls.Clear();
            JugadoresDAO jugadoresDAO = new JugadoresDAO();
            foreach (String s in jugadoresDAO.obtenerEquipo(rowIndex))
            {
                Label l = new Label();
                l.Text = s;
                flowLayoutPanel1.Controls.Add(l);
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
