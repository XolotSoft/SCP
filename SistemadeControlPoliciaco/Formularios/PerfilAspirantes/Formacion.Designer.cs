namespace SistemadeControlPoliciaco
{
    partial class Formacion
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
            this.CBestudios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCer = new System.Windows.Forms.Button();
            this.btnEdi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBpauxilios = new System.Windows.Forms.RadioButton();
            this.RBpcivil = new System.Windows.Forms.RadioButton();
            this.RBcsocial = new System.Windows.Forms.RadioButton();
            this.RBafuego = new System.Windows.Forms.RadioButton();
            this.btnLim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBestudios
            // 
            this.CBestudios.FormattingEnabled = true;
            this.CBestudios.Items.AddRange(new object[] {
            "",
            "Básica",
            "Media Superior ",
            "Superior",
            "Postgrado"});
            this.CBestudios.Location = new System.Drawing.Point(291, 181);
            this.CBestudios.Name = "CBestudios";
            this.CBestudios.Size = new System.Drawing.Size(144, 21);
            this.CBestudios.TabIndex = 7;
            this.CBestudios.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nivel de Estudios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(15, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.Text = "SI";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.Location = new System.Drawing.Point(105, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "NO";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 122);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(433, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Seleccione su nivel maximo de estudios";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(115, 230);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(559, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Seleccione los cursos realizados hasta el momento ";
            // 
            // btnCer
            // 
            this.btnCer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCer.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401842826_cross_24;
            this.btnCer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCer.Location = new System.Drawing.Point(338, 392);
            this.btnCer.Name = "btnCer";
            this.btnCer.Size = new System.Drawing.Size(110, 35);
            this.btnCer.TabIndex = 42;
            this.btnCer.Text = "Cerrar   ";
            this.btnCer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCer.UseVisualStyleBackColor = true;
            this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
            // 
            // btnEdi
            // 
            this.btnEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdi.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401844327_checkmark_24;
            this.btnEdi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdi.Location = new System.Drawing.Point(596, 392);
            this.btnEdi.Name = "btnEdi";
            this.btnEdi.Size = new System.Drawing.Size(110, 35);
            this.btnEdi.TabIndex = 41;
            this.btnEdi.Text = "Continuar";
            this.btnEdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdi.UseVisualStyleBackColor = true;
            this.btnEdi.Click += new System.EventHandler(this.btnEdi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(-47, -121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 58);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RBpauxilios
            // 
            this.RBpauxilios.AutoSize = true;
            this.RBpauxilios.BackColor = System.Drawing.Color.Transparent;
            this.RBpauxilios.Location = new System.Drawing.Point(11, 19);
            this.RBpauxilios.Name = "RBpauxilios";
            this.RBpauxilios.Size = new System.Drawing.Size(103, 17);
            this.RBpauxilios.TabIndex = 49;
            this.RBpauxilios.TabStop = true;
            this.RBpauxilios.Text = "Primeros Auxilios";
            this.RBpauxilios.UseVisualStyleBackColor = false;
            // 
            // RBpcivil
            // 
            this.RBpcivil.AutoSize = true;
            this.RBpcivil.BackColor = System.Drawing.Color.Transparent;
            this.RBpcivil.Location = new System.Drawing.Point(11, 19);
            this.RBpcivil.Name = "RBpcivil";
            this.RBpcivil.Size = new System.Drawing.Size(98, 17);
            this.RBpcivil.TabIndex = 50;
            this.RBpcivil.TabStop = true;
            this.RBpcivil.Text = "Proteccion Civil";
            this.RBpcivil.UseVisualStyleBackColor = false;
            // 
            // RBcsocial
            // 
            this.RBcsocial.AutoSize = true;
            this.RBcsocial.BackColor = System.Drawing.Color.Transparent;
            this.RBcsocial.Location = new System.Drawing.Point(11, 19);
            this.RBcsocial.Name = "RBcsocial";
            this.RBcsocial.Size = new System.Drawing.Size(118, 17);
            this.RBcsocial.TabIndex = 51;
            this.RBcsocial.TabStop = true;
            this.RBcsocial.Text = "Comunicaion Social";
            this.RBcsocial.UseVisualStyleBackColor = false;
            // 
            // RBafuego
            // 
            this.RBafuego.AutoSize = true;
            this.RBafuego.BackColor = System.Drawing.Color.Transparent;
            this.RBafuego.Cursor = System.Windows.Forms.Cursors.Default;
            this.RBafuego.Location = new System.Drawing.Point(11, 19);
            this.RBafuego.Name = "RBafuego";
            this.RBafuego.Size = new System.Drawing.Size(158, 17);
            this.RBafuego.TabIndex = 52;
            this.RBafuego.TabStop = true;
            this.RBafuego.Text = "Manejo de Armas  de Fuego";
            this.RBafuego.UseVisualStyleBackColor = false;
            // 
            // btnLim
            // 
            this.btnLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLim.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401843024_refresh1;
            this.btnLim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLim.Location = new System.Drawing.Point(469, 392);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(110, 35);
            this.btnLim.TabIndex = 53;
            this.btnLim.Text = "Limpiar";
            this.btnLim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::SistemadeControlPoliciaco.Properties.Resources.acepta;
            this.pictureBox1.Location = new System.Drawing.Point(468, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Correctamente agregado";
            this.label2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.RBpauxilios);
            this.groupBox2.Location = new System.Drawing.Point(187, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 49);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.RBpcivil);
            this.groupBox3.Location = new System.Drawing.Point(187, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 49);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.RBcsocial);
            this.groupBox4.Location = new System.Drawing.Point(424, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 49);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.RBafuego);
            this.groupBox5.Location = new System.Drawing.Point(424, 265);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(186, 49);
            this.groupBox5.TabIndex = 59;
            this.groupBox5.TabStop = false;
            // 
            // Formacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.FORMULARIO;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCer);
            this.Controls.Add(this.btnEdi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBestudios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formacion";
            this.Text = "Formacion";
            this.Load += new System.EventHandler(this.Formacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBestudios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCer;
        private System.Windows.Forms.Button btnEdi;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBpauxilios;
        private System.Windows.Forms.RadioButton RBpcivil;
        private System.Windows.Forms.RadioButton RBcsocial;
        private System.Windows.Forms.RadioButton RBafuego;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}