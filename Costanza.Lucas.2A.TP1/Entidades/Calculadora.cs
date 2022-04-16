using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
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
