using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
  abstract public class Llamada
  {
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    public float Duracion { get { return duracion; } }
    public string NroDestino { get { return nroDestino; } }
    public string NroOrigen { get { return nroOrigen; } }
    public abstract float CostoLlamada { get; }
    
    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
      this.duracion = duracion;
      this.nroDestino = nroDestino;
      this.nroOrigen = nroOrigen;
    }

    protected virtual string Mostrar()
    {
      StringBuilder str = new StringBuilder();

      str.AppendLine($"Duracion: {Duracion}");
      str.AppendLine($"Nro. Destino: {NroDestino}");
      str.AppendLine($"Nro Origen: {NroOrigen}");

      return str.ToString();
    }

    public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
    {
      int rtn = 0;

      if (llamada2.duracion>llamada1.duracion)
      {
        rtn = -1;
      }
      else
      {
        if (llamada2.duracion < llamada1.duracion)
        {
          rtn = 1;
        }
      }

      return rtn;
    }

    public static bool operator ==(Llamada l1, Llamada l2)
    {
      return l1.Equals(l2) && l1.NroDestino==l2.NroDestino && l1.NroOrigen==l2.NroOrigen;
    }

    public static bool operator !=(Llamada l1, Llamada l2)
    {
      return !(l1==l2);
    }

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }

  }
}
