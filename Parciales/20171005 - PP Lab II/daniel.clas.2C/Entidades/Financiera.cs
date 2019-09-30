using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public float InteresesEnDolares { get { return this.CalcularInteresesGanados(Prestamo.TipoDePrestamo.Dolares); } }
        public float InteresesEnPeso { get { return this.CalcularInteresesGanados(Prestamo.TipoDePrestamo.Pesos); } }
        public float InteresesTotales { get { return this.CalcularInteresesGanados(Prestamo.TipoDePrestamo.Todos); } }
        public List<Prestamo> ListaDePrestamos { get { return this.listaDePrestamos; } }
        public string RazonSocial { get { return this.razonSocial; } }

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        private float CalcularInteresesGanados(Prestamo.TipoDePrestamo tipoPrestamo)
        {
            float acum = 0;
            PrestamoDolar pDolar;
            PrestamoPesos pPeso;

            foreach (Prestamo p in this.ListaDePrestamos)
            {
                switch (tipoPrestamo)
                {
                    case Prestamo.TipoDePrestamo.Pesos:
                        if(p is PrestamoPesos)
                        {
                            pPeso = (PrestamoPesos)p;
                            acum += pPeso.Interes;
                        }
                        break;
                    case Prestamo.TipoDePrestamo.Dolares:
                        if (p is PrestamoDolar)
                        {
                            pDolar = (PrestamoDolar)p;
                            acum += pDolar.Interes;
                        }
                        break;
                    case Prestamo.TipoDePrestamo.Todos:
                        if (p is PrestamoPesos)
                        {
                            pPeso = (PrestamoPesos)p;
                            acum += pPeso.Interes;
                        }
                        else
                        {
                            pDolar = (PrestamoDolar)p;
                            acum += pDolar.Interes;
                        }
                        break;
                    default:
                        break;
                }
            }

            return acum;
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder str = new StringBuilder($"Razon social: {financiera.RazonSocial}");

            str.AppendLine($"Intereses totales: {financiera.InteresesTotales} Pesos: {financiera.InteresesEnPeso} Dolares: {financiera.InteresesEnDolares}");

            financiera.OrdenarPrestamos();
            financiera.ListaDePrestamos.ForEach(k => str.AppendLine(k.Mostrar()));

            return str.ToString();

        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            return financiera.ListaDePrestamos.Contains(prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if (financiera != prestamoNuevo)
            {
                financiera.ListaDePrestamos.Add(prestamoNuevo);
            }

            return financiera;
        }


    }
}
