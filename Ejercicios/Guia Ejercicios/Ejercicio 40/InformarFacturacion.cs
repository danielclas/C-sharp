using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_40
{
    public partial class InformarFacturacion : Form
    {
        Centralita centralita;

        public InformarFacturacion(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public void Ganancias(Llamada.TipoLlamada tipo)
        {
            string rtn = "Las ganancias por ";

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    rtn += ($"local es ${centralita.GananciasPorLocal}");
                    break;
                case Llamada.TipoLlamada.Provincial:
                    rtn += ($"pronvicial es ${centralita.GananciasPorProvincial}");
                    break;
                case Llamada.TipoLlamada.Todas:
                    rtn += ($"total es ${centralita.GananciasPorTotal}");
                    break;
                default:
                    break;
            }

            this.richTextBoxInformar.Text = rtn;
            
        }
    }
}
