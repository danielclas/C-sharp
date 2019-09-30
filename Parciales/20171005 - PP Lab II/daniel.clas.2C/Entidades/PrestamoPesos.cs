using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeIntereses;
        public float Interes { get { return this.CalcularInteres(); } }

        private float CalcularInteres()
        {
            return (this.porcentajeIntereses * base.monto) / 100;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float days = (DateTime.Now - nuevoVencimiento).Days;
            days = days * (float)0.25;

            this.porcentajeIntereses += days;
            base.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder(base.Mostrar());

            str.AppendLine($"\nPorcentaje interes: {this.porcentajeIntereses} Intereses: {this.Interes}");

            return str.ToString();
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes):base(monto, vencimiento)
        {
            this.porcentajeIntereses = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres):this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {

        }
    }
}
