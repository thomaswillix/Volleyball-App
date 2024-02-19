using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Proyecto.Controladores.BBDD
{
    public class ImagenDAO
    {

        public DataTable obtenerJugadores()
        {
            // Cadena de conexión a la base de datos
            string connectionString = ConnectionDB.construirCadenaConexión();
            // Query para obtener los jugadores
            string query = "SELECT * FROM Imagenes";

            // Crear una tabla para almacenar los resultados
            DataTable dataTable = new DataTable();

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un adaptador de datos
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Llenar la tabla con los resultados de la consulta
                    adapter.Fill(dataTable);
                }
                connection.Close();
            }

            return dataTable;

        }

        // Modificado: Ahora los parámetros son pasados como argumentos
        public void insertarJugador(string id_foto, string foto)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = ConnectionDB.construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Imagenes (Id_Foto, foto) VALUES (@Id, @foto)";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@Id", id_foto);
                    command.Parameters.AddWithValue("@foto", foto);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                        connection.Close();
                    }
                }
            }
        }

        public DataTable consultaRuta(string id_foto)
        {
            // Cadena de conexión a la base de datos
            string connectionString = ConnectionDB.construirCadenaConexión();
            // Query para obtener los jugadores
            string query = "SELECT foto FROM Imagenes where Id_Foto = @Id";

            // Crear una tabla para almacenar los resultados
            DataTable dataTable = new DataTable();

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión

                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@Id", id_foto);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se encontró el archivo. Registros afectados: {registrosAfectados}");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                        {

                            // Llenar la tabla con los resultados de la consulta
                            adapter.Fill(dataTable);
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                        connection.Close();
                    }
                    // Crear un adaptador de datos
                }
            }

            return dataTable;

        }
    }
}
