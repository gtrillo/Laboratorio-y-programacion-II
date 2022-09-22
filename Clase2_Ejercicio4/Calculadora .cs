using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio4
{
    internal class Calculadora
    {
        public static double Calcular (double operando1, double operando2, string operacion)
        {
            double resultado=0;
            switch(operacion)
            {
                case "+":
                    resultado = operando1 + operando2;
                break;
                case "-":
                    resultado = operando1 - operando2;
                break;
                case "*":
                    resultado = operando1 * operando2;
                break;
                case "/":
                    if(!Validar(operando2))
                    {
                        resultado = operando1 / operando2;
                    }
                    else
                    {
                        Console.WriteLine("error no es posible la divición por 0");
                    }
                break;
            }
            return resultado;   
        }

        public static bool Validar (double segundoOperando)
        {
            bool retorno = false;

            if(segundoOperando != 0)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
