using System;
using System.Text;
namespace Clase5_Entidades
{
    public class Ingresante
    {
        private string cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;


        public Ingresante(string cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }
    
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"Direccion: {this.direccion}");
            stringBuilder.AppendLine($"Edad: {this.edad}");
            stringBuilder.AppendLine($"Genero: {this.genero}");
            stringBuilder.AppendLine($"País: {this.pais}");
            stringBuilder.AppendLine($"Cursos: {this.cursos}");

            return stringBuilder.ToString();
        }


    }
}
