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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }
        private static EditarUsuario frmInst = null;
        ManejoBD bd = new ManejoBD();

        public static EditarUsuario Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EditarUsuario();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            bd.buscarg("id as ID,username as Usuario," +
               "rol as Tipo", "usuarios");
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.DataSource = bd.ds.Tables[0]; 
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txbId.Text = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
            txbUser.Text = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells[1].Value);
            txbTipo.Text = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells[2].Value);
        }

        private void dgvUsers_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                txbId.Text = Convert.ToString(dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value);
                txbUser.Text = Convert.ToString(dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[1].Value);
                txbTipo.Text = Convert.ToString(dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[2].Value);
            }
            if (e.KeyCode == Keys.Tab)
            {
                txbUser.Focus();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bd.ds.Clear();
            bd.buscarg("id as ID,username as Usuario," +
              "rol as Tipo", "usuarios");
            dgvUsers.Refresh();
            dgvUsers.Focus();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                if (txbPass.Text == txbPass2.Text)
                {
                    string salt = "hbxOlOt23";
                    string passInput = Hash.sha1(Hash.md5(txbPass.Text + salt));
                    string sql = "UPDATE usuarios SET username = '" + txbUser.Text + "'," +
                    "password ='" + passInput + "' WHERE id = '" + txbId.Text + "'";
                    if (bd.modificar(sql))
                    {
                        bd.ds.Clear();
                        bd.buscarg("id as ID,username as Usuario," +
                          "rol as Tipo", "usuarios");
                        dgvUsers.Refresh();
                        dgvUsers.Focus();
                        Limpiar.txb(this);
                        MessageBox.Show("Se ha modificado el Usuario", "Correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha modificado el Usuario", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("NO puedes dejar campos vacios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void txbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }
    }
}
