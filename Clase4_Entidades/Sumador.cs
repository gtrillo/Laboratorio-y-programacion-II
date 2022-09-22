using System;

namespace Clase4_Entidades
{
    public class Sumador
    {
        private int cantidadSumas;


        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador():this(0)
        {

        }
        public long Sumar(long a, long b)
        {
            long resultado;
            cantidadSumas++;
            resultado = a + b;
            return resultado;
        }

        public string Sumar (string a, string b)
        {
            return a + " " + b;
        }
    }
}
