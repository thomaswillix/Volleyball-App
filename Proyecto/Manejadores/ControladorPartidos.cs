using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Proyecto.Modelo;


namespace Proyecto.Manejadores
{
    public static class ControladorPartidos
    {
        public static List<Partido> listaPartidos = new List<Partido>();


        public static void escribirPartidosXML()
        {
            try
            {
                using (var writer = new StreamWriter("partidos.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaPartidos.GetType());
                    serializer.Serialize(writer, listaPartidos, namespaces);
                }
            }
            catch (Exception e)
            {

            }
        }
        public static void leerPartidosXML()
        {
            try
            {
                string xml = File.ReadAllText("partidos.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaPartidos.GetType());
                    listaPartidos = (List<Partido>)serializer.Deserialize(reader);
                }
            }

            catch (Exception)
            {

            }
        }

    }
}
