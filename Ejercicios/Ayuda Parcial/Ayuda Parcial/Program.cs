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
            Persona persona = new Persona("Daniel", "Clas", new DateTime(1996, 2, 6), 39328065);
            string path = "C:\\Users\\daniel.julio.clas\\Desktop\\laboratorio-2\\Ejercicios\\Ayuda Parcial";

            XML<Persona> xml = new XML<Persona>();
            Texto<Persona> texto = new Texto<Persona>();
            DAO dao = new DAO();

            xml.Guardar(path+"\\XML.xml", persona);
            texto.Guardar(path + "\\texto.txt", persona);
            //dao.Guardar("", persona);

            Console.Read();
        }
    }
}
