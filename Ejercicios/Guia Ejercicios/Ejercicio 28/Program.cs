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
      //Console.Title = "Ejercicio 28";

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
      List<KeyValuePair<string, int>> list;
      string maximo = "";

      texto=texto.Replace(' ', ',');
      texto=texto.Replace('.', ',');
      texto = texto.Replace(",,", ",");
      foreach (string palabra in texto.Split(','))        
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

      list = dic.ToList();
      list.Sort(CompararKVP);

      for (int i = 0; i < 3 && i<list.Count ; i++)
      {
        maximo += ($"Palabra: {list[i].Key}, {list[i].Value} veces\n");
      }       

      return maximo;
    }

    public static int CompararKVP(KeyValuePair<string, int> k1, KeyValuePair<string, int> k2)
    {
      int rtn = 0;

      if (k1.Value>k2.Value)
      {
        rtn = -1;
      }
      else
      {
        if (k2.Value > k1.Value)
        {
          rtn = 1;
        }
      }

      return rtn;
    }

  }
}
