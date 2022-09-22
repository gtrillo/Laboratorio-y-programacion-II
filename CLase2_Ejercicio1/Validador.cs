using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio1
{
    internal class Validador
    {
        public static bool Validar(int valor, int minimo, int maximo)
        {
            bool retorno = false;
            if (valor >= minimo && valor <= maximo)
            {
                return true;
            }
            return retorno;
        }
    }
}
