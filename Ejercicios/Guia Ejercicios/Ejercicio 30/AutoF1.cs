using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
  class AutoF1
  {
    private short cantidadCombustible;
    private bool enCompetencia;
    private string escuderia;
    private short numero;
    private short vueltasRestantes;

    public short VueltasRestantes { get { return vueltasRestantes; } set { vueltasRestantes = value; } }
    public short CantidadCombustible { get { return cantidadCombustible; } set { cantidadCombustible = value; } }
    public bool EnCompetencia { get { return enCompetencia; } set { enCompetencia = value; } }
    public string Escuderia { get { return escuderia; } set { escuderia = value; } }
    public short Numero { get { return numero; } set { numero = value; } }

    public AutoF1(short numero, string escuderia)
    {
      enCompetencia = false;
      cantidadCombustible = 0;
      vueltasRestantes = 0;
      this.numero = numero;
      this.escuderia = escuderia;
    }

    public string mostrarDatos()
    {
      return ($"\nEscuderia: {escuderia}, nro: {numero}. Comb: {cantidadCombustible}. " + $"Vueltas restantes: {vueltasRestantes}. En competencia {enCompetencia}");
    }

    public static bool operator ==(AutoF1 a1, AutoF1 a2)
    {
      return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
    }

    public static bool operator !=(AutoF1 a1, AutoF1 a2)
    {
      return !(a1==a2);
    }
  }
}
