using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Conexion
{
    public class conexion
    {

        private static string servidor = "Orlando\\SQLEXPRESS";
        private static string basededatos = "BsePTC";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data Source = {servidor}; Initial Catalog = {basededatos}; Integrated Security = true";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }

}

