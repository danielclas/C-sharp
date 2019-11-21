using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayuda_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Daniel", "Clas", 39328065);
            Persona personaXML;
            Persona personaSQL;
            string path = "C:\\Users\\Dani\\Desktop\\laboratorio-2\\Ejercicios\\Ayuda Parcial";

            XML<Persona> xml = new XML<Persona>();
            Texto<Persona> texto = new Texto<Persona>();
            DAO dao = new DAO();

            xml.Guardar(path+"\\XML.xml", persona);
            texto.Guardar(path + "\\texto.txt", persona);
            dao.Guardar("", persona);

            personaXML=xml.Leer(path+"\\XML.xml");
            personaSQL = dao.Leer("");

            Console.WriteLine("Persona XML: "+personaXML.ToString());
            Console.WriteLine("Persona SQL: "+personaSQL.ToString());

            Console.Read();
        }
    }
}
