using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_41
{
  public class Centralita
  {
    private List<Llamada> listaDeLlamadas;
    protected string razonSocial;

    public float GananciasPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
    public float GananciasPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
    public float GananciasPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }
    public List<Llamada> Llamadas { get { return listaDeLlamadas; } }   

    private void AgregarLlamada(Llamada nuevaLlamada)
    {
      this.Llamadas.Add(nuevaLlamada);
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

    public static bool operator !=(Centralita c, Llamada llamada)
    {
      return !(c == llamada);
    }

    public static bool operator ==(Centralita c, Llamada llamada)
    {
      bool rtnVal = false;

      foreach (Llamada l in c.Llamadas)
      {
        if (l==llamada)
        {
          rtnVal = true;
          break;
        }
      }

      return rtnVal;
    }

    public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
    {
      if (c!=nuevaLlamada)
      {
        c.AgregarLlamada(nuevaLlamada);
      }
      else
      {
        throw new CentralitaException("La llamada ya existe", "Llamador", "Operador +");
      }

      return c;
    }

    public Centralita()
    {
      listaDeLlamadas = new List<Llamada>();
    }

    public Centralita(string nombreEmpresa) : this()
    {
      razonSocial = nombreEmpresa;
    }

    public string Mostrar()
    {
      Local local;
      Provincial provincial;
      StringBuilder str = new StringBuilder(($"Razon social: {razonSocial} Ganancia total: {GananciasPorTotal}\n"));
      str.AppendLine($"Ganancias Local: {GananciasPorLocal} Ganancias Provincial: {GananciasPorProvincial}");

      foreach (Llamada l in Llamadas)
      {
        if (l is Local)
        {
          local = (Local)l;
          str.AppendLine(local.ToString());
        }
        else
        {
          provincial = (Provincial)l;
          str.AppendLine(provincial.ToString());
        }
      }

      return str.ToString();
    }
    
    public void OrdenarLlamadas()
    {
        listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      float acum = 0;
      Local local;
      Provincial provincial;

      foreach (Llamada l in Llamadas)
      {
        if (tipo == Llamada.TipoLlamada.Todas)
        {
          if (l is Local)
          {
            local = (Local)l;
            acum += local.CostoLlamada;
          }
          else
          {
            provincial = (Provincial)l;
            acum += provincial.CostoLlamada;
          }
        }
        else if (tipo == Llamada.TipoLlamada.Local)
        {
          if (l is Local)
          {
            local = (Local)l;
            acum += local.CostoLlamada;
          }          
        }
        else if (tipo == Llamada.TipoLlamada.Provincial)
        {
          if (l is Provincial)
          {
            provincial = (Provincial)l;
            acum += provincial.CostoLlamada;
          }          
        }
      }

      return acum;
    }


  }
}
