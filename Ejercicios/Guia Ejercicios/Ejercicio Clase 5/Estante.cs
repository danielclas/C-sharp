using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_5
{
  public class Estante
  {
    private Producto[] productos;
    private int ubicacionEstante;

    private Estante(int capacidad)
    {
      productos = new Producto[capacidad];
    }
    public Estante(int capacidad, int ubicacion):this(capacidad)
    {
      this.ubicacionEstante = ubicacion;
    }

    public Producto[] GetProductos()
    {
      return productos;
    }

    public static string MostrarEstante(Estante e)
    {
      string rtn = ($"Ubicacion: {e.ubicacionEstante}\n");

      foreach (Producto p in e.productos)
      {
        if (!(p is null))
        {
          rtn += ($"{Producto.MostrarProducto(p)}\n");
        }
      }

      return rtn;
    }

    public static bool operator ==(Estante e, Producto p)
    {
      bool rtn = false;

      foreach (Producto p2 in e.productos)
      {        
        if (!(p2 is null))
        {
          if (p2 == p)
          {
            rtn = true;
            break;
          }
        }
      }

      return rtn;
    }

    public static bool operator !=(Estante e, Producto p)
    {
      return !(e == p);
    }

    public static bool operator +(Estante e, Producto p)
    {
      bool rtn = false;
      int index = e.productos.Length - 1;

      if (e!=p)
      {
        for (int i = 0; i < e.productos.Length; i++)
        {
          if (e.productos[i] is null)
          {
            e.productos[i] = p;
            rtn = true;
            break;
          }
        }
      }          

       return rtn;
    }

    public static Estante operator -(Estante e, Producto p)
    {
      for (int i = 0; i < e.productos.Length; i++)
      {
        if (!(e.productos[i] is null))
        {
          if (e.productos[i] == p)
          {
            e.productos[i] = null;
          }
        }        
      }

      return e;
    }
  }
}
