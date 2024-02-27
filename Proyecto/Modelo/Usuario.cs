using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Controladores;

namespace Proyecto.Modelo
{
    [Serializable]
    public class Usuario 
    {
        private string nombre;
        private string contrasenia;
        private bool esJugador;
        private char sexo;
        public static Usuario u;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public bool EsJugador { get => esJugador; set => esJugador = value; }
        public char Sexo { get => sexo; set => sexo = value; }

        public Usuario() { }

        public Usuario(string nombre, string contrasenia, bool esJugador, char sexo)
        {
            Nombre = nombre;
            Contrasenia = contrasenia;
            EsJugador = esJugador;
            this.sexo = sexo;
        }
       
    }
}
