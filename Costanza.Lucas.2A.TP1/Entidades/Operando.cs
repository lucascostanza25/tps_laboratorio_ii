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

        public string SetNumero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        private double ValidarOperando(string strNumero)
        {
            double numeroParseado;
            bool estado;
            estado = double.TryParse(strNumero, out numeroParseado);

            if(!estado)
            {
                numeroParseado = 0;
            }

            return numeroParseado;
        }

        public static double operator +(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            double resultado;

            if(n2.numero!=0)
            {
                resultado = n1.numero + n2.numero;
            }
            else
            {
                resultado = double.MinValue;
            }

            return resultado;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }
    }
}
