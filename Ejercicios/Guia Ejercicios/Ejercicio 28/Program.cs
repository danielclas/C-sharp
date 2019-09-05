using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 28";

      //Utilizar Diccionarios (Dictionary<string, int>)para realizar un contador de palabras, recorriendo el
      //texto palabra por palabra se deberá lograr que si se trata de una nueva palabra, se la agregará al
      //diccionario e inicializar su contador en 1, caso contrario se deberá incrementar dicho contador.
      //Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra.
      //Informar mediante un MessageBox el TOP 3 de palabras con más apariciones.
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());

    }
  }

  public static class Texto
  {
    public static string texto = "";

    public static string CapturarTexto(string texto)
    {
      Texto.texto = texto;
      Dictionary<string, int> dic = new Dictionary<string, int>();
      Dictionary<string, int> max = new Dictionary<string, int>();
      List<KeyValuePair<string, int>> list;
      string key="";
      string maximo = "";
      string prevMax = "";
      int c = 0;

      foreach (string palabra in texto.Split(' ', ',', '.'))
      {
        if (!dic.ContainsKey(palabra))
        {
          dic.Add(palabra, 1);
        }
        else
        {
          dic[palabra]++;
        }
      }
      
      do{
        key = dic.Max().Key;
        if (key!=prevMax)
        {
          maximo += ($"Palabra: {key}, {dic[key]} veces - ");
          //dic[key] = 0;
        }     
        c++;
        prevMax = key;
      } while (c<3);
      

      return maximo;
    }

  }
}
