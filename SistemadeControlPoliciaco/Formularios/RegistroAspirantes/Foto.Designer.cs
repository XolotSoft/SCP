namespace SistemadeControlPoliciaco
{
    partial class Foto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foto));
            this.btnIniCam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnRepetir = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.pcbCap = new System.Windows.Forms.PictureBox();
            this.pcbCamara = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDisp = new System.Windows.Forms.Label();
            this.cmbDis = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniCam
            // 
            this.btnIniCam.Image = global::SistemadeControlPoliciaco.Properties.Resources.webcam;
            this.btnIniCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniCam.Location = new System.Drawing.Point(124, 360);
            this.btnIniCam.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniCam.Name = "btnIniCam";
            this.btnIniCam.Size = new System.Drawing.Size(149, 35);
            this.btnIniCam.TabIndex = 0;
            this.btnIniCam.Text = "Iniciar Camara ";
            this.btnIniCam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniCam.UseVisualStyleBackColor = true;
            this.btnIniCam.Click += new System.EventHandler(this.btnIniCam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(597, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Captura actual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Image = global::SistemadeControlPoliciaco.Properties.Resources.Camara;
            this.btnCapturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapturar.Location = new System.Drawing.Point(399, 191);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(110, 35);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar  ";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnRepetir
            // 
            this.btnRepetir.Image = global::SistemadeControlPoliciaco.Properties.Resources.deleteDates;
            this.btnRepetir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepetir.Location = new System.Drawing.Point(399, 274);
            this.btnRepetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepetir.Name = "btnRepetir";
            this.btnRepetir.Size = new System.Drawing.Size(110, 35);
            this.btnRepetir.TabIndex = 3;
            this.btnRepetir.Text = "Repetir    ";
            this.btnRepetir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRepetir.UseVisualStyleBackColor = true;
            this.btnRepetir.Click += new System.EventHandler(this.btnRepetir_Click);
            // 
            // btnSig
            // 
            this.btnSig.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401844327_checkmark_24;
            this.btnSig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSig.Location = new System.Drawing.Point(610, 416);
            this.btnSig.Margin = new System.Windows.Forms.Padding(4);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(110, 35);
            this.btnSig.TabIndex = 4;
            this.btnSig.Text = "Siguiente ";
            this.btnSig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.button4_Click);
            // 
            // pcbCap
            // 
            this.pcbCap.Location = new System.Drawing.Point(574, 171);
            this.pcbCap.Name = "pcbCap";
            this.pcbCap.Size = new System.Drawing.Size(146, 138);
            this.pcbCap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCap.TabIndex = 7;
            this.pcbCap.TabStop = false;
            // 
            // pcbCamara
            // 
            this.pcbCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbCamara.Location = new System.Drawing.Point(85, 121);
            this.pcbCamara.Name = "pcbCamara";
            this.pcbCamara.Size = new System.Drawing.Size(242, 223);
            this.pcbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCamara.TabIndex = 6;
            this.pcbCamara.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(82, 102);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 9;
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.BackColor = System.Drawing.Color.Transparent;
            this.lblDisp.Location = new System.Drawing.Point(51, 419);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(82, 16);
            this.lblDisp.TabIndex = 10;
            this.lblDisp.Text = "Dispositivos";
            // 
            // cmbDis
            // 
            this.cmbDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDis.FormattingEnabled = true;
            this.cmbDis.Location = new System.Drawing.Point(139, 416);
            this.cmbDis.Name = "cmbDis";
            this.cmbDis.Size = new System.Drawing.Size(159, 24);
            this.cmbDis.TabIndex = 8;
            this.cmbDis.SelectedIndexChanged += new System.EventHandler(this.cmbDis_SelectedIndexChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401842826_cross_24;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(490, 416);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 35);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar   ";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.fotografia;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblDisp);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbDis);
            this.Controls.Add(this.pcbCap);
            this.Controls.Add(this.pcbCamara);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnRepetir);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniCam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Foto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto";
            this.Load += new System.EventHandler(this.Foto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniCam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnRepetir;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.PictureBox pcbCap;
        private System.Windows.Forms.PictureBox pcbCamara;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.ComboBox cmbDis;
        private System.Windows.Forms.Button btnCerrar;
    }
}