namespace SistemadeControlPoliciaco
{
    partial class Escaneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escaneo));
            this.BTNescanear = new System.Windows.Forms.Button();
            this.BTNrepetir = new System.Windows.Forms.Button();
            this.BTNregistrar = new System.Windows.Forms.Button();
            this.BTNatras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbHuella = new System.Windows.Forms.PictureBox();
            this.BTNcerrar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNescanear
            // 
            this.BTNescanear.Image = global::SistemadeControlPoliciaco.Properties.Resources._1412453811_67_16;
            this.BTNescanear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNescanear.Location = new System.Drawing.Point(289, 180);
            this.BTNescanear.Margin = new System.Windows.Forms.Padding(4);
            this.BTNescanear.Name = "BTNescanear";
            this.BTNescanear.Size = new System.Drawing.Size(110, 35);
            this.BTNescanear.TabIndex = 0;
            this.BTNescanear.Text = "Escanear";
            this.BTNescanear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNescanear.UseVisualStyleBackColor = true;
            this.BTNescanear.Click += new System.EventHandler(this.BTNescanear_Click);
            // 
            // BTNrepetir
            // 
            this.BTNrepetir.Image = global::SistemadeControlPoliciaco.Properties.Resources.deleteDates;
            this.BTNrepetir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNrepetir.Location = new System.Drawing.Point(289, 278);
            this.BTNrepetir.Margin = new System.Windows.Forms.Padding(4);
            this.BTNrepetir.Name = "BTNrepetir";
            this.BTNrepetir.Size = new System.Drawing.Size(110, 35);
            this.BTNrepetir.TabIndex = 1;
            this.BTNrepetir.Text = "Repetir";
            this.BTNrepetir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNrepetir.UseVisualStyleBackColor = true;
            // 
            // BTNregistrar
            // 
            this.BTNregistrar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401844327_checkmark_24;
            this.BTNregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNregistrar.Location = new System.Drawing.Point(651, 425);
            this.BTNregistrar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNregistrar.Name = "BTNregistrar";
            this.BTNregistrar.Size = new System.Drawing.Size(110, 35);
            this.BTNregistrar.TabIndex = 3;
            this.BTNregistrar.Text = "Registrar  ";
            this.BTNregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNregistrar.UseVisualStyleBackColor = true;
            this.BTNregistrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTNatras
            // 
            this.BTNatras.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401843024_refresh1;
            this.BTNatras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNatras.Location = new System.Drawing.Point(524, 425);
            this.BTNatras.Margin = new System.Windows.Forms.Padding(4);
            this.BTNatras.Name = "BTNatras";
            this.BTNatras.Size = new System.Drawing.Size(110, 35);
            this.BTNatras.TabIndex = 4;
            this.BTNatras.Text = "Atras";
            this.BTNatras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNatras.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(112, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vista Previa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemadeControlPoliciaco.Properties.Resources.mano002;
            this.pictureBox1.Location = new System.Drawing.Point(470, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pcbHuella
            // 
            this.pcbHuella.Image = global::SistemadeControlPoliciaco.Properties.Resources.huella;
            this.pcbHuella.Location = new System.Drawing.Point(85, 158);
            this.pcbHuella.Name = "pcbHuella";
            this.pcbHuella.Size = new System.Drawing.Size(149, 192);
            this.pcbHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHuella.TabIndex = 6;
            this.pcbHuella.TabStop = false;
            // 
            // BTNcerrar
            // 
            this.BTNcerrar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401842826_cross_24;
            this.BTNcerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNcerrar.Location = new System.Drawing.Point(395, 425);
            this.BTNcerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNcerrar.Name = "BTNcerrar";
            this.BTNcerrar.Size = new System.Drawing.Size(110, 35);
            this.BTNcerrar.TabIndex = 7;
            this.BTNcerrar.Text = "Cerrar";
            this.BTNcerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNcerrar.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(690, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 29);
            this.label18.TabIndex = 31;
            this.label18.Text = "Etapa 5";
            // 
            // Escaneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.Escaneo;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.BTNcerrar);
            this.Controls.Add(this.pcbHuella);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNatras);
            this.Controls.Add(this.BTNregistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNrepetir);
            this.Controls.Add(this.BTNescanear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Escaneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escaneo";
            this.Load += new System.EventHandler(this.Escaneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHuella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNescanear;
        private System.Windows.Forms.Button BTNrepetir;
        private System.Windows.Forms.Button BTNregistrar;
        private System.Windows.Forms.Button BTNatras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbHuella;
        private System.Windows.Forms.Button BTNcerrar;
        private System.Windows.Forms.Label label18;
    }
}