using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro:Mascota
    {
        private int edad;
        private bool esAlfa;

        public int Edad { get { return this.edad;} set { this.edad = value; } }
        public bool EsAlfa { get { return this.esAlfa; } set { this.esAlfa = value; } }

        public override bool Equals(object obj)
        {
            bool rtn = false;

            if (obj is Perro)
            {
                rtn = this == (Perro)obj;
            }

            return rtn;
        }

        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }

        protected override string Ficha()
        {
            string str = this.EsAlfa ? ", alfa de la manada," :"";

            return ($"{this.Nombre} {this.Raza} {str} {this.Edad} ");
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            return (j1.Raza == j2.Raza && j1.Nombre == j2.Nombre && j1.Edad == j2.Edad);
        }

        public Perro(string nombre, string raza):base(nombre, raza)
        {
            this.Edad = 0;
            this.EsAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa):base(nombre, raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
