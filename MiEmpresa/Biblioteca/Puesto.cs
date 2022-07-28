namespace Biblioteca
{
    public class Puesto
    {
        private int id;
        private string descripcion;

        public Puesto(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }



        public static bool operator ==(Puesto p1, Puesto p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return p1.id == p2.id;
            }

            return false;
        }

        public static bool operator !=(Puesto p1, Puesto p2)
        {
            return !(p1 == p2);
        }



        public override bool Equals(object obj)
        {
            Puesto p = obj as Puesto;
            return p != null && this == p;
        }

        /// <summary>
        /// Rescritura del metodo GetHashCode()
        /// </summary>
        /// <returns>Devuelve el hashcode de la identificacion del bovino</returns>
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

    }
}
