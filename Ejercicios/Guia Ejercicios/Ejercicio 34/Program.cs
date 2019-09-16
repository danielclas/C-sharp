using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 34";

            Moto moto = new Moto(10, 10, Colores.Rojo, 100);
            Auto auto = new Auto(4, 5, Colores.Negro, 6, 7);
            Camion camion = new Camion(8, 3, Colores.Azul, 4, 10000);

            Console.WriteLine("Moto");
            Console.WriteLine(moto.MostrarDatos());
            Console.WriteLine("Auto");
            Console.WriteLine(auto.MostrarDatos());
            Console.WriteLine("Camion");
            Console.WriteLine(camion.MostrarDatos());

            Console.ReadKey();
        }

        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }
    }
}
