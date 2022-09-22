using System;
using System.Text;
namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;


        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get { return titular; }
        }

        public decimal Cantidad
        { get { return cantidad; } }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Titular: {this.titular} mosto actual en la cuenta {this.cantidad}");
            return sb.ToString();
        }


        public void Ingresar(decimal montoIngresado)
        {
            if (montoIngresado <= 0)
            {
                return;
            }
            else
            {
                this.cantidad += montoIngresado;
            }
        }


        public void Retirar(decimal montoRetirado)
        {
            if (montoRetirado <= 0)
            {
                return;
            }
            else
            {
                this.cantidad -= montoRetirado;
            }
        }



    }
}
