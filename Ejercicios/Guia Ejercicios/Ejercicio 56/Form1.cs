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
    public static FileInfo file = null;

    public Form1()
    {
      InitializeComponent();
    }

    private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog o = new OpenFileDialog();

      o.ShowDialog();

      if (o.CheckFileExists && o.FileName!="")
      {
        file = new FileInfo(o.FileName);

        using (StreamReader reader = new StreamReader(file.FullName))
        {
          this.richTextBox1.Text = reader.ReadToEnd();          
        }
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
        guardarComoToolStripMenuItem_Click(sender, e);
      }
      else
      {
        this.EscribirEnArchivo(file.FullName);
      }
    }

    private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog s = new SaveFileDialog();

      s.ShowDialog();

      if (s.CheckPathExists && s.FileName!="")
      {
        file = new FileInfo(s.FileName);
        this.EscribirEnArchivo(file.FullName);
      }
    }

    private void EscribirEnArchivo(string fileName)
    {
      StreamWriter writer = new StreamWriter(fileName);
      string[] arr = richTextBox1.Text.Split('\n');

      foreach (string s in arr)
      {
        writer.WriteLine(s);
      }

      writer.Close();
    }
  }
}
