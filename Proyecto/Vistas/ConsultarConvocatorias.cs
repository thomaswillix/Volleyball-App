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

namespace Proyecto.Vistas
{
    public partial class ConsultarConvocatorias : Form
    {
        public ConsultarConvocatorias()
        {
            InitializeComponent();
        }

        private void ConsultarConvocatorias_Load(object sender, EventArgs e)
        {
            /*Lo dejo comentado hasta que se creen los partidos porque el archivo, 
            *al estar vacío nos da un problema de lectura errónea y la app crashea.*/
            
            //ControladorPartidos.leerPartidos();
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
