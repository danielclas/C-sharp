using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Practice
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private DateTime nacimiento;

        public int Edad { get { return this.edad; } set { this.edad = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public DateTime Nacimiento { get { return this.nacimiento; } set { this.nacimiento = value; } }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, int edad, DateTime nacimiento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Nacimiento = nacimiento;
        }

        public override string ToString()
        {
            return $"{apellido}, {nombre}. {edad}, {nacimiento}";
        }

    }
}
