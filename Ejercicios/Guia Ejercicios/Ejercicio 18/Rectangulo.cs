using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
  class Rectangulo
  {
    private Punto vertice1;
    private Punto vertice2;
    private Punto vertice3;
    private Punto vertice4;

    private float area;
    private float perimetro;

    public float GetArea()
    {
      if (area == 0) {
        area = Area();
      }

      return area;
    }

    public float GetPerimetro()
    {
      return perimetro;
    }

    private float Area()
    {
      return 0;
    }




  }
}
