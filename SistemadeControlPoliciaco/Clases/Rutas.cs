using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeControlPoliciaco
{
    class Rutas
    {
        private static string rutai()
        {
           string rutai = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
           rutai = rutai.Remove(0, 6);
           rutai = rutai.Remove(rutai.Length - 9);
           return rutai;
        }
        

        public static string foto()
        {
            string ruta = rutai();
            ruta = ruta + "Fotos/";
            return ruta;
        }

        public static string pdf()
        {
            string ruta = rutai();
            ruta = ruta + "Pdf/";
            return ruta;
        }
    }
}
