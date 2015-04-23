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
    public partial class Escaneo : Form, DPFP.Capture.EventHandler
    {
        public Escaneo()
        {
            InitializeComponent();
        }
        Huella huella = new Huella();
        private static Escaneo frmInst = null;
        private DPFP.Capture.Capture Capturador;
        private DPFP.Processing.Enrollment Enroller = new DPFP.Processing.Enrollment();
        public static Escaneo Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Escaneo();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pcbHuella.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ManejoBD bd = new ManejoBD();
            if (bd.insertarHue(ms))
            {
                if (bd.modificar("UPDATE aspirantes SET etapa = 5 WHERE id = '" + Variables.aspiranteId + "'"))
                {
                    MessageBox.Show("Se ha concluido satisfactoriamente el proceso de registro", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            
        }


        private void BTNescanear_Click(object sender, EventArgs e)
        {
            Capturador = new DPFP.Capture.Capture();
            Capturador.EventHandler = this;
            huella.Start(Capturador);

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
                            MessageBox.Show("Se ha generado correctamente el templete de la huella", "Correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
            {

            }
            else
            {

            }
        }
        #endregion
    }
}
