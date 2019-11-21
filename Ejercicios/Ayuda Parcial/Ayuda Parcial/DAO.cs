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
            throw new NotImplementedException();
        }

        public bool Guardar(string path, Persona objeto)
        {
            string nombre, apellido;
            int dni, insertados=0;
            DateTime fecha;
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();
            connString.IntegratedSecurity = true;
            connString.DataSource = ".\\SQLEXPRESS";
            connString.InitialCatalog = "Persona";

            SqlConnection connection = new SqlConnection(connString.ToString());

            nombre = objeto.Nombre;
            apellido = objeto.Apellido;
            dni = objeto.Dni;
            fecha = objeto.FechaNac;

            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = $"INSERT INTO Persona (nombre, apellido, dni, fecha) values ('{nombre}', '{apellido}', {dni}, {fecha})";

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
