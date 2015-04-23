namespace SistemadeControlPoliciaco
{
    partial class EditarPersonal
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
            this.label9 = new System.Windows.Forms.Label();
            this.cbxEdoCiv = new System.Windows.Forms.ComboBox();
            this.btnLim = new System.Windows.Forms.Button();
            this.btnCer = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.txbRfcHom = new System.Windows.Forms.TextBox();
            this.txbRfcAut = new System.Windows.Forms.TextBox();
            this.txbCurHom = new System.Windows.Forms.TextBox();
            this.txbCurAut = new System.Windows.Forms.TextBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.cbxEntFed = new System.Windows.Forms.ComboBox();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbApeMat = new System.Windows.Forms.TextBox();
            this.txbApePat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(485, 318);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Edo. Civil:";
            // 
            // cbxEdoCiv
            // 
            this.cbxEdoCiv.FormattingEnabled = true;
            this.cbxEdoCiv.Items.AddRange(new object[] {
            "",
            "Soltero",
            "Casado"});
            this.cbxEdoCiv.Location = new System.Drawing.Point(559, 315);
            this.cbxEdoCiv.Name = "cbxEdoCiv";
            this.cbxEdoCiv.Size = new System.Drawing.Size(170, 24);
            this.cbxEdoCiv.TabIndex = 42;
            // 
            // btnLim
            // 
            this.btnLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLim.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401843024_refresh1;
            this.btnLim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLim.Location = new System.Drawing.Point(509, 396);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(110, 35);
            this.btnLim.TabIndex = 39;
            this.btnLim.Text = "Regresar  ";
            this.btnLim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // btnCer
            // 
            this.btnCer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCer.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401842826_cross_24;
            this.btnCer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCer.Location = new System.Drawing.Point(389, 396);
            this.btnCer.Name = "btnCer";
            this.btnCer.Size = new System.Drawing.Size(110, 35);
            this.btnCer.TabIndex = 41;
            this.btnCer.Text = "Cerrar   ";
            this.btnCer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCer.UseVisualStyleBackColor = true;
            this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
            // 
            // btnCon
            // 
            this.btnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon.Image = global::SistemadeControlPoliciaco.Properties.Resources._1412453987_new_24_16;
            this.btnCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCon.Location = new System.Drawing.Point(629, 396);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(110, 35);
            this.btnCon.TabIndex = 37;
            this.btnCon.Text = "Cambiar  ";
            this.btnCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNac.Location = new System.Drawing.Point(219, 312);
            this.dtpFecNac.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFecNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(170, 22);
            this.dtpFecNac.TabIndex = 32;
            this.dtpFecNac.Value = new System.DateTime(2014, 9, 23, 0, 0, 0, 0);
            this.dtpFecNac.Leave += new System.EventHandler(this.dtpFecNac_Leave);
            // 
            // txbRfcHom
            // 
            this.txbRfcHom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRfcHom.Location = new System.Drawing.Point(696, 270);
            this.txbRfcHom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbRfcHom.Name = "txbRfcHom";
            this.txbRfcHom.Size = new System.Drawing.Size(35, 22);
            this.txbRfcHom.TabIndex = 36;
            this.txbRfcHom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRfcHom_KeyPress);
            this.txbRfcHom.Leave += new System.EventHandler(this.txbRfcHom_Leave);
            // 
            // txbRfcAut
            // 
            this.txbRfcAut.Enabled = false;
            this.txbRfcAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRfcAut.Location = new System.Drawing.Point(559, 270);
            this.txbRfcAut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbRfcAut.Name = "txbRfcAut";
            this.txbRfcAut.Size = new System.Drawing.Size(130, 22);
            this.txbRfcAut.TabIndex = 40;
            // 
            // txbCurHom
            // 
            this.txbCurHom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurHom.Location = new System.Drawing.Point(696, 227);
            this.txbCurHom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCurHom.Name = "txbCurHom";
            this.txbCurHom.Size = new System.Drawing.Size(35, 22);
            this.txbCurHom.TabIndex = 35;
            this.txbCurHom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCurHom_KeyPress);
            this.txbCurHom.Leave += new System.EventHandler(this.txbCurHom_Leave);
            // 
            // txbCurAut
            // 
            this.txbCurAut.Enabled = false;
            this.txbCurAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurAut.Location = new System.Drawing.Point(559, 227);
            this.txbCurAut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCurAut.Name = "txbCurAut";
            this.txbCurAut.Size = new System.Drawing.Size(131, 22);
            this.txbCurAut.TabIndex = 38;
            // 
            // cbxSex
            // 
            this.cbxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "",
            "Hombre",
            "Mujer"});
            this.cbxSex.Location = new System.Drawing.Point(559, 130);
            this.cbxSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(170, 24);
            this.cbxSex.TabIndex = 33;
            this.cbxSex.Leave += new System.EventHandler(this.cbxSex_Leave);
            // 
            // cbxEntFed
            // 
            this.cbxEntFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEntFed.FormattingEnabled = true;
            this.cbxEntFed.Location = new System.Drawing.Point(559, 179);
            this.cbxEntFed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxEntFed.Name = "cbxEntFed";
            this.cbxEntFed.Size = new System.Drawing.Size(170, 24);
            this.cbxEntFed.TabIndex = 34;
            this.cbxEntFed.Leave += new System.EventHandler(this.cbxEntFed_Leave);
            // 
            // txbNom
            // 
            this.txbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNom.Location = new System.Drawing.Point(219, 252);
            this.txbNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(170, 22);
            this.txbNom.TabIndex = 31;
            this.txbNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNom_KeyPress);
            this.txbNom.Leave += new System.EventHandler(this.txbNom_Leave);
            // 
            // txbApeMat
            // 
            this.txbApeMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApeMat.Location = new System.Drawing.Point(219, 192);
            this.txbApeMat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbApeMat.Name = "txbApeMat";
            this.txbApeMat.Size = new System.Drawing.Size(170, 22);
            this.txbApeMat.TabIndex = 30;
            this.txbApeMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApeMat_KeyPress);
            this.txbApeMat.Leave += new System.EventHandler(this.txbApeMat_Leave);
            // 
            // txbApePat
            // 
            this.txbApePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApePat.Location = new System.Drawing.Point(219, 132);
            this.txbApePat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbApePat.Name = "txbApePat";
            this.txbApePat.Size = new System.Drawing.Size(170, 22);
            this.txbApePat.TabIndex = 29;
            this.txbApePat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApePat_KeyPress);
            this.txbApePat.Leave += new System.EventHandler(this.txbApePat_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(516, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "RFC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "CURP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Entidad Federativa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre (s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellido Materno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Apellido Paterno:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 44;
            this.button1.Text = "Domicilio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 45;
            this.button2.Text = "Contacto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(631, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 35);
            this.button3.TabIndex = 46;
            this.button3.Text = "Huella Dig";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(631, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 35);
            this.button4.TabIndex = 47;
            this.button4.Text = "Fotografia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EditarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.Datosper;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxEdoCiv);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.btnCer);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.dtpFecNac);
            this.Controls.Add(this.txbRfcHom);
            this.Controls.Add(this.txbRfcAut);
            this.Controls.Add(this.txbCurHom);
            this.Controls.Add(this.txbCurAut);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.cbxEntFed);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.txbApeMat);
            this.Controls.Add(this.txbApePat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarDatPerAsp";
            this.Load += new System.EventHandler(this.EditarDatPerAsp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxEdoCiv;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.Button btnCer;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.TextBox txbRfcHom;
        private System.Windows.Forms.TextBox txbRfcAut;
        private System.Windows.Forms.TextBox txbCurHom;
        private System.Windows.Forms.TextBox txbCurAut;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.ComboBox cbxEntFed;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbApeMat;
        private System.Windows.Forms.TextBox txbApePat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}