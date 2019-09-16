using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class DT : Persona
    {
        private DateTime fechaNacimiento;

        private DT(string nombre) : base(nombre)
        {

        }

        public DT(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public new string MostrarDatos()
        {
            return ($"{base.MostrarDatos()} Nacimiento: {fechaNacimiento}");
        }

        public static bool operator ==(DT d1, DT d2)
        {
            return d1.nombre == d2.nombre && d1.fechaNacimiento == d2.fechaNacimiento ? true : false;
        }

        public static bool operator !=(DT d1, DT d2)
        {
            return !(d1 == d2);
        }
    }
}
