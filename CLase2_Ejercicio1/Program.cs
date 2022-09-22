using System;

namespace Clase2_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cantidadNumeros = 5;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int acumulador = 0;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100:");
                numero = int.Parse(Console.ReadLine());
                while (!Validador.Validar(numero, -100, 100))
                {
                    Console.WriteLine("ERROR ! Ingrese un numero entre -100 y 100:");
                    numero = int.Parse(Console.ReadLine());
                }

                if (numero > maximo)
                {
                    maximo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }

                acumulador += numero;

            }

            Console.WriteLine("el menor numero ingresado es " + minimo);
            Console.WriteLine("el maximo numero ingresado es " + maximo);
            Console.WriteLine("el promedio es " + acumulador / cantidadNumeros);
        }
    }
}
