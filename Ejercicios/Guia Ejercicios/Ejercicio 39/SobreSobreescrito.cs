using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_38;

namespace Ejercicio_39
{
  class SobreSobreescrito:Sobreescrito
  {

    public override string MiPropiedad { get { return base.miAtributo; } }

    public override string MiMetodo(){ return MiPropiedad; }

  }
}
