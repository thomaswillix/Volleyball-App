using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Proyecto 
    {
        private int codigo;
        private String descripcion;
        private DateTime fechaIni;
        private DateTime fechaFin;
        private bool estado;
        private Double presupuestoIni;
        private Double presupuestoAct;
        private bool cambios;
        private int codigoCliente;

        public Proyecto(int codigo, string descripcion, DateTime fechaIni, DateTime fechaFin, bool estado, double presupuestoIni, double presupuestoAct, bool cambios, int codigoCliente)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.FechaIni = fechaIni;
            this.FechaFin = fechaFin;
            this.Estado = estado;
            this.PresupuestoIni = presupuestoIni;
            this.PresupuestoAct = presupuestoAct;
            this.Cambios = cambios;
            this.CodigoCliente = codigoCliente;
        }
        public Proyecto(string descripcion, DateTime fechaIni, DateTime fechaFin)
        {
            this.Descripcion = descripcion;
            this.PresupuestoIni = presupuestoIni;
            this.PresupuestoAct = presupuestoAct;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaIni { get => fechaIni; set => fechaIni = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public bool Estado { get => estado; set => estado = value; }
        public double PresupuestoIni { get => presupuestoIni; set => presupuestoIni = value; }
        public double PresupuestoAct { get => presupuestoAct; set => presupuestoAct = value; }
        public bool Cambios { get => cambios; set => cambios = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }

    }
}
