﻿using System;
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

        public Equipo(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
        public Equipo() { }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

    }
}
