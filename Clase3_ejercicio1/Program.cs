using System;
using Entidades;
namespace Clase3_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Gonzalo", 100);
            cuenta1.Mostrar();
            cuenta1.Ingresar(230);
            cuenta1.Ingresar(-12);
            Console.WriteLine(cuenta1.Mostrar());
            cuenta1.Retirar(12359);
            Console.WriteLine(cuenta1.Mostrar());
        }
    }
}
