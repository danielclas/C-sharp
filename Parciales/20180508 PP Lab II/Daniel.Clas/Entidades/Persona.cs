using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Persona
  {
    private string apellido;
    private string documento;
    private string nombre;

    public string Apellido { get { return this.apellido; }  }
    public string Documento { get { return this.documento; } set { if (this.ValidarDocumentacion(value)) this.documento = value; } }
    public string Nombre { get { return this.nombre; }  }

    public virtual string ExponerDatos()
    {
      StringBuilder str = new StringBuilder();

      str.Append($"{this.Apellido}, {this.Nombre}. DNI: {this.Documento}");

      return str.ToString();
    }

    public Persona(string nombre, string apellido, string documento)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.Documento = documento;
    }

    protected abstract bool ValidarDocumentacion(string doc);
   
  }
}
