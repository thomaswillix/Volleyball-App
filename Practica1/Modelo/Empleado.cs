using System;
using System.Collections.Generic;

public class Empleado
{
	private int id;
	private string dni;
	private string nombre;
	private string apellido1;
    private string apellido2;
	private string puesto;
	private int telefono;
	private string correo;
	private DateTime fechaNac;
	private int numSS;
	private string comentarios;
    

    public Empleado(int id, string dni, string nombre, string apellido1, string apellido2, string puesto, int telefono, string correo, DateTime fechaNac, int numSS, string comentarios)
    {
        this.id = id;
        this.dni = dni;
        this.nombre = nombre;
        this.apellido1 = apellido1;
        this.apellido2 = apellido2;
        this.puesto = puesto;
        this.telefono = telefono;
        this.correo = correo;
        this.fechaNac = fechaNac;
        this.numSS = numSS;
        this.comentarios = comentarios;
    }
    public Empleado(int id, string nombre, string apellido1, string apellido2, string puesto, DateTime fechaNac)
    {
        this.nombre = nombre;
        this.apellido1 = apellido1;
        this.apellido2 = apellido2;
        this.puesto = puesto;
        this.fechaNac = fechaNac;
    }
    public Empleado() { }

    public bool esJefe()
    {
        if (this.puesto == "jefe")
        {
            return true;
        }
        return false;
    }

    public int Id { get => id; set => id = value; }
    public string Dni { get => dni; set => dni = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido1 { get => apellido1; set => apellido1 = value; }
    public string Apellido2 { get => apellido2; set => apellido2 = value; }
    public string Puesto { get => puesto; set => puesto = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public string Correo { get => correo; set => correo = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public int NumSS { get => numSS; set => numSS = value; }
    public string Comentarios { get => comentarios; set => comentarios = value; }

    public override bool Equals(object obj)
    {
        return obj is Empleado empleado &&
               id == empleado.id &&
               dni == empleado.dni &&
               nombre == empleado.nombre &&
               apellido1 == empleado.apellido1 &&
               apellido2 == empleado.apellido2 &&
               puesto == empleado.puesto &&
               telefono == empleado.telefono &&
               correo == empleado.correo &&
               fechaNac == empleado.fechaNac &&
               numSS == empleado.numSS &&
               comentarios == empleado.comentarios;
    }

    public override int GetHashCode()
    {
        int hashCode = -920621640;
        hashCode = hashCode * -1521134295 + id.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dni);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(apellido1);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(apellido2);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(puesto);
        hashCode = hashCode * -1521134295 + telefono.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(correo);
        hashCode = hashCode * -1521134295 + fechaNac.GetHashCode();
        hashCode = hashCode * -1521134295 + numSS.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(comentarios);
        return hashCode;
    }
}
