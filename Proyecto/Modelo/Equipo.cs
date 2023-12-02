using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo
{
    public class Equipo
    {
        private string nombre;

        public Equipo(string nombre)
        {
            this.Nombre = nombre;
        }
        public Equipo() { }

        public string Nombre { get => nombre; set => nombre = value; }


    }
}
