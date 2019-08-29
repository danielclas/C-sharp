using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
  class Rectangulo
  {
    //Atributos hechos publicos para corroborar el calculo correcto de los vertices
    public Punto vertice1;
    public Punto vertice2;
    public Punto vertice3;
    public Punto vertice4;

    private float area;
    private float perimetro;

    public Rectangulo(Punto vertice1, Punto vertice3)
    {
      this.vertice1 = vertice1;
      this.vertice3 = vertice3;

      int ver2X = vertice3.GetX();
      int ver2Y = vertice1.GetY();

      this.vertice2 = new Punto(ver2X, ver2Y);

      int punto4X, punto4Y, dif;

      dif = Math.Abs(vertice1.GetX() - vertice3.GetX());
      punto4X = vertice3.GetX() - dif;
      punto4X = Math.Abs(punto4X);

      dif = Math.Abs(vertice3.GetY() - vertice1.GetY());
      punto4Y= vertice1.GetY() - dif;
      punto4Y = Math.Abs(punto4Y);

      this.vertice4 = new Punto(punto4X, punto4Y);

    }
    public float GetArea()
    {
      if (area == 0)
      {
        area = Area();
      }

      return area;
    }

    public float GetPerimetro()
    {
      if (perimetro == 0)
      {
        perimetro = Perimetro();
      }

      return perimetro;
    }

    private float Area()
    {
      float area;
      int b, altura;

      b = vertice4.GetX() - vertice3.GetX();
      b = Math.Abs(b);

      altura = vertice2.GetY() - vertice3.GetY();
      altura = Math.Abs(altura);

      area = b * altura;

      return area;
    }

    private float Perimetro()
    {
      float perimetro;
      int b, altura;

      b = vertice4.GetX() - vertice3.GetX();
      b = Math.Abs(b);

      altura = vertice2.GetY() - vertice3.GetY();

      perimetro = (b + altura) * 2;

      return perimetro;

    }




  }
}
