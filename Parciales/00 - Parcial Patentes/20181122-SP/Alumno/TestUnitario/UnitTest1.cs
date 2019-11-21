using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Archivos;
using Entidades;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        //Agregar 3 test unitarios, uno para cada método Guardar de las clases Xml, Sql y Texto. 
        //Cada uno de estos test generará un nuevo archivo, luego lo leerá y verificará que el dato leído sea correcto.

        [TestMethod]
        public void TestXML()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test.xml");
            Patente patente = new Patente("AJ123DC", Patente.Tipo.Mercosur);
            Patente objetoXML;

            Xml<Patente> xml = new Xml<Patente>();
            xml.Guardar(path, patente);

            xml.Leer(path, out objetoXML);

            Assert.IsTrue(patente.CodigoPatente == objetoXML.CodigoPatente && patente.TipoCodigo == objetoXML.TipoCodigo);
        }

        [TestMethod]
        public void TestSQL()
        {
            Patente patente = new Patente("AJ123DC", Patente.Tipo.Mercosur);
            Patente objetoSQL;

            Queue<Patente> colaSQL = new Queue<Patente>();
            Queue<Patente> cola = new Queue<Patente>();

            cola.Enqueue(patente);

            Sql sql = new Sql();
            sql.Guardar("Patentes", cola);

            sql.Leer("Patentes", out colaSQL);
            objetoSQL = cola.Dequeue();

            Assert.IsTrue(patente.CodigoPatente == objetoSQL.CodigoPatente && patente.TipoCodigo == objetoSQL.TipoCodigo);
        }

        [TestMethod]
        public void TestTexto()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test.txt");
            Patente patente = new Patente("AJ123DC", Patente.Tipo.Mercosur);
            Patente objetoText;

            Queue<Patente> colaText = new Queue<Patente>();
            Queue<Patente> cola = new Queue<Patente>();

            cola.Enqueue(patente);

            Texto texto = new Texto();
            texto.Guardar(path, cola);

            texto.Leer(path, out colaText);
            objetoText = colaText.Dequeue();

            Assert.IsTrue(patente.CodigoPatente == objetoText.CodigoPatente && patente.TipoCodigo == objetoText.TipoCodigo);
        }
    }
}
