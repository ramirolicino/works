using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Centralita
    {
        private List<Llamada> listaLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Empresa
        {
            get { return this.razonSocial; }
        }

        public float GananciasLocal
        {
            get
            {
                return (float)CalcularGanancia(Llamada.TipoLLamadas.Local);
            }
        }

        public float GananciasProvincial
        {
            get
            {
                return (float)CalcularGanancia(Llamada.TipoLLamadas.Provincial); ;
            }
        }

        public float GananciasTodas
        {
            get
            {
                return (float)CalcularGanancia(Llamada.TipoLLamadas.Todas); ;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaLlamadas;
            }
        }


        private float CalcularGanancia(Llamada.TipoLLamadas tipo)
        {
            float rta = 0;

            if (tipo is Llamada.TipoLLamadas.Local)
            {
                foreach (Llamada llamada in this.listaLlamadas)
                {
                    if (llamada.GetType() == typeof(Local))
                    {
                        rta += ((Local)llamada).CostoLLamada;
                    }
                }
            }
            else if (tipo is Llamada.TipoLLamadas.Provincial)
            {
                foreach (Llamada llamada in this.listaLlamadas)
                {
                    if (llamada.GetType() == typeof(Provincial))
                    {
                        rta += ((Provincial)llamada).CostoLLamada;
                    }
                }
            }
            else if (tipo is Llamada.TipoLLamadas.Todas)
            {
                foreach (Llamada llamada in this.listaLlamadas)
                {
                    rta = ((Local)llamada).CostoLLamada + ((Provincial)llamada).CostoLLamada;
                }
            }

            return rta;
        }


        protected string MostrarCentralita()
        {
            StringBuilder sb = new();

            foreach (Llamada llamada in this.listaLlamadas)
            {
                if (llamada.GetType() == typeof(Local))
                {
                    sb.AppendLine(((Local)llamada).ToString());
                }
                else if (llamada.GetType() == typeof(Provincial))
                {
                    sb.AppendLine(((Provincial)llamada).ToString());
                }
                else
                {
                    sb.AppendLine("NO HAY NADA...");
                }

                sb.AppendLine("RESUMEN->  \n");
                sb.AppendLine($" * {Empresa} * ");
                sb.AppendLine($"GananciaLocal: {GananciasLocal}");
                sb.AppendLine($"GananciaProv: {GananciasProvincial}");
                sb.AppendLine($"GananciaTotal: {GananciasLocal}");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarCentralita();
        }

        public void OrdenarLlamadas()
        {

        }

        private void AgregarLlamada(Llamada nuevaLLamada)
        {
            if (nuevaLLamada is not null)
            {
                listaLlamadas.Add(nuevaLLamada);
            }
        }

        //OPERADORES

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            if (c.Llamadas.Count != 0)
            {
                foreach (Llamada ll in c.Llamadas)
                {
                    if (ll == llamada)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            try
            {
                if (c == llamada)
                {
                    return c;
                }
                c.AgregarLlamada(llamada);

            }
            catch (Exception e)
            {
                throw new CentralitaException("Error", "Centralita", "+", e);
            }

            return c;

        }


        //SOBRECARGA
        public override bool Equals(Object obj)
        {
            Centralita centralita = obj as Centralita;
            return centralita != null && this == centralita;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
