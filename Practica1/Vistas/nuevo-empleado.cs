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
            if (cod.Value <= 0 ||nom.Text == "" || ape1.Text == "" || ape2.Text == "" || correo.Text != ||(fechaIni.Value > fechaFin.Value)
                || presuIni.Value < 0 || presuFin.Value < 0
                || codCli.Value <= 0)
            {
                return false;
            }
            return true;
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
