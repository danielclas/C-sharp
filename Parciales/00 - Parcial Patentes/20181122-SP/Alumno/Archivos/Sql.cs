using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            string patente, tipo;

            try
            {
                this.conexion.Open();
                foreach (Patente p in datos)
                {
                    patente = p.CodigoPatente;
                    tipo = p.TipoCodigo.ToString();
                    this.comando.CommandText = $"INSERT INTO dbo.{tabla} (patente, tipo) VALUES ('{patente}','{tipo}')";
                    comando.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            List<string> patentes = new List<string>();
            Queue<Patente> queue = new Queue<Patente>();

            try
            {
                this.conexion.Open();
                this.comando.CommandText = $"SELECT patente FROM dbo.{tabla}";
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    queue.Enqueue(reader[0].ToString().ValidarPatente());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }

            datos = queue;
        }

        public Sql()
        {
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder()
            {
                IntegratedSecurity = true,
                DataSource = ".\\SQLEXPRESS",
                InitialCatalog = "patentes-sp-2018"
            };

            this.comando = new SqlCommand();
            this.conexion = new SqlConnection(connString.ToString());

            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

        }
    }
}
