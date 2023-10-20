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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Practica1
{
    public partial class FrmProyectos : Form
    {
        private List<Proyecto> listaProyectos = new List<Proyecto>();
        Proyecto p;
        DateTime fechaIni;
        DateTime fechaFin;

        public FrmProyectos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cargarProyectos()
        {
            fechaIni = new DateTime(2021, 2, 3 , 13, 0, 0);
            fechaFin = DateTime.Today;
            p = new Proyecto(1, "Best Proyecto", fechaIni, fechaFin, true, 1234.14, 9895.50, false, 1);
            listaProyectos.Add(p);
            fechaIni = new DateTime(2022, 5, 21, 8, 0, 0);
            fechaFin = new DateTime(2023, 9, 30, 9, 0, 0);
            p = new Proyecto(2, "No muy buen Proyecto", fechaIni, fechaFin, false, 5555.89, 0, true, 2);
            listaProyectos.Add(p);
            fechaIni = new DateTime(2020, 7, 14, 6, 0, 0);
            fechaFin = new DateTime(2020, 10, 3, 10, 0, 0);
            p = new Proyecto(3, "Fatal", fechaIni, fechaFin, false, 62.0, 0, false, 2);
            listaProyectos.Add(p);
            fechaIni = new DateTime(2023, 9, 21, 19, 0, 0);
            fechaFin = DateTime.Today;
            p = new Proyecto(2, "Good Proyecto", fechaIni, fechaFin, true, 654.1, 1000.41, false, 3);
            listaProyectos.Add(p);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void mostrarProyectos()
        {
            groupBox1.Controls.Clear();
            int n = 1;
            int posicion = 10;
            foreach (Proyecto project in listaProyectos)
            {
                crearEtiqueta(project.Descripcion, posicion, n);
                posicion += 30;
                n++;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ordenarProyectosFecha();
        }
        
        private void ordenarProyectosFecha()
        {
            groupBox1.Controls.Clear();
            listaProyectos.Sort();
            mostrarProyectos();
        }
        private void crearEtiqueta(string proyectoText, int posicion, int contadorNombre)
        {
            Label LblProyecto = new System.Windows.Forms.Label();
            LblProyecto.AutoSize = true;
            LblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            LblProyecto.Location = new System.Drawing.Point(75, posicion);
            LblProyecto.Name = "lblProyecto" + contadorNombre;
            LblProyecto.Size = new System.Drawing.Size(291, 20);
            LblProyecto.TabIndex = 1;
            LblProyecto.Text = proyectoText;
            groupBox1.Controls.Add(LblProyecto);
        }

        private void FrmProyectos_Load(object sender, EventArgs e)
        {
            cargarProyectos();
            mostrarProyectos();
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
            ordenarProyectosNombre(Proyecto => Proyecto.Descripcion);
            groupBox1.Controls.Clear();
            mostrarProyectos();
        }

        
        private void ordenarProyectosNombre(Func<Proyecto,IComparable> aux)
        {
            listaProyectos = listaProyectos.OrderBy(aux).ToList();
            
        }
    }
}
