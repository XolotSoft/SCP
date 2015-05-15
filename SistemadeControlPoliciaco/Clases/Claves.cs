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
        string curp, primeraLetraPaterno, segundaLetraPaterno,fecha,sexo,entidad,paternoConsonanteInterna,nombreConsonanteInterna,slNombre,scMaterno,primeraLetraMaterno,rfc,daPaterno,daMaterno,sNombre,fec;
        public string Curp(string paterno, string materno, string plNombre,DateTimePicker fecna,ComboBox enf, ComboBox sex)
        {
            #region Apellido Paterno
            if (paterno == string.Empty)
            {
                primeraLetraPaterno = "X";
                segundaLetraPaterno = "X";
            }
            else
            {
                primeraLetraPaterno = paterno.Substring(0, 1).ToUpper();

                if (paterno.Length < 2)
                {
                    segundaLetraPaterno = "X";
                }
                else
                {
                    string paternoSinLetraUno = paterno.Substring(1, paterno.Length - 1).ToUpper();

                    for (int i = 0; i < paternoSinLetraUno.Length; i++)
                    {
                        string letra = paternoSinLetraUno.Substring(i, 1);
                        if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
                        {
                            segundaLetraPaterno = letra;
                            break;
                        }
                        else
                        {
                            segundaLetraPaterno = "X";
                        }
                    }

                    for (int i = 0; i < paternoSinLetraUno.Length; i++)
                    {
                        string letra = paternoSinLetraUno.Substring(i, 1);
                        if (letra == "Ñ")
                        {
                            paternoConsonanteInterna = "X";
                            break;
                        }
                        else if (letra != "A" && letra != "E" && letra != "I" && letra != "O" && letra != "U")
                        {
                            paternoConsonanteInterna = letra;
                            break;
                        }
                        else
                        {
                            paternoConsonanteInterna = "X";
                        }
                    }
                }
                
            }
            #endregion

            #region Apellido Materno
            if (materno == string.Empty)
             {
                 primeraLetraMaterno = "X";
             } 
             else
             {
                 primeraLetraMaterno = materno.Substring(0, 1).ToUpper();
                 for (int i = 1; i < materno.Length; i++)
                 {
                     string letra = materno.Substring(i, 1).ToUpper();

                     if (letra == "Ñ")
                     {
                         paternoConsonanteInterna = "X";
                         break;
                     }
                     else if (letra != "A" && letra != "E" && letra != "I" && letra != "O" && letra != "U")
                     {
                         scMaterno = letra.Substring(0, 1).ToUpper();
                         break;
                     }
                     else
                     {
                         scMaterno = "X";
                     }

                 }
             }

            #endregion

            #region Nombre
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

            if (plNombre == string.Empty || plNombre.Length < 2)
            {
                nombreConsonanteInterna = "X";
            }
            else
            {
                string nombreSinLetraUno = plNombre.Substring(1, plNombre.Length - 1).ToUpper();
                for (int i = 0; i < nombreSinLetraUno.Length; i++)
                {
                    string letra = nombreSinLetraUno.Substring(i, 1);

                    if (letra != "A" && letra != "E" && letra != "I" && letra != "O" && letra != "U")
                    {
                        nombreConsonanteInterna = letra;
                        break;
                    }
                    else
                    {
                        nombreConsonanteInterna = "X";
                    }
                }
            }
            #endregion

            fecna.CustomFormat = "yyyy-MM-dd";
            string anio = fecna.Text.Substring(2, 2);
            string mes = fecna.Text.Substring(5, 2);
            string dia = fecna.Text.Substring(8, 2);
            fecha = anio + mes + dia;

            if (sex.SelectedIndex != -1)
            {
                sexo = sex.Text.Substring(0, 1).ToUpper();
            }
            if (enf.SelectedIndex != -1)
            {
                entidad = enf.SelectedValue.ToString();
            }


            curp = primeraLetraPaterno + segundaLetraPaterno + primeraLetraMaterno + slNombre + fecha + sexo + entidad + paternoConsonanteInterna + scMaterno + nombreConsonanteInterna;
            return curp;
        }
        public string Rfc(string apellidoPatr, string apellidoMatr,string nombrer, DateTimePicker fechan)
        {
            if (apellidoPatr == string.Empty) daPaterno = "XX";
            else daPaterno = apellidoPatr.Substring(0, 2).ToUpper();

            if (apellidoMatr != string.Empty) daMaterno = apellidoMatr.Substring(0, 1).ToUpper();
            else daMaterno = "X";

            if (nombrer != string.Empty) sNombre = nombrer.Substring(0, 1).ToUpper();
            else sNombre = "X";

            fechan.CustomFormat = "yyyy-MM-dd";
            string anio = fechan.Text.Substring(2, 2);
            string mes = fechan.Text.Substring(5, 2);
            string dia = fechan.Text.Substring(8, 2);
            fec = anio + mes + dia;

            return rfc = daPaterno + daMaterno + sNombre + fec; 
        }
     }
}
