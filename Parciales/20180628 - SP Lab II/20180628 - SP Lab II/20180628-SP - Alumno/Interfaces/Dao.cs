using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Archivos
{
  public class Dao : IArchivo<Entidades.Votacion>
  {
    public Entidades.Votacion Leer(string rutaArchivo)
    {
      throw new NotImplementedException();
    }

    public bool Guardar(string rutaArchivo, Entidades.Votacion objeto)
    {
      string nombreLey = objeto.NombreLey, nombreAlumno="Clas";
      short afirmativos=objeto.Afirmativos, negativos=objeto.Negativos, abstenciones=objeto.Abstenciones;
      int cantInsertada;

      string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog =votacion-sp-2018; Integrated Security = True";
      SqlConnection sqlConnection = new SqlConnection(connectionStr);
      SqlCommand sqlCommand = new SqlCommand();

      sqlCommand.CommandType = System.Data.CommandType.Text;
      sqlCommand.Connection = sqlConnection;

      sqlCommand.CommandText = $"INSERT INTO dbo.Votaciones (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno) VALUES ('{nombreLey}', {afirmativos}, {negativos}, {abstenciones}, '{nombreAlumno}')";

      try
      {
        sqlConnection.Open();
        cantInsertada = sqlCommand.ExecuteNonQuery();
      }
      catch (Exception e)
      {        
        throw e;
      }

      return cantInsertada==1;

    }
  }
}  

