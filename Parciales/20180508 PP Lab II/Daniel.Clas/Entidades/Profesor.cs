using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Profesor:Persona
  {
    private DateTime fechaIngreso;

    public int Antiguedad { get { return (DateTime.Now -fechaIngreso).Days; } }
    
    public override string ExponerDatos()
    {
      StringBuilder str = new StringBuilder(base.ExponerDatos());

      str.Append($" Antiguedad: {this.Antiguedad}");

      return str.ToString();
    }

    public Profesor(string nombre, string apellido, string documento):base(nombre,apellido,documento)
    {

    }

    public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso):this(nombre,apellido,documento)
    {
      this.fechaIngreso = fechaIngreso;
    }

    protected override bool ValidarDocumentacion(string doc)
    {
      return doc.Length == 8;
    }

  }
}
