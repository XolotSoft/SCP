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
    public partial class EditarFoto : Form
    {
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public EditarFoto()
        {
            InitializeComponent();
            BuscarDispositivos();
        }
        private static EditarFoto frmInst = null;
        public static EditarFoto Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EditarFoto();
            }
            frmInst.BringToFront();
            return frmInst;
        }
        private void btnHuella_Click(object sender, EventArgs e)
        {
            EditarHuella ft = null;
            ft = EditarHuella.Instancia();
            ft.MdiParent = AdminMDI.ActiveForm;
            ft.Show();
            this.Close();
        }

        private void EditarFoto_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            bd.buscare("*",
               "foto", "aspirante_id", "" + Variables.idAsp + "");
            Byte[] data = new Byte[0];
            data = (Byte[])(bd.ds.Tables[0].Rows[0]["foto"]);
            MemoryStream mem = new MemoryStream(data);
            pcbCap.Image = Image.FromStream(mem);

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

        private void btnContacto_Click(object sender, EventArgs e)
        {
            EditarContacto ec = null;
            ec = EditarContacto.Instancia();
            ec.MdiParent = AdminMDI.ActiveForm;
            ec.Show();
            this.Hide();
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pcbCamara.Image = Imagen;
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
                btnSig.Enabled = true;
            }
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            if (ExistenDispositivos)
            {
                FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cmbDis.SelectedIndex].MonikerString);
                FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                FuenteDeVideo.Start();
                lblEstado.Text = "Ejecutando dispositivo";
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

        private void btnSig_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pcbCap.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ManejoBD bd = new ManejoBD();
            if (bd.editarFoto(ms))
            {  
                    MessageBox.Show("Se ha editado correctamente la foto", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TerminarFuenteDeVideo();
                    pcbCap.Image = null;
                    this.Close();
                    EditarAspirante con = null;
                    con = EditarAspirante.Instancia();
                    con.MdiParent = AdminMDI.ActiveForm;
                    con.MdiParent = UserMDI.ActiveForm;
                    con.Show();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            EditarAspirante con = null;
            con = EditarAspirante.Instancia();
            con.MdiParent = AdminMDI.ActiveForm;
            con.MdiParent = UserMDI.ActiveForm;
            con.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            EditarDomicilio ed = null;
            ed = EditarDomicilio.Instancia();
            ed.MdiParent = AdminMDI.ActiveForm;
            ed.Show();
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
