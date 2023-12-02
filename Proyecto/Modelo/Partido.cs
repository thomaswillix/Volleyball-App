using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Modelo;

namespace Proyecto
{
    public class Partido 
    {
        private Equipo equipo1;
        private Equipo equipo2;
        private DateTime fecha;
        
        public Partido(Equipo equipo1, Equipo equipo2, DateTime fecha)
        {
            this.Equipo1 = equipo1;
            this.Equipo2 = equipo2;
            this.Fecha = fecha;
        }
        public Partido() { }
        
        public Equipo Equipo1 { get => equipo1; set => equipo1 = value; }
        public Equipo Equipo2 { get => equipo2; set => equipo2 = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        
    }
}
