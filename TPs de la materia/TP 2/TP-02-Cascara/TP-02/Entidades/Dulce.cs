using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {
        /// <summary>
        /// Setea campos marca, codigo y color de clase base
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Dulce(EMarca marca, string codigo, ConsoleColor color):base(codigo, marca, color)
        {

        }

        /// <summary>
        /// Devuelve cantidad de calorias en Dulce
        /// </summary>
        /// <returns>Entero de cantidad de calorias del producto</returns>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        /// <summary>
        /// Publica todos los datos del producto tipo Snacks
        /// </summary>
        /// <returns>Descripcion del objeto Dulce</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());            
            sb.Append($"\nCALORIAS : {CantidadCalorias}");
            sb.AppendLine("\n---------------------");

            return sb.ToString();
        }
    }
}
