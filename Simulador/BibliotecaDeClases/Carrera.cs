using System;

namespace BibliotecaDeClases
{
    public class Carrera : ICalificacion
    {
        string nombre; // no modificar linea

        // no modificar metodo
        public Carrera(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; } // no modificar linea

        public decimal ClasificacionFinal
        {
            get
            {
                return GeneradorDeDatos.Rnd.Next(1, 11);
            }
        }


        //completar
        public override string ToString()
        {
            return this.nombre + " - " + "Puntaje del curso: " + ClasificacionFinal.ToString();
        }
    }
}
