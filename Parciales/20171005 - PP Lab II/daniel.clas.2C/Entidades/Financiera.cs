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

        public float InteresesEnDolares { get;}
        public float InteresesEnPeso { get;}
        public float InteresesTotales { get; }
        public List<Prestamo> ListaDePrestamos { get;}
        public string RazonSocial { get { return this.razonSocial; } }

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public  Financiera(string razonSocial):this()
        {
            this.razonSocial = razonSocial;
        }

        private float CalcularInteresesGanados(Prestamo.TipoDePrestamo tipoPrestamo)
        {

        }

        //e.CalcularInteresGanado: Método privado que recibe un Enumerado de tipo TipoDePrestamo y
        //retornará el valor equivalente a la suma de intereses entre todos los préstamos(invocar a la
        //propiedad Interes de la clase PrestamoPesos o PrestamoDolar según el tipo de préstamo
        //evaluado)

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public void OrdenarPrestamos()
        {
            this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder str = new StringBuilder($"Razon social: {financiera.RazonSocial}");

            str.AppendLine($"Intereses totales: {financiera.InteresesTotales} Pesos: {financiera.InteresesEnPeso} Dolares: {financiera.InteresesEnDolares}");

            financiera.OrdenarPrestamos();
            financiera.listaDePrestamos.ForEach(k => str.AppendLine(k.Mostrar()));

            return str.ToString();

        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {

        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {

        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {

        }


    }
}
