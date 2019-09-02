using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    class Fahrenheit
    {
        //F = C* (9/5) + 32
        //C = (F-32) * 5/9
        //F = K* 9/5 – 459.67
        //K = (F + 459.67) * 5/9

        private double grados;

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }
        public double GetGrados()
        {
            return grados;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            Celsius celsius;
            double gradosF=f.GetGrados();
            double gradosC = (gradosF - 32) * (5 / 9);

            celsius = new Celsius(gradosC);

            return celsius;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            Kelvin kelvin;
            double gradosF = f.GetGrados();
            double gradosK = (gradosF + 459.67) * (5 / 9);

            kelvin = new Kelvin(gradosK);

            return kelvin;
        }

        public static implicit operator Fahrenheit(double f)
        {
            Fahrenheit fahrenheit = new Fahrenheit(f);

            return fahrenheit;
        }
    }

    class Kelvin
    {
        private double grados;

        public Kelvin(double grados)
        {
            this.grados = grados;
        }
        public double GetGrados()
        {
            return grados;
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            Fahrenheit fahrenheit;

            double gradosK = k.GetGrados();
            double gradosF = (gradosK * (9 / 5)) - 459.67;

            fahrenheit = new Fahrenheit(gradosF);

            return fahrenheit;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            Fahrenheit fahrenheit = (Fahrenheit)k;
            Celsius celsius = (Celsius)fahrenheit;

            return celsius;
        }

        public static implicit operator Kelvin(double k)
        {
            Kelvin kelvin = new Kelvin(k);

            return kelvin;
        }
    }

    class Celsius
    {
        private double grados;

        public Celsius(double grados)
        {
            this.grados = grados;
        }
        public double GetGrados()
        {
            return grados;
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            Fahrenheit fahrenheit;

            double gradosC = c.GetGrados();
            double gradosF = (gradosC * (9 / 5)) + 32;
            fahrenheit = new Fahrenheit(gradosF);

            return fahrenheit;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            Fahrenheit fahrenheit = (Fahrenheit)c;
            Kelvin kelvin = (Kelvin)fahrenheit;

            return kelvin;
        }


        public static implicit operator Celsius(double c)
        {
            Celsius celsius = new Celsius(c);

            return celsius;
        }


    }
}
