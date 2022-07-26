using System;

namespace BibliotecaDeClases
{
    public class Alumno : ICalificacion
    {
        #region No Modificar

        decimal dni;
        string nombreCompleto;
        decimal notaPrimerParcial;
        decimal notaSegundoParcial;

        public Alumno(decimal dni, string nombreCompleto, decimal notaPrimerParcial, decimal notaSegundoParcial)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.notaPrimerParcial = notaPrimerParcial;
            this.notaSegundoParcial = notaSegundoParcial;
        }

        public decimal Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public decimal NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public decimal NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }

        public decimal ClasificacionFinal
        {
            get
            {
                return PromedioFinal(notaPrimerParcial, notaSegundoParcial);
            }
        }

        #endregion


        //completar
        private decimal PromedioFinal(decimal n1, decimal n2)
        {
            return Decimal.Round(((n1 + n2) / 2), 2);
        }
    }
}
