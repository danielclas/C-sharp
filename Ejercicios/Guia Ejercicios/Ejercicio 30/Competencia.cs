using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
  class Competencia
  {
    private short cantidadCompetidores;
    private short cantidadVueltas;
    private List<AutoF1> competidores;

    private Competencia()
    {
      competidores = new List<AutoF1>();
    }

    public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
    {
      this.cantidadCompetidores = cantidadCompetidores;
      this.cantidadVueltas = cantidadVueltas;
    }

    public static bool operator +(Competencia c, AutoF1 a)
    {
      bool rtn = false;
      Random random;

      if (c.cantidadCompetidores > c.competidores.Count)
      {
        if (c!=a)
        {
          random = new Random();
          c.competidores.Add(a);
          a.EnCompetencia = true;
          a.VueltasRestantes = c.cantidadVueltas;
          a.CantidadCombustible = (short)random.Next(15,100);
          rtn = true;
        }
      }

      return rtn;
    }

    public static bool operator -(Competencia c, AutoF1 a)
    {
      bool rtn = false;
      int i=0;

      if (c==a)
      {
        for (; i < c.competidores.Count; i++)
        {
          if (a.Numero == c.competidores[i].Numero)
          {
            rtn = true;
            break;
          }
        }

        c.competidores.RemoveAt(i);
        rtn = true;
      }

      return rtn;
    }

    public static bool operator ==(Competencia c, AutoF1 a)
    {
      bool rtn = false;
      int i = 0;

      if (c.cantidadCompetidores > c.competidores.Count)
      {
        for (; i < c.competidores.Count; i++)
        {
          if (a.Numero == c.competidores[i].Numero)
          {
            rtn=true;
            break;
          }
        }
      }

      return rtn;
    }

    public static bool operator !=(Competencia c, AutoF1 a) { return !(c == a); }

    public string MostrarDatos()
    {
      string rtn;

      rtn = ($"\nCompetencia: Vueltas {cantidadVueltas}, competidores actuales: {competidores.Count}, competidores maximo: {cantidadCompetidores}");

      foreach (AutoF1 a in competidores)
      {
        rtn += a.mostrarDatos();
      }

      return rtn;
    }



  }
}
