using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_21;

namespace Ejercicio_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnF_Click(object sender, EventArgs e)
        {
            double num;
            Fahrenheit f;
            Celsius c;
            Kelvin k;

            if (double.TryParse(txtFahrenheit.Text, out num))
            {
                f = new Fahrenheit(num);
                c = (Celsius)f;
                k = (Kelvin)f;

                txtFtoF.Text = f.GetGrados().ToString();
                txtFtoC.Text = c.GetGrados().ToString();
                txtFtoK.Text = k.GetGrados().ToString();
            }            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            double num;
            Celsius c;
            Fahrenheit f;
            Kelvin k;

            if (double.TryParse(txtCelsius.Text, out num))
            {
                c = new Celsius(num);
                f = (Fahrenheit)c;
                k = (Kelvin)c;

                txtCtoC.Text = c.GetGrados().ToString();
                txtCtoF.Text = f.GetGrados().ToString();
                txtCtoK.Text = k.GetGrados().ToString();
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            double num;
            Kelvin k;
            Celsius c;
            Fahrenheit f;

            if (double.TryParse(txtKelvin.Text, out num))
            {
                k = new Kelvin(num);
                c = (Celsius)k;
                f = (Fahrenheit)k;

                txtKtoK.Text = k.GetGrados().ToString();
                txtKtoF.Text = f.GetGrados().ToString();
                txtKtoC.Text = c.GetGrados().ToString();
            }
        }
    }
}
