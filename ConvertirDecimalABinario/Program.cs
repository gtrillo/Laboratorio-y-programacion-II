using System;

namespace Clase2_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1010;
            int numeroDecimal;
            
            numeroDecimal = Conversor.ConvertirBinarioDecimal(numero);

            Console.Write(numeroDecimal);
        }
    }
}
