using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
  class Persona
  {
    protected long dni;
    protected string nombre;

    protected long Dni { get { return dni; } set { dni = value; } }
    protected string Nombre { get { return nombre; } set { nombre = value; } }

    protected Persona(string nombre)
    {
      Nombre = nombre;
    }

    protected Persona(long dni, string nombre) : this(nombre)
    {
      Dni = dni;
    }

    protected string MostrarDatos()
    {
      return ($"DNI: {Dni} Nombre: {Nombre}");
    }


  }  
}
