using System;
using System.Text;

namespace Biblioteca
{
    public class Empleado
    {
        private int id;
        private string nombre;
        private string apellido;
        private string sexo;
        private DateTime fechaIngreso;
        private Puesto puesto;
        private bool estado;





        public Empleado(string nombre, string apellido, string sexo, DateTime fechaIngreso, Puesto puesto, bool estado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.fechaIngreso = fechaIngreso;
            this.puesto = puesto;
            this.estado = estado;
        }


        public Empleado(int id, string nombre, string apellido, string sexo, DateTime fechaIngreso, Puesto puesto, bool estado)
        : this(nombre, apellido, sexo, fechaIngreso, puesto, estado)
        {
            this.id = id;
        }






        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public Puesto Puesto { get => puesto; set => puesto = value; }
        public bool Estado { get => estado; set => estado = value; }



        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine($"\n****************");
            sb.AppendLine($"ID:{Id}");
            sb.AppendLine($"Puesto: {Puesto}");
            sb.AppendLine($"{Nombre}");
            sb.AppendLine($"{Apellido}");
            sb.AppendLine($"{Sexo}");
            sb.AppendLine($"{FechaIngreso.ToShortDateString()}");
            sb.AppendLine($"****************");

            return sb.ToString();
        }



        public static bool operator ==(Empleado e1, Empleado e2)
        {
            if (e1 is not null && e2 is not null)
            {
                return e1.id == e2.id;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }


        public override bool Equals(object obj)
        {
            Empleado emp = obj as Empleado;
            return emp != null && this == emp;
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
