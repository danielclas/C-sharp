using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class Motocross:VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada { get; set; }

        public Motocross(short numero, string escuderia) : base(numero, escuderia) { }

        public Motocross(short numero, string escuderia, short cilindrada):this(numero, escuderia) { this.cilindrada = cilindrada; }        

        public string MostrarDatos()
        {

        }
        public static bool operator ==(Motocross m1, Motocross m2)
        {
            return m1.Numero == m2.Numero && m1.Escuderia == m2.Escuderia && m1.Cilindrada == m2.Cilindrada;
        }

        public static bool operator !=(Motocross m1, Motocross m2)
        {
            return !(m1 == m2);
        }
    }
}
