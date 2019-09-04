using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_5
{
  public class Producto
  {
    private string codigoDeBarra;
    private string marca;
    private float precio;

    public Producto(string marca, string codigo, float precio)
    {
      this.marca = marca;
      this.codigoDeBarra = codigo;
      this.precio = precio;
    }

    public string GetMarca()
    {
      return marca;
    }

    public float GetPrecio()
    {
      return precio;
    }

    public static string MostrarProducto(Producto p)
    {
      return ($"Marca: {p.marca}, ${p.precio}. Cod: {p.codigoDeBarra}");
    }

    public static explicit operator string(Producto p)
    {
      return p.codigoDeBarra;
    }

    public static bool operator ==(Producto p, string marca)
    {
      return p.marca == marca;
    }

    public static bool operator !=(Producto p, string marca)
    {
      return p.marca != marca;
    }

    public static bool operator ==(Producto p, Producto p2)
    {
      bool rtn = p.codigoDeBarra == p2.codigoDeBarra;
      bool rtn2 = p.marca == p2.marca;

      return rtn && rtn2;
    }

    public static bool operator !=(Producto p, Producto p2)
    {
      return !(p==p2);
    }





  }
}
