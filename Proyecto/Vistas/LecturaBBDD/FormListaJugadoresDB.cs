﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vistas.LecturaBBDD
{
    public partial class FormListaJugadoresDB : Form
    {
        public FormListaJugadoresDB()
        {
            InitializeComponent();
        }

        private void FormListaJugadoresDB_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseDataSet.Jugadores' Puede moverla o quitarla según sea necesario.
            this.jugadoresTableAdapter.Fill(this.databaseDataSet.Jugadores);

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
