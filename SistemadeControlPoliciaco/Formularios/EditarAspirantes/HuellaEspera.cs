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
    public partial class HuellaEspera : Form
    {
        public HuellaEspera()
        {
            InitializeComponent();
            pgbCargando.Maximum = 100;
            pgbCargando.Minimum = 0;
            pgbCargando.Value = 0;
            pgbCargando.Step = 1;
            tiempo.Enabled = true;
        }

        private static HuellaEspera frmInst = null;

        public static HuellaEspera Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new HuellaEspera();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (pgbCargando.Value < 100)
            {
                pgbCargando.Value += 2;
                
            }
            else
            {
                pgbCargando.Value = 0;
            }
        }

        private void HuellaEspera_Load(object sender, EventArgs e)
        {

        }
    }
}
