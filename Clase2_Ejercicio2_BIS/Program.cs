using System;
namespace Clase2_Ejercicio2_BIS
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Sello.mensaje = "hola mundo";


            Sello.Imprimir();//retorna string}
            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();

            Sello.Imprimir();//retorna string
            Console.WriteLine(Sello.Imprimir());

            Sello.mensaje = "hola mundo C#";

            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Sello.Imprimir();//retorna string
            Console.WriteLine(Sello.Imprimir());
        }

    }
}
