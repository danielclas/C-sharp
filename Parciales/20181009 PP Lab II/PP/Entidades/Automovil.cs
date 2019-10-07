using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        private ConsoleColor color;
        static private int valorHora;

        static Automovil()
        {
            Automovil.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color):base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora):this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            return ($"{base.ToString()} Color: {this.color} ${Automovil.valorHora}/hora");
        }

        public override bool Equals(object obj)
        {
            bool equals = false;

            if (obj is Automovil)
            {
                equals = ((Automovil)obj).Patente == this.Patente;
            }
            return equals;
        }

        public override string ImprimirTicket()
        {
            double hours = (DateTime.Now - base.ingreso).Hours;

            hours *= Automovil.valorHora;

            return ($"{base.ImprimirTicket()} Costo: ${hours}");
        }

    }
}
