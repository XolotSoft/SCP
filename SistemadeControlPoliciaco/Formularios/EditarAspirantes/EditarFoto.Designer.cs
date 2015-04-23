namespace SistemadeControlPoliciaco
{
    partial class EditarFoto
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblDisp = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbDis = new System.Windows.Forms.ComboBox();
            this.pcbCap = new System.Windows.Forms.PictureBox();
            this.pcbCamara = new System.Windows.Forms.PictureBox();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnRepetir = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniCam = new System.Windows.Forms.Button();
            this.btnDomicilio = new System.Windows.Forms.Button();
            this.btnHuella = new System.Windows.Forms.Button();
            this.btnContacto = new System.Windows.Forms.Button();
            this.btnPersonales = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401842826_cross_24;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(375, 399);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 35);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.Text = "Cerrar   ";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.BackColor = System.Drawing.Color.Transparent;
            this.lblDisp.Location = new System.Drawing.Point(51, 419);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(82, 16);
            this.lblDisp.TabIndex = 22;
            this.lblDisp.Text = "Dispositivos";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(82, 102);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 21;
            // 
            // cmbDis
            // 
            this.cmbDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDis.FormattingEnabled = true;
            this.cmbDis.Location = new System.Drawing.Point(139, 416);
            this.cmbDis.Name = "cmbDis";
            this.cmbDis.Size = new System.Drawing.Size(159, 24);
            this.cmbDis.TabIndex = 20;
            // 
            // pcbCap
            // 
            this.pcbCap.Location = new System.Drawing.Point(574, 171);
            this.pcbCap.Name = "pcbCap";
            this.pcbCap.Size = new System.Drawing.Size(146, 138);
            this.pcbCap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCap.TabIndex = 19;
            this.pcbCap.TabStop = false;
            // 
            // pcbCamara
            // 
            this.pcbCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbCamara.Location = new System.Drawing.Point(85, 121);
            this.pcbCamara.Name = "pcbCamara";
            this.pcbCamara.Size = new System.Drawing.Size(242, 223);
            this.pcbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCamara.TabIndex = 18;
            this.pcbCamara.TabStop = false;
            // 
            // btnSig
            // 
            this.btnSig.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401844327_checkmark_24;
            this.btnSig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSig.Location = new System.Drawing.Point(616, 399);
            this.btnSig.Margin = new System.Windows.Forms.Padding(4);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(108, 35);
            this.btnSig.TabIndex = 17;
            this.btnSig.Text = "Modificar";
            this.btnSig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnRepetir
            // 
            this.btnRepetir.Image = global::SistemadeControlPoliciaco.Properties.Resources.deleteDates;
            this.btnRepetir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepetir.Location = new System.Drawing.Point(399, 274);
            this.btnRepetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepetir.Name = "btnRepetir";
            this.btnRepetir.Size = new System.Drawing.Size(110, 35);
            this.btnRepetir.TabIndex = 16;
            this.btnRepetir.Text = "Repetir    ";
            this.btnRepetir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRepetir.UseVisualStyleBackColor = true;
            this.btnRepetir.Click += new System.EventHandler(this.btnRepetir_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Image = global::SistemadeControlPoliciaco.Properties.Resources.Camara;
            this.btnCapturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapturar.Location = new System.Drawing.Point(399, 191);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(110, 35);
            this.btnCapturar.TabIndex = 15;
            this.btnCapturar.Text = "Capturar  ";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
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
            this.label1.TabIndex = 14;
            this.label1.Text = "Captura actual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnIniCam
            // 
            this.btnIniCam.Image = global::SistemadeControlPoliciaco.Properties.Resources.webcam;
            this.btnIniCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniCam.Location = new System.Drawing.Point(124, 360);
            this.btnIniCam.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniCam.Name = "btnIniCam";
            this.btnIniCam.Size = new System.Drawing.Size(149, 35);
            this.btnIniCam.TabIndex = 13;
            this.btnIniCam.Text = "Iniciar Camara ";
            this.btnIniCam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniCam.UseVisualStyleBackColor = true;
            this.btnIniCam.Click += new System.EventHandler(this.btnIniCam_Click);
            // 
            // btnDomicilio
            // 
            this.btnDomicilio.Location = new System.Drawing.Point(629, 8);
            this.btnDomicilio.Name = "btnDomicilio";
            this.btnDomicilio.Size = new System.Drawing.Size(110, 35);
            this.btnDomicilio.TabIndex = 55;
            this.btnDomicilio.Text = "Domicilio";
            this.btnDomicilio.UseVisualStyleBackColor = true;
            this.btnDomicilio.Click += new System.EventHandler(this.btnDomicilio_Click);
            // 
            // btnHuella
            // 
            this.btnHuella.Location = new System.Drawing.Point(629, 48);
            this.btnHuella.Name = "btnHuella";
            this.btnHuella.Size = new System.Drawing.Size(109, 34);
            this.btnHuella.TabIndex = 54;
            this.btnHuella.Text = "Huella Dig";
            this.btnHuella.UseVisualStyleBackColor = true;
            this.btnHuella.Click += new System.EventHandler(this.btnHuella_Click);
            // 
            // btnContacto
            // 
            this.btnContacto.Location = new System.Drawing.Point(513, 49);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(110, 35);
            this.btnContacto.TabIndex = 53;
            this.btnContacto.Text = "Contacto";
            this.btnContacto.UseVisualStyleBackColor = true;
            this.btnContacto.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // btnPersonales
            // 
            this.btnPersonales.Location = new System.Drawing.Point(513, 8);
            this.btnPersonales.Name = "btnPersonales";
            this.btnPersonales.Size = new System.Drawing.Size(109, 36);
            this.btnPersonales.TabIndex = 52;
            this.btnPersonales.Text = "Personales";
            this.btnPersonales.UseVisualStyleBackColor = true;
            this.btnPersonales.Click += new System.EventHandler(this.btnPersonales_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401843024_refresh1;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(494, 399);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 35);
            this.btnRegresar.TabIndex = 56;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // EditarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.fotografia;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnDomicilio);
            this.Controls.Add(this.btnHuella);
            this.Controls.Add(this.btnContacto);
            this.Controls.Add(this.btnPersonales);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarFoto";
            this.Load += new System.EventHandler(this.EditarFoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbDis;
        private System.Windows.Forms.PictureBox pcbCap;
        private System.Windows.Forms.PictureBox pcbCamara;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btnRepetir;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniCam;
        private System.Windows.Forms.Button btnDomicilio;
        private System.Windows.Forms.Button btnHuella;
        private System.Windows.Forms.Button btnContacto;
        private System.Windows.Forms.Button btnPersonales;
        private System.Windows.Forms.Button btnRegresar;
    }
}