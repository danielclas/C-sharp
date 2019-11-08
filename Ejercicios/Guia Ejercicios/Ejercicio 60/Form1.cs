using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ejercicio_60
{
  public partial class Form1 : Form
  {
    SqlConnection connection;
    SqlCommand readCommand;
    SqlDataReader reader;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=LAB3PC01\\SQLEXPRESS; Initial Catalog=AdventureWorks2012; Integrated Security=True";

        connection = new SqlConnection(connectionString);
        readCommand = new SqlCommand();
        this.HacerConsulta();

    }

    private void HacerConsulta()
    {
      readCommand.CommandType = CommandType.Text;
      readCommand.Connection = connection;
      readCommand.CommandText = "SELECT * FROM Production.Product";

      connection.Open();
      reader = readCommand.ExecuteReader();

      while (reader.Read())
      {
        string pID, name, pNumber;
        pID = reader["ProductID"].ToString();
        name = reader["Name"].ToString();
        pNumber = reader["ProductNumber"].ToString();

        richTextBox1.Text += String.Format("{0,-10} {1,-35} {2,-25}\n", pID, name, pNumber);
      }

      connection.Close();
    }

  }
}
