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
    public static class ControladorJugadores
    {
        public static List<Jugador> listaJugadores = new List<Jugador>();
        public static List<Jugador> equipoMasc= new List<Jugador>();
        public static List<Jugador> equipoFem = new List<Jugador>();


        public static void escribirJugadoresXML()
        {
            try
            {
                using (var writer = new StreamWriter("jugadores.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(equipoMasc.GetType());
                    serializer.Serialize(writer, equipoMasc, namespaces);
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void leerJugadoresXML()
        {
            try
            {
                string xml = File.ReadAllText("jugadores.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(equipoMasc.GetType());
                    equipoMasc = (List<Jugador>)serializer.Deserialize(reader);
                }
            }

            catch (Exception)
            {

            }
        }

    }
}
