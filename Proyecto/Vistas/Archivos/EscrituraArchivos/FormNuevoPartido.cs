using Proyecto.Controladores;
using Proyecto.Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto.Vistas
{
    public partial class FormNuevoPartido : Form
    {
        DateTime fechaActual = new DateTime();

        public FormNuevoPartido()
        {
            InitializeComponent();
        }


        private bool validar()
        {

            if (fechaPart.Value < fechaActual || String.IsNullOrEmpty(equipoL.Text) || String.IsNullOrEmpty(equipoV.Text))
            {
                return false;
            }
            return true;
        }
        private void camposIncorrectos()
        {
            if (fechaPart.Value < fechaActual)
            {
                MessageBox.Show("La fecha del partido no puede ser anterior a la fecha actual");
                fechaPart.CalendarTitleBackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(equipoL.Text))
            {
                equipoL.BackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(equipoV.Text))
            {
                equipoV.BackColor = Color.Red;
            }
        }
        private void camposNormal()
        {
            fechaPart.CalendarTitleBackColor = Color.White;
            equipoL.BackColor = Color.White;
            equipoV.BackColor = Color.White;
        }
        private void vaciarCampos()
        {
            fechaPart.Value = DateTime.Now;
            equipoL.ResetText();
            equipoV.ResetText();
        }

        private void aniadirPartido()
        {
            Equipo eL = new Equipo(equipoL.Text);
            Equipo eV = new Equipo(equipoV.Text);
            ControladorPartidosJSON.listaPartidos.Add(new Partido(eL, eV, fechaPart.Value));
            ControladorPartidosJSON.escribirPartidos();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aniadirPartido();
                vaciarCampos();
                MessageBox.Show("Partido añadido al repositorio de Partidos");

            }
            else
            {
                camposNormal();
                camposIncorrectos();
                MessageBox.Show("Revisa los campos, hay algún dato erróneo");
            }
        }

        private void NuevoPartido_Load(object sender, EventArgs e)
        {
            fechaActual.ToLocalTime();
        }

        private void mismoEquipo()
        {
            if (equipoV.SelectedIndex == equipoL.SelectedIndex)
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void equipoL_SelectedIndexChanged(object sender, EventArgs e)
        {
            camposNormal();
            mismoEquipo();
        }

        private void equipoV_SelectedIndexChanged(object sender, EventArgs e)
        {
            camposNormal();
            mismoEquipo();
        }

        private void fechaNac_ValueChanged(object sender, EventArgs e)
        {
            camposNormal();
        }
    }
}
