using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Moto:VehiculoT
    {
        private short cilindrada;
        
        public Moto(short ruedas, short puertas, Program.Colores color, short cilindrada):base(ruedas, puertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarDatos()
        {
            return ($"{base.Datos()} Cilindrada: {cilindrada}");
        }
    }
}
