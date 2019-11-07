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

      Persona alguien = new Persona("Juan", "Carlos");

      Console.WriteLine($"Muestro persona creada: {alguien.ToString()}");
      Console.WriteLine("Intento serializar..");
      Console.ReadKey();

      XmlTextWriter writer = new XmlTextWriter("D:\\aaaPersona.xml", Encoding.UTF8);
      XmlSerializer serializer = new XmlSerializer(typeof(Persona));

      serializer.Serialize(writer, alguien);

      writer.Close();

      Console.WriteLine("El archivo fue creado..");
      Console.WriteLine(alguien.ToString());
      Console.ReadKey();


    }
  }
}
