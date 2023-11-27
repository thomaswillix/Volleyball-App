using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Modelo;

namespace Proyecto
{
    internal class Entrenador : Usuario
    {
        private string apellido1;
        private DateTime fechaNac;

        public Entrenador(string nombre, string apellido1, DateTime fechaNac)
        {
            Nombre = nombre;
            this.apellido1 = apellido1;
            this.fechaNac = fechaNac;
        }

        public Entrenador()
        {
        } 

        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }

        public override bool Equals(object obj)
        {
            return obj is Entrenador entrenador &&
                   Nombre == entrenador.Nombre &&
                   Contrasenia == entrenador.Contrasenia &&
                   EsJugador == entrenador.EsJugador &&
                   Apellido1 == entrenador.Apellido1 &&
                   FechaNac == entrenador.FechaNac;
        }

        public override int GetHashCode()
        {
            int hashCode = -1842456293;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Contrasenia);
            hashCode = hashCode * -1521134295 + EsJugador.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellido1);
            hashCode = hashCode * -1521134295 + FechaNac.GetHashCode();
            return hashCode;
        }


    }
}
