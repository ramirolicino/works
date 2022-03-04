using System;

namespace Entidades
{
    public static class Calculadora
    {
        //Metodos
        /// <summary>
        /// Segun el operador ingresado realiza el calculo 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operando"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operando)
        {
            double resultado = 0;

            switch (ValidarOperando(operando))
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                case '/':
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }

        private static char ValidarOperando(char operando)
        {
            if (operando != '+' && operando != '-' && operando != '*' && operando != '/')
            {
                return '+';
            }
            return operando;
        }
    }
}
