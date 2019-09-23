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
    public partial class Llamador : Form
    {
        public Llamador()
        {
            InitializeComponent();
        }

        private void ControlarDestino(object sender, EventArgs e)
        {
            if (this.textBoxNroDestino.Text[0] != '#')
            {
                this.comboBoxFranja.Enabled = false;
            }
            else
            {
                this.comboBoxFranja.Enabled = true;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxNroDestino.Text = "Nro Destino";
            this.textBoxNroOrigen.Text = "Nro Origen";
            this.comboBoxFranja.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
