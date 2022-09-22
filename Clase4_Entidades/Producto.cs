using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_Entidades
{
    public class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;


        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            string codigos = codigo;
            this.precio = precio;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"codigo de barras: {p.codigoDeBarras}, marca: {p.GetMarca()}, precio {p.GetPrecio()}");
            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return (string)p.codigoDeBarras;
        }

        public static bool operator == (Producto p1, Producto p2)
        {
            return p2.codigoDeBarras == p1.marca;
        }


        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p2.codigoDeBarras == p1.marca);
        }


        public static bool operator ==(Producto p1, string cadena)
        {
            return cadena == p1.marca;
        }


        public static bool operator !=(Producto p1, string cadena)
        {
            return !(cadena == p1.marca);
        }

    }
}
