using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks:Producto
    {
        /// <summary>
        /// Setea los campos marca, codigo y color
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Snacks(EMarca marca, string codigo, ConsoleColor color): base(codigo, marca, color)
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
                return 104;
            }
        }

        /// <summary>
        /// Publica todos los datos del producto tipo Snacks
        /// </summary>
        /// <returns>Descripcion del objeto Snack</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());            
            sb.AppendLine($"\nCALORIAS : {CantidadCalorias}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
