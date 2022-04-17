using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        /// <summary>
        /// Atributo que setea el valor a numero validado
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }
        /// <summary>
        /// Constructor base
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Sobrecargar del constructor 
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Sobrecarga del constructor que convierte el string en numero
        /// </summary>
        /// <param name="strNumero">Numero en tipo string</param>
        public Operando(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        /// <summary>
        /// Valida sin el oprando es un numero y si se pudo parsear, de caso contrario retornara 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retorna el numero validado o 0</returns>
        private double ValidarOperando(string strNumero)
        {
            double numeroParseado;
            bool estado;
            estado = double.TryParse(strNumero, out numeroParseado);

            if (!estado)
            {
                numeroParseado = 0;
            }

            return numeroParseado;
        }
        /// <summary>
        /// Sobrecarga del operador suma
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>Retorna el resultado de la suma</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }
        /// <summary>
        /// Sobrecarga del operador multiplicacion
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>Retorna el resultado de la multiplicacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }
        /// <summary>
        /// Sobrecarga del operador division
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>Retorna el resultado de la division</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double resultado;

            if (n2.numero != 0)
            {
                resultado = n1.numero / n2.numero;
            }
            else
            {
                resultado = double.MinValue;
            }

            return resultado;
        }
        /// <summary>
        /// Sobrecarga del operador resta
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>Retorna el resultado de la resta</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }

        private bool EsBinario(string binario)
        {
            for(int i=0; i<binario.Length; i++)
            {
                if(binario[i]!='0' && binario[i]!='1')
                {
                    return false;
                }
            }

            return true;
        }

        public string BinarioDecimal(string binario)
        {
            if(EsBinario(binario))
            {
                double resultado = Convert.ToInt32(binario, 2);
                return resultado.ToString();
            }

            return "Valor invalido";
        }

        public string DecimalBinario(double numero)
        {
            double auxNumero = Math.Abs(numero);
            string binario = "";

            if(auxNumero>0)
            {
                while(auxNumero>0)
                {
                    binario = auxNumero % 2 + binario;
                    auxNumero = auxNumero / 2;
                }

                return binario;
            }

            return "Valor invalido";
        }

        public string DecimalBinario(string numero)
        {
            double.TryParse(numero, out double numeroParseado);
            return DecimalBinario(numeroParseado);
        }
    }
}
