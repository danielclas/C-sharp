using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
  class Jugador
  {
    private int dni;
    private string nombre;
    private int partidosJugados;
    private int totalGoles;

    public int PartidosJugados { get { return partidosJugados; } set { partidosJugados = value; } }
    public float PromedioGoles { get { return (float)TotalGoles / PartidosJugados; } set { } }
    public int TotalGoles { get { return totalGoles;} set { totalGoles=value;} }
    public string Nombre { get { return nombre; } }
    public int Dni { get { return dni; } }

    private Jugador()
    {
      PartidosJugados = 0;
      TotalGoles = 0;
    }

    public Jugador(int dni, string nombre) : this()
    {
      this.dni = dni;
      this.nombre = nombre;
    }

    public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
    {
      TotalGoles = totalGoles;
      PartidosJugados = totalPartidos;
    }

    public string mostrarDatos()
    {
      string rtn = "";

      rtn += ($"{Dni}, {Nombre}. Goles: {TotalGoles} - Partidos: {PartidosJugados} - Promedio: {PromedioGoles}");

      return rtn;
    }

    public static bool operator ==(Jugador j1, Jugador j2)
    {
      bool rtn = false;

      if (j1.dni == j2.dni)
      {
        rtn = true;
      }

      return rtn;
    }

    public static bool operator !=(Jugador j1, Jugador j2)
    {
      return !(j1 == j2);
    }


  }
}
