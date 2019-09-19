using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada { get { return CalcularCosto(); } }

        public Provincial(Franja miFranja, Llamada llamada):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder(base.Mostrar());

            str.AppendLine($"Tipo provincial, costo: {this.CostoLlamada} Franja: {franjaHoraria}");

            return str.ToString();
        }


        private float CalcularCosto()
        {
            float opr=0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    opr = (float)0.99;
                    break;
                case Franja.Franja_2:
                    opr = (float)1.25;
                    break;
                case Franja.Franja_3:
                    opr = (float)0.66;
                    break;
                default:
                    break;
            }

            return base.Duracion * opr;
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
