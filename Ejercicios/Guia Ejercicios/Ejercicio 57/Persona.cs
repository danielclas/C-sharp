using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
  public class Persona
  {
    //  a.Crear una clase Persona con dos atributos privados del tipo string, nombre y apellido.
    //i.Agregarle un constructor que reciba ambos parámetros.
    //ii.Crear un método estático llamado Guardar que reciba una persona y la serialice en
    //un archivo.
    //iii.Crear un método estático Leer que deserialice un archivo y retorne una Persona.
    //iv.Sobrecargar el método ToString para mostrar los datos de la persona.
    private string nombre;
    private string apellido;

    public string Nombre { get { return nombre; } set { } }
    public string Apellido { get { return apellido; } set {  } }

    public Persona()
    {

    }

    public Persona(string nombre, string apellido)
    {
      this.nombre = nombre;
      this.apellido = apellido;
    }

    public void Guardar(Persona persona)
    {

    }

    public override string ToString()
    {
      return $"{apellido}, {nombre}.";
    }
  }
}
