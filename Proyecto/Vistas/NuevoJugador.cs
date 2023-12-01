using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Manejadores;
using Proyecto.Modelo;

namespace Proyecto
{
    public partial class NuevoJugador : Form
    {
        DateTime fechaActual = new DateTime();
        TimeSpan edad;
        double edadAnios;
        char s;

        public NuevoJugador()
        {
            InitializeComponent();
        }

        private void NuevoJugador_Load(object sender, EventArgs e)
        {
         
        }
        public void calcularEdad()
        {
            fechaActual.ToLocalTime();
            edad = fechaActual - fechaNac.Value;
            edadAnios = (edad.TotalDays / 365.25);
        }
        public void establecerSexo()
        {
            if(sexo.SelectedItem.ToString() == "Hombre")
            {
                s = 'H';
            }
            else if(sexo.SelectedItem.ToString() == "Mujer")
            {
                s = 'M';
            }
        }
        private bool validar()
        {
            calcularEdad();

            if (String.IsNullOrEmpty(nom.Text) || String.IsNullOrEmpty(ape.Text) || String.IsNullOrEmpty(nomCami.Text)||
                numeroCami.Value < 1 || numeroCami.Value > 18 || edadAnios < 18)
            {
                return false;
            }
            return true;
        }
        private void camposIncorrectos()
        {
            if (String.IsNullOrEmpty(nom.Text))
            {
                nom.BackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(ape.Text))
            {
                ape.BackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(nomCami.Text))
            {
                nomCami.BackColor = Color.Red;
            }
            if (numeroCami.Value<1 || numeroCami.Value>18)
            {
                nomCami.BackColor = Color.Red;
            }
            if (edadAnios<18)
            {
                fechaNac.CalendarTitleBackColor = Color.Red;
            }
        }
        private void camposNormal()
        {
            nom.BackColor = Color.White;
            ape.BackColor = Color.White;
            nomCami.BackColor = Color.White;
            numeroCami.BackColor = Color.White;
            posicion.BackColor = Color.White;
            fechaNac.CalendarTitleBackColor = Color.White;    
        }

        private void vaciarCampos()
        { 
            nom.Clear();
            ape.Clear();
            nomCami.Clear();
            numeroCami.Value = 0;
            posicion.Items.Clear();
            }
        private void aniadirJugador()
        {
            establecerSexo();
            Equipo e = new Equipo(equipo.SelectedText.ToString());
            ControladorJugadores.listaJugadores.Add(new Jugador((int)numeroCami.Value, nom.Text, ape.Text, nomCami.Text, posicion.Text,
                s, fechaNac.Value, e));
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aniadirJugador();
                vaciarCampos();
                MessageBox.Show("Jugador añadido al repositorio de Jugador");

            }
            else
            {
                camposNormal();
                camposIncorrectos();
                MessageBox.Show("Revisa los campos, hay algún dato erróneo");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cod_ValueChanged(object sender, EventArgs e)
        {

        }


        private void come_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fechaNac_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
