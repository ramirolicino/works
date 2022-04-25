using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LogDAO
    {
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;


        public LogDAO()
        {
            this.connectionString = @"Data Source=.\MSSQLSERVER04; Initial Catalog=bomberos-db;Integrated Security=True";
            this.command = new SqlCommand();
            this.connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public void Insertar(string log)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO log(entrada, alumno) VALUES(@entrada, 'Ramiro olicino')";
                command.Parameters.AddWithValue("@entrada", log);
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

        public string Leer()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT entrada FROM log";
                SqlDataReader reader = command.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (reader.Read())
                {
                    string log = reader.GetString(0);
                    sb.AppendLine(log);
                }

                return sb.ToString();
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
