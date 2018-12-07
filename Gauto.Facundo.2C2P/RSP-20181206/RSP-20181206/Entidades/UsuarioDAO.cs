using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class UsuarioDAO
    {
        string cadenaDeConexion = "Data Source=.\\SQLEXPRESS; Initial Catalog = patentes-sp-2018; Integrated Security=true";
        SqlCommand comando;
        SqlConnection conexion;

        public UsuarioDAO()
        {
            //string connection = "Data Source=.\\SQLEXPRESS; Initial Catalog = patentes-sp-2018; Integrated Security=true";
            this.conexion = new SqlConnection(this.cadenaDeConexion);
            this.comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public bool Guardar(Usuario u)
        {
            conexion.Open();
            string tabla = "Usuarios";
            
            comando.CommandText = string.Format("INSERT INTO {0}(clave,nombre) VALUES ('{1}','{2}')", tabla, u.Clave, u.Nombre);
            comando.ExecuteNonQuery();
            
            conexion.Close();
            return true;
        }

        public Usuario Leer(string usuario, string clave)
        {
            string tabla = "Usuarios"; 
            try
            {
                conexion.Open();
                Usuario usuario1 = new Usuario();
                SqlDataReader reader = comando.ExecuteReader();
                string queryString = string.Format("Select * from {0} WHERE clave = {1} AND nombre = {2}", tabla,clave,usuario);
                this.comando.CommandText = queryString;

                while (reader.Read())
                {
                    usuario1 = new Usuario(reader["nombre"].ToString(), reader["clave"].ToString());
                }
                return usuario1;
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
