using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Mor�n", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lan�s", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se ir�n registrando en la Centralita.
            // La centralita mostrar� por pantalla todas las llamadas seg�n las vaya registrando.
            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());
            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
        }
    }
}
