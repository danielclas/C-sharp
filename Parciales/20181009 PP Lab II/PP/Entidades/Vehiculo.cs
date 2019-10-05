using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        //11 minutos hasta creacion de solucion, proyecto, clases y diagramado.
        protected DateTime ingreso;
        private string patente;

        public string Patente { get; set; }

        public static string ConsultarDatos()
        {

        }

        public string ImprimirTicket()
        {

        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {

        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public Vehiculo(string patente)
        {

        }
    }
}
