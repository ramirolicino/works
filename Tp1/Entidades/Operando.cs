using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;


        //CONSTRUCTORES
        public Operando()
        {
            numero = 0;
        }

        public Operando(double numero)
            : this()
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
            : this()
        {
            this.Numero = strNumero;
        }


        //PROPIEDAD
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }


        ////METODOS

        /// <summary>
        /// Pasaje de bin a dec
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            //int numeroDecimal = 0;
            double numeroDecimal = 0;
            int cantCaracteres = binario.Length;

            if (EsBinario(binario))
            {

                foreach (char caracter in binario)
                {
                    cantCaracteres--;
                    if (caracter == '1')
                    {
                        numeroDecimal += (int)Math.Pow(2, cantCaracteres);
                    }
                }

                return numeroDecimal.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }


        /// <summary>
        /// Pasaje de dec a bin
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string ValorBin = string.Empty;
            int resultDiv = (int)numero;
            int restoDiv;

            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    ValorBin = restoDiv.ToString() + ValorBin;

                } while (resultDiv > 0);
            }

            return ValorBin;
        }


        /// <summary>
        /// Pasaje de dec (string) a bin 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero, out double num))
            {
                return DecimalBinario(num);
            }
            else
            {
                return "Valor inválido";
            }
        }

        /// <summary>
        /// Comprueba si es bin
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public bool EsBinario(string binario)
        {
            foreach (char caracter in binario)
            {
                if (caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }

            return true;
        }


        private double ValidarOperando(string strNumero)
        {
            if (double.TryParse(strNumero, out double numero))
            {
                return numero;
            }
            else
            {
                return 0;
            }
        }



        //OPERANDO
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator /(Operando num1, Operando num2)
        {
            try
            {
                return num1.numero / num2.numero;
            }
            catch (DivideByZeroException e)
            {
                throw new MiExcepcion("No se puede dividir x cero", e);
            }
        }
    }
}
