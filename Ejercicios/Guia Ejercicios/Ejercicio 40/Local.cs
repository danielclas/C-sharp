using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
  public class Local : Llamada
  {
    protected float costo;
    public override float CostoLlamada { get { return CalcularCosto(); } }

    public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
    {
      this.costo = costo;
    }

    public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
    {
      this.costo = costo;
    }

    protected override string Mostrar()
    {
      StringBuilder str = new StringBuilder(base.Mostrar());

      str.AppendLine($"Tipo local, costo: {this.CostoLlamada}");

      return str.ToString();
    }

    private float CalcularCosto()
    {
      return base.Duracion * this.costo;
    }

    public override bool Equals(object obj)
    {
      return obj is Local;
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

  }
}
