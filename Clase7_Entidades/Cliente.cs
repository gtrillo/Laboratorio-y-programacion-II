using System;

namespace Clase7_Entidades
{
    public class Cliente
    {
        public string nombre;
        public int numero;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Numero
        {
            get { return numero; }
        }


        public Cliente (int numero)
        {
            this.numero = numero;
        }


        public Cliente (int numero, string nombre):this (numero)
        {
            this.nombre = nombre;
        }


        public static bool operator == (Cliente cliente1, Cliente cliente2)
        {
            return cliente1.Numero == cliente2.Numero;
        }

        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1.Numero == cliente2.Numero);
        }


    }
}
