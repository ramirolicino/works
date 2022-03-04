using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public class AccesoDatos
    {
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;


        //MANEJO SQL
        public AccesoDatos()
        {
            this.connectionString = @"Data Source=.\MSSQLSERVER04; Initial Catalog=20211123-SP;Integrated Security=True";
            this.command = new SqlCommand();
            this.connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }


        //Leer SQL
        public List<Serie> ObtenerBacklog()
        {
            List<Serie> ListaSeries = new List<Serie>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM series";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListaSeries.Add(new Serie(reader["nombre"].ToString(), reader["genero"].ToString()));
                }

                return ListaSeries;
            }
            catch (BacklogException)
            {
                throw new BacklogException("Error al obtener el archivo");
            }
            finally
            {
                connection.Close();
            }
        }


        public void ActualizarSerie(Serie serie)
        {
            try
            {
                connection.Open();
                command.CommandText = $"UPDATE series SET alumno = 'Ramiro Olicino'       WHERE nombre = @nombre;";
                command.Parameters.AddWithValue("@nombre", serie.Nombre);
                command.ExecuteNonQuery();
            }
            catch (BacklogException ex)
            {
                throw new BacklogException("Error al obtener el archivo", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
