using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Data.SqlClient;

namespace SistemadeControlPoliciaco
{
    public partial class Foto : Form
    {
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public Foto()
        {
            InitializeComponent();
            BuscarDispositivos();
        }
        private static Foto foto = null;

        public static Foto Instancia()
        {
            if (((foto == null) || (foto.IsDisposed == true)))
            {
                foto = new Foto();
            }
            foto.BringToFront();
            return foto;
        }
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
                cmbDis.Items.Add(Dispositivos[i].Name.ToString());
            cmbDis.Text = cmbDis.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
            }
        }
        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pcbCamara.Image = Imagen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            MemoryStream ms = new MemoryStream();
            pcbCap.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ManejoBD bd = new ManejoBD();
            if (bd.insertarFoto(ms))
            {
                if (bd.modificar("UPDATE aspirantes SET etapa = 4 WHERE id = '"+ Variables.aspiranteId +"'"))
                {
                    MessageBox.Show("Se ha concluido satisfactoriamente la etapa 4 del registro", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TerminarFuenteDeVideo();
                    pcbCap.Image = null;
                    this.Hide();
                    Escaneo con = null;
                    con = Escaneo.Instancia();
                    con.MdiParent = AdminMDI.ActiveForm;
                    con.MdiParent = UserMDI.ActiveForm;
                    con.Show();
                }
            }
        }
        
        private void btnIniCam_Click(object sender, EventArgs e)
        {
            if (ExistenDispositivos)
            {
                FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cmbDis.SelectedIndex].MonikerString);
                FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                FuenteDeVideo.Start();
                lblEstado.Text = " Ejecutando dispositivo";
                cmbDis.Enabled = false;
                btnCapturar.Enabled = true;
                btnIniCam.Enabled = false;
            }
            else
                lblEstado.Text = "Error: No se encuentra dispositivo.";
        }

        private void Foto_Load(object sender, EventArgs e)
        {
            btnCapturar.Enabled = false;
            btnRepetir.Enabled = false;
            btnSig.Enabled = false; 
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (FuenteDeVideo.IsRunning)
            {
                TerminarFuenteDeVideo();
                lblEstado.Text = " Dispositivo detenido";
                cmbDis.Enabled = false;
                btnIniCam.Enabled = false;
                btnCapturar.Enabled = false;
                btnRepetir.Enabled = true;
                pcbCap.Image = pcbCamara.Image;
                pcbCamara.Image = null;
            }
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            if (ExistenDispositivos)
            {
                FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cmbDis.SelectedIndex].MonikerString);
                FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                FuenteDeVideo.Start();
                lblEstado.Text = " Ejecutando dispositivo";
                cmbDis.Enabled = false;
                btnCapturar.Enabled = true;
                btnRepetir.Enabled = false;
                btnIniCam.Enabled = false;
                pcbCap.Image = null;
            }
            else
            {
                lblEstado.Text = "Error: No se encuentra dispositivo.";
            }
                
            pcbCap.Image = null;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            TerminarFuenteDeVideo();
            this.Close();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pcbCap.Image = null;
            this.Hide();
        }
    }
}
