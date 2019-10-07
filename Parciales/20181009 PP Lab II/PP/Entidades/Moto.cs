using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        public override string ConsultarDatos()
        {
            return ($"{base.ToString()} {this.ruedas} ruedas, CC: {this.cilindrada}. ${Moto.valorHora}/hora");
        }

        public override bool Equals(object obj)
        {
            bool equals = false;

            if (obj is Moto)
            {
                equals = ((Moto)obj).Patente == this.Patente;
            }
            return equals;
        }

        public override string ImprimirTicket()
        {
            double hours = (DateTime.Now - base.ingreso).Hours;

            hours *= Moto.valorHora;

            return ($"{base.ImprimirTicket()} Costo: ${hours}");
        }

        static Moto()
        {
            Moto.valorHora = 30;
        }

        public Moto(string patente, int cilindrada):base(patente)
        {
            this.ruedas = 2;
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas):this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora):this(patente, cilindrada, ruedas)
        {
            Moto.valorHora = valorHora;
        }
    }
}
