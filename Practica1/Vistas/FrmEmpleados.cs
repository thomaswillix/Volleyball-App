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
    public partial class FrmEmpleados : Form
    {

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            //Esto se comentará luego.
            ControladorEmpleadosJSON.cargarEmpleados();
            ControladorEmpleadosJSON.escribirEmpleados();
            ControladorEmpleadosJSON.leerEmpleados();
            mostrarEmpleados();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void crearChecked(string e, int posicion)
        {
            System.Windows.Forms.CheckBox cb = new System.Windows.Forms.CheckBox();
            cb.AutoSize = true;
            cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            cb.Location = new System.Drawing.Point(75, posicion);
            cb.Size = new System.Drawing.Size(291, 20);
            cb.TabIndex = 1;
            cb.Text = e;
            groupBox1.Controls.Add(cb);
        }

        private void mostrarEmpleados()
        {
            int posicion = 10;
            foreach (Empleado e in ControladorEmpleadosJSON.listaEmpleados)
            {
                crearChecked(e.Nombre ,posicion);
                posicion += 30;
            }
        }

        private void ordenarEmpleados(Func<Empleado, IComparable> aux)
        {
            ControladorEmpleadosJSON.listaEmpleados = ControladorEmpleadosJSON.listaEmpleados.OrderBy(aux).ToList();

        }

        private void ordenarFecha_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            ordenarEmpleados(Empleado => Empleado.FechaNac);
            mostrarEmpleados();
        }

        private void ordenarNombre_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            ordenarEmpleados(Empleado => Empleado.Nombre);
            mostrarEmpleados();
        }

        private void btElim_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.CheckBox cd in groupBox1.Controls)
            {
                if (cd.Checked)
                {
                    int posicion = ControladorEmpleadosJSON.listaEmpleados.FindIndex(x => x.Nombre == cd.Text);
                    ControladorEmpleadosJSON.listaEmpleados.RemoveAt(posicion);
                }
            }
            this.groupBox1.Controls.Clear();
            mostrarEmpleados();
        }

        private void botonImprimir_Click(object sender, EventArgs e)
        {
            mostrarEmpleados();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ControladorEmpleadosJSON.escribirEmpleados();
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("No guardado");            
            }
        }
    }
}
