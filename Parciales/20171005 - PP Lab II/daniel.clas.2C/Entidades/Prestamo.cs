using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto { get { return this.monto; } }
        public DateTime Vencimiento {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if (value>DateTime.Now)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            return ($"\nMonto: ${this.monto} Vencimiento: {this.Vencimiento}");
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return p1.Vencimiento.CompareTo(p2.Vencimiento);
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }

        public enum PeriodicidadDePagos
        {
            Mensual, Bimestral, Trimestral
        }

        public enum TipoDePrestamo
        {
            Pesos, Dolares, Todos
        }
    }
}
