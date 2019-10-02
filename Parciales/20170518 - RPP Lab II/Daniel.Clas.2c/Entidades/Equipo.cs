using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

  public class Equipo
  {
    public enum Deportes
    {
      Basquet, Futbol, Handball, Rugby
    }

    private static Deportes deporte;
    private DirectorTecnico dt;
    private List<Jugador> jugadores;
    private string nombre;

    public Deportes Deporte { set { Equipo.deporte = value; } }

    static Equipo()
    {
      Equipo.deporte = Deportes.Futbol;
    }

    private Equipo()
    {
      this.jugadores = new List<Jugador>();
    }

    public Equipo(string nombre, DirectorTecnico dt):this()
    {
      this.nombre = nombre;
      this.dt = dt;
    }

    public Equipo(string nombre, DirectorTecnico dt, Deportes deporte):this(nombre, dt)
    {
      Equipo.deporte = deporte;
    }

    public static implicit operator string(Equipo e)
    {
      StringBuilder str = new StringBuilder($"\nCount: {e.jugadores.Count}\n**{e.nombre}**\nNomina jugadores:\n");

      e.jugadores.ForEach(k=>str.AppendLine(k.ToString()));
      str.AppendLine($"Dirigido por: {e.dt.ToString()}");

      return str.ToString();
    }

    public static bool operator !=(Equipo e, Jugador j)
    {
      return !(e == j);
    }

    public static bool operator ==(Equipo e, Jugador j)
    {
      bool contains = false;

      foreach (Jugador j2 in e.jugadores)
      {
        if (j==j2)
        {
          contains = true;
          break;
        }
      }

      return contains;
    }

    public static Equipo operator +(Equipo e, Jugador j)
    {
      if (e!=j)
      {
        e.jugadores.Add(j);
      }

      return e;
    }

    public static Equipo operator -(Equipo e, Jugador j)
    {
      if (e==j)
      {
        e.jugadores.Remove(j);
      }

      return e;
    }





  }
}
