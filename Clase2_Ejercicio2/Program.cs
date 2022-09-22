using System;

namespace Clase2_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoIngresado;
            int numero;
            int acumulador = 0;
            char respuesta;
            do
            {
                Console.WriteLine("Ingrese un numero:");
                textoIngresado = Console.ReadLine();
                while (!int.TryParse(textoIngresado, out numero))
                {
                    Console.WriteLine("Error, ingrese un numero");
                    textoIngresado = Console.ReadLine();
                }
                acumulador+=numero;
                Console.WriteLine("Desea ingresar otro numero? precione s para confirmar");
                respuesta = char.Parse(Console.ReadLine());//preguntar al profe
            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine("La suma es: {0}",acumulador);
        }
    }
}
