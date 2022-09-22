using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;


        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime DateTime
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }


        public int CalcularEdad()
        {
            
           int edad = DateTime.Today.AddTicks(-this.fechaNacimiento.Ticks).Year - 1;
           return edad;
        }


        public string EsMayorDeEdad()
        {
            if(CalcularEdad() >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }
    }
    
}
