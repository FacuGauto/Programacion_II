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

        public Sql()
        {
            string connection = "Data Source=.\\SQLEXPRESS; Initial Catalog = patentes-sp-2018; Integrated Security=true";
            this.conexion = new SqlConnection(connection);
            this.comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            conexion.Open();
            foreach (Patente p in datos)
            {
                comando.CommandText = string.Format("INSERT INTO {0}(patente,tipo) VALUES ('{1}','{2}')", tabla, p.CodigoPatente, p.TipoCodigo);
                comando.ExecuteNonQuery();
            }
            conexion.Close();
        }
        
        public void Leer(string tabla, out Queue<Patente> datos)
        {
            try
            {
                datos = new Queue<Patente>();
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                string queryString = string.Format("Select * from {0}", tabla);
                string patente;
                Patente.Tipo tipo = Patente.Tipo.Vieja;
                Patente p;
                while (reader.Read())
                {
                    patente = reader["patente"].ToString();
                    tipo = (Patente.Tipo)reader.GetSqlValue(1);
                    p = new Patente(patente, tipo);
                    datos.Enqueue(p);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (!(conexion is null))
                    conexion.Close();
            }
        }
        
    }
}
