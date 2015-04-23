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
    public partial class EditarAspirante : Form, DPFP.Capture.EventHandler
    {
        public EditarAspirante()
        {
            InitializeComponent();

        }
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator = new DPFP.Verification.Verification();
        private DPFP.Capture.Capture Capturador;
        private DPFP.Processing.Enrollment Enroller = new DPFP.Processing.Enrollment();
        string id;
        Huella huella = new Huella();
        ManejoBD bd = new ManejoBD();
        private static EditarAspirante frmInst = null;

        public static EditarAspirante Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EditarAspirante();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void EditarAspirante_Load(object sender, EventArgs e)
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
            pcbFoto.Image = Image.FromStream(mem);
            pcbHuella.Image = Image.FromStream(mem2);
            
        }

        private void dgvAsp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                id = Convert.ToString(dgvAsp.Rows[dgvAsp.CurrentRow.Index].Cells[0].Value);
                Variables.Editar(id);
                lblSelec.Text = Variables.idAsp;
                Byte[] data = new Byte[0];
                Byte[] data2 = new Byte[0];
                data = (Byte[])(bd.ds.Tables[0].Rows[dgvAsp.CurrentRow.Index]["foto"]);
                data2 = (Byte[])(bd.ds.Tables[0].Rows[dgvAsp.CurrentRow.Index]["huella_01"]);
                MemoryStream mem = new MemoryStream(data);
                MemoryStream mem2 = new MemoryStream(data2);
                pcbFoto.Image = Image.FromStream(mem);
                pcbHuella.Image = Image.FromStream(mem2);
            }
            if (e.KeyCode == Keys.Tab)
            {
                btnEdi.Focus();
            }
        }

        private void btnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
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
            pcbFoto.Image = null;
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (lblSelec.Text != string.Empty)
            {
                this.Close();
                EditarPersonal dom = null;
                dom = EditarPersonal.Instancia();
                dom.MdiParent = AdminMDI.ActiveForm;
                dom.MdiParent = UserMDI.ActiveForm;
                dom.Show();
            }
            else
            {
                MessageBox.Show("No has selccionado el Aspirante a editar", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void txbNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbRfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbApe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuella_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coloca el dedo sobre el Scanner...", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Capturador = new DPFP.Capture.Capture();
            Capturador.EventHandler = this;
            huella.Start(Capturador);
        }
        protected virtual void Process(DPFP.Sample Sample)
        {
            huella.DrawPicture(huella.ConvertSampleToBitmap(Sample), pcbHuella);
            DPFP.FeatureSet features = huella.ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);
            if (features != null) 
                {
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    Verificator.Verify(features, Template, ref result);
                }
                
                
        }
        #region Eventos Lector de Huella
        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            Process(Sample);
        }
        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {

        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {

        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {

        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MessageBox.Show("No se ha conectado un escaner!", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
            {

            }
            else
            {

            }
        }
        #endregion

        private void pcbFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
