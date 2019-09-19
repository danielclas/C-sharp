using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    public class Centralita
  {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal { get; }
        public float GananciasPorProvincial { get;}
        public float GananciasPorTotal { get;}
        public List<Llamada> Llamadas { get;}

        public Centralita()
        {

        }

        public Centralita(string nombreEmpresa)
        {

        }

        public string Mostrar()
        {

        }

        public void OrdenarLlamadas()
        {

        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {

        }


    }
}
