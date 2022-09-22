using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Clase7_Entidades
{
    enum Puesto
    {
        caja1,
        caja2,
    }
    internal class PuestoDeAtencion
    {
        private static int numeroActual;
        private Puesto puesto;


         static PuestoDeAtencion()
        {
            numeroActual = 0;
        }

        public PuestoDeAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get { return numeroActual=numeroActual + 1; }
        }

        public bool Atenter(Cliente cli)
        {
            bool retorno = false;

            Thread.Sleep(2000);
            retorno = true;

            return retorno;
        }


    }

    
}
