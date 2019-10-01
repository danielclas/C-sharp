using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {

        private string nombre;
        private string raza;

        public string Nombre { get { return this.nombre; } }
        public string Raza { get { return this.raza; }  }

        protected virtual string DatosCompletos()
        {
            return String.Format($"Nombre: {this.Nombre} Raza: {this.Raza}");
        }

        protected abstract string Ficha();
        
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
    }
}
