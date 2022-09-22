using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio2
{
    internal class Validador
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            bool retorno = false;

            if(respuesta == 's')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
