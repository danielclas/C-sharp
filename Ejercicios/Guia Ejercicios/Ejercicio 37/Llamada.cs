using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
  public class Llamada
  {
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    public float Duracion { get { return duracion; } }

    public string NroDestino { get { return nroDestino; } }

    public string NroOrigen { get { return nroOrigen; } }

    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
      this.duracion = duracion;
      this.nroDestino = nroDestino;
      this.nroOrigen = nroOrigen;
    }

    public string Mostrar()
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

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }

  }
}
