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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }
        private static EliminarUsuario frmInst = null;
        ManejoBD bd = new ManejoBD();
        string id;

        public static EliminarUsuario Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EliminarUsuario();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            bd.buscarg("idUsu as ID,noUsu as Usuario," +
              "tpUsu as Tipo", "usuarios");
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.DataSource = bd.ds.Tables[0]; 
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            id = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
            lblSelec.Text = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells[1].Value);
        }

        private void dgvUsers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                id = Convert.ToString(dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value);
                lblSelec.Text = Convert.ToString(dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[1].Value);
            }
            if (e.KeyCode == Keys.Tab)
            {
                btnEliminar.Focus();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bd.ds.Clear();
            bd.buscarg("idUsu as ID,noUsu as Usuario," +
              "tpUsu as Tipo", "usuarios");
            dgvUsers.Refresh();
            dgvUsers.Focus();
            lblSelec.Text = "";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (bd.eliminar("usuarios", "idUsu", id))
            {
                bd.ds.Clear();
                bd.buscarg("idUsu as ID,noUsu as Usuario," +
                  "tpUsu as Tipo", "usuarios");
                dgvUsers.Refresh();
                dgvUsers.Focus();
                lblSelec.Text = "";
                 MessageBox.Show("Se ha eliminado el Usuario", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha eliminado el Usuario", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
