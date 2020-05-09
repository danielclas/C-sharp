using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        public delegate void EventoBDD(string mensaje);
        public static event EventoBDD excepcionBDD;

        /// <summary>
        /// Constructor estatico
        /// </summary>
        static PaqueteDAO()
        {
            SqlConnectionStringBuilder connectionString;

            connectionString = new SqlConnectionStringBuilder();
            connectionString.IntegratedSecurity = true;
            connectionString.InitialCatalog = "correo-sp-2017";
            connectionString.DataSource = ".\\SQLEXPRESS";

            PaqueteDAO.conexion = new SqlConnection(connectionString.ToString());
            PaqueteDAO.comando = new SqlCommand();
            PaqueteDAO.comando.CommandType = System.Data.CommandType.Text;
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
        }

        /// <summary>
        /// Inserta un paquete en la base de datos
        /// </summary>
        /// <param name="p">Paquete a insertar</param>
        /// <returns>True si pudo insertar los datos, false caso contrario</returns>
        public static bool Insertar(Paquete p)
        {
            string direccion, trackingID;
            int insert = 0;
            Exception ex = null;

            if (!ReferenceEquals(p, null))
            {
                direccion = p.DireccionEntrega;
                trackingID = p.TrackingID;
                PaqueteDAO.comando.CommandText = $"INSERT INTO dbo.Paquetes(direccionEntrega, trackingID, alumno) VALUES('{direccion}', '{trackingID}', 'Daniel Clas')";

                try
                {
                    PaqueteDAO.conexion.Open();
                    insert = PaqueteDAO.comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    ex = e;
                }
                finally
                {
                    PaqueteDAO.conexion.Close();
                }
            }

            if (!ReferenceEquals(ex, null) || insert==0)
            {
                excepcionBDD.Invoke("Error guardando en la base de datos");
            }

            return insert == 1;
        }

    }
}
