using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Clase2_Ejercicio3.Conversor;
namespace Clase4_Entidades
{
    internal class NumeroBinario
    {
        private string numero;

        public NumeroBinario (string numero)
        {
            this.numero = numero;
        }

        public string Numero
        {
            get { return numero; }
        }


        public static int ConvertirBinarioDecimal(string numeroEntero)
        {
            int contadorExponente = 0;
            int acumulador = 0;
            int caracterInt;
            foreach (char caracter in numeroEntero.Reverse())
            {
                caracterInt = int.Parse(caracter.ToString());
                acumulador += (int)(caracterInt * Math.Pow(2, contadorExponente));
                contadorExponente++;
            }
            return (int)acumulador;
        }


        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static implicit operator NumeroDecimal(NumeroBinario numeroBinario)
        {
            return (NumeroDecimal)NumeroBinario.ConvertirBinarioDecimal(numeroBinario.Numero);
        }

        public static bool operator + (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.ConvertirDecimalBinario((NumeroDecimal)numeroBinario.Numero + numeroDecimal.Numero);
        }

    }
} 
