using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;


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
            if (i > 0) return true; else return false;
        }

        public bool insertarFoto( MemoryStream ms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.conectar();
            cmd.CommandText = "INSERT INTO foto(aspirante_id,foto)VALUES(@aspirante_id,@foto)";
            cmd.Parameters.Add("@aspirante_id", SqlDbType.Int);
            cmd.Parameters.Add("@foto", SqlDbType.Image);
            cmd.Parameters["@aspirante_id"].Value = Variables.aspiranteId;
            cmd.Parameters["@foto"].Value = ms.GetBuffer();
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0) return true; else return false;
        }

        public bool editarFoto(MemoryStream ms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.conectar();
            cmd.CommandText = "UPDATE foto SET foto = @foto WHERE aspirante_id = '"+Variables.idAsp +"'";
            cmd.Parameters.Add("@foto", SqlDbType.Image);
            cmd.Parameters["@foto"].Value = ms.GetBuffer();
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0) return true; else return false;
        }
        public bool insertarHue(MemoryStream ms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.conectar();
            cmd.CommandText = "INSERT INTO huella(aspirante_id,huella_01)VALUES(@aspirante_id,@huella)";
            cmd.Parameters.Add("@aspirante_id", SqlDbType.Int);
            cmd.Parameters.Add("@huella", SqlDbType.Image);
            cmd.Parameters["@aspirante_id"].Value = Variables.aspiranteId;
            cmd.Parameters["@huella"].Value = ms.GetBuffer();
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0) return true; else return false;
        }

        public bool editarHuella(MemoryStream ms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.conectar();
            cmd.CommandText = "UPDATE huella SET huella_01 = @huella WHERE aspirante_id = '" + Variables.idAsp + "'";
            cmd.Parameters.Add("@huella", SqlDbType.Image);
            cmd.Parameters["@huella"].Value = ms.GetBuffer();
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0) return true; else return false;
        }

        public bool insertarq(string query)
        {
            string sql = query;
            cmd = new SqlCommand(sql, Conexion.conectar());
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0) return true; else return false;
        }
        public bool eliminar(string tabla, string columna, string valor)
        {
            string sql = "DELETE FROM " + tabla + " WHERE " + columna + " = " + valor;
            cmd = new SqlCommand(sql, Conexion.conectar());
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0) return true; else return false;
        }
        public bool modificar(string sql)
        {
            cmd = new SqlCommand(sql, Conexion.conectar());
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0) return true; else return false;
        }
    }
}
