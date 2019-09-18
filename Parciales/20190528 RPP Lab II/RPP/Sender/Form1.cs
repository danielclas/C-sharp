using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Sender
{
    public partial class Form1 : Form
    {
        ManejadorDeEmisores manejador;
        EmisorDeWhatsapp emisor;
        public Form1()
        {
            InitializeComponent();
            manejador = new ManejadorDeEmisores("West Europe");
            this.comboBoxProductos.DataSource = Enum.GetNames(typeof(Emisor.EProducto));

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Emisor.EProducto producto;
            if (Enum.TryParse(this.comboBoxProductos.SelectedItem.ToString(), out producto))
            {
                emisor = new EmisorDeWhatsapp(richMensaje.Text, producto);
                if (manejador+emisor)
                {
                    MessageBox.Show("Emisor agregado", "El emisor pudo agregarse", MessageBoxButtons.OK);
                    richMensaje.Text = "";
                    textEmail.Text = "";
                }
            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            richConsola.Text=manejador.EnviarMensajes();
        }
    }
}
