using System;
using System.Text;


namespace Entidades
{
    public abstract class Botella
    {
    #region Atributos

    protected int capacidadML;
    protected int contenidoML;
    protected string marca;
    #endregion

    #region Propiedades

    /// <summary>
    /// Devuelve Capacidad de litros de la botella
    /// </summary>
    /// <returns>Entero con los mililitros de la capacidad maxima</returns>
    public int CapacidadLitros {
      get {
        return this.capacidadML / 1000; }
    }

    /// <summary>
    /// Devuelve y Setea Contenido de litros de la botella 
    /// </summary>
    /// <returns>Entero con los mililitros de contenido de la botella</returns>
    public int Contenido {
      get {
        return this.contenidoML;
      }
      set {
        this.contenidoML = value;
      }
    }

    /// <summary>
    /// Devuelve porcentaje de contenido restante
    /// </summary>
    /// <returns>Float con el porcentaje del contenido segun la capacidad</returns>
    public float PorcentajeContenido {
      get
      {
        return (this.contenidoML * 100) / this.capacidadML;
      }
    }
    #endregion

    #region Constructor

    /// <summary>
    /// Setea campos del objeto Botella 
    /// </summary>
    /// <param name="marca"></param>
    /// <param name="capacidadML"></param>
    /// <param name="contenidoML"></param>
    protected Botella(string marca, int capacidadML, int contenidoML)
    {
      int contenido= contenidoML;

      if (contenido > capacidadML)
      {
        contenido = capacidadML;
      }

      this.marca = marca;
      this.Contenido = contenido;
      this.capacidadML = capacidadML;

    }

    #endregion

    #region Metodos
    /// <summary>
    /// Expone la informacion del objeto tipo Botella
    /// </summary>
    /// <returns>String con la informacion del objeto</returns>
    protected virtual string GenerarInforme()
    {
      StringBuilder str = new StringBuilder();

      str.AppendLine($"Capacidad litros: {this.CapacidadLitros}");
      str.AppendLine($"Contenido: {this.Contenido}");
      str.AppendLine($"Porcentaje contenido: {this.PorcentajeContenido}");
      str.AppendLine($"Marca: {this.marca}");

      return str.ToString();

    }

    /// <summary>
    /// Sirve una medida de la botella y resta al contenido
    /// </summary>
    /// <returns>Cantidad de mililitros consumidos</returns>
    public abstract int ServirMedida();

    /// <summary>
    /// Convierte a String y expone los datos
    /// </summary>
    /// <returns>String con informacion del objeto</returns>
    public override string ToString()
    {
      return this.GenerarInforme();
    }

    #endregion

    #region Enum
    public enum Tipo
    {
      Plastico,
      Vidrio
    }
    #endregion

    }
}
