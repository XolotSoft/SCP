using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeControlPoliciaco
{
    public class Limpiar
    {
        public static void txb(Form frm)
        {
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        public static void cbx(Form frm)
        {
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.ResetText();
                }
            }
        }
   
        public static void trim(Form frm)
        {
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text.Trim();
                }
            }
        }
    }
}
