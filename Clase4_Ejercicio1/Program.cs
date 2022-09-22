using System;
using Clase4_Entidades;
namespace Clase4_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();


            Console.WriteLine(sumador1.Sumar(1, 2));
            Console.WriteLine(sumador1.Sumar("Brisa", "Te amo"));
        }
    }
}
