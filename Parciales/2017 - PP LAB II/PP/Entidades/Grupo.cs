using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private TipoManada tipo;

        public TipoManada Tipo { set { this.tipo = value; } }

        private Grupo()
        {
            manada = new List<Mascota>();
            this.Tipo = TipoManada.Unica;
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {
            this.Tipo = tipo;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder str = new StringBuilder($"**{e.nombre} {e.tipo.ToString()}**\nIntegrantes:\n");

            foreach (Mascota m in e.manada)
            {
                if (m is Perro)
                {
                    str.AppendLine(((Perro)m).ToString());
                }
                else
                {
                    str.AppendLine(((Gato)m).ToString());
                }
            }

            return str.ToString();
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }
        public static bool operator ==(Grupo e, Mascota j)
        {
            bool contained = false;
            
            foreach (Mascota m in e.manada)
            {
                if (m.GetType() == j.GetType() && m==j)
                {
                    contained = true;
                    break;
                }
            }

            return contained;
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            if (e!=j)
            {
                e.manada.Add(j);
            }

            return e;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            if (e==j)
            {
                e.manada.Remove(j);
            }

            return e;
        }

        public enum TipoManada
        {
            Unica, Mixta
        }
    }
}
