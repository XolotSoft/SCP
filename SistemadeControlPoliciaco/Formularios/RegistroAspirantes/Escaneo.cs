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
            ManejoBD bd = new ManejoBD();
            if(bd.insertar("aspirantes","appAsp, apmAsp, nomAsp, fncAsp, sexAsp, enfAsp, curAsp,"+
                "rfcAsp, edcAsp,efdAsp, domAsp, colAsp, cdpAsp, cllAsp, nueAsp, nuiAsp,conAsp, pueAsp,"+
                "telAsp, celAsp, emaAsp, fotAsp", "'" + Variables.appAsp + "','" + Variables.apmAsp + "','" + Variables.nomAsp + 
                "','" + Variables.fncAsp + "','" + Variables.sexAsp + "','" + Variables.enfAsp + "','" + Variables.curAsp + 
                "','" + Variables.rfcAsp + "','" + Variables.edcAsp + "','" + Variables.efdAsp + "','" + Variables.domAsp + 
                "','" + Variables.colAsp + "','" + Variables.cdpAsp + "','" + Variables.cllAsp + "','" + Variables.nueAsp + 
                "','" + Variables.nuiAsp + "','" + Variables.conAsp + "','" + Variables.pueAsp + "','" + Variables.telAsp +
                "','" + Variables.celAsp + "','" + Variables.emaAsp + "','" + Variables.fotAsp + "'"))
            {
                MessageBox.Show("El aspirante se ha registrado", "Correcto",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se registro el Aspirante", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
