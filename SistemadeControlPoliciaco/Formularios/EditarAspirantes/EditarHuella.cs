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
    public partial class EditarHuella : Form, DPFP.Capture.EventHandler
    {
        public EditarHuella()
        {
            InitializeComponent();
        }

        Huella huella = new Huella();
        private static EditarHuella frmInst = null;
        private DPFP.Capture.Capture Capturador;
        private DPFP.Processing.Enrollment Enroller = new DPFP.Processing.Enrollment();

        public static EditarHuella Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EditarHuella();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        protected virtual void Process(DPFP.Sample Sample)
        {
            huella.DrawPicture(huella.ConvertSampleToBitmap(Sample), pcbHuella);
            DPFP.FeatureSet features = huella.ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);
            if (features != null) try
                {
                    for (int i = -1; i < Enroller.FeaturesNeeded; i++)
                    {
                        Enroller.AddFeatures(features);
                    }
                    Enroller.AddFeatures(features);
                }
            finally
            {
                switch (Enroller.TemplateStatus)
                {
                    case DPFP.Processing.Enrollment.Status.Ready:
                        //MessageBox.Show("Se ha generado correctamente el templete de la huella", "Correcto",
                        //MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MemoryStream ms = new MemoryStream();
                        huella.Stop(Capturador);
                        Enroller.Template.Serialize(ms);
                        break;

                    case DPFP.Processing.Enrollment.Status.Failed:
                        Enroller.Clear();
                        huella.Stop(Capturador);
                        huella.Start(Capturador);
                        break;
                }
            }
        }

        #region Eventos Lector de Huella

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            HuellaEspera he = new HuellaEspera();
            he.Close();
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
            HuellaEspera he = null;
            he = HuellaEspera.Instancia();
            he.Show();
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MessageBox.Show("No se ha conectado un escaner!", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good){}else{}
        }

        #endregion

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pcbHuella.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ManejoBD bd = new ManejoBD();
            if (bd.editarHuella(ms))
            {
                    MessageBox.Show("Se ha modificado correctamente la Huella", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    EditarAspirante con = null;
                    con = EditarAspirante.Instancia();
                    con.MdiParent = AdminMDI.ActiveForm;
                    con.MdiParent = UserMDI.ActiveForm;
                    con.Show();
            }

        }

        private void EditarHuella_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            bd.buscare("*",
               "huella", "aspirante_id", "" + Variables.idAsp + "");
            Byte[] data = new Byte[0];
            data = (Byte[])(bd.ds.Tables[0].Rows[0]["huella_01"]);
            MemoryStream mem = new MemoryStream(data);
            pcbHuella.Image = Image.FromStream(mem);
        }

        private void BTNescanear_Click_1(object sender, EventArgs e)
        {
                Capturador = new DPFP.Capture.Capture();
                Capturador.EventHandler = this;
                huella.Start(Capturador);        
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            EditarAspirante con = null;
            con = EditarAspirante.Instancia();
            con.MdiParent = AdminMDI.ActiveForm;
            con.MdiParent = UserMDI.ActiveForm;
            con.Show();
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            EditarDomicilio ed = null;
            ed = EditarDomicilio.Instancia();
            ed.MdiParent = AdminMDI.ActiveForm;
            ed.Show();
            this.Close();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            EditarContacto ec = null;
            ec = EditarContacto.Instancia();
            ec.MdiParent = AdminMDI.ActiveForm;
            ec.Show();
            this.Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            EditarFoto ft = null;
            ft = EditarFoto.Instancia();
            ft.MdiParent = AdminMDI.ActiveForm;
            ft.Show();
            this.Close();
        }

        private void btnPersonales_Click(object sender, EventArgs e)
        {
            EditarPersonal ec = null;
            ec = EditarPersonal.Instancia();
            ec.MdiParent = AdminMDI.ActiveForm;
            ec.Show();
            this.Close();
        }
    }
}
