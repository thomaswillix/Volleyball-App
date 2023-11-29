using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1.manejadores;

namespace Practica1
{
    public partial class nuevo_proyecto : Form
    {
        ToolTip tp = new ToolTip();
        public nuevo_proyecto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void checkBox2_MouseHover(object sender, EventArgs e)
        {
            tp.Show("Marcarse solo si sigue activo", cambios);
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            tp.Show("Marcarse solo si han habido cambios en la realización del proyecto", cambios);
        }

        private void cambios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cod_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool validar()
        {
            if (desc.Text == "" || (fechaIni.Value > fechaFin.Value) 
                || presuIni.Value<0 || presuFin.Value<0 || cod.Value<=0 
                ||codCli.Value <=0)
            {
                return false;
            }
            return true;
        }
        private void camposIncorrectos()
        {
            if (desc.Text == "")
            {
                desc.BackColor = Color.Red;
            }
            if(fechaIni.Value > fechaFin.Value)
            {
                fechaIni.CalendarTitleBackColor = Color.Red;
                fechaFin.CalendarTitleBackColor = Color.Red;
            }
            if (presuIni.Value < 0)
            {
                presuIni.BackColor = Color.Red;
            }
            if (presuFin.Value < 0)
            {
                presuFin.BackColor = Color.Red;
            }
            if (cod.Value <= 0)
            {
                cod.BackColor = Color.Red;
            }
            if (codCli.Value <= 0)
            {
                codCli.BackColor = Color.Red;
            }
        }
        private void camposNormal()
        {
            desc.BackColor = Color.White;
            fechaIni.CalendarTitleBackColor = Color.White;
            fechaFin.CalendarTitleBackColor = Color.White;
            presuIni.BackColor = Color.White;
            presuFin.BackColor = Color.White;
            cod.BackColor = Color.White;
            codCli.BackColor = Color.White;
              
        }
        private void vaciarCampos()
        {
            desc.Clear();
            fechaIni.Value = DateTime.Now;
            fechaFin.Value = DateTime.Now;
            presuIni.Value = 0;
            estado.Checked = false;
            cambios.Checked = false;
            presuFin.Value = 0;
            cod.Value = 0;
            codCli.Value = 0;

        }

        private void aniadirProyecto()
        {
            ControladorProyectosBin.listaProyectos.Add(new Proyecto((int)cod.Value, desc.Text, fechaIni.Value,
                fechaFin.Value, estado.Checked, (Double)presuIni.Value, (Double)presuFin.Value,
                cambios.Checked, (int)codCli.Value));
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                aniadirProyecto();
                vaciarCampos();
                MessageBox.Show("Proyecto añadido al repositorio de Proyectos");

            }
            else
            {
                camposNormal();
                camposIncorrectos();
                MessageBox.Show("Revisa los campos, hay algún dato erróneo");
            }
        }

        private void nuevo_proyecto_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
