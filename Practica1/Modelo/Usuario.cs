using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Usuario
    {
        String user;
        String pass;

        //Usuario del que mantendremos la sesión
        public static Usuario u;

        public Usuario(string user, string pass)
        {
            this.User = user;
            this.Pass = pass;
        }
        public Usuario() { }

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

    }
}
