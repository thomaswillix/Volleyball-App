using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Modelo;
using Proyecto.Manejadores;

namespace Proyecto
{
    public partial class FormNuevoPartido : Form
    {
        DateTime fechaActual = new DateTime();

        public FormNuevoPartido()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void cambios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cod_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool validar()
        {
            
            if (fechaPart.Value<fechaActual || String.IsNullOrEmpty(equipoL.Text) || String.IsNullOrEmpty(equipoV.Text))
            {
                return false;
            }
            return true;
        }
        private void camposIncorrectos()
        {
            if (fechaPart.Value < fechaActual) {
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mismoEquipo()
        {
            if(equipoV.SelectedIndex == equipoL.SelectedIndex)
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
