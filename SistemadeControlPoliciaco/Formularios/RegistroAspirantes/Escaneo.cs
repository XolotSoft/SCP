using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeControlPoliciaco
{
    public partial class Escaneo : Form
    {
        public Escaneo()
        {
            InitializeComponent();
        }
        private static Escaneo frmInst = null;

        public static Escaneo Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Escaneo();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha concluido satisfactoriamente el proceso de registro", "Correcto",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
