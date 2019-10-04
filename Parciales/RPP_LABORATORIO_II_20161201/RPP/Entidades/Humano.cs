using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Humano : Animal
    {
        private string apellido;
        private string nombre;
        private static int piernas;

        static Humano()
        {
            Humano.piernas = 4;
        }
        public Humano(int velocidadMaxima) : base(Humano.piernas, velocidadMaxima)
        {

        }

        public Humano(string nombre, string apellido, int velocidadMaxima) : this(velocidadMaxima)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string MostrarHumano()
        {
            return ($"{base.MostrarDatos()}\nNombre: {this.apellido}, {this.nombre}");
        }

        public static bool operator ==(Humano h1, Humano h2)
        {
            return (h1.nombre == h2.nombre && h1.apellido == h2.apellido);
        }

        public static bool operator !=(Humano h1, Humano h2)
        {
            return !(h1 == h2);
        }




    }
}
