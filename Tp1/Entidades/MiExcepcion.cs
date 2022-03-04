using System;


namespace Entidades
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string msj)
        : this(msj, null)
        {

        }

        public MiExcepcion(string msj, Exception inner)
        : base(msj, inner)
        {

        }

    }
}
