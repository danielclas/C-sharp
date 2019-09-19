using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
  abstract class Sobreescrito
  {
    public string miAtributo;

    public Sobreescrito() { miAtributo = "Probar abstractos"; }

    abstract public string MiPropiedad { get; }

    abstract public string MiMetodo();

    public override string ToString()
    {
      return "¡Este es mi metodo ToString sobreescrito!";
    }

    public override bool Equals(object obj)
    {      
      return obj is Sobreescrito;
    }

    public override int GetHashCode()
    {
      return 1142510187;
    }
  }
}
