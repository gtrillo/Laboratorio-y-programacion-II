using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Clase4_Entidades
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int cantidadProductos)
        {
            this.productos = new Producto[cantidadProductos];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos(Estante e)
        {
            return e.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < e.productos.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(e.productos[i]));
                sb.AppendLine("_____________________");
            }
            return sb.ToString();
        }

        public static bool operator == (Estante e, Producto p)
        {
            bool retorno = false;
            for(int i = 0; i < e.productos.Length; i++)
            {
                return e.productos[i] == p;
            }
            return retorno;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            bool retorno = false;
            for (int i = 0; i < e.productos.Length; i++)
            {
                return e.productos[i] != p;
            }
            return retorno;
        }

        public static bool operator + (Estante e, Producto p)
        {
            if (e != p)
            {
                for(int i = 0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }


        public static bool operator -(Estante e, Producto p)
        {
        
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            return false;
        }
    }
    
}
