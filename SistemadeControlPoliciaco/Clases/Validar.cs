using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SistemadeControlPoliciaco
{
    class Validar
    {
        public static void letynum(KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten letras y números", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void letynumesp(KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsWhiteSpace(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se permiten letras y numeros", "Atención",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public static void letrasyesp(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsWhiteSpace(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se permiten letras", "Atención",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public static void letras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten letras", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void num(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten números", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static bool mail(string smail)
        {
            return Regex.IsMatch(smail, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$");
        }

        public static void numypun(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo se permiten números y un punto decimal", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

    }
}
