using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Manejadores;
using Proyecto.Modelo;


namespace Proyecto
{
    public partial class ListaJugadores : Form
    {
        private Jugador e;
        private int a = 0;
        private Equipo eq;
        private DateTime d;

        public ListaJugadores()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            if (Usuario.u.Sexo == 'H') {
                ControladorJugadores.cargarJugadoresMasc();
                ControladorJugadores.escribirJugadoresXML();
            } else if (Usuario.u.Sexo == 'M')
            {

            }
            ControladorJugadores.leerJugadoresXML();
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
            panel2.Controls.Add(cb);
        }

        private void mostrarEmpleados()
        {
            int posicion = 10;
            foreach (Jugador e in ControladorJugadores.listaJugadores)
            {
                crearChecked(e.Nombre + " " + e.Apellido1 +" | " + e.Posicion + " | " + e.NumCamiseta ,posicion);
                posicion += 30;
            }
        }

        private void ordenarEmpleados(Func<Jugador, IComparable> aux)
        {
            ControladorJugadores.listaJugadores = ControladorJugadores.listaJugadores.OrderBy(aux).ToList();

        }

        private void ordenarFecha_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            ordenarEmpleados(Empleado => Empleado.FechaNac);
            mostrarEmpleados();
        }

        private void ordenarNombre_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ordenarEmpleados(Empleado => Empleado.Nombre);
            mostrarEmpleados();
        }

        private void btElim_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.CheckBox cd in panel2.Controls)
            {
                if (cd.Checked)
                {
                    int posicion = ControladorJugadores.listaJugadores.FindIndex(x => x.Nombre + " " + x.Apellido1 + " | " + x.Posicion + " | " + x.NumCamiseta == cd.Text);
                    ControladorJugadores.listaJugadores.RemoveAt(posicion);
                }
            }
            this.panel2.Controls.Clear();
            mostrarEmpleados();
        }

        private void botonImprimir_Click(object sender, EventArgs e)
        {
            a ++;
            if (a <= 1) { 
                mostrarEmpleados();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListaJugadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ControladorJugadores.escribirJugadoresXML();
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("No guardado");
            }

        }
    }
}
