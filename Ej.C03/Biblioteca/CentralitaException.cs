using System;

namespace Biblioteca
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;


        public CentralitaException(string msj, string nombreClase, string nombreMetodo)
        : this(msj, nombreClase, nombreMetodo,null)
        {

        }

        public CentralitaException(string msj, string nombreClase, string nombreMetodo, Exception inner)
        : base(msj, inner)
        {

        }



        //PROPIEDADES
        public string NombreClase
        {
            get { return nombreClase; }
        }

        public string NombreMetodo
        {
            get { return nombreMetodo; }
        }
    }
}
