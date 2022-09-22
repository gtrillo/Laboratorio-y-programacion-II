using System;

namespace Clase2_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textoIngresado;
            double numero1;
            double numero2;
            double resultado;
            string operacion;


            Console.WriteLine("Ingrese un numero:");
            textoIngresado = Console.ReadLine();
            while (!double.TryParse(textoIngresado, out numero1))
            {
                Console.WriteLine("Error, ingrese un numero");
                textoIngresado = Console.ReadLine();
            }

            Console.WriteLine("Ingrese otro numero:");
            textoIngresado = Console.ReadLine();
            while (!double.TryParse(textoIngresado, out numero2))
            {
                Console.WriteLine("Error, ingrese un numero");
                textoIngresado = Console.ReadLine();
            }

            Console.WriteLine("Ingrese operacion:");
            operacion = Console.ReadLine();
            while (operacion != "+" && operacion != "-" && operacion != "/" && operacion != "*")
            {
                Console.WriteLine("Error, Ingrese un tipo de operador valido + - * /");
                operacion = Console.ReadLine();
            }

            resultado = Calculadora.Calcular(numero1,numero2, operacion);
            Console.WriteLine("El resultado es{0}: ", resultado);
        }
    }
}
