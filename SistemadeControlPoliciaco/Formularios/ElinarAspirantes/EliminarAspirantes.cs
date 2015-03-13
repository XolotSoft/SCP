using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemadeControlPoliciaco
{
    public partial class EliminarAspirantes : Form
    {
        public EliminarAspirantes()
        {
            InitializeComponent();
        }
        private static EliminarAspirantes frmInst = null;
        ManejoBD bd = new ManejoBD();
        string id;
        public static EliminarAspirantes Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EliminarAspirantes();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void EliminarAspirantes_Load(object sender, EventArgs e)
        {
            bd.buscar("SELECT a.idAsp as ID,p.appAsp as Paterno,p.apmAsp as Materno,p.nomAsp as Nombre,p.rfcAsp as RFC,c.fotAsp FROM aspirantes a INNER JOIN personales p ON a.personales_id = p.personales_id INNER JOIN captura c ON a.captura_id = c.captura_id");
            dgvAsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsp.RowHeadersVisible = false;
            dgvAsp.DataSource = bd.ds.Tables[0];
            dgvAsp.Columns[5].Visible = false;
            dgvAsp.Columns[0].Width = 55;
            dgvAsp.Columns[4].Width = 150;
            lblSelec.Text = string.Empty;
            pcbFoto.Image = null;
        }

        private void dgvAsp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                id = Convert.ToString(dgvAsp.Rows[dgvAsp.CurrentRow.Index].Cells[0].Value);
                Variables.Editar(id);
                lblSelec.Text = Variables.idAsp;
                pcbFoto.ImageLocation = Convert.ToString(dgvAsp.Rows[dgvAsp.CurrentRow.Index].Cells[6].Value);
            }
            if (e.KeyCode == Keys.Tab)
            {
                btnEdi.Focus();
            }
        }

        private void txbApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbRfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void btnFil_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT idAsp as ID,appAsp as Paterno,apmAsp as Materno," +
                "nomAsp as Nombre,rfcAsp as RFC,conAsp as Convocatoria, fotAsp FROM aspirantes " +
                "WHERE appAsp LIKE '%" + txbApe.Text + "%' AND nomAsp LIKE '%" + txbNom.Text + "%' AND rfcAsp LIKE '%"
                + txbRfc.Text + "%' AND conAsp LIKE '%" + txbCon.Text + "%'";
            bd.ds.Clear();
            bd.buscar(sql);
            dgvAsp.DataSource = bd.ds.Tables[0];
            dgvAsp.Columns[6].Visible = false;
            dgvAsp.Columns[0].Width = 55;
            dgvAsp.Columns[4].Width = 120;
            dgvAsp.Refresh();
            dgvAsp.Focus();
            lblSelec.Text = string.Empty;
            pcbFoto.Image = null;

        }

        private void dgvAsp_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            id = Convert.ToString(dgvAsp.Rows[e.RowIndex].Cells[0].Value);
            Variables.Editar(id);
            lblSelec.Text = Variables.idAsp;
            Byte[] data = new Byte[0];
            data = (Byte[])(bd.ds.Tables[0].Rows[e.RowIndex]["fotAsp"]);
            MemoryStream mem = new MemoryStream(data);
            pcbFoto.Image = Image.FromStream(mem);
        }

        private void btnCer_Click_1(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
            this.Close();
        }

        private void btnEdi_Click(object sender, EventArgs e)
        {
            if (lblSelec.Text != string.Empty)
            {
                if (bd.eliminar("aspirantes", "idAsp", "" + id + ""))
                {
                    MessageBox.Show("El aspirante se ha Eliminado de forma permanente", "Correcto",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bd.ds.Clear();
                    string sql = "SELECT idAsp as ID,appAsp as Paterno,apmAsp as Materno," +
                   "nomAsp as Nombre,rfcAsp as RFC,conAsp as Convocatoria, fotAsp FROM aspirantes " +
                   "WHERE appAsp LIKE '%" + txbApe.Text + "%' AND nomAsp LIKE '%" + txbNom.Text + "%' AND rfcAsp LIKE '%"
                   + txbRfc.Text + "%' AND conAsp LIKE '%" + txbCon.Text + "%'";
                    bd.ds.Clear();
                    bd.buscar(sql);
                    dgvAsp.DataSource = bd.ds.Tables[0];
                    dgvAsp.Columns[6].Visible = false;
                    dgvAsp.Columns[0].Width = 55;
                    dgvAsp.Columns[4].Width = 120;
                    dgvAsp.Refresh();
                    dgvAsp.Focus();
                    lblSelec.Text = string.Empty;
                    pcbFoto.Image = null;
                }
                else
                {
                    MessageBox.Show("El aspirante no se ha eliminado", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }     
    }
}
