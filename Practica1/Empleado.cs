using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Empleado
    {
        private readonly int id;
        private static int incr= 1;
        private String dni;
        private String nombre;
        private String ape1;
        private String ape2;
        private String puesto;
        private int telef;
        private String correo;
        private DateTime fechaNac;
        private int segurSocial;
        private String comentarios;

        public Empleado( string dni, string nombre, string ape1, string ape2, string puesto, int telef, string correo, DateTime fechaNac, int segurSocial, string comentarios)
        {
            incr++;
            this.id = incr;
            this.dni = dni;
            this.nombre = nombre;
            this.ape1 = ape1;
            this.ape2 = ape2;
            this.puesto = puesto;
            this.telef = telef;
            this.correo = correo;
            this.fechaNac = fechaNac;
            this.segurSocial = segurSocial;
            cambiarComentarios(comentarios);
        }
        public Empleado(string dni, string nombre, string ape1, string ape2, string puesto, string correo, DateTime fechaNac, int segurSocial)
        {
            this.id++;
            this.dni = dni;
            this.nombre = nombre;
            this.ape1 = ape1;
            this.ape2 = ape2;
            this.puesto = puesto;
            this.correo = correo;
            this.fechaNac = fechaNac;
            this.segurSocial = segurSocial;
        }
        public Empleado()
        {
           
        }
        public bool esJefe()
        {
            if (this.puesto.ToLower().Equals("jefe"))
            {
                return true;
            } 
            return false;
        }
        public void cambiarComentarios(String cometarios)
        {
            if (comentarios.Length <1000)
            {
                int i ;
                for (i = comentarios.Length; i <= 1000; i++)
                {
                    comentarios.Append('.');
                }
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Empleado empleado &&
                   id == empleado.id &&
                   dni == empleado.dni &&
                   nombre == empleado.nombre &&
                   ape1 == empleado.ape1 &&
                   ape2 == empleado.ape2 &&
                   puesto == empleado.puesto &&
                   telef == empleado.telef &&
                   correo == empleado.correo &&
                   fechaNac == empleado.fechaNac &&
                   segurSocial == empleado.segurSocial &&
                   comentarios == empleado.comentarios;
        }

        public override int GetHashCode()
        {
            int hashCode = 908012845;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dni);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ape1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ape2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(puesto);
            hashCode = hashCode * -1521134295 + telef.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(correo);
            hashCode = hashCode * -1521134295 + fechaNac.GetHashCode();
            hashCode = hashCode * -1521134295 + segurSocial.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(comentarios);
            return hashCode;
        }

        public int Id { get => id;}
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ape1 { get => ape1; set => ape1 = value; }
        public string Ape2 { get => ape2; set => ape2 = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public int Telef { get => telef; set => telef = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int SegurSocial { get => segurSocial; set => segurSocial = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }

        
    }
}
