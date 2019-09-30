using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos:Prestamo
    {
        private float porcentajeIntereses;
        public float Interes { get; }

        private float CalcularInteres()
        {

        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {

        }

        public override string Mostrar()
        {

        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
        {

        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres)
        {

        }
    }
}
