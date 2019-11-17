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
            List<string> tipos = new List<string>();
            Patente.Tipo tipo;
            Queue<Patente> queue = new Queue<Patente>();

            try
            {
                this.conexion.Open();
                this.comando.CommandText = $"SELECT * FROM dbo.{tabla}";
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    patentes.Add(reader[0].ToString());
                    tipos.Add(reader[1].ToString());
                }

                for (int i = 0; i < patentes.Count; i++)
                {
                    if (tipos[i]=="Mercosur")
                    {
                        tipo = Patente.Tipo.Mercosur;
                    }
                    else
                    {
                        tipo = Patente.Tipo.Vieja;
                    }

                    queue.Enqueue(new Patente(patentes[i], tipo));
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
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();
            connString.IntegratedSecurity = true;
            connString.DataSource = ".\\SQLEXPRESS";
            connString.InitialCatalog = "patentes-sp-2018";

            this.comando = new SqlCommand();
            this.conexion = new SqlConnection(connString.ToString());

            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

        }
    }
}
