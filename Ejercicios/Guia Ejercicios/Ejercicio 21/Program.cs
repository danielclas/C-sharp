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

            Console.WriteLine($"Metodo GetGrados - F: {f.GetGrados()} - C: {c.GetGrados()} - K: {k.GetGrados()}\n");
            Console.WriteLine("Conv. implicitas desde double");

            f = 1000;
            c = 1000;
            k = 1000;

            Console.WriteLine($"\nF: {f.GetGrados()} C: {c.GetGrados()} K: {k.GetGrados()}");

            Console.WriteLine("\nConv. explicitas\n");

            Fahrenheit f2 = (Fahrenheit)c;
            Kelvin k2 = (Kelvin)c;

            Console.WriteLine($"Celsius a Fahrenheit {f2.GetGrados()} y Kelvin {k2.GetGrados()}");

            Celsius c2 = (Celsius)f;
            k2 = (Kelvin)f;

            Console.WriteLine($"\nFahrenheit a Celsius {c2.GetGrados()} y Kelvin {k2.GetGrados()}");

            k2 = 1000;
            c2 = (Celsius)k2;
            f2 = (Fahrenheit)k2;

            Console.WriteLine($"\nKelvin a Fahrenheit {f2.GetGrados()} y Celsius {c2.GetGrados()}");                       

            Console.ReadKey();
        }
    }
}
