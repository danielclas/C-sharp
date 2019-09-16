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

            /*a. Crear un enumerado Colores { Rojo, Blanco, Azul, Gris, Negro }
              b. Camión tendrá los atributos cantidadRuedas : short, cantidadPuertas : short, color : Colores,
              cantidadMarchas : short, pesoCarga : int.
              c. Automovil: cantidadRuedas : short, cantidadPuertas : short, color : Colores,
              cantidadMarchas : short, cantidadPasajeros : int.
              d. Moto: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
              e. Crearle a cada clase un constructor que reciba todos sus atributos.
              f. Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores.
              Luego generar una relación de herencia entre ellas, según corresponda.
              g. VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos. Modificar las
              clases que heredan de ésta para que lo reutilicen
            */

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
