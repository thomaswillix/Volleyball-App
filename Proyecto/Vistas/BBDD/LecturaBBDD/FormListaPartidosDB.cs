using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Controladores;
using System.Windows.Forms;

namespace Proyecto.Vistas
{
    public partial class FormListaPartidosDB : Form
    {
        public FormListaPartidosDB()
        {
            InitializeComponent();
            PartidosDAO db = new PartidosDAO();
            dataGridView1.DataSource =  db.ObtenerPartidos();
        }
    }
}
