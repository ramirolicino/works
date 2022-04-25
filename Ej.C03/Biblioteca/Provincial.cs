using System;
using System.Text;

namespace Biblioteca
{
    public class Provincial : Llamada
    {
        public enum Franja
        { Franja_1, Franja_2, Franja_3 }

        protected Franja franjaHoraria;


        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override float CostoLLamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            if (Franja.Franja_1 == this.franjaHoraria)
            {
                return (float)120;
            }

            else if (Franja.Franja_2 == this.franjaHoraria)
            {
                return (float)132.2;
            }

            else if (Franja.Franja_3 == this.franjaHoraria)
            {
                return (float)190.80;
            }
            else
            {
                return 0;
            }
        }
        protected override string MostrarLLamada()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" PROVINCIAL ");
            sb.AppendLine($"Costo: {CostoLLamada}");
            sb.AppendLine($"Franja Horaria: {this.franjaHoraria}");
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
            Provincial llamada = obj as Provincial;
            return llamada != null && this == llamada;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + numDestino.GetHashCode();
        }
    }
}
