using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_56
{
  public partial class Form1 : Form
  {
    public static FileInfo file=null;

    public Form1()
    {
      InitializeComponent();
    }

    private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog o = new OpenFileDialog();

      o.ShowDialog();

      if (o.CheckFileExists)
      {
        file = new FileInfo(o.FileName);
      }
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
      this.lblCaracteres.Text = $"{richTextBox1.Text.Length} caracteres";
    }

    private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (file is null)
      {
        guardarComoToolStripMenuItem_Click(new object(), new EventArgs());
      }
      else
      {
        StreamWriter writer = new StreamWriter(file.Name);

        writer.Write(richTextBox1.Text);

        writer.Close();
      }
    }

    private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}
