using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro("Loli", "Beagle");
            Perro p2 = new Perro("Lola", "Labrador");
            Perro p3 = new Perro("Lolo", "Pitbull", 10, true);

            Gato g1 = new Gato("Juan", "Siames");
            Gato g2 = new Gato("Juana", "Raza");

            Grupo grupo = new Grupo("Manada", Grupo.TipoManada.Mixta);

            Console.WriteLine("\nMuestro datos de p1: \n");
            Console.WriteLine(p1.ToString());

            Console.WriteLine("\nMuestro datos de p3: \n");
            Console.WriteLine(p3.ToString());

            Console.WriteLine("\nMuestro datos de g1: \n");
            Console.WriteLine(g1.ToString());

            Console.WriteLine("Agrego perros al grupo...\n");

            grupo += p1;
            grupo += p2;
            grupo += p2;
            grupo += p3;

            Console.WriteLine("Tres perros agregados, imprimo datos de grupo: \n");
            Console.WriteLine(grupo);

            Console.WriteLine("Agrego gatos al grupo...\n");

            grupo += g1;
            grupo += g1;
            grupo += g2;

            Console.WriteLine("Dos gatos agregados, imprimo datos de grupo: \n");
            Console.WriteLine(grupo);

            Console.WriteLine("Resto p1 y g1 del grupo: \n");

            grupo -= p1;
            grupo -= g1;

            Console.WriteLine(grupo);         

            Console.ReadKey();
        }
    }
}
