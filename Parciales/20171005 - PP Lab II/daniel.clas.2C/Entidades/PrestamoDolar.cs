using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public float Interes { get { return this.CalcularInteres(); } }
        public PeriodicidadDePagos Periodicidad { get { return this.periodicidad; } }

        #region Metodos

        private float CalcularInteres()
        {
            float acum = 0;

            switch (this.periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    acum = (this.monto * 25) / 100;
                    break;
                case PeriodicidadDePagos.Bimestral:
                    acum = (this.monto * 35) / 100;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    acum = (this.monto * 40) / 100;
                    break;
                default:
                    break;
            }

            return acum;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int days = (DateTime.Now - nuevoVencimiento).Days;

            this.Vencimiento = nuevoVencimiento;
            this.monto += days * (float)2.5;
        }

        public override string Mostrar()
        {
            StringBuilder str = new StringBuilder(base.Mostrar());

            str.AppendLine($"\nPeriodicidad: {this.Periodicidad} Intereses: {this.Interes}");

            return str.ToString();
        }
        #endregion

        #region Constructores

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad) : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad) : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {

        }

        #endregion

    }
}
