using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeControlPoliciaco
{
    public static class Variables
    {
        public static string aspiranteId,gueAsp, idAsp, idass;


        public static void AspiranteID(string id)

        {
            aspiranteId = id;
        }

        public static void Editar(string id)
        {
            idAsp = id;    
        }

        public static void etapa(string id)
        {
            idass = id;
        }
    }
}
