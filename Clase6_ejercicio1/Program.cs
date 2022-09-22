using System;
using System.Collections.Generic;
namespace Clase6_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumerosLocos = new int[20];
            Random rnd = new Random();
            for (int i = 0; i <arrayNumerosLocos.Length; i++)
            {
               arrayNumerosLocos[i] = rnd.Next(-100, 100);
            }
            Console.WriteLine("MUESTRO EL ARRAY EN EL ORDEN EN EL QUE FUE INGRESADO");
            for (int i = 0; i <arrayNumerosLocos.Length; i++)
            {
                Console.WriteLine(arrayNumerosLocos[i]);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("MUESTRO EL ARRAY ORDENADO DE MENOR A MAYOR");
            Array.Sort(arrayNumerosLocos);
            for (int i = 0; i < arrayNumerosLocos.Length; i++)
            {
                Console.WriteLine(arrayNumerosLocos[i]);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("MUESTRO EL ARRAY ORDENADO DE MAYOR A MENOR");
            Array.Reverse(arrayNumerosLocos);
            for (int i = 0; i < arrayNumerosLocos.Length; i++)
            {
                Console.WriteLine(arrayNumerosLocos[i]);
            }
        }
    }
}
