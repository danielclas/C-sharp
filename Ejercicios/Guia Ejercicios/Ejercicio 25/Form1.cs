using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_13;

namespace Ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            txtResultadoDec.Text = Conversor.BinarioDecimal(txtBinario.Text).ToString();
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            double num;

            if (double.TryParse(txtDecimal.Text, out num))
                txtResultadoBin.Text = Conversor.DecimalBinario(num).ToString();
            else txtResultadoBin.Text = "0";
        }
    }
}
