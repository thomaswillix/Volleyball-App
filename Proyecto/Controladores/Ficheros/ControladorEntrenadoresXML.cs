using Proyecto.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace Proyecto.Controladores
{
    public static class ControladorEntrenadoresXML
    {
        public static List<Entrenador> listaEntrenadores = new List<Entrenador>();


        public static void escribirEntrenadores()
        {
            try
            {
                using (var writer = new StreamWriter("entrenadores.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaEntrenadores.GetType());
                    serializer.Serialize(writer, listaEntrenadores, namespaces);
                }
            }
            catch (Exception)
            {

            }
        }

        public static void cargarEntrenadoresXML()
        {
            try
            {
                string xml = File.ReadAllText("entrenadores.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaEntrenadores.GetType());
                    listaEntrenadores = (List<Entrenador>)serializer.Deserialize(reader);
                }
            }

            catch (Exception)
            {

            }
        }
        public static void crearEntrenadores()
        {
            Equipo eq;
            DateTime d;
            Entrenador e;
            eq = new Equipo("Selección Masc Brasileña");
            d = new DateTime(1960, 7, 19, 0, 0, 0);
            e = new Entrenador("Renan", "Dal Zotto", d, eq);
            listaEntrenadores.Add(e);
            d = new DateTime(1954, 7, 31, 0, 0, 0);
            eq = new Equipo("Selección Fem Brasileña");
            e = new Entrenador("José Roberto", "Lages Gimarães", d, eq);
            listaEntrenadores.Add(e);
        }
    }
}
