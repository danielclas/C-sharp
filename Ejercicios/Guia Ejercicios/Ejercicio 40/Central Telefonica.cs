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
    public partial class Central_Telefonica : Form
    {
        Centralita centralita;
        InformarFacturacion inf;

        public Central_Telefonica()
        {
            InitializeComponent();
            centralita = new Centralita("Centralita Form");
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            inf = new InformarFacturacion(centralita);
            inf.Ganancias(Llamada.TipoLlamada.Todas);
            inf.Show();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            inf = new InformarFacturacion(centralita);
            inf.Ganancias(Llamada.TipoLlamada.Local);
            inf.Show();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            inf = new InformarFacturacion(centralita);

            inf.Ganancias(Llamada.TipoLlamada.Provincial);
            inf.Show();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            Llamador llamador = new Llamador(centralita);
            llamador.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
