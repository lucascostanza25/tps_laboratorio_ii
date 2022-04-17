using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el operando sea correcto
        /// </summary>
        /// <param name="operadorRecibido"></param>
        /// <returns>Retorna el operando recibido validado o + en caso contrario</returns>
        private static char ValidarOperando(char operadorRecibido)
        {
            if(operadorRecibido=='+' || operadorRecibido=='-' || operadorRecibido=='*' || operadorRecibido=='/')
            {
                return operadorRecibido;
            }
            else
            {
                return '+';
            }
        }

        /// <summary>
        /// Realiza las operaciones solicitadas
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operadorRecibido"></param>
        /// <returns>Retorna el valor de la operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operadorRecibido)
        {
            double resultado = 0;

            switch(ValidarOperando(operadorRecibido))
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
    }
}
