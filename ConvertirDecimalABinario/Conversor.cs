using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio3
{
    internal class Conversor
    {
        public static string ConvertirDecimalBinario(int numeroEntero)
        {
            long binario = 0;
            const int DIVISOR = 2;
            long digito = 0;
            for (int i = numeroEntero % DIVISOR, j = 0; numeroEntero > 0; numeroEntero /= DIVISOR, i = numeroEntero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                binario += digito * (long)Math.Pow(10, j);
            }
            return binario.ToString();
        }

        public static int ConvertirBinarioDecimal(int numeroEntero)
        {
            string numeroString = numeroEntero.ToString();
            int contadorExponente = 0;
            int acumulador = 0;
            int caracterInt;
            foreach(char caracter in numeroString.Reverse())
            {
                caracterInt = int.Parse(caracter.ToString());
                acumulador += (int)(caracterInt * Math.Pow(2,contadorExponente));
                contadorExponente++;
            }
            return (int)acumulador;
        }


    }
}
