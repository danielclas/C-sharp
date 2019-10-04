using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Animal
    {
        public enum Razas
        {
            Galgo, OverjeroAleman
        }

        private static int patas;
        private Razas raza;

        public string MostrarPerro()
        {
            return ($"{base.MostrarDatos()}\nRaza: {this.raza} Patas: {Perro.patas}");
        }
        static Perro()
        {
            Perro.patas = 4;
        }

        public Perro(int velocidadMaxima) : base(Perro.patas, velocidadMaxima)
        {

        }

        public Perro(Razas raza, int velocidadMaxima) : this(velocidadMaxima)
        {
            this.raza = raza;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return (p1.VelocidadMaxima == p2.VelocidadMaxima && p1.raza == p2.raza);
        }
    }
}
