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
            dgvAsignaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsignaciones.RowHeadersVisible = false;
            ManejoBD bd = new ManejoBD();
            ManejoBD db = new ManejoBD();
            bd.buscarg("*", "departamentos");
            string sql3 = "SELECT d.nombre as Departamento, r.total as 'Cantidad Asignada' from recursos r INNER JOIN departamentos d ON d.id = r.departamento_id";
            db.buscar(sql3);
            dgvAsignaciones.DataSource = db.ds.Tables[0];  
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
                    Actividades acti = new Actividades();
                    acti.Show();

                }
                else
                {

                }
            }
        }
    }
}
