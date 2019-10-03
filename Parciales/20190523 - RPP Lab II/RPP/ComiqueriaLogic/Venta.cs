using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  public sealed class Venta
  {
    private DateTime fecha;
    private static int porcentajeIva;
    private double precioFinal;
    private Producto producto;
    private int cantidad;

    public DateTime Fecha { get { return fecha; } }
    public int Cantidad { get { return this.cantidad; } }

    static Venta()
    {
      porcentajeIva = 21;
    }

    internal Venta(Producto producto, int cantidad)
    {
      this.producto = producto;
      this.cantidad = cantidad;
      Vender(Cantidad);
    }

    public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
    {
      double iva = Venta.porcentajeIva + 100;
      double precioFinal;
      iva /= 100;

      precioFinal = precioUnidad * cantidad;
      precioFinal *= iva;

      return precioFinal;
    }

    public string ObtenerDescripcion()
    {
      return ($"Fecha: {Fecha} - Descripcion: {producto.Descripcion} - Precio final: {precioFinal:0.00}");
    }

    private void Vender(int cantidad)
    {
      producto.Stock -= cantidad;
      //Agrego thread para que los DateTime generados tengan diferente horario
      System.Threading.Thread.Sleep(3000);
      fecha = DateTime.Now;
      precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
    }

    public static explicit operator Producto(Venta v)
    {
      return v.producto;
    }

  }
}
