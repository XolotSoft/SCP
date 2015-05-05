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
    public partial class Asignar : Form
    {
        public Asignar()
        {
            InitializeComponent();
        }

        private static Asignar frmInst = null;

        public static Asignar Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Asignar();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void Asignar_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            bd.buscarg("*", "departamentos");
            cmbArea.DataSource = bd.ds.Tables[0].DefaultView;
            cmbArea.DisplayMember = "nombre";
            cmbArea.ValueMember = "id";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            if (Vacio.txb(this))
            {
                string sql = "INSERT INTO recursos(departamento_id,total,restante)VALUES('" + Convert.ToString(cmbArea.SelectedValue) +
                    "','" + txbMonto.Text + "','" + txbMonto.Text + "')";
                if (bd.insertarq(sql))
                {
                    MessageBox.Show("Se asignaron correctamente los recursos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
        }
    }
}
