

namespace Entidades
{
    public class Serie
    {
        private string genero;
        private string nombre;

        public Serie()
        {

        }

        public Serie(string genero, string nombre)
        {
            this.genero = genero;
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; }

        public override string ToString()
        {
            return $"{nombre}   {genero}"; 
        }
    }
}
