using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobantesLogic
{
  public abstract class Comprobante
  {
    protected DateTime fechaEmision;
    private Venta venta;

    internal Venta Venta { get { return this.venta; } }

    public Comprobante(Venta venta)
    {
      this.fechaEmision = venta.Fecha;
      this.venta = venta;
    }

    public override bool Equals(object obj)
    {
      bool equals = false;

      if (obj is Comprobante)
      {
        if (this.fechaEmision == ((Comprobante)obj).fechaEmision)
        {
          equals = true;
        }
      }

      return equals;
    }

    public abstract string GenerarComprobante();

  }

}
