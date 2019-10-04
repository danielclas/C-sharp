using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera
    {
        private List<Animal> animales;
        private int corredoresMax;

        private Carrera()
        {
            this.animales = new List<Animal>();
        }

        public Carrera(int corredoresMax):this()
        {
            this.corredoresMax = corredoresMax;
        }

        public string MostrarCarrera(Carrera c)
        {
            StringBuilder str = new StringBuilder($"Corredores: {c.animales.Count} Max: {c.corredoresMax}");

            foreach (Animal a in c.animales)
            {
                if (a is Humano)
                {
                    str.AppendLine(((Humano)a).MostrarHumano());
                }
                else if (a is Caballo)
                {
                    str.AppendLine(((Caballo)a).MostrarCaballo());
                }
                else
                {
                    str.AppendLine(((Perro)a).MostrarPerro());

                }
            }

            return str.ToString();
        }
        
        public static bool operator !=(Carrera c, Animal a)
        {
            return !(c == a);
        }

        public static bool operator ==(Carrera c, Animal a)
        {
            bool contains = false;

            foreach (Animal a2 in c.animales)
            {
                if (a2.GetType() == a.GetType())
                {
                    if (a == a2)
                    {
                        contains = true;
                        break;
                    }
                }
            }

            return contains;
        }

        public static Carrera operator +(Carrera c, Animal a)
        {
            if (c.animales.Count < c.corredoresMax && c != a)
            {
                c.animales.Add(a);
            }

            return c;
        }
    }
}
