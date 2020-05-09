using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        private List<Producto> productos;
        private int espacioDisponible;

        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }

        #region "Constructores"
        /// <summary>
        /// Inicializa la lista de productos
        /// </summary>
        private Changuito()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        /// Setea el espacio disponible en el changuito
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Changuito(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el Changuito y TODOS los Productos
        /// </summary>
        /// <returns>Descripcion del changuito</returns>
        public override string ToString()
        {
            return Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="tipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>Descripcion de los productos segun el tipo y del changuito</returns>
        public static string Mostrar(Changuito c, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();
         
            sb.AppendLine($"Tenemos {c.productos.Count} lugares ocupados de un total de {c.espacioDisponible} disponibles\n");

            foreach (Producto v in c.productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                        if (v is Snacks)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Dulce:
                        if (v is Dulce)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Leche:
                        if (v is Leche)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns>El changuito recibido mas el producto, si fue posible agregarlo</returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            if (!c.productos.Exists(k => k == p) && c.productos.Count < c.espacioDisponible)
            {
                c.productos.Add(p);
            }

            return c;
        }

        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns>El changuito recibido menos el producto, si el mismo estaba presente</returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            if (c.productos.Exists(k => k == p))
            {
                c.productos.Remove(p);
            }

            return c;
        }
        #endregion
    }
}
