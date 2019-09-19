using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
  class Competencia
  {
    private short cantidadCompetidores;
    private short cantidadVueltas;
    private List<VehiculoDeCarrera> competidores;
    private TipoCompetencia tipo;

    public short CantidadCompetidores { get { return cantidadCompetidores; } set { cantidadCompetidores = value; } }
    public short CantidadVueltas { get { return cantidadVueltas; } set { cantidadVueltas = value; } }
    public TipoCompetencia Tipo { get { return tipo; } set { tipo = value; } }
    public VehiculoDeCarrera this[int i] { get { return competidores[i]; } }

    private Competencia()
    {
      competidores = new List<VehiculoDeCarrera>();
    }

    public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
    {
      this.cantidadCompetidores = cantidadCompetidores;
      this.cantidadVueltas = cantidadVueltas;
    }

    public static bool operator +(Competencia c, VehiculoDeCarrera a)
    {
      bool rtn = false;
      Random random;

      if (c.cantidadCompetidores > c.competidores.Count)
      {
        if (c != a)
        {
          if (c.competidores.Count == 0 || c[0].GetType().ToString() == a.GetType().ToString())
          {
            c.Tipo = a.GetType().ToString() == "Ejercicio_36.AutoF1" ? TipoCompetencia.F1 : TipoCompetencia.MotoCross;
            random = new Random();
            c.competidores.Add(a);
            a.EnCompetencia = true;
            a.VueltasRestantes = c.cantidadVueltas;
            a.CantidadCombustible = (short)random.Next(15, 100);
            rtn = true;
          }
        }
      }

      return rtn;
    }

    public static bool operator -(Competencia c, VehiculoDeCarrera a)
    {
      bool rtn = false;
      int i = 0;

      if (c == a)
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

    public static bool operator ==(Competencia c, VehiculoDeCarrera a)
    {
      bool rtn = false;
      int i = 0;

      if (c.cantidadCompetidores > c.competidores.Count)
      {
        for (; i < c.competidores.Count; i++)
        {
          if (a == c[i] && a.GetType() == c[i].GetType())
          {
            rtn = true;
            break;
          }
        }
      }

      return rtn;
    }

    public static bool operator !=(Competencia c, VehiculoDeCarrera a) { return !(c == a); }

    public string MostrarDatos()
    {
      string rtn;

      rtn = ($"\nTipo Competencia: {Tipo} Vueltas {cantidadVueltas}, competidores actuales: {competidores.Count}, competidores maximo: {cantidadCompetidores}");

      foreach (VehiculoDeCarrera a in competidores)
      {
        rtn += a.MostrarDatos();
      }

      return rtn;
    }

    public enum TipoCompetencia
    {
      F1,
      MotoCross
    }



  }


}
