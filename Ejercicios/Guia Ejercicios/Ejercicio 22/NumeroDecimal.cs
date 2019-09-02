using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_13;

namespace Ejercicio_22
{
    class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNumero() { return numero; }

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            double num = Conversor.BinarioDecimal(b.GetNumero());
            double result = d.GetNumero() + num;

            return result;
        }        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            double num = Conversor.BinarioDecimal(b.GetNumero());
            double result = d.GetNumero() - num;

            return result;
        }        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            bool rtnVal = false;
            double num = Conversor.BinarioDecimal(b.GetNumero());

            if (num==d.GetNumero())
            {
                rtnVal = true;
            }

            return rtnVal;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            bool rtnVal = false;
            double num = Conversor.BinarioDecimal(b.GetNumero());

            if (num != d.GetNumero())
            {
                rtnVal = true;
            }


            return rtnVal;
        }

        public static implicit operator NumeroDecimal(double d)
        {
            NumeroDecimal num = new NumeroDecimal(d);

            return num;
        }

        public static explicit operator double(NumeroDecimal d)
        {
            double rtn = d.GetNumero();

            return rtn;
        }



    }
}
