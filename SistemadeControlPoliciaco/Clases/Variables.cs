using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeControlPoliciaco
{
    public static class Variables
    {
        public static string appAsp, apmAsp, nomAsp, fncAsp, sexAsp, enfAsp, curAsp, rfcAsp, edcAsp,
            efdAsp, domAsp, colAsp, cdpAsp, cllAsp, nueAsp, nuiAsp,
            conAsp, pueAsp, telAsp, celAsp, emaAsp, fotAsp, gueAsp, idAsp;


        public static void DatosPersonales(string aPat, string aMat, string nAsp, string fNac, string eFed, string sAsp, string cAsp, string rAsp, string ccAsp)

        {
            appAsp = aPat;
            apmAsp = aMat;
            nomAsp = nAsp;
            fncAsp = fNac;
            enfAsp = eFed;
            sexAsp = sAsp;
            curAsp = cAsp;
            rfcAsp = rAsp;
            edcAsp = ccAsp;

        }

        public static void Domicilio(string ef, string dm, string cl, string cp, string cy, string ne, string ni)
        {
            efdAsp = ef;
            domAsp = dm;
            colAsp = cl;
            cdpAsp = cp;
            cllAsp = cy;
            nueAsp = ne;
            nuiAsp = ni;
        }

        public static void Contacto(string cn, string pt, string tl, string cl, string em)
        {
            conAsp = cn;
            pueAsp = pt;
            telAsp = tl;
            celAsp = cl;
            emaAsp = em;
        }

        public static void Editar(string id)
        {
            idAsp = id;
        
        }

        public static void Foto(string ft)
        {
            fotAsp = ft;

        }
    }
}
