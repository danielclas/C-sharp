using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayuda_Parcial
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public int Dni { get { return this.dni; } set { this.dni = value; } }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }

        public override string ToString()
        {
            return $"{Apellido}, {Nombre}. DNI: {Dni}";
        }
    }
}
