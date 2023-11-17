using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button.CheckBox;

namespace Practica1
{
    public partial class ListaPartidos : Form
    {
        Partido p;
        DateTime fechaIni;
        DateTime fechaFin;


        public ListaPartidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ordenarProyectos(Func<Partido, IComparable> aux)
        {
            Partido.listaProyectos = Partido.listaProyectos.OrderBy(aux).ToList();

        }

        private void mostrarProyectos()
        {
            int posicion = 10;

            foreach (Partido p in Partido.listaProyectos)
            {
                crearChecked(p, posicion);
                posicion += 30;
            }
        }

        private void cargarProyectos()
        {
            fechaIni = new DateTime(2011, 2, 3 , 13, 0, 0);
            fechaFin = DateTime.Today;
            p = new Partido("Proyecto Antiguo", fechaIni, fechaFin);
            Partido.listaProyectos.Add(p);
            fechaIni = new DateTime(2015, 5, 21, 8, 0, 0);
            fechaFin = new DateTime(2023, 9, 30, 9, 0, 0);
            p = new Partido("Segundo Proyecto", fechaIni, fechaFin);
            Partido.listaProyectos.Add(p);
            fechaIni = new DateTime(2022, 7, 14, 6, 0, 0);
            fechaFin = new DateTime(2020, 10, 3, 10, 0, 0);
            p = new Partido("Most Recent", fechaIni, fechaFin);
            Partido.listaProyectos.Add(p);
            fechaIni = new DateTime(2018, 9, 21, 19, 0, 0);
            fechaFin = DateTime.Today;
            p = new Partido("Tercero", fechaIni, fechaFin);
            Partido.listaProyectos.Add(p);
            fechaIni = new DateTime(2015, 9, 21, 19, 0, 0);
            fechaFin = new DateTime(2022, 10, 3, 10, 0, 0);
            p = new Partido("Cuato", fechaIni, fechaFin);
            Partido.listaProyectos.Add(p);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cargarProyectos();
            mostrarProyectos();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            ordenarProyectos(Proyecto => Proyecto.FechaIni);
            mostrarProyectos();
        }
        
        
        private void crearChecked(Partido p1, int posicion)
        {
            System.Windows.Forms.CheckBox cb = new System.Windows.Forms.CheckBox();

            cb.AutoSize = true;
            cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            cb.Location = new System.Drawing.Point(75, posicion);
            cb.Size = new System.Drawing.Size(291, 20);
            cb.TabIndex = 1;
            cb.Text = p1.Descripcion;
            groupBox1.Controls.Add(cb);
        }

        private void FrmProyectos_Load(object sender, EventArgs e)
        {
        }
        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to really exit ? ",
                                    "Exit",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                this.Show();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void ordenarNombre_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            ordenarProyectos(Proyecto => Proyecto.Descripcion);
            mostrarProyectos();
        }

        private void btElim_Click(object sender, EventArgs e)
        {/*
            foreach (System.Windows.Forms.CheckBox cd in groupBox1.Controls)
            {
                if (cd.Checked)
                {
                    int posicion = Proyecto.listaProyectos.FindIndex(x => x.Descripcion == cd.Text);
                    Proyecto.listaProyectos.RemoveAt(posicion);
                }
            }
            this.groupBox1.Controls.Clear();
            mostrarProyectos();*/
        }
    }
}
