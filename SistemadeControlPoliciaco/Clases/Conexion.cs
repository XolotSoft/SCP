using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace SistemadeControlPoliciaco
{
    public class Conexion
    {
        static string cadena = ConfigurationManager.ConnectionStrings["luis"].ConnectionString;
        static SqlConnection conectado = new SqlConnection(cadena);
        public static SqlConnection conectar()
        {
            conectado.Open();
            return conectado;
        }
        public static SqlConnection desconectar()
        {
            conectado.Close();
            return conectado;
        }
    }
}
