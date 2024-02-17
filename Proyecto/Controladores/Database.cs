using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Proyecto.Controladores
{
    public class Database
    {

        public string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            // A diferencia de la anterior versión, forzamos a que coja la ruta relativa con el
            // Path.GetFullPath
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Database.mdf"));
            //string databaseFileName = "Database.mdf";
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;
        }

        // Modificado: Ahora los parámetros son pasados como argumentos
        public void insertarJugador(int numeroCamiseta, string nombre, string apellidos, string nombreCamiseta, string posicion, char sexo, DateTime fechaNac, int codigoEquipo)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Jugadores (NumeroCamiseta, Nombre, Apellidos, NombreCamiseta, Posicion, Sexo, FechaNac, CodEquipo) VALUES (@NumeroCami, @Nombre, @Apellidos, @NombreCami, @Posicion, @Sexo, @FechaNac, @CodEquipo)";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@NumeroCamiseta", numeroCamiseta);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@NombreCamiseta", nombreCamiseta);
                    command.Parameters.AddWithValue("@Posicion", posicion);
                    command.Parameters.AddWithValue("@Sexo", sexo);
                    command.Parameters.AddWithValue("@FechaNac", fechaNac);
                    command.Parameters.AddWithValue("@CodEquipo", codigoEquipo);
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
        public void insertarPartido(int equipoVisitante, int equipoLocal, DateTime fechaPartido)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = construirCadenaConexión();
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
                    command.Parameters.AddWithValue("@Apellidos", fechaPartido);
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
        public DataTable ObtenerJugadores()
        {
            // Cadena de conexión a la base de datos
            string connectionString = construirCadenaConexión();
            // Query para obtener los jugadores
            string query = "SELECT * FROM Jugadores";

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


        //Hoy que probar este método, no estoy seguro e que funcione pero we'll see.
        public DataTable ObtenerPartidos()
        {
            // Cadena de conexión a la base de datos
            string connectionString = construirCadenaConexión();
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

        public void CargarDatosEspecificosDataGridView(DataGridView dataGridView)
        {
            // Cadena de conexión a la base de datos
            string connectionString = construirCadenaConexión();
            // Query para obtener los datos específicos
            string query = "SELECT nombre, apellidos, posicion, numero_camiseta FROM Jugadores";

            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Nombre", "nombre");
            dataGridView.Columns.Add("Apellidos", "apellidos");
            dataGridView.Columns.Add("Posición", "posicion");
            dataGridView.Columns.Add("Dorsal", "numero_camiseta");


            // Crear la conexión

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar una nueva fila al DataGridView con el código y el nombre del proyecto
                                dataGridView.Rows.Add(reader["nombre"].ToString(), reader["apellidos"].ToString(), reader["posicion"].ToString(), reader["numero_camiseta"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
                    connection.Close();
                }
            }

        }
    }
}