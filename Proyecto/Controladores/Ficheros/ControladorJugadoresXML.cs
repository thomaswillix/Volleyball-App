using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Proyecto.Modelo;

namespace Proyecto.Controladores
{
    public static class ControladorJugadoresXML
    {
        public static List<Jugador> listaJugadores = new List<Jugador>();

        public static void escribirJugadoresXML()
        {
            try
            {
                using (var writer = new StreamWriter("jugadores.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaJugadores.GetType());
                    serializer.Serialize(writer, listaJugadores, namespaces);
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void cargarJugadoresXML()
        {
            try
            {
                string xml = File.ReadAllText("jugadores.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaJugadores.GetType());
                    listaJugadores = (List<Jugador>)serializer.Deserialize(reader);
                }
            }

            catch (Exception)
            {

            }
        }
        public static void crearJugadoresMasc()
        {
            Equipo eq;
            DateTime d;
            Jugador e;
            eq = new Equipo("Seleccion Masc Brasileña");
            d = new DateTime(1986, 7, 2, 0, 0, 0);
            e = new Jugador(1, "Bruno", "Rezende", "Bruno", "Colocador", 'H', d, eq);
            listaJugadores.Add(e);
            d = new DateTime(1991, 2, 27, 0, 0, 0);
            e = new Jugador(4, "Otávio Henrique", "Rodrigues Pinto", "Otávio", "Bloqueador Central", 'H', d, eq);
            listaJugadores.Add(e);
            d = new DateTime(2002, 2, 6, 0, 0, 0);
            e = new Jugador(6, "Adriano", "Fernandes P.X.Calvante", "Adriano", "Opuesto", 'H', d, eq);
            listaJugadores.Add(e);
            d = new DateTime(1997, 3, 18, 0, 0, 0);
            e = new Jugador(8, "Henrique", "Dantas Nóbrega Honorato", "Honorato", "Opuesto", 'H', d, eq);
            listaJugadores.Add(e);
            d = new DateTime(1997, 7, 16, 0, 0, 0);
            e = new Jugador(15, "Maique", "Reis Nascimento", "Nascimento", "Libero", 'H', d, eq);
            listaJugadores.Add(e);
            d = new DateTime(1993, 4, 22, 0, 0, 0);
            e = new Jugador(23, "Flavio", "Resende Gualberto", "Flavio", "Bloqueador Central", 'H', d, eq);
            listaJugadores.Add(e);
            d = new DateTime(1996, 1, 13, 0, 0, 0);
            e = new Jugador(14, "Fernando", "Gil Kreling", "Fernando", "Colocador", 'H', d, eq);
            listaJugadores.Add(e);
        }
    }
}
