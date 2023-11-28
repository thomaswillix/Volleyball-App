using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Practica1
{
    public static class ControladorEmpleadosXML
    {
        public static List<Empleado> listaEmpleados= new List<Empleado>();


        public static void escribirEmpleadosXML()
        {
            try
            {
                using (var writer = new StreamWriter("empleados.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaEmpleados.GetType());
                    serializer.Serialize(writer, listaEmpleados, namespaces);
                }
            }
            catch (Exception e)
            {

            }
        }

        public static void leerEmpleadosXML()
        {
            try
            {
                string xml = File.ReadAllText("empleados.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaEmpleados.GetType());
                    listaEmpleados = (List<Empleado>)serializer.Deserialize(reader);
                }
            }

            catch (Exception)
            {

            }
        }

    }
}
