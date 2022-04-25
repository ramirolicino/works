using System;
using System.Text;

namespace Biblioteca
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo)
        : base(duracion, destino, origen)
        {
            this.costo = costo;
        }


        public override float CostoLLamada
        {
            get { return CalcularCosto(); }   
        }



        private float CalcularCosto()
        {
            return (float)this.costo;
        }

        protected override string MostrarLLamada()
        {
            StringBuilder sb = new();

            sb.AppendLine(" LOCAL ");
            sb.AppendLine($"Costo: {CostoLLamada}");
            sb.AppendLine($"{base.MostrarLLamada()}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarLLamada();
        }


        //SOBRECARGA
        public override bool Equals(Object obj)
        {
            Local llamada = obj as Local;
            return llamada != null && this == llamada;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + numDestino.GetHashCode();
        }
    }
}
