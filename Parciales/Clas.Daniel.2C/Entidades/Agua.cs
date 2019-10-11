using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Agua:Botella
    {

    
    #region Atributos
    const int MEDIDA = 400;
    #endregion

    #region Constructores
    /// <summary>
    /// Setea campos del objeto Agua llamando al constructor base
    /// </summary>
    /// <param name="capacidadML"></param>
    /// <param name="marca"></param>
    /// <param name="contenidoML"></param>
    public Agua(int capacidadML, string marca, int contenidoML):base(marca, capacidadML, contenidoML)
    {

    }
    #endregion

    #region Metodos
    /// <summary>
    /// Expone la informacion del objeto tipo Agua
    /// </summary>
    /// <returns>String con la informacion del objeto</returns>
    protected override string GenerarInforme()
    {
      StringBuilder str = new StringBuilder(base.GenerarInforme());

      str.AppendLine($"Medida: {Agua.MEDIDA}");

      return str.ToString();
    }

    /// <summary>
    /// Sirve una medida de la botella y resta al contenido
    /// </summary>
    /// <returns>Cantidad de mililitros consumidos</returns>
    public override int ServirMedida()
    {
      return this.ServirMedida(Agua.MEDIDA);
    }

    /// <summary>
    /// Sirve una medida de la botella y resta al contenido
    /// </summary>
    /// <param name="medida">Cantidad a consumir</param>
    /// <returns>Cantidad de mililitros consumidos</returns>
    public int ServirMedida(int medida)
    {
      int medida2;

      if (Agua.MEDIDA <= this.Contenido)
      {
        medida2 = Agua.MEDIDA;
      }
      else
      {
        medida2 = this.Contenido;
      }

      this.Contenido -= medida2;

      return medida2;
    }
    #endregion
  }
}
