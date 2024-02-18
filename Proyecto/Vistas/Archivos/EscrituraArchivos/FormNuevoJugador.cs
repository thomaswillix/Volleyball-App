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
using Proyecto.Controladores;
using Proyecto.Modelo;

namespace Proyecto.Vistas
{
    public partial class FormNuevoJugador : Form
    {
        DateTime fechaActual = new DateTime();
        TimeSpan edad;
        double edadAnios;
        char s;

        public FormNuevoJugador()
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

            List<string> errores = new List<string>();

            // Realiza todas las validaciones y recopila los mensajes de error
            if (!Validator.validateTextBox(nom))
            {
                errores.Add("La descripción está vacía.");
            }
            if (!Validator.validateTextBox(ape))
            {
                errores.Add("La descripción está vacía.");
            }
            if (!Validator.validateTextBox(nomCami))
            {
                errores.Add("La descripción está vacía.");
            }

            if (!Validator.validateNumUpDown(numeroCami))
            {
                errores.Add("El presupuesto inicial no es válido.");
            }

            if (edadAnios < 18)
            {
                errores.Add("El jugador no es mayo de edad.");
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
            
        private void aniadirJugador()
        {
            establecerSexo();
            Equipo e = new Equipo(equipo.SelectedText.ToString());
            ControladorJugadoresXML.listaJugadores.Add(new Jugador((int)numeroCami.Value, nom.Text, ape.Text, nomCami.Text, posicion.Text,
                s, fechaNac.Value, e));
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aniadirJugador();
                MessageBox.Show("Jugador añadido al repositorio de Jugador");

            }
            else
            {
                MessageBox.Show("Revisa los campos, hay algún dato erróneo");
            }
        }
    }
}
