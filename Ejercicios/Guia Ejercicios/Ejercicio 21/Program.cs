using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 21";

            Fahrenheit f = new Fahrenheit(100);
            Celsius c = new Celsius(100);
            Kelvin k = new Kelvin(100);

            Console.WriteLine("Conv. implicitas desde double");

            f = 1000;
            c = 1000;
            k = 1000;

            Console.WriteLine($"\nF: {f.GetGrados()} C: {c.GetGrados()} K: {k.GetGrados()}\n");

            f = (Fahrenheit)c;
            Console.WriteLine($"C a F: {f.GetGrados()}");

            c = (Celsius)f;
            Console.WriteLine($"F a C: {c.GetGrados()}");

            f = (Fahrenheit)k;
            Console.WriteLine($"K a F: {f.GetGrados()}");

            k = (Kelvin)f;
            Console.WriteLine($"F a K: {k.GetGrados()}");

            c = (Celsius)k;
            Console.WriteLine($"K a C: {c.GetGrados()}");

            k = (Kelvin)c;
            Console.WriteLine($"C a K: {k.GetGrados()}");

            Console.ReadKey();
        }
    }
}
