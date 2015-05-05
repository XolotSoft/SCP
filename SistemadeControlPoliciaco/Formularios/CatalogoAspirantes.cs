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
    public partial class CatalogoAspirantes : Form
    {

        public CatalogoAspirantes()
        {
            InitializeComponent();
        }
        ManejoBD bd = new ManejoBD();
        private static CatalogoAspirantes frmInst = null;

        public static CatalogoAspirantes Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new CatalogoAspirantes();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void CatalogoAspirantes_Load(object sender, EventArgs e)
        {
            bd.buscarg("*", "aspirantes");
            dgvAsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvAsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsp.RowHeadersVisible = false;
            dgvAsp.DataSource = bd.ds.Tables[0];
            lblSelec.Text = string.Empty;
            pcbFoto.Image = null;
        }

        private void dgvAsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            pcbFoto.ImageLocation =   Convert.ToString(dgvAsp.Rows[e.RowIndex].Cells[22].Value);
        }
    }
}
