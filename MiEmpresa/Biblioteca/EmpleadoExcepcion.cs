using System;

namespace Biblioteca
{
    public class EmpleadoExcepcion : Exception
    {
        public EmpleadoExcepcion()
        {
        }

        public EmpleadoExcepcion(string message) : base(message)
        {
        }

        public EmpleadoExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
