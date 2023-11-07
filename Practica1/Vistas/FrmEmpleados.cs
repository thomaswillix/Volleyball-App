using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class FrmEmpleados : Form
    {
        private Empleado e;
        private DateTime d;
        private static CheckedListBox clb = new CheckedListBox();

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
        }
        private void cargarEmpleados()
        {
            d = new DateTime(2002, 2, 3, 13, 0, 0);
            e = new Empleado(1,"Juan","Rodriguez","Perez", "programador",d);
            Empleado.listaEmpleados.Add(e);
            d = new DateTime(2000, 9, 4, 22, 0, 0);
            e = new Empleado(1, "Pablo", "Hernandez", "Ortiz", "becario", d);
            Empleado.listaEmpleados.Add(e);
            d = new DateTime(2005, 6, 2, 7, 0, 0);
            e = new Empleado(1, "Juana", "Martin", "Soler", "programador", d);
            Empleado.listaEmpleados.Add(e);
            d = new DateTime(1997, 8, 2, 12, 0, 0);
            e = new Empleado(1, "Maria", "Pinar", "Dueñas", "jefe", d);
            Empleado.listaEmpleados.Add(e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void crearChecked(string empleado, int posicion, int contadorNombre)
        {
            clb.Items.Add(empleado);
            clb.AutoSize = true;
            clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            clb.Location = new System.Drawing.Point(75, posicion);
            clb.Name = "clbProyectos" + contadorNombre;
            clb.Size = new System.Drawing.Size(291, 20);
            clb.TabIndex = 1;
            clb.Text = empleado;
            groupBox1.Controls.Add(clb);
        }

        private void mostrarEmpleados()
        {
            int n = 1;
            int posicion = 10;
            foreach (Empleado e in Empleado.listaEmpleados)
            {
                crearChecked(e.Nombre + " " + e.Apellido1 + " " + e.Apellido2 + " " + e.Puesto,posicion, n);
                n++;
            }
        }
        private void ordenarEmpleados(Func<Empleado, IComparable> aux)
        {
            Empleado.listaEmpleados = Empleado.listaEmpleados.OrderBy(aux).ToList();

        }

        private void ordenarFecha_Click(object sender, EventArgs e)
        {
            ordenarEmpleados(Empleado => Empleado.FechaNac);
            groupBox1.Controls.Clear();
            mostrarEmpleados();
        }

        private void ordenarNombre_Click(object sender, EventArgs e)
        {
            ordenarEmpleados(Empleado => Empleado.Nombre);
            groupBox1.Controls.Clear();
            mostrarEmpleados();
        }
    }
}
