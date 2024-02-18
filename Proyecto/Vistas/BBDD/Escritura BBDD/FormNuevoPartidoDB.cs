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
    public partial class FormNuevoPartidoDB : Form
    {
        public FormNuevoPartidoDB()
        {
            InitializeComponent();
            populateComboBoxes();
        }

        private void populateComboBoxes()
        {
            
        }

        private void equipoL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormNuevoPartidoDB_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseDataSet.Equipos' Puede moverla o quitarla según sea necesario.
            this.equiposTableAdapter.Fill(this.databaseDataSet.Equipos);
        }
    }
}
