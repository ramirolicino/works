using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class PuestoSQL
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;


        /// <summary>
        /// Estableze la conexion a la db
        /// </summary>
        static PuestoSQL()
        {
            connectionString = EmpleadoSQL.ConnectionString;
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }





        public static Puesto CargarPuestoXid(Puesto puesto)
        {
            Puesto auxPuesto = null;

            try
            {
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM Puestos      WHERE ID = @id;";

                command.Parameters.AddWithValue("@id", puesto.Id);

                connection.Open();
                command.ExecuteNonQuery();

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["ID"].ToString());
                    string nombre = dataReader["DESCRIPCION"].ToString();

                    auxPuesto = new Puesto(id, nombre);
                }

                if (auxPuesto is not null)
                {
                    return auxPuesto;
                }
                else
                {
                    throw new EmpleadoExcepcion("No se encuentra el Puesto elegido");
                }
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



        public static List<Puesto> CargarPuestos()
        {
            List<Puesto> list = new List<Puesto>();

            try
            {
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM Puestos;";

                connection.Open();
                command.ExecuteNonQuery();

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["ID"].ToString());
                    string nombre = dataReader["DESCRIPCION"].ToString();

                    list.Add(new Puesto(id, nombre));
                }

                return list;
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



        public static bool Agregar(Puesto puesto)
        {
            try
            {
                command.CommandText = $"INSERT INTO Puestos(DESCRIPCION)    VALUES(@nombre) ";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", puesto.Descripcion);


                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Debe ingresar un Puesto valido");
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



        public static bool Modificar(Puesto puesto)
        {
            try
            {
                if (CargarPuestoXid(puesto) is not null)
                {
                    command.Parameters.Clear();

                    command.CommandText = $"UPDATE Puestos SET DESCRIPCION = @nombre  " +
                                          $"WHERE ID = @id";

                    command.Parameters.AddWithValue("@id", puesto.Id);
                    command.Parameters.AddWithValue("@nombre", puesto.Descripcion);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return true;
                }

                return false;
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
