using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Jugador:Persona
  {       

    private bool esCapitan;
    private int numero;

    public bool EsCapitan { get { return this.esCapitan; } set { this.esCapitan = value; } }
    public int Numero { get { return this.numero; } set { this.numero = value; } }

    public override bool Equals(object obj)
    {
      bool rtn = false;

      if (obj is Jugador)
      {
        if (obj==this)
        {
          rtn = true;
        }
      }

      return rtn;
    }

    public static explicit operator int(Jugador jugador)
    {
      return jugador.Numero;
    }

    protected override string FichaTecnica()
    {
      string capitan = this.EsCapitan ?", capitan del equipo":"";

      return ($"{base.NombreCompleto()}{capitan}, camiseta nro. {this.Numero}");
    }

    public Jugador(string nombre, string apellido):base(nombre, apellido)
    {
      this.Numero = 0;
      this.EsCapitan = false;
    }

    public Jugador(string nombre, string apellido, int numero, bool capitan):this(nombre, apellido)
    {
      this.Numero = numero;
      this.EsCapitan = capitan;
    }

    public static bool operator !=(Jugador j1, Jugador j2)
    {
      return !(j1 == j2);
    }

    public static bool operator ==(Jugador j1, Jugador j2)
    {
      return (j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido && j1.Numero == j2.Numero);
    }

    public override string ToString()
    {
      return this.FichaTecnica();
    }
  }
}
