using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_Entidades
{
    public class Negocio
    {
        private PuestoDeAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        
        public Negocio()
        {
            clientes = new Queue<Cliente>();
        }

        public Negocio (string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }
            set
            {
                if(clientes.Contains(value))
                {
                    clientes.Enqueue(value);
                }
            }
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if(n!=c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator == (Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    return true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }


        public static bool operator ~(Negocio n)
        {
            bool retorno = false;

            while (n.clientes.Count > 0)
            {
                n.caja.Atenter(n.Cliente);
            }
            return retorno;
        }

    }
}
