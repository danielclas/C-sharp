using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico:Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia { get; set; }

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia):base(nombre, apellido, edad, dni)
        {
            this.AñosExperiencia = añosExperiencia;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder(base.Mostrar());

            str.Append($"Años experiencia: {this.añosExperiencia}");

            return str.ToString();
        }

        public bool ValidarAptitud()
        {
            return (this.Edad < 65 && this.añosExperiencia >= 2);
        }
    }
}
