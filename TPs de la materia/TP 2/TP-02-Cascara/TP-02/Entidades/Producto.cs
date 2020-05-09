using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }

        private EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;

        /// <summary>
        /// Setea los campos marca, codigo y color
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Producto(string codigo, EMarca marca, ConsoleColor color)
        {
            this.codigoDeBarras = codigo;
            this.marca = marca;
            this.colorPrimarioEmpaque = color;
        }

        /// <summary>
        /// Retorna la cantidad de calorias del producto
        /// </summary>
        protected abstract short CantidadCalorias { get; }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns>String con la descripcion del producto</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Convierte de manera explicita un Producto a tipo string, exponiendo sus atributos
        /// </summary>
        /// <param name="p"></param>
        /// <returns>String con los datos del producto recibido</returns>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"CODIGO DE BARRAS: {p.codigoDeBarras}\r\n");
            sb.Append($"MARCA          : {p.marca.ToString()}\r\n");
            sb.Append($"COLOR EMPAQUE  : {p.colorPrimarioEmpaque.ToString()}\r");
            sb.Append("\n---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Booleano indicando si los producto son iguales</returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1.codigoDeBarras == v2.codigoDeBarras);
        }

        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Booleano indicando si los productos son distintos</returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1 == v2);
        }
    }
}
