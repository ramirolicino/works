using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblioteca
{
    public static class EmpleadoSQL
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;


        /// <summary>
        /// Estableze la conexion a la db
        /// </summary>
        static EmpleadoSQL()
        {
            connectionString = ConnectionString;
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }


        public static string ConnectionString { get => @"Data Source=localhost; Initial Catalog=Empresa_DB;Integrated Security=True"; }





        public static Empleado CargarEmpleadoXid(Empleado emp)
        {
            Empleado auxEmpleado = null;

            try
            {
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM Empleados      WHERE ID = @id;";

                command.Parameters.AddWithValue("@id", emp.Id);

                connection.Open();
                command.ExecuteNonQuery();

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["ID"].ToString());
                    string nombre = dataReader["NOMBRE"].ToString();
                    string apellido = dataReader["APELLIDO"].ToString();
                    string sexo = dataReader["SEXO"].ToString();
                    DateTime fechaIngerso = Convert.ToDateTime(dataReader["FECHA_INGRESO"].ToString());
                    int puesto = int.Parse(dataReader["ID_PUESTO"].ToString());
                    bool estado = bool.Parse(dataReader["ESTADO"].ToString());

                    Puesto descPuesto = Extencion.ConvertirPuesto(puesto);

                    auxEmpleado = new Empleado(id, nombre, apellido, sexo, fechaIngerso, descPuesto.Descripcion, puesto, estado);
                }

                if (auxEmpleado is not null)
                {
                    return auxEmpleado;
                }
                else
                {
                    throw new EmpleadoExcepcion("No se encuentra el jugador elegido");
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



        /// <summary>
        /// Muestra todos los jugadores de la db indicando su estado (activo/inactivo)
        /// </summary>
        /// <param name="indicar"></param>
        /// <returns></returns>
        public static List<Empleado> CargarEmpleados(int indicar)
        {
            List<Empleado> list = new List<Empleado>();
            //Puesto auxPuesto = null;

            try
            {
                command.Parameters.Clear();
                //command.CommandText = "SELECT e.ID, p.DESCRIPCION, e.NOMBRE, e.APELLIDO, e.SEXO, e.FECHA_INGRESO, e.ESTADO " +
                //                      " FROM Empleados e " +
                //                      " INNER JOIN Puestos p ON e.ID_PUESTO = p.ID " +
                //                      " WHERE ESTADO = @activo;";

                command.CommandText = "SELECT * FROM Empleados  WHERE ESTADO = @activo;";

                command.Parameters.AddWithValue("@activo", indicar);

                connection.Open();
                command.ExecuteNonQuery();

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["ID"].ToString());
                    string nombre = dataReader["NOMBRE"].ToString();
                    string apellido = dataReader["APELLIDO"].ToString();
                    string sexo = dataReader["SEXO"].ToString();
                    DateTime fechaIngerso = Convert.ToDateTime(dataReader["FECHA_INGRESO"].ToString());
                    int puesto = int.Parse(dataReader["ID_PUESTO"].ToString());
                    bool estado = bool.Parse(dataReader["ESTADO"].ToString());

                    Puesto descPuesto = Extencion.ConvertirPuesto(puesto);

                    list.Add(new Empleado(id, nombre, apellido, sexo, fechaIngerso, descPuesto.Descripcion, puesto, estado));
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


        public static bool Agregar(Empleado emp)
        {
            try
            {
                command.CommandText = $"INSERT INTO Empleados(NOMBRE, APELLIDO, SEXO, FECHA_INGRESO, ID_PUESTO, ESTADO)    VALUES(@nombre, @apellido, @sexo, @fechaIngreso, @puesto, @activo) ";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nombre", emp.Nombre);
                command.Parameters.AddWithValue("@apellido", emp.Apellido);
                command.Parameters.AddWithValue("@sexo", emp.Sexo);
                command.Parameters.AddWithValue("@fechaIngreso", emp.FechaIngreso);
                command.Parameters.AddWithValue("@puesto", emp.ID_Puesto);
                command.Parameters.AddWithValue("@activo", emp.Estado);

                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Debe ingresar un Empleado valido");
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



        public static bool Modificar(Empleado emp)
        {
            try
            {
                if (CargarEmpleadoXid(emp) is not null)
                {
                    command.Parameters.Clear();

                    command.CommandText = $"UPDATE Empleados SET NOMBRE = @nombre, APELLIDO = @apellido, SEXO = @sexo, ID_PUESTO = @puesto " +
                                          $"WHERE ID = @id";

                    command.Parameters.AddWithValue("@id", emp.Id);
                    command.Parameters.AddWithValue("@nombre", emp.Nombre);
                    command.Parameters.AddWithValue("@apellido", emp.Apellido);
                    command.Parameters.AddWithValue("@sexo", emp.Sexo);
                    command.Parameters.AddWithValue("@puesto", emp.ID_Puesto);

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



        public static bool Estado(Empleado emp)
        {
            try
            {
                if (CargarEmpleadoXid(emp) is not null)
                {
                    command.Parameters.Clear();
                    command.CommandText = $"UPDATE Empleados SET ESTADO = @activo   WHERE ID = @id";
                    command.Parameters.AddWithValue("@id", emp.Id);
                    command.Parameters.AddWithValue("@activo", emp.Estado);

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
