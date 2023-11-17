using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Partido 
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
        public static List<Partido> listaProyectos = new List<Partido>();

        public Partido(int codigo, string descripcion, DateTime fechaIni, DateTime fechaFin, bool estado, double presupuestoIni, double presupuestoAct, bool cambios, int codigoCliente)
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
        public Partido(string descripcion, DateTime fechaIni, DateTime fechaFin)
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

       
        public override bool Equals(object obj)
        {
            return obj is Partido proyecto &&
                   Codigo == proyecto.Codigo &&
                   Descripcion == proyecto.Descripcion &&
                   FechaIni == proyecto.FechaIni &&
                   FechaFin == proyecto.FechaFin &&
                   Estado == proyecto.Estado &&
                   PresupuestoIni == proyecto.PresupuestoIni &&
                   PresupuestoAct == proyecto.PresupuestoAct &&
                   Cambios == proyecto.Cambios &&
                   CodigoCliente == proyecto.CodigoCliente;
        }

        public override int GetHashCode()
        {
            int hashCode = -55884537;
            hashCode = hashCode * -1521134295 + Codigo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Descripcion);
            hashCode = hashCode * -1521134295 + FechaIni.GetHashCode();
            hashCode = hashCode * -1521134295 + FechaFin.GetHashCode();
            hashCode = hashCode * -1521134295 + Estado.GetHashCode();
            hashCode = hashCode * -1521134295 + PresupuestoIni.GetHashCode();
            hashCode = hashCode * -1521134295 + PresupuestoAct.GetHashCode();
            hashCode = hashCode * -1521134295 + Cambios.GetHashCode();
            hashCode = hashCode * -1521134295 + CodigoCliente.GetHashCode();
            return hashCode;
        }

    }
}
