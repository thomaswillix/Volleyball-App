using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Modelo;

namespace Proyecto
{
    public class Entrenador : Usuario
    {
        private string apellido1;
        private Equipo e;
        private DateTime fechaNac;

        public Entrenador(string nombre, string apellido1, DateTime fechaNac, Equipo e)
        {
            Nombre = nombre;
            this.apellido1 = apellido1;
            this.fechaNac = fechaNac;
            this.E = e;
        }

        public Entrenador()
        {
        } 

        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public Equipo E { get => e; set => e = value; }

        public override bool Equals(object obj)
        {
            return obj is Entrenador entrenador &&
                   Nombre == entrenador.Nombre &&
                   Contrasenia == entrenador.Contrasenia &&
                   EsJugador == entrenador.EsJugador &&
                   apellido1 == entrenador.apellido1 &&
                   EqualityComparer<Equipo>.Default.Equals(e, entrenador.e) &&
                   fechaNac == entrenador.fechaNac &&
                   Apellido1 == entrenador.Apellido1 &&
                   FechaNac == entrenador.FechaNac &&
                   EqualityComparer<Equipo>.Default.Equals(E, entrenador.E);
        }

        public override int GetHashCode()
        {
            int hashCode = -864810619;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Contrasenia);
            hashCode = hashCode * -1521134295 + EsJugador.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(apellido1);
            hashCode = hashCode * -1521134295 + EqualityComparer<Equipo>.Default.GetHashCode(e);
            hashCode = hashCode * -1521134295 + fechaNac.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellido1);
            hashCode = hashCode * -1521134295 + FechaNac.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Equipo>.Default.GetHashCode(E);
            return hashCode;
        }
    }
}
