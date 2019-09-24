using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int dni;
        private int edad;

        public string Apellido { get { return this.apellido; } }
        public int Dni { get { return this.dni; } }
        public int Edad { get { return this.edad; } }
        public string Nombre { get { return this.nombre; } }

        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"{apellido},{nombre}. DNI: {dni}. Edad: {edad}");

            return str.ToString();
        }

        public Persona(string nombre, string apellido, int edad, int dni)
        {

        }

        public abstract bool ValidarAptitud();
        
    }
}
