using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Auto : VehiculoT
    {
        private short marchas;
        private int pasajeros;

        public Auto(short ruedas, short puertas, Program.Colores color, short marchas, int pasajeros) : base(ruedas, puertas, color)
        {
            this.marchas = marchas;
            this.pasajeros = pasajeros;
        }
        public string MostrarDatos()
        {
            return ($"{base.Datos()} Marchas: {marchas} Pasajeros: {pasajeros}");
        }
    }
}
