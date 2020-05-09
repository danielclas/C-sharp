using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        private ETipo tipo;

        /// <summary>
        /// Setea los campos marca, codigo, color y tipo (por defecto es entera)
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color):this(marca, codigo, color, ETipo.Entera)
        {

        }

        /// <summary>
        /// Setea los campos marca, codigo, color y tipo
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Leche (EMarca marca, string codigo, ConsoleColor color, ETipo tipo):base(codigo, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Devuelve cantidad de calorias en Dulce
        /// </summary>
        /// <returns>Entero de cantidad de calorias del producto</returns>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        /// <summary>
        /// Publica todos los datos del producto tipo Snacks
        /// </summary>
        /// <returns>Descripcion del objeto Leche</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("LECHE\n");
            sb.Append(base.Mostrar());            
            sb.AppendLine($"\n\nCALORIAS : {CantidadCalorias} TIPO: {tipo}");
            sb.Append("");
            sb.Append("\n---------------------\n");

            return sb.ToString();
        }
    }
}
