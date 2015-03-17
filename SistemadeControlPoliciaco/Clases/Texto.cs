using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SistemadeControlPoliciaco
{
    class Texto
    {
        public string Capital(string cadena)
        {
            string cap;
            cap = cadena.ToLower();
            cap = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(cap);
            return cap;
        }
    }
}
