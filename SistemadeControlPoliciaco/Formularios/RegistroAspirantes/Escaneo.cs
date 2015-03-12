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
            ob_id id = new ob_id();
            string ida = id.obtener(Variables.rfcAsp);
            if (bd.insertar("identificadores", "guAsp", "'huellax'"))
            {

                if (bd.modificar("UPDATE aspirantes SET identificador_id = (SELECT TOP 1 identificadores_id FROM identificadores d ORDER BY identificadores_id DESC),etapa=5 WHERE idAsp = '" + ida + "'"))
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
}
