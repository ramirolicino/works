using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public enum TipoLLamadas
        { Local, Provincial, Todas }

        public abstract float CostoLLamada { get; }

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string numDestino
        {
            get { return this.nroDestino; }
        }

        public string numOrigen
        {
            get { return this.nroOrigen; }
        }

        protected virtual string MostrarLLamada()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" LLAMADA \n");
            sb.AppendLine($"Duracion: {this.duracion}");
            sb.AppendLine($"nro_Destino: {this.nroDestino}");
            sb.AppendLine($"nro_Origen: {this.nroOrigen}");

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            return l1.duracion.CompareTo(l2.duracion); //Ascendente
        }

        //OPERADORES
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.numDestino == l2.numDestino && l1.numOrigen == l2.numOrigen; 
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2); 
        }


        //SOBRECARGA

        public override bool Equals(Object obj)
        {
            Llamada llamada = obj as Llamada;
            return llamada != null && this == llamada;
        }

        public override int GetHashCode()
        {
            return numDestino.GetHashCode() + GetType().GetHashCode() + numOrigen.GetHashCode();
        }

    }
}
