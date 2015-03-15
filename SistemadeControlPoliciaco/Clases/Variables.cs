using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeControlPoliciaco
{
    public static class Variables
    {
        public static string rfcAsp, fotAsp, gueAsp, idAsp, idass;


        public static void DatosPersonales(string rAsp)

        {
            rfcAsp = rAsp;
        }

        public static void Editar(string id)
        {
            idAsp = id;    
        }

        public static void Foto(string ft)
        {
            fotAsp = ft;
        }
        public static void etapa(string id)
        {
            idass = id;
        }
    }
}
