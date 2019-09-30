using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar:Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public float Interes { get; }
        public PeriodicidadDePagos Periodicidad { get; }

        private float CalcularInteres()
        {

        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {

        }

        public override string Mostrar()
        {

        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
        {

        }

        public PrestamoDolar (Prestamo prestamo, PeriodicidadDePagos periodicidad)
        {

        }
    }
}
