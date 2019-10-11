using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCantina;
using Entidades;

namespace FrmCantina
{
  public partial class Form1 : Form
  {

    public Form1()
    {
      InitializeComponent();
      this.radioAgua.Checked = true;


    }

    private void Form1_Load(object sender, EventArgs e)
    {

      cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
      this.barra.SetCantina = Cantina.GetCantina(10);

      //this.cmbBotellaTipo.SelectedIndex = 0;
    }

    private void radioCerveza_CheckedChanged(object sender, EventArgs e)
    {
      //this.radioAgua.Checked = false;
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      Botella botella;
      string marca = txtMarca.Text;
      int capacidad = (int)numCapacidad.Value;
      int contenido = (int)numContenido.Value;
      Botella.Tipo tipo;
      Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);

      if (radioCerveza.Checked)
      {
        botella = new Cerveza(capacidad, marca, tipo, contenido);
      }
      else 
      {
        botella = new Agua(capacidad, marca, contenido);
      }


      barra.AgregarBotella(botella);

    }

    private void radioAgua_CheckedChanged(object sender, EventArgs e)
    {
      //this.radioCerveza.Checked = false;

    }
  }
}
