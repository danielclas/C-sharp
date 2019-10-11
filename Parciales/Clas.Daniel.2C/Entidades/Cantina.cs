using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Cantina
  {
    #region Atributos

    private List<Botella> botellas;
    private int espaciosTotales;
    private static Cantina singleton;
    #endregion

    #region Propiedades

    /// <summary>
    /// Devuelve la lista de botellas
    /// </summary>
    /// <returns>Objeto List con las botellas de la cantina</returns>
    public List<Botella> Botellas {
      get {
        return this.botellas;
      }
    }
    #endregion
  
    #region Constructores
    private Cantina(int espacios)
    {
      this.espaciosTotales = espacios;
      this.botellas = new List<Botella>();
    }
    #endregion

    #region Metodos
    /// <summary>
    /// Devuelve la instancia de singleton actual o instancia una si no existe
    /// </summary>
    /// <param name="espacios">Espacios totales en la cantina</param>
    /// <returns>La instancia de cantina</returns>
    public static Cantina GetCantina(int espacios)
    {
      if (singleton is null)
      {
        singleton = new Cantina(espacios);
      }
      else
      {
        singleton.espaciosTotales = espacios;
      }

      return singleton;
    }
    #endregion

    #region Operadores
    /// <summary>
    /// Sobrecarga operador + para agregar botella a cantina
    /// </summary>
    /// <param name="c">Cantina</param>
    /// <param name="b">Botella</param>
    /// <returns>True or False indicando si pudo o no agregar la botella</returns>
    public static bool operator +(Cantina c, Botella b)
      {
        bool rtnVal = false;

        if (c.espaciosTotales>c.Botellas.Count)
        {
          c.Botellas.Add(b);
          rtnVal = true;
        }

        return rtnVal;
      }
    #endregion
  }
}
