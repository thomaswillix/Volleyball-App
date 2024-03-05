using Proyecto.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto.Vistas
{
    public partial class FormNuevoPartidoDB : Form
    {
        PersistenciaJugadores jugadores = new PersistenciaJugadores();
        EquiposDAO equipos = new EquiposDAO();

        public FormNuevoPartidoDB()
        {
            InitializeComponent();
        }

        private void equipoL_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idL = equipos.obtenerId(equipoL.Text);

            jugadores.cargarDatosEspecificosDataGridView(dataGridView1, idL);
        }

        private void FormNuevoPartidoDB_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseDataSet.Equipos' Puede moverla o quitarla según sea necesario.
            this.equiposTableAdapter.Fill(this.databaseDataSet.Equipos);
        }

        private void btProgr_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aniadirPartido();
                vaciarCampos();
                MessageBox.Show("Proyecto añadido al repositorio de Proyectos");

            }
            else
            {
                MessageBox.Show("Revisa los campos, hay algún dato erróneo");
            }
        }

        private bool validar()
        {
            List<string> errores = new List<string>();

            // Realiza todas las validaciones y recopila los mensajes de error

            if (fechaPart == null || fechaPart.Value < DateTime.Today)
            {
                errores.Add("La fecha no es válida.");
            }

            if (!Validator.validateComboBox(equipoL))
            {
                errores.Add("El equipo local no es válido.");
            }

            if (!Validator.validateComboBox(equipoV))
            {
                errores.Add("El equipo visitante no es válido.");
            }

            // Si hay mensajes de error, imprímelos y devuelve false
            if (errores.Count > 0)
            {
                foreach (var error in errores)
                {
                    Console.WriteLine(error);
                }
                return false;
            }
            // Si no hay errores, devuelve true
            return true;
        }

        private void vaciarCampos()
        {
            equipoL.SelectedValue = 0;
            equipoV.SelectedValue = 0;
            fechaPart.Value = DateTime.Now;
        }

        private void aniadirPartido()
        {
            int idV = equipos.obtenerId(equipoV.Text);
            int idL = equipos.obtenerId(equipoL.Text);

            PartidosDAO db = new PartidosDAO();
            db.insertarPartido(idV, idL, fechaPart.Value);
        }

        private void equipoV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idV = equipos.obtenerId(equipoV.Text);

            jugadores.cargarDatosEspecificosDataGridView(dataGridView1, idV);
        }
    }
}
