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
using Practica1.manejadores;

namespace Practica1
{
    public partial class nuevo_empleado : Form
    {
        public nuevo_empleado()
        {
            InitializeComponent();
        }

        private void nuevo_empleado_Load(object sender, EventArgs e)
        {

        }
        //Devuelve true si es valido el DNI
        static bool validarDni(string dni)
        {
            //Comprobamos si el DNI tiene 9 digitos
            if (dni.Length != 9)
            {
                //No es un DNI Valido
                return false;
            }
            return true;
            //Extraemos los números y la letra
            /*string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);
            //Intentamos convertir los números del DNI a integer
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                return false;
            }
            if (CalculateDNILeter(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                return false;
            }
            //DNI Valido :)
            return true;*/
        }


        /*static string CalculateDNILeter(int dniNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }*/
        private bool validar()
        {
            if (cod.Value <= 0 || !validarDni(dni.Text) || String.IsNullOrEmpty(nom.Text) || String.IsNullOrEmpty(ape1.Text) || String.IsNullOrEmpty(ape2.Text)
                || !ValidacionEmail.IsValid(correo.Text)|| tlf.Value > 699999999 || tlf.Value <= 600000000 || String.IsNullOrEmpty(come.Text))
            {
                return false;
            }
            return true;
        }
        private void camposIncorrectos()
        {
            if (cod.Value <= 0)
            {
                cod.BackColor = Color.Red;
            }
            if (!validarDni(dni.Text))
            {
                dni.BackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(nom.Text))
            {
                nom.BackColor = Color.Red;
            }
            if (!ValidacionEmail.IsValid(correo.Text))
            {
                correo.BackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(ape1.Text))
            {
                ape1.BackColor = Color.Red;
            }
            if (String.IsNullOrEmpty(ape2.Text))
            {
                ape2.BackColor = Color.Red;

            }
            if (String.IsNullOrEmpty(come.Text))
            {
                come.BackColor = Color.Red;
            }
        }
        private void camposNormal()
        {
            cod.BackColor = Color.White;
            dni.BackColor = Color.White;
            nom.BackColor = Color.White;
            ape1.BackColor = Color.White;
            ape2.BackColor = Color.White;
            puesto.BackColor = Color.White;
            tlf.BackColor = Color.White;
            correo.BackColor = Color.White;
            fechaNac.CalendarTitleBackColor = Color.White;
            numSS.BackColor = Color.White;
            come.BackColor = Color.White;
        }

        private void vaciarCampos()
        { 
            string fecha =  "Jan 01, 1953";
            var parsedDate = DateTime.Parse(fecha);
            cod.Value = 0;
            dni.Clear();
            nom.Clear();
            ape1.Clear();
            ape2.Clear();
            puesto.Items.Clear();
            tlf.Value = 600000000;
            correo.Clear();
            fechaNac.Value = parsedDate;
            numSS.Value = 0;
            come.Clear();
        }
        private void aniadirEmpleado()
        {
            ControladorEmpleadosJSON.listaEmpleados.Add(new Empleado((int)cod.Value, dni.Text, nom.Text, ape1.Text, ape2.Text,
                puesto.Text, (int)tlf.Value, correo.Text, fechaNac.Value, (int)numSS.Value, come.Text));
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aniadirEmpleado();
                vaciarCampos();
                MessageBox.Show("Empleado añadido al repositorio de Empleados");

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

        private void bt2_Click(object sender, EventArgs e)
        {
            wb.Visible = true;
        }

        private void esc_Click(object sender, EventArgs e)
        {
            wb.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cod_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tlf_ValueChanged(object sender, EventArgs e)
        {

        }

        private void come_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
