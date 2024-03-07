using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto.Controladores
{
    internal class PartidosDAO
    {
        //Hoy que probar este método, no estoy seguro e que funcione pero we'll see.
        public DataTable obtenerPartidos()
        {
            // Cadena de conexión a la base de datos
            string connectionString = ConnectionDB.construirCadenaConexión();
            // Query para obtener los partidos
            string query =
                "SELECT Equipos.nombre as Local, (SELECT nombre " +
                "FROM Equipos join Partidos on idEquipo = EquipoVisitanteID " +
                "WHERE EquipoLocalID = 2) as Visitante, Partidos.fecha_partido as 'Fecha del Partido' " +
                "FROM Equipos join Partidos on idEquipo = EquipoLocalID";

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
        public bool eliminarPartido(int id)
        {
            // Cadena de conexión a la base de datos
            string connectionString = ConnectionDB.construirCadenaConexión();
            // Query para obtener los jugadores
            string query = "Delete FROM Partidos where idPartido = @id";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se eliminó correctamente el partido. Registros afectados: {registrosAfectados}");
                        connection.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el partido: {ex.Message}");
                        connection.Close();
                    }
                }
            }
            return false;
        }

        public void insertarPartido(int equipoVisitante, int equipoLocal, DateTime fechaPartido)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = ConnectionDB.construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Partidos (EquipoVisitanteID, EquipoLocalID, fecha_partido) VALUES (@EquipoVisitanteID, @EquipoLocalID, @fecha_partido)";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@EquipoVisitanteID", equipoVisitante);
                    command.Parameters.AddWithValue("@EquipoLocalID", equipoLocal);
                    command.Parameters.AddWithValue("@fecha_partido", fechaPartido);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se insertó correctamente el partido. Registros afectados: {registrosAfectados}");
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
    }
}
