using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
  public class Local : Llamada
  {
    protected float costo;
    public float CostoLlamada { get { return CalcularCosto(); } }

    public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
    {
      this.costo = costo;
    }

    public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
    {
      this.costo = costo;
    }

    public string Mostrar()
    {
      StringBuilder str = new StringBuilder(base.Mostrar());

      str.AppendLine($"Tipo local, costo: {this.CostoLlamada}");

      return str.ToString();
    }

    private float CalcularCosto()
    {
      return base.Duracion * this.costo;
    }
     
    }
}
