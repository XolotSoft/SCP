using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeControlPoliciaco
{
    public class Vacio
    {
        public static int bo;
        public static bool txb(Form frm)
        {

            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is TextBox && ctrl.Text == String.Empty)
                {
                    bo = 0;
                    break;
                }
                else
                {
                    bo = 1;
                }
            }
            if (bo > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool cbx(Form frm)
        {

            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is ComboBox && ctrl.Text == String.Empty)
                {
                    bo = 0;
                    break;
                }
                else
                {
                    bo = 1;
                }
            }
            if (bo > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
