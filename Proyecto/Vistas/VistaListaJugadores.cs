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
    public partial class VistaListaJugadores : Form
    {

        public VistaListaJugadores()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            //ControladorJugadoresXML.cargarJugadoresMasc();
            //ControladorJugadoresXML.escribirJugadoresXML();
            ControladorJugadoresXML.leerJugadoresXML();
            mostrarJugadores();
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /*private void crearChecked(string nom, string ape, string pos, int numCami, int posicion)
        {
            System.Windows.Forms.CheckBox cb = new System.Windows.Forms.CheckBox();
            cb.AutoSize = true;
            cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            cb.Location = new System.Drawing.Point(10, posicion);
            cb.Size = new System.Drawing.Size(291, 20);
            cb.TabIndex = 1;
            cb.Text = e;
            listView1.Controls.Add(cb);
        }*/
        private void createListElement(string nom, string ape, string pos, string numCami, string equipo)
        {
            ListViewItem item = new ListViewItem();
            item.Text = nom;
            item.SubItems.Add(ape);
            item.SubItems.Add(pos);
            item.SubItems.Add(numCami);
            item.SubItems.Add(equipo);
            listView1.Items.Add(item);
        }
        private void mostrarJugadores()
        {
            foreach (Jugador e in ControladorJugadoresXML.listaJugadores)
            {
                string numcami = e.NumCamiseta.ToString();
                createListElement(e.Nombre, e.Apellido1, e.Posicion, numcami , e.E.Nombre);
            } 
        }

        private void ordenarJugadores(Func<Jugador, IComparable> aux)
        {
            ControladorJugadoresXML.listaJugadores = ControladorJugadoresXML.listaJugadores.OrderBy(aux).ToList();

        }

        private void ordenarFecha_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ordenarJugadores(Jugador=> Jugador.FechaNac);
            mostrarJugadores();
        }

        private void ordenarNombre_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ordenarJugadores(Jugador => Jugador.Nombre);
            mostrarJugadores();
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
                ControladorJugadoresXML.escribirJugadoresXML();
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("No guardado");
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            ordenarJugadores(Jugador => Jugador.NumCamiseta);
            mostrarJugadores();
        }
    }
}
