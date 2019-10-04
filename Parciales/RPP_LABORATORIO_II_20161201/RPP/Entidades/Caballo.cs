using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : Animal
    {
        private string nombre;
        private static int patas;

        static Caballo()
        {
            Caballo.patas = 4;
        }

        public Caballo(string nombre, int velocidadMaxima):base(Caballo.patas, velocidadMaxima)
        {
            this.nombre = nombre;
        }

        public string MostrarCaballo()
        {
            return ($"{base.MostrarDatos()}\nNombre: {this.nombre} Patas:{Caballo.patas}");
        }

        public static bool operator ==(Caballo c1, Caballo c2)
        {
            return (c1.nombre == c2.nombre);
        }

        public static bool operator !=(Caballo c1, Caballo c2)
        {
            return !(c1 == c2);
        }





    }
}
