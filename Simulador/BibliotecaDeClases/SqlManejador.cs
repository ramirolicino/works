using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public class SqlManejador
    {
        private static string conexionString;
        private static SqlCommand comando;
        private static SqlConnection conexion;



        public SqlManejador()
        {
            conexionString = @"Data Source=.\MSSQLSERVER04; Initial Catalog=SP_2D_2022_C1;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(conexionString);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }


        public int Insertar(Alumno alumno)
        {
            try
            {
                comando.Parameters.Clear();

                comando.CommandText = $"INSERT INTO Alumnos(Dni, NombreCompleto, NotaUno, NotaDos, CalificacionFinal)     VALUES (@dni, @nombreCompleto, @notaUno, @notaDos, @CalificacionFinal)";

                if (alumno.Dni >= 10000000 && alumno.Dni <= 45000000)
                {
                    comando.Parameters.AddWithValue("@dni", alumno.Dni);
                }

                if (!string.IsNullOrEmpty(alumno.NombreCompleto))
                {
                    comando.Parameters.AddWithValue("@nombreCompleto", alumno.NombreCompleto);
                }

                if (alumno.NotaPrimerParcial >= 1 && alumno.NotaPrimerParcial <= 10)
                {
                    comando.Parameters.AddWithValue("@notaUno", alumno.NotaPrimerParcial);
                }

                if (alumno.NotaSegundoParcial >= 1 && alumno.NotaSegundoParcial <= 10)
                {
                    comando.Parameters.AddWithValue("@notaDos", alumno.NotaSegundoParcial);
                }

                comando.Parameters.AddWithValue("@CalificacionFinal", alumno.ClasificacionFinal);


                conexion.Open();
                comando.ExecuteNonQuery();


                return 1;

            }
            catch (Exception)
            {
                throw new DatosNoValidosException("Error, unos de los parametros no es valido");
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
