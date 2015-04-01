using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeControlPoliciaco
{
    class Claves
    {
        string curp, plPaterno, slPaterno,fecha,sexo,entidad,pcinterna,scPaterno,slNombre,scMaterno,plMaterno,rfc,daPaterno,daMaterno,sNombre,fec;
        public string Curp(string app, string apellidoMat, string plNombre,DateTimePicker fecna,ComboBox enf, ComboBox sex)
        {
           
            plPaterno = app.Substring(0, 1).ToUpper();

            string appr = app.Substring(1,app.Length -1).ToUpper();

            for (int i = 0; i < appr.Length; i++)
		    {
                string letra = appr.Substring(i, 1);
			    if (letra == "A" || letra == "E"|| letra == "I"|| letra == "O" || letra == "U")
                {
                    slPaterno = letra;
                    break;
                }
		    }

            for (int i = 0; i < appr.Length; i++)
            {
                string letra = appr.Substring(i, 1);
                if (letra != "A" || letra != "E" || letra != "I" || letra != "O" || letra != "U")
                {
                    pcinterna = letra;
                    break;
                }
            }

             if (apellidoMat == string.Empty)
             {
                 plMaterno = "X";
             } 
             else
             {
                 plMaterno = apellidoMat.Substring(0, 1).ToUpper();
                 for (int i = 1; i < apellidoMat.Length; i++)
                 {
                     string letra = apellidoMat.Substring(i, 1).ToUpper();
                     if (letra != "A" || letra != "E" || letra != "I" || letra != "O" || letra != "U")
                     {
                         scMaterno = letra.Substring(0, 1).ToUpper();
                         break;
                     }

                 }
             }
      

            for (int i = 0; i < plNombre.Length; i++)
            {
                string letra = plNombre.Substring(i, 1).ToUpper();
                if (letra == " ")
                {
                    string largo = plNombre.Substring(0, i).ToUpper();
                    
                   
                    if (largo.Length == 5)

                    {
                        if (plNombre.Substring(0, 5).ToUpper() == "MARIA")
                        {
                           slNombre = plNombre.Substring(5, plNombre.Length - 5).ToUpper();
                           slNombre = slNombre.Substring(1, 1).ToUpper();
                        }
                        else 
                        {
                            slNombre = plNombre.Substring(0, 1).ToUpper();
                        }

                    }

                    if (largo.Length == 4)
                    {
                        if (plNombre.Substring(0, 4).ToUpper() == "JOSE")
                        {
                            slNombre = plNombre.Substring(4, plNombre.Length - 4).ToUpper();
                            slNombre = slNombre.Substring(1, 1).ToUpper();
                        }
                        else
                        {
                            slNombre = plNombre.Substring(0, 1).ToUpper();
                        }

                    }
                    break;
                }
                else
                {
                    slNombre = plNombre.Substring(0, 1).ToUpper();
                }

            }

                fecna.CustomFormat = "yyyy-MM-dd";
            string anio = fecna.Text.Substring(2, 2);
            string mes = fecna.Text.Substring(5, 2);
            string dia = fecna.Text.Substring(8, 2);
            fecha = anio + mes + dia;

            if (sex.SelectedIndex != 0)
            {
                sexo = sex.Text.Substring(0, 1).ToUpper();
            }
            if (sex.SelectedIndex != 0)
            {
                entidad = enf.SelectedValue.ToString();
            }
                

            curp = plPaterno + slPaterno + plMaterno + slNombre + fecha + sexo + entidad + pcinterna + scMaterno;
            return curp;
        }
        public string Rfc(string apellidoPatr, string apellidoMatr,string nombrer, DateTimePicker fechan)
        {
            daPaterno = apellidoPatr.Substring(0, 2).ToUpper();
            if (apellidoMatr != string.Empty)
            {
                daMaterno = apellidoMatr.Substring(0, 1).ToUpper();
            }
            if (nombrer != string.Empty)
            {
                sNombre = nombrer.Substring(0, 1).ToUpper();
            }

            fechan.CustomFormat = "yyyy-MM-dd";
            string anio = fechan.Text.Substring(2, 2);
            string mes = fechan.Text.Substring(5, 2);
            string dia = fechan.Text.Substring(8, 2);
            fec = anio + mes + dia;

            return rfc = daPaterno + daMaterno + sNombre + fec; 
        }
     }
}
