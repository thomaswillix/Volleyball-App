using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Proyecto.Modelo;
using System.IO;


namespace Proyecto.Manejadores
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
            catch (Exception e)
            {

            }
        }

        public static void leerEntrendoresXML()
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
    }
}
