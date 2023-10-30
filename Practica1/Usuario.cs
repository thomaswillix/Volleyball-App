using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Usuario
    {
        String user;
        String pass;

        public Usuario(string user, string pass)
        {
            this.User = user;
            this.Pass = pass;
        }

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   this.User == usuario.User &&
                   Pass == usuario.Pass;
        }

        public override int GetHashCode()
        {
            int hashCode = -2076927977;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(User);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Pass);
            return hashCode;
        }
    }
}
