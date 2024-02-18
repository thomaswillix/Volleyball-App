using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Controladores;

namespace Proyecto.Vistas
{
    public partial class FormListaPartidos : Form
    {
        public FormListaPartidos()
        {
            InitializeComponent();
        }

        private void ConsultarConvocatorias_Load(object sender, EventArgs e)
        {
            ControladorPartidosJSON.cargarPartidos();
            mostrarPartidos();
        }
        public void mostrarPartidos()
        {
            int posicion = 10;
            foreach (Partido e in ControladorPartidosJSON.listaPartidos)
            {
                createList(e.Equipo1.Nombre, e.Equipo2.Nombre, e.Fecha, posicion);
                posicion += 35;
            }
        }
        public void createList(string equipo1, string equipo2, DateTime fecha, int posicion)
        {
            System.Windows.Forms.Label l = new System.Windows.Forms.Label();
            l.AutoSize = true;
            l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            l.ForeColor = System.Drawing.Color.White;
            l.Location = new System.Drawing.Point(10, posicion);
            l.Size = new System.Drawing.Size(291, 20);
            l.TabIndex = 1;
            l.Text = equipo1 + " versus " + equipo2 + " " + fecha.DayOfWeek + " " + fecha.Day + " de " + fecha.Month + " " + fecha.Year;
            groupBox1.Controls.Add(l);
        }
        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
