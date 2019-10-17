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
    System.Windows.Forms.TextBox textBoxActual;
    Centralita centralita;

    public Llamador(Centralita centralita)
    {
      InitializeComponent();
      textBoxActual = textBoxNroDestino;
      comboBoxFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
      this.centralita = centralita;
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

    private bool ControlarTexto()
    {
      if (textBoxActual.Text == "Nro Destino" || textBoxActual.Text == "Nro Origen")
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "1"; else textBoxActual.Text += '1';
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "2"; else textBoxActual.Text += '2';
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "3"; else textBoxActual.Text += '3';
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "4"; else textBoxActual.Text += '4';
    }

    private void button5_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "5"; else textBoxActual.Text += '5';
    }

    private void button6_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "6"; else textBoxActual.Text += '6';
    }

    private void button7_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "7"; else textBoxActual.Text += '7';
    }

    private void button8_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "8"; else textBoxActual.Text += '8';
    }

    private void button9_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "9"; else textBoxActual.Text += '9';
    }

    private void buttonAsterico_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "*"; else textBoxActual.Text += '*';
    }

    private void button0_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "0"; else textBoxActual.Text += '0';
    }

    private void buttonNumeral_Click(object sender, EventArgs e)
    {
      if (ControlarTexto()) textBoxActual.Text = "#"; else textBoxActual.Text += '#';
    }

    private void CambiarTextBoxDestino(object sender, EventArgs e)
    {
      this.textBoxActual = textBoxNroDestino;
    }

    private void CambiarTextBoxOrigen(object sender, EventArgs e)
    {
      this.textBoxActual = textBoxNroOrigen;
    }

    private void buttonLlamar_Click(object sender, EventArgs e)
    {
      Random random = new Random();
      Local local;
      Provincial provincial;
      Llamada llamada;
      Provincial.Franja franja; Enum.TryParse<Provincial.Franja>(comboBoxFranja.SelectedValue.ToString(), out franja);

      if (textBoxNroDestino.Text[0] == '#')
      {
        provincial = new Provincial(textBoxNroOrigen.Text, franja, random.Next(1, 50), textBoxNroDestino.Text);
        llamada = provincial;
      }
      else
      {
        local = new Local(textBoxNroOrigen.Text, random.Next(1, 50), textBoxNroDestino.Text, (float)(random.NextDouble() * (5.6 - 0.5) + 0.5));
        llamada = local;
      }

      centralita += llamada;

      MessageBox.Show("Llamada agregada");
    }

    private void buttonSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
