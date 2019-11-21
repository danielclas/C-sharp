using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Ayuda_Parcial
{
    public class DAO:IArchivo<Persona>
    {
        public Persona Leer(string path)
        {
            Persona persona = null;
            List<int> lista = new List<int>();
            string nombre ="", apellido="";
            int dni=0;

            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();
            connString.IntegratedSecurity = true;
            connString.DataSource = ".\\SQLEXPRESS";
            connString.InitialCatalog = "Persona";

            SqlConnection connection = new SqlConnection(connString.ToString());

            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = $"select * from dbo.Personas where nombre='Juan'";
                command.Connection = connection;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    nombre = reader[0].ToString();
                    apellido = reader[1].ToString();
                    dni = int.Parse(reader[2].ToString());
                }

                persona = new Persona(nombre, apellido, dni);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return persona;

        }

        public bool Guardar(string path, Persona objeto)
        {
            string nombre, apellido;
            int dni, insertados=0;
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();
            connString.IntegratedSecurity = true;
            connString.DataSource = ".\\SQLEXPRESS";
            connString.InitialCatalog = "Persona";

            SqlConnection connection = new SqlConnection(connString.ToString());

            nombre = objeto.Nombre;
            apellido = objeto.Apellido;
            dni = objeto.Dni;

            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = $"INSERT INTO dbo.Personas (nombre, apellido, dni) values ('{nombre}', '{apellido}', {dni})";

                command.Connection = connection;
                connection.Open();
                insertados=command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }

            return insertados==1;
        }
    }
}
