using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo
{
    public class Usuario
    {
        private string nombre;
        private string contrasenia;
        private bool esJugador;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public bool EsJugador { get => esJugador; set => esJugador = value; }

        public Usuario() { }    

        public Usuario(string nombre, string contrasenia, bool esJugador)
        {
            Nombre = nombre;
            Contrasenia = contrasenia;
            EsJugador = esJugador;
        }
    }
}
