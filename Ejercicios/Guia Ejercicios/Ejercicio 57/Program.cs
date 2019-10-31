using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_57
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 57";


      //b.En el Main instanciar un objeto del tipo Persona e intentar serializarlo.
      //c.Luego intentar leer ese objeto serializado en una nueva instancia de persona y lo muestre
      //por pantalla.
      //d.Por cada excepción que lance la aplicación:
      //  i.Generar un catch que la capture y la maneje.
      //ii.Luego corregir el problema que genera la excepción.
      //iii.Repetir el proceso hasta capturar todas las excepciones de forma individual(no
      //utilizar Exception).
      //iv.Los datos de la Persona guardada deben ser el nombre y el apellido, y coincidir con
      //     los de la Persona leída
      Persona alguien = new Persona("Nombre", "Apellido");

      Console.WriteLine($"Muestro persona creada: {alguien.ToString()}");
      Console.WriteLine("Intento serializar..");
      Console.ReadKey();

      XmlTextWriter writer = new XmlTextWriter("D:\\a.xml", Encoding.Default);
      XmlSerializer serializer = new XmlSerializer(typeof(Persona));

      serializer.Serialize(writer, alguien);

      writer.Close();

      Console.WriteLine("El archivo fue creado..");
      Console.ReadKey();


    }
  }
}
