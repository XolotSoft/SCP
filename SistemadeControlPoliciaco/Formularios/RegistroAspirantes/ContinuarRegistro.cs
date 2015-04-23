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
    public partial class ContinuarRegistro : Form
    {
        public ContinuarRegistro()
        {
            InitializeComponent();
        }

        ManejoBD bd = new ManejoBD();
        private static ContinuarRegistro frmInst = null;

        public static ContinuarRegistro Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new ContinuarRegistro();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void ContinuarRegistro_Load(object sender, EventArgs e)
        {
            bd.buscar("SELECT a.id as ID,p.apellido_paterno as Paterno,p.apellido_materno as Materno,p.nombre as Nombre,p.rfc as RFC, a.etapa AS 'Etapa Actual' FROM aspirantes a INNER JOIN personal p ON a.id = p.aspirante_id WHERE a.etapa < 5");
            dgvAsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsp.RowHeadersVisible = false;
            dgvAsp.DataSource = bd.ds.Tables[0];
            dgvAsp.Columns[0].Width = 55;
            dgvAsp.Columns[4].Width = 150;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT a.id as ID,p.apellido_paterno as Paterno,p.apellido_materno as Materno,p.nombre as Nombre,p.rfc as RFC, a.etapa AS 'Etapa Actual' FROM aspirantes a INNER JOIN personal p ON a.id = p.aspirante_id " +
                 "WHERE a.etapa < 5 AND (apellido_paterno LIKE '%" + txbApe.Text + "%' OR nombre LIKE '%" + txbApe.Text + "%' OR apellido_materno LIKE '%" + txbApe.Text + "%' OR rfc LIKE '%"
                 + txbApe.Text + "%') ";
            bd.ds.Clear();
            bd.buscar(sql);
            dgvAsp.DataSource = bd.ds.Tables[0];
            dgvAsp.Columns[0].Width = 55;
            dgvAsp.Columns[4].Width = 120;
            dgvAsp.Refresh();
            dgvAsp.Focus();
        }

        private void dgvAsp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string id = Convert.ToString(dgvAsp.Rows[e.RowIndex].Cells[0].Value);
            Variables.AspiranteID(id);
            string etapa = Convert.ToString(dgvAsp.Rows[e.RowIndex].Cells[5].Value);
            switch (etapa)
            {
                case "1":
                    this.Close();
                    Domicilio domicilio = null;
                    domicilio = Domicilio.Instancia();
                    domicilio.MdiParent = AdminMDI.ActiveForm;
                    domicilio.MdiParent = UserMDI.ActiveForm;
                    domicilio.Show();
                    break;
                case "2":
                    this.Close();
                    Contacto contacto = null;
                    contacto = Contacto.Instancia();
                    contacto.MdiParent = AdminMDI.ActiveForm;
                    contacto.MdiParent = UserMDI.ActiveForm;
                    contacto.Show();
                    break;
                case "3":
                    this.Close();
                    Foto foto = null;
                    foto = Foto.Instancia();
                    foto.MdiParent = AdminMDI.ActiveForm;
                    foto.MdiParent = UserMDI.ActiveForm;
                    foto.Show();
                    break;
                case "4":
                    this.Close();
                    Escaneo escaneo = null;
                    escaneo = Escaneo.Instancia();
                    escaneo.MdiParent = AdminMDI.ActiveForm;
                    escaneo.MdiParent = UserMDI.ActiveForm;
                    escaneo.Show();
                    break;
                default:
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dgvAsp.Rows[dgvAsp.CurrentRow.Index].Cells[0].Value);
            Variables.AspiranteID(id);
            string etapa = Convert.ToString(dgvAsp.Rows[dgvAsp.CurrentRow.Index].Cells[5].Value);
            switch (etapa)
            {
                case "1":
                    this.Close();
                    Domicilio domicilio = null;
                    domicilio = Domicilio.Instancia();
                    domicilio.MdiParent = AdminMDI.ActiveForm;
                    domicilio.MdiParent = UserMDI.ActiveForm;
                    domicilio.Show();
                    break;
                case "2":
                    this.Close();
                    Contacto contacto = null;
                    contacto = Contacto.Instancia();
                    contacto.MdiParent = AdminMDI.ActiveForm;
                    contacto.MdiParent = UserMDI.ActiveForm;
                    contacto.Show();
                    break;
                case "3":
                    this.Close();
                    Foto foto = null;
                    foto = Foto.Instancia();
                    foto.MdiParent = AdminMDI.ActiveForm;
                    foto.MdiParent = UserMDI.ActiveForm;
                    foto.Show();
                    break;
                case "4":
                    this.Close();
                    Escaneo escaneo = null;
                    escaneo = Escaneo.Instancia();
                    escaneo.MdiParent = AdminMDI.ActiveForm;
                    escaneo.MdiParent = UserMDI.ActiveForm;
                    escaneo.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
