using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class NuevoPartido : Form
    {
        ToolTip tp = new ToolTip();
        public NuevoPartido()
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
            //tp.Show("Marcarse solo si sigue activo", cambios);
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            //tp.Show("Marcarse solo si han habido cambios en la realización del proyecto", cambios);
        }

        private void cambios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cod_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool validar()
        {
            /*if (fechaNac.Value<)
            {
                return false;
            }*/
            return true;
        }
        private void camposIncorrectos()
        {
            /*if (fechaNac.Value<)
            {
                fechaNac.CalendarTitleBackColor = Color.Red;
             }*/
        }
        private void camposNormal()
        {
            
            fechaNac.CalendarTitleBackColor = Color.White;
            
        }
        private void vaciarCampos()
        {
            fechaNac.Value = DateTime.Now;
            
        }

        private void aniadirProyecto()
        {/*
            Proyecto.listaProyectos.Add(new Proyecto((int)cod.Value, desc.Text, fechaIni.Value,
                fechaFin.Value, estado.Checked, (Double)presuIni.Value, (Double)presuFin.Value,
                cambios.Checked, (int)codCli.Value));*/
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

        private void NuevoPartido_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void presuFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void codCli_ValueChanged(object sender, EventArgs e)
        {

        }

        private void presuIni_ValueChanged(object sender, EventArgs e)
        {

        }

        private void puesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
