using System;

namespace Entidades
{
    public class BacklogException : Exception
    {
        public BacklogException(string msj)
            : base(msj, null) { }

        public BacklogException(string msj, Exception inner)
            : base(msj, inner) { }
    }
}
