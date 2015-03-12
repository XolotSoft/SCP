using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemadeControlPoliciaco
{
    class ob_id
    {
        string ida;
        public string obtener(string rfc)

        {
            string sql = "SELECT a.idAsp from aspirantes a INNER JOIN personales p ON p.personales_id = a.personales_id WHERE p.rfcAsp = '" + rfc + "'";
            ManejoBD bd = new ManejoBD();
            bd.buscar(sql);
            if (bd.dt.Rows.Count > 0)
            {
                DataRow u = bd.dt.Rows[0];
                ida = Convert.ToString(u[0]);
               
            }
            return ida;




        }
    }
}
