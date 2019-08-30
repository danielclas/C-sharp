using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio 18";

      //a.La clase Punto ha de tener dos atributos privados con acceso de sólo lectura(sólo con
      //getters), que serán las coordenadas del punto. También un constructor que reciba los
      //parámetros x e y.

      //b.La clase Rectangulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4
      //(que corresponden a los cuatro vértices del rectángulo).

      //c.La base de todos los rectángulos de esta clase será siempre horizontal. Por lo tanto, debe
      //tener un constructor para construir el rectángulo por medio de los vértices 1 y 3(utilizar el
      //método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para
      //obtener la distancia entre puntos).

      //d.Realizar los métodos getters para los atributos privados área y perímetro.
      //e.Los atributos área(base * altura) y perímetro((base + altura)*2) se deberán calcular sólo
      //una vez, al llamar por primera vez a su correspondiente método getter.Luego se deberá
      //retornar siempre el mismo valor.

      //En el espacio de nombres PruebaGeometria es donde se escribirá
      //una clase con el método Main.

      //f.Probar las funcionalidades de las clases Punto y Rectangulo.
      //i.Generar un nuevo Rectangulo.
      //ii.Imprimir por pantalla los valores de área y perímetro.

      //g.Desarrollar un método de clase que muestre todos los datos del rectángulo que recibe como
      //parámetro

      /*************
       *1          2 *
       *             *
       *             *
       *             *
       * 4         3 *
       * ***********/

      Console.Title = "Ejercicio 18";

      Punto punto1 = new Punto(0,5);
      Punto punto3 = new Punto(10,0);

      Rectangulo rec1 = new Rectangulo(punto1, punto3);

      Console.WriteLine($"Area: {rec1.GetArea()} Perimetro: {rec1.GetPerimetro()}");
      Console.WriteLine($"Punto 1 X:{rec1.vertice1.GetX()} Y:{rec1.vertice1.GetY()} || Punto 2 X:{rec1.vertice2.GetX()} Y:{rec1.vertice2.GetY()}");
      Console.WriteLine($"Punto 4 X:{rec1.vertice4.GetX()} Y:{rec1.vertice4.GetY()} || Punto 3 X:{rec1.vertice3.GetX()} Y:{rec1.vertice3.GetY()}");

      Console.ReadKey();
    }
  }
}
