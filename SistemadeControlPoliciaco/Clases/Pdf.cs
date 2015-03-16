using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemadeControlPoliciaco
{
    class Pdf
    {
        static FileStream[] fsi = new FileStream[5];
        static int[] peso = new int[5];

        public static void cargar(int i, FileStream fs )
        {
            fsi[i] = fs;
            if (fsi[i].Length > 0)
            {
                peso[i] = 1;
            }
            else
            {
                peso[i] = 0;
            }
        }
        public static void guardar()
        {
            FileStream[] fso = new FileStream[5];
 
            for (int i = 0; i < 5; i++)
            { 
                if (peso[i] != 0)
                {
                    fso[i] = File.Create(Rutas.pdf() + i + Variables.aspiranteId + ".pdf");
                    fsi[i].CopyTo(fso[i]);
                    fsi[i] = null;
                    fso[i] = null;
                    peso[i] = 0;
                }
            }    
        }
    }
}
