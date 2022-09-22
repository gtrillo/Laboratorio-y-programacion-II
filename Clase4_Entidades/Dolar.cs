using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_Entidades
{
    public class Dolar
    {
        private double cantidad;
        static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public double GetCantidad
        {
            get { return this.cantidad; }
        }

        public static double CotzRespectoDolar
        {
            get { return Dolar.cotzRespectoDolar; }
        }

        /*public static explicit operator Dolar()
        {

        }*/

        public static implicit operator Dolar(double dolar)
        {
            return new Dolar(dolar);
        }

            

    }
}
