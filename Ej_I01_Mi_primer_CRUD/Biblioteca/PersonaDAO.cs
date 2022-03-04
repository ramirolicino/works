using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class PersonaDAO
    {
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;


        public PersonaDAO()
        {
            this.connectionString = @"Data Source=.\MSSQLSERVER04; Initial Catalog=Persona_DB;Integrated Security=True";
            this.command = new SqlCommand();
            this.connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }



        public void Guardar(Persona persona)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO Personas(NOMBRE, APELLIDO)    VALUES(@nombre, @apellido)";
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@apellido", persona.Apellido);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Persona> Leer()
        {
            List<Persona> lista = new List<Persona>();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM Personas";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Persona(Convert.ToInt32(reader["id"]), reader["nombre"].ToString(), reader["apellido"].ToString()));
                }

                return lista;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

        }

        public List<Persona> LeerXID(int id)
        {
            List<Persona> lista = new List<Persona>();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM Personas WHERE ID = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Persona(reader["nombre"].ToString(), reader["apellido"].ToString()));
                }

                return lista;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }
        }

        public void Modificar(Persona persona)
        {
            try
            {
                connection.Open();
                command.CommandText = $"UPDATE Personas SET NOMBRE = @nombre, APELLIDO = @apellido   WHERE ID = @id;";
                command.Parameters.AddWithValue("@id", persona.Id);
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@apellido", persona.Apellido);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection?.Close();
            }
        }

        public void Borrar(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM Personas WHERE ID = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
