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
        private int valorHora;

        public string ConsultarDatos()
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public string ImprimirTicket()
        {

        }

        private Moto()
        {

        }

        public Moto(string patente, int cilindrada)
        {

        }

        public Moto(string patente, int cilindrada, short ruedas)
        {

        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora)
        {

        }
    }
}
