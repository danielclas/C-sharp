using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(10, "Boca");
            Jugador j = new Jugador(39328065, "Daniel Clas", 20, 50);
            Jugador j2 = new Jugador(39328065, "Juan Carlos", 30, 30);
            Jugador j3 = new Jugador(38989222, "Jorge Luis", 10, 100);

            if (equipo+j)
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

            j.GetPromedioGoles();
            j2.GetPromedioGoles();
            j3.GetPromedioGoles();

            Console.WriteLine(j.mostrarDatos());
            Console.WriteLine(j2.mostrarDatos());
            Console.WriteLine(j3.mostrarDatos());

            Console.ReadKey();

        }
    }
}
