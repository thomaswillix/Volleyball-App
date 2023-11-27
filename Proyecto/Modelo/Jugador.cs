using System;
using System.Collections.Generic;
using Proyecto;
using Proyecto.Modelo;

public class Jugador : Usuario
{
    private int numCamiseta;
	private string apellido1;
    private string nombreCamiseta;
	private string posicion;
    private char sexo;
	private DateTime fechaNac;
    private Equipo e;

    public Jugador(int numCamiseta, string nombre, string apellido1, string nombreCamiseta, string posicion, char sexo, DateTime fechaNac, Equipo e)
    {
        this.numCamiseta = numCamiseta;
        Nombre = nombre;
        this.apellido1 = apellido1;
        this.nombreCamiseta = nombreCamiseta;
        this.posicion = posicion;
        this.sexo = sexo;
        this.fechaNac = fechaNac;
        this.E = e;
    }

    public Jugador()
    {
    }

    public int NumCamiseta { get => numCamiseta; set => numCamiseta = value; }
    public string Apellido1 { get => apellido1; set => apellido1 = value; }
    public string NombreCamiseta { get => nombreCamiseta; set => nombreCamiseta = value; }
    public string Posicion { get => posicion; set => posicion = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public Equipo E { get => e; set => e = value; }

    public override bool Equals(object obj)
    {
        return obj is Jugador jugador &&
               numCamiseta == jugador.numCamiseta &&
               apellido1 == jugador.apellido1 &&
               nombreCamiseta == jugador.nombreCamiseta &&
               posicion == jugador.posicion &&
               sexo == jugador.sexo &&
               fechaNac == jugador.fechaNac &&
               EqualityComparer<Equipo>.Default.Equals(e, jugador.e);
    }

    public override int GetHashCode()
    {
        int hashCode = -801381194;
        hashCode = hashCode * -1521134295 + numCamiseta.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(apellido1);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombreCamiseta);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(posicion);
        hashCode = hashCode * -1521134295 + sexo.GetHashCode();
        hashCode = hashCode * -1521134295 + fechaNac.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<Equipo>.Default.GetHashCode(e);
        return hashCode;
    }
}
