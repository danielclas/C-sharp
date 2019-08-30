using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas = 0;

        public Sumador() : this(0)
        {

        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador a)
        {
            return a.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool rtn = false;

            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                rtn = true;
            }

            return rtn;
        }
    }
}
