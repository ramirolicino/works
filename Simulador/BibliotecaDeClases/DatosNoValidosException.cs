using System;
using System.Runtime.Serialization;

namespace BibliotecaDeClases
{
    public class DatosNoValidosException : Exception
    {
        public DatosNoValidosException(string message) : base(message)
        {

        }
    }
}
