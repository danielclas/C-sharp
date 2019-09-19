using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
  class VehiculoDeCarrera
  {
    protected short cantidadCombustible;
    protected bool enCompetencia;
    protected string escuderia;
    protected short numero;
    protected short vueltasRestantes;

    public short CantidadCombustible { get { return cantidadCombustible; } set { cantidadCombustible = value; } }
    public bool EnCompetencia { get { return enCompetencia; } set { enCompetencia = value; } }
    public string Escuderia { get { return escuderia; } set { escuderia = value; } }
    public short Numero { get { return numero; } set { numero = value; } }
    public short VueltasRestantes { get { return vueltasRestantes; } set { vueltasRestantes = value; } }

    public string MostrarDatos()
    {
      return ($"\nComb: {CantidadCombustible} En Competencia: {EnCompetencia} Escuderia: {Escuderia} Nro: {Numero} Vueltas restantes: {VueltasRestantes}");
    }

    public VehiculoDeCarrera(short numero, string escuderia)
    {
        this.numero = numero;
        this.escuderia = escuderia;
    }

    public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
    {
      return v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia;
    }

    public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
    {
      return !(v1 == v2);
    }


  }
}
