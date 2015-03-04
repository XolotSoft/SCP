using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace SistemadeControlPoliciaco
{
     public class ManejoBD
    {
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public SqlDataReader dr;

        public void buscar(string sql)
        {
            cmd = new SqlCommand(sql, Conexion.conectar());
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            da.Fill(ds);
            Conexion.desconectar();
        }

        public void buscarg(string campos, string tabla)
        {
            string sql = "SELECT "+campos+" FROM "+tabla;
            cmd = new SqlCommand(sql, Conexion.conectar());
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            da.Fill(ds);
            Conexion.desconectar();
        }

        public void buscare(string campos, string tabla, string columna, string valor)
        {
            string sql = "SELECT " + campos + " FROM " + tabla+" WHERE "+columna+" = "+valor;
            cmd = new SqlCommand(sql, Conexion.conectar());
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            da.Fill(ds);
            Conexion.desconectar();
        }

        public bool insertar(string tabla, string columnas, string valores)
        {
            string sql = "INSERT INTO "+tabla+" ("+columnas+")VALUES("+valores+")";
            cmd = new SqlCommand(sql, Conexion.conectar());
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool insertarq(string query)
        {
            string sql = query;
            cmd = new SqlCommand(sql, Conexion.conectar());
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool eliminar(string tabla, string columna, string valor)
        {
            string sql = "DELETE FROM " + tabla + " WHERE " + columna + " = " + valor;
            cmd = new SqlCommand(sql, Conexion.conectar());
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool modificar(string sql)
        {
            cmd = new SqlCommand(sql, Conexion.conectar());
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
