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
    public class Sql
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {

        }

        void Guardar(string tabla, Queue<Patente> datos)
        {

        }/*
        void Leer(string tabla, out Queue<Patente> datos)
        {

        }
        */
    }
}
