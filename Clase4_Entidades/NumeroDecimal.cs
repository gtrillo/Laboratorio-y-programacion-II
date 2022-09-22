using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_Entidades
{
    internal class NumeroDecimal
    {
        private double numero;

        public NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero
        {
            get { return numero; }
        }


        public static string ConvertirDecimalBinario(double numeroEntero)
        {
            double binario = 0;
            const int DIVISOR = 2;
            double digito = 0;
            for (double i = numeroEntero % DIVISOR, j = 0; numeroEntero > 0; numeroEntero /= DIVISOR, i = numeroEntero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                binario += digito * (long)Math.Pow(10, j);
            }
            return binario.ToString();
        }
        
        public static explicit operator NumeroDecimal (double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static implicit operator NumeroBinario (NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)NumeroDecimal.ConvertirDecimalBinario(numeroDecimal.Numero);
        }
    }   
}
