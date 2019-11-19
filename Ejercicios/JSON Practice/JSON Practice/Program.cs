using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace JSON_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Daniel", "Clas", 23, DateTime.Now);

            StreamWriter writer = new StreamWriter("C:\\Users\\daniel.julio.clas\\Desktop\\laboratorio-2\\Ejercicios\\JSON Practice\\prueba.json");
            JsonSerializer serializer = new JsonSerializer();

            serializer.Serialize(writer, persona);
            writer.Close();

            Console.WriteLine(JsonConvert.SerializeObject(persona));
            persona.Escribir();
            Console.Read();
        }
    }
}
