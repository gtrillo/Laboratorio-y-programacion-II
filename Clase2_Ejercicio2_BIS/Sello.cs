using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio2_BIS
{
    internal class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Sello.Imprimir();
        }

        public static string ArmarFormatoMensaje ()
        {
            int acumulador=0;
            foreach(var item in Sello.mensaje)
            {
                acumulador += item;
            }
        }
    }
}
