using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SistemadeControlPoliciaco
{
    public class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection conectado = new SqlConnection(@"Data Source=DARTHVADER\SQLEXPRESS;Initial Catalog=policiacoDB;Integrated Security=True");
            conectado.Open();
            return conectado;
        }
        public static SqlConnection desconectar()
        {
            SqlConnection conectado = new SqlConnection(@"Data Source=DARTHVADER\SQLEXPRESS;Initial Catalog=policiacoDB;Integrated Security=True");
            conectado.Close();
            return conectado;
        }
    }
}
