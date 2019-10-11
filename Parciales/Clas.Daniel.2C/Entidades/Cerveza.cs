using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cerveza:Botella
    {
    

    #region Atributos
    const int MEDIDA=330;
    private Tipo tipo;
    #endregion

    #region Constructores
    /// <summary>
    /// Setea campos del objeto cerveza llamando al otro constructor
    /// </summary>
    /// <param name="capacidadML"></param>
    /// <param name="marca"></param>
    /// <param name="contenidoML"></param>
    public Cerveza(int capacidadML, string marca, int contenidoML):this(capacidadML, marca, Tipo.Vidrio, contenidoML)
    {

    }

    /// <summary>
    /// Setea campos del objeto cerveza llamando al constructor base
    /// </summary>
    /// <param name="capacidadML"></param>
    /// <param name="marca"></param>
    /// <param name="tipo"></param>
    /// <param name="contenidoML"></param>
    public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML):base(marca, capacidadML, contenidoML)
    {
      this.tipo = tipo;
    }

    #endregion

    #region Metodos
    /// <summary>
    /// Expone la informacion del objeto tipo Cerveza
    /// </summary>
    /// <returns>String con la informacion del objeto</returns>
    protected override string GenerarInforme()
    {
      StringBuilder str = new StringBuilder(base.GenerarInforme());

      str.AppendLine($"Medida: {Cerveza.MEDIDA}");
      str.AppendLine($"Tipo: {this.tipo}");

      return str.ToString();
    }

    /// <summary>
    /// Sirve una medida de la botella y resta al contenido
    /// </summary>
    /// <returns>Cantidad de mililitros consumidos</returns>
    public override int ServirMedida()
    {
      int medida2;

      if (Cerveza.MEDIDA <= this.Contenido)
      {
        medida2 = (Cerveza.MEDIDA*80)/100;
      }
      else
      {
        medida2 = this.Contenido;
      }

      this.Contenido -= medida2;

      return medida2;
    }

    #endregion

    #region Operadores
    /// <summary>
    /// Recibe un objeto Cerveza y devuelve su tipo
    /// </summary>
    /// <param name="cerveza">Botella de cerveza</param>
    /// <returns>El tipo de la botella de Cerveza recibido</returns>
    public static implicit operator Botella.Tipo(Cerveza cerveza)
    {
      return cerveza.tipo;
    }

    #endregion


  }
}
