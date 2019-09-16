using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 35";

            Equipo equipo = new Equipo(10, "Boca");
            Jugador j = new Jugador(39328065, "Daniel Clas", 20, 50);
            Jugador j2 = new Jugador(39328065, "Juan Carlos", 30, 30);
            Jugador j3 = new Jugador(38989222, "Jorge Luis", 10, 100);
            DT d1 = new DT("Basile", new DateTime(1980, 2, 10));
            DT d2= new DT("Bielsa", new DateTime(1980, 2, 10));

            if (equipo + j)
            {
                Console.WriteLine("Pudo agregarse el primer jugador");
            }
            else
            {
                Console.WriteLine("No pudo agregar el primer jugador");
            }

            if (equipo + j2)
            {
                Console.WriteLine("Pudo agregarse el segundo jugador");
            }
            else
            {
                Console.WriteLine("No pudo agregar el segundo jugador");
            }

            if (equipo + j3)
            {
                Console.WriteLine("Pudo agregarse el tercer jugador");
            }
            else
            {
                Console.WriteLine("No pudo agregar el tercer jugador");
            }

            Console.WriteLine("\nPromedio J1: {0}", j.PromedioGoles);
            Console.WriteLine("Promedio J2: {0}", j2.PromedioGoles);
            Console.WriteLine("Promedio J3: {0}\n", j3.PromedioGoles);

            Console.WriteLine(j.MostrarDatos());
            Console.WriteLine(j2.MostrarDatos());
            Console.WriteLine(j3.MostrarDatos());

            Console.WriteLine("\nTecnicos: ");
            Console.WriteLine(d1.MostrarDatos());
            Console.WriteLine(d2.MostrarDatos());

            Console.WriteLine($"D1 y D2 son iguales? {d1==d2}");

            Console.ReadKey();
        }
    }
}
