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
        private bool validar()
        {
            if (cod.Value <= 0 || nom.Text == "" || ape1.Text == "" || ape2.Text == "" || ValidacionEmail.IsValid(correo.Text)
                || tlf.Value > 699999999 || tlf.Value <= 600000000 || come.Text != "")
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
            if (true)
            {
                
            }



            /*|| nom.Text == "" || ape1.Text == "" || ape2.Text == "" || ValidacionEmail.IsValid(correo.Text)
        || tlf.Value > 699999999 || tlf.Value <= 600000000 || come.Text != "")
    {
        return false;
    }
    return true;*/
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
            cod.Value = 0;
            dni.Clear();
            nom.Clear();
            ape1.Clear();
            ape2.Clear();
            puesto.Items.Clear();
            tlf.Value = 0;
            correo.Clear();
            fechaNac.Value = DateTime.Now;
            numSS.Value = 0;
            come.Clear();
        }
        private void aniadirEmpleado()
        {
            Empleado.listaEmpleados.Add(new Empleado((int)cod.Value, dni.Text, nom.Text, ape1.Text, ape2.Text,
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
    }
}
