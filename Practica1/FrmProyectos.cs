﻿using System;
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
        Proyecto p;
        DateTime fechaIni;
        DateTime fechaFin;
        private static CheckedListBox clb = new CheckedListBox();


        public FrmProyectos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ordenarProyectos(Func<Proyecto, IComparable> aux)
        {
            Proyecto.listaProyectos = Proyecto.listaProyectos.OrderBy(aux).ToList();

        }

        private void mostrarProyectos()
        {
            int n = 1;
            int posicion = 10;
            foreach (Proyecto project in Proyecto.listaProyectos)
            {
                crearChecked(project.Descripcion, posicion, n);
                posicion += 30;
                n++;
            }
        }

        private void cargarProyectos()
        {
            fechaIni = new DateTime(2011, 2, 3 , 13, 0, 0);
            fechaFin = DateTime.Today;
            p = new Proyecto("Proyecto Antiguo", fechaIni, fechaFin);
            Proyecto.listaProyectos.Add(p);
            fechaIni = new DateTime(2015, 5, 21, 8, 0, 0);
            fechaFin = new DateTime(2023, 9, 30, 9, 0, 0);
            p = new Proyecto("Segundo Proyecto", fechaIni, fechaFin);
            Proyecto.listaProyectos.Add(p);
            fechaIni = new DateTime(2022, 7, 14, 6, 0, 0);
            fechaFin = new DateTime(2020, 10, 3, 10, 0, 0);
            p = new Proyecto("Most Recent", fechaIni, fechaFin);
            Proyecto.listaProyectos.Add(p);
            fechaIni = new DateTime(2018, 9, 21, 19, 0, 0);
            fechaFin = DateTime.Today;
            p = new Proyecto("Tercero", fechaIni, fechaFin);
            Proyecto.listaProyectos.Add(p);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ordenarProyectos(Proyecto => Proyecto.FechaIni);
            groupBox1.Controls.Clear();
            mostrarProyectos();
        }
        
        
        private void crearChecked(string proyectoText, int posicion, int contadorNombre)
        {
            clb.Items.Add(proyectoText);
            clb.AutoSize = true;
            clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            clb.Location = new System.Drawing.Point(75, posicion);
            clb .Name = "clbProyectos" + contadorNombre;
            clb.Size = new System.Drawing.Size(291, 20);
            clb.TabIndex = 1;
            clb.Text = proyectoText;
            groupBox1.Controls.Add(clb);
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
            ordenarProyectos(Proyecto => Proyecto.Descripcion);
            groupBox1.Controls.Clear();
            mostrarProyectos();
        }

        private void btElim_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<= Proyecto.listaProyectos.Count; i++)
            {
                if (p.Descripcion[i] == clb.CheckedItems.ToString().Trim()[i])
                {
                    Proyecto.listaProyectos.Remove(p);
                }
            }
            clb.CheckedItems.ToString().Trim();
        }
    }
}
