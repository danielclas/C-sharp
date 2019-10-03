using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobantesLogic
{
  class Factura : Comprobante
  {

    public enum TipoFactura { A, B, C, E }

    private DateTime fechaVencimiento;
    private TipoFactura tipoFactura;

    public override bool Equals(object obj)
    {
      bool rtn = false;
      Factura f;

      if (obj is Factura)
      {
        f = (Factura)obj;
        rtn = (f.tipoFactura == this.tipoFactura && f.fechaEmision == this.fechaEmision);
      }

      return base.Equals(obj);
    }

    public Factura(Venta venta, int diasParaVencimiento, TipoFactura tipoFactura) : base(venta)
    {
      this.tipoFactura = tipoFactura;
      this.fechaVencimiento = DateTime.Now.AddDays((double)diasParaVencimiento);
    }

    public Factura(Venta venta, TipoFactura tipoFactura) : this(venta, 15, tipoFactura)
    {

    }

    public override string GenerarComprobante()
    {
      StringBuilder comprobante = new StringBuilder($"Factura {this.tipoFactura}");
      Producto p = (Producto)base.Venta;

      comprobante.AppendLine($"\nFecha emision: {this.fechaEmision}\nFecha vencimiento: {this.fechaVencimiento}\n");
      comprobante.AppendLine($"Producto: {p.Descripcion}\nCantidad:{base.Venta.Cantidad}\nPrecio unitario: ${p.Precio:0.00}");
      comprobante.AppendLine($"Subtotal: ${p.Precio}\nImporte IVA: ${Venta.CalcularPrecioFinal(p.Precio,base.Venta.Cantidad)-p.Precio}\nImporte total:{Venta.CalcularPrecioFinal(p.Precio, base.Venta.Cantidad)}");

      return comprobante.ToString();
    }
  }
}
