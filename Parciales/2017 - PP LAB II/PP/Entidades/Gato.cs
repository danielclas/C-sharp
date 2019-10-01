using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public override bool Equals(object obj)
        {
            bool rtn = false;

            if (obj is Gato)
            {
                rtn = this == (Gato)obj;
            }

            return rtn;
        }

        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public Gato(string nombre, string raza):base(nombre, raza)
        {

        }

        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }

        public static bool operator ==(Gato obj1, Gato obj2)
        {
            return (obj1.Raza == obj2.Raza && obj1.Nombre == obj2.Nombre);
        }

        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
