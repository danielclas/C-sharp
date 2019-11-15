using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComiqueriaLogic.Comun
{
  public static class ArchivoTexto
  {
    public static bool Escribir(Excepciones.IArchivoTexto<Venta> objeto, bool append)
    {
      
    }

    public static string Leer()
    {
      
    }

    //a.Agregarle un método estático “Escribir”:
    //i.Que reciba cualquier objeto que implemente IArchivoTexto(NO usar generics).
    //ii.Que también reciba un parámetro “append” de tipo bool que indicará: true para
    //anexar datos al archivo, false para sobrescribir el archivo.
    //iii.Deberá guardar el texto devuelto por la propiedad Texto en un archivo (de texto) en
    //el path especificado por la propiedad Ruta, que el texto se anexe o sobrescriba
    //según lo indicando por el parámetro “append”, el encoding deberá ser UTF8.

    //b.Agregarle un método estático “Leer” que reciba la ruta a un archivo de texto y devuelva todo
    //su contenido como tipo string.

    //c.Utilizar el método Escribir cuando se genere una nueva ComiqueriaException de forma
    //que se vaya anexando el Texto de cada excepción en el archivo de log.
    //d.Recuerde cerrar siempre las conexiones.

  }
}
