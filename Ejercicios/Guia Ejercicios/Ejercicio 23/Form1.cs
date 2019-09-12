using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio_23
{
  public partial class Form1 : Form
  {
        private static int img = 0;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionPeso.Text = Peso.GetCotizacion().ToString();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void txtCotizacionEuro_Leave(object sender, System.EventArgs e)
    {
      if (txtEuro.Text != "")
      {
        double cotizacion = double.Parse(txtCotizacionEuro.Text);
        Euro euro = new Euro(double.Parse(txtEuro.Text), cotizacion);

        Peso peso = (Peso)euro;
        Dolar dolar = (Dolar)euro;

        txtEuroADolar.Text = dolar.GetCantidad().ToString();
        txtEuroAPeso.Text = peso.GetCantidad().ToString();
      }     
      
    }

    private void txtCotizacionPeso_Leave(object sender, System.EventArgs e)
    {
      if (txtPeso.Text != "")
      {
        double cotizacion = double.Parse(txtCotizacionPeso.Text);
        Peso peso = new Peso(double.Parse(txtPeso.Text), cotizacion);

        Dolar dolar = (Dolar)peso;
        Euro euro = (Euro)dolar;

        txtPesoAEuro.Text = euro.GetCantidad().ToString();
        txtPesoADolar.Text = dolar.GetCantidad().ToString();
      }

    }

    private void button1_Click(object sender, EventArgs e)
    {
            if (img == 0)
            {
                img = 1;
                txtCotizacionDolar.ReadOnly = true;
                txtCotizacionEuro.ReadOnly = true;
                txtCotizacionPeso.ReadOnly = true;
            }
            else
            {
                img = 0;
                txtCotizacionDolar.ReadOnly = false;
                txtCotizacionEuro.ReadOnly = false;
                txtCotizacionPeso.ReadOnly = false;
            }

            btnLockCotizacion.Image = imageList1.Images[img];        
    }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtEuro.Text);
            double cotizacion = double.Parse(txtCotizacionEuro.Text);

            Euro euro = new Euro(cantidad,cotizacion);
            Dolar dolar = (Dolar)euro;
            Peso peso = (Peso)euro;

            txtEuroAEuro.Text = euro.GetCantidad().ToString();
            txtEuroADolar.Text = dolar.GetCantidad().ToString();
            txtEuroAPeso.Text = peso.GetCantidad().ToString();

        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtDolar.Text);

            Dolar dolar = new Dolar(cantidad);
            Euro euro = (Euro)dolar;
            Peso peso = (Peso)dolar;

            txtDolarAEuro.Text = euro.GetCantidad().ToString();
            txtDolarADolar.Text = dolar.GetCantidad().ToString();
            txtDolarAPeso.Text = peso.GetCantidad().ToString();
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtPeso.Text);
            double cotizacion = double.Parse(txtCotizacionPeso.Text);

            Peso peso = new Peso(cantidad, cotizacion);
            Euro euro = (Euro)peso;
            Dolar dolar = (Dolar)peso;

            txtPesoADolar.Text = dolar.GetCantidad().ToString();
            txtPesoAEuro.Text = euro.GetCantidad().ToString();
            txtPesoAPeso.Text = peso.GetCantidad().ToString();
        }
    }
}
