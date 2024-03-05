﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto.Controladores
{
    public class PersistenciaJugadores
    {

        public DataTable obtenerJugadores()
        {
            // Cadena de conexión a la base de datos
            string connectionString = ConnectionDB.construirCadenaConexión();
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

        // Modificado: Ahora los parámetros son pasados como argumentos
        public void insertarJugador(int numeroCamiseta, string nombre, string apellidos, string nombreCamiseta, string posicion, char sexo, DateTime fechaNac, int codigoEquipo)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = ConnectionDB.construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Jugadores (NumeroCamiseta, Nombre, Apellidos, NombreCamiseta, Posicion, Sexo, FechaNac, EquipoID) VALUES (@NumeroCami, @Nombre, @Apellidos, @NombreCami, @Posicion, @Sexo, @FechaNac, @CodEquipo)";

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

        public void cargarDatosEspecificosDataGridView(DataGridView dataGridView, int codEquipo)
        {
            // Cadena de conexión a la base de datos
            string connectionString = ConnectionDB.construirCadenaConexión();
            // Query para obtener los datos específicos
            string query = "SELECT nombre, apellidos, posicion, numero_camiseta FROM Jugadoresw where EquipoID = @CodEquipo";

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
                        command.Parameters.AddWithValue("@CodEquipo", codEquipo);
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