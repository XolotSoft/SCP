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
            bd.buscar("SELECT a.id as ID,p.apellido_paterno as Paterno,p.apellido_materno as Materno,p.nombre as Nombre,p.rfc as RFC,c.foto,h.huella_01 FROM aspirantes a INNER JOIN personal p ON a.id = p.aspirante_id INNER JOIN foto c ON a.id = c.aspirante_id INNER JOIN huella h ON a.id = h.aspirante_id");
            dgvAsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsp.RowHeadersVisible = false;
            dgvAsp.DataSource = bd.ds.Tables[0];
            dgvAsp.Columns[5].Visible = false;
            dgvAsp.Columns[0].Width = 55;
            dgvAsp.Columns[4].Width = 150;
            dgvAsp.Columns[6].Visible = false;
            lblSelec.Text = string.Empty;
            pcbFoto.Image = null;
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

        private void btnCer_Click_1(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
            this.Close();
        }

        private void btnEdi_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFil_Click(object sender, EventArgs e)
        {    
            string sql = "SELECT a.id as ID,p.apellido_paterno as Paterno,p.apellido_materno as Materno,p.nombre as Nombre,p.rfc as RFC,c.foto,h.huella_01 FROM aspirantes a INNER JOIN personal p ON a.id = p.aspirante_id INNER JOIN foto c ON a.id = c.aspirante_id INNER JOIN huella h ON a.id = h.aspirante_id " +
             "WHERE apellido_paterno LIKE '%" + txbApe.Text + "%' OR nombre LIKE '%" + txbApe.Text + "%' OR apellido_materno LIKE '%" + txbApe.Text + "%' OR rfc LIKE '%"
             + txbApe.Text + "%'";
            bd.ds.Clear();
            bd.buscar(sql);
            dgvAsp.DataSource = bd.ds.Tables[0];
            dgvAsp.Columns[6].Visible = false;
            dgvAsp.Columns[0].Width = 55;
            dgvAsp.Columns[4].Width = 120;
            dgvAsp.Refresh();
            dgvAsp.Focus();
            lblSelec.Text = string.Empty;
            pcbHuella.Image = null;
            pcbFoto.Image = null;
        }

        private void dgvAsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            id = Convert.ToString(dgvAsp.Rows[e.RowIndex].Cells[0].Value);
            Variables.Editar(id);
            lblSelec.Text = Variables.idAsp;
            Byte[] data = new Byte[0];
            Byte[] data2 = new Byte[0];
            data = (Byte[])(bd.ds.Tables[0].Rows[e.RowIndex]["foto"]);
            data2 = (Byte[])(bd.ds.Tables[0].Rows[e.RowIndex]["huella_01"]);
            MemoryStream mem = new MemoryStream(data);
            MemoryStream mem2 = new MemoryStream(data2);
            //if(mem == "")
            //{
            //    pcbFoto.Image = 
            //}
            pcbFoto.Image = Image.FromStream(mem);
            pcbHuella.Image = Image.FromStream(mem2);
        }

        private void btnEdi_Click_1(object sender, EventArgs e)
        {          
            string id = Convert.ToString(dgvAsp.Rows[dgvAsp.CurrentRow.Index].Cells[0].Value);
            ManejoBD el = new ManejoBD();
            if (el.eliminar("aspirantes", "id", id))
            {
                MessageBox.Show("Se ha eliminado correctamente");
                bd.ds.Clear();
                bd.buscar("SELECT a.id as ID,p.apellido_paterno as Paterno,p.apellido_materno as Materno,p.nombre as Nombre,p.rfc as RFC,c.foto,h.huella_01 FROM aspirantes a INNER JOIN personal p ON a.id = p.aspirante_id INNER JOIN foto c ON a.id = c.aspirante_id INNER JOIN huella h ON a.id = h.aspirante_id");
                dgvAsp.DataSource = bd.ds.Tables[0];
                dgvAsp.Columns[6].Visible = false;
                dgvAsp.Columns[0].Width = 55;
                dgvAsp.Columns[4].Width = 120;
                dgvAsp.Refresh();
                dgvAsp.Focus();
                lblSelec.Text = string.Empty;
                pcbHuella.Image = null;
                pcbFoto.Image = null;
            }

            else
            {
                MessageBox.Show("No se realizo");
            }
        }

        private void btnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
