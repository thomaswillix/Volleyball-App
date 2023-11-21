using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Manejadores;

namespace Proyecto.Modelo
{
    public class Usuario
    {
        private string nombre;
        private string contrasenia;
        private bool esJugador;
        public static Usuario u;

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
        public static bool validaLogin(ref string usuario, ref string clave)
        {
            for (int i = 0; i < ControladorUsuarios.listaUsuarios.Count; i++)
            {
                if ((usuario == ControladorUsuarios.listaUsuarios[i].Nombre.ToLower())
                    && (clave == ControladorUsuarios.listaUsuarios[i].Contrasenia))
                {
                    return true;
                }
                else if ((usuario != ControladorUsuarios.listaUsuarios[i].Nombre.ToLower())
                    || (clave != ControladorUsuarios.listaUsuarios[i].Contrasenia.ToLower()))
                {
                    continue;
                }
            }
            return false;
        }

        public static Usuario buscarUsuario(string usuario, string pass)
        {
            Usuario u = new Usuario();
            for (int i = 0; i < ControladorUsuarios.listaUsuarios.Count; i++)
            {
                if (usuario == ControladorUsuarios.listaUsuarios[i].Nombre.ToLower())
                {
                    u = ControladorUsuarios.listaUsuarios[i];
                    if (pass == ControladorUsuarios.listaUsuarios[i].Contrasenia)
                    {
                        return u;
                    }
                }
            }
            return u;
        }

    }
}
