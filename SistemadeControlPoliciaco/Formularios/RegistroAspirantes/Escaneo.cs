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
    public partial class Escaneo : Form, DPFP.Capture.EventHandler
    {
        public Escaneo()
        {
            InitializeComponent();
        }
        private static Escaneo frmInst = null;
        private DPFP.Capture.Capture Capturador;
        public static Escaneo Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Escaneo();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        protected virtual void Init()
        {
            try
            {
                Capturador = new DPFP.Capture.Capture();
                if (null != Capturador)
                {
                    Capturador.EventHandler = this;
                }
                else
                {
                    MessageBox.Show("No se puede iniciar la operacion de captura!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No se puede iniciar la operacion de captura!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Start()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha concluido satisfactoriamente el proceso de registro", "Correcto",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void Escaneo_Load(object sender, EventArgs e)
        {

        }

        private void DrawPicture(Bitmap bitmap)
        {
            pcbHuella.Image = new Bitmap(bitmap, pcbHuella.Size );
        }

        private void BTNescanear_Click(object sender, EventArgs e)
        {
            Capturador = new DPFP.Capture.Capture();
            Capturador.EventHandler = this;
            Capturador.StartCapture();

        }
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
            
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
           
        }
        protected virtual void Process(DPFP.Sample Sample)
        {
            
            DrawPicture(ConvertSampleToBitmap(Sample));
        }
        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

    }
}
