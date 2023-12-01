using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo
{
    public class Equipo
    {
        private int id;
        private string nombre;
        private static int num = 0;
        public Equipo(string nombre)
        {
            this.Id = num;
            this.Nombre = nombre;
            num++;
        }
        public Equipo() { }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }


    }
}
