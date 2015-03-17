using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeControlPoliciaco
{
    class Huella
    {

        public void DrawPicture(Bitmap bitmap, PictureBox pcb)
        {
            pcb.Image = new Bitmap(bitmap, pcb.Size);
        }

        public Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

        public DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        public void Start(DPFP.Capture.Capture Capturador)
        {
            if (null != Capturador)
            {
                try
                {
                    Capturador.StartCapture();
                }
                catch
                {

                }
            }
        }
        public void Stop(DPFP.Capture.Capture Capturador)
        {
            if (null != Capturador)
            {
                try
                {
                    Capturador.StopCapture();
                }
                catch
                {

                }
            }
        }
    }
}
