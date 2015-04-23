namespace SistemadeControlPoliciaco
{
    partial class EditarAspirante
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
            this.dgvAsp = new System.Windows.Forms.DataGridView();
            this.btnFil = new System.Windows.Forms.Button();
            this.btnCer = new System.Windows.Forms.Button();
            this.btnEdi = new System.Windows.Forms.Button();
            this.txbApe = new System.Windows.Forms.TextBox();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblMen = new System.Windows.Forms.Label();
            this.lblSelec = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbHuella = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuella = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsp
            // 
            this.dgvAsp.AllowUserToAddRows = false;
            this.dgvAsp.AllowUserToDeleteRows = false;
            this.dgvAsp.AllowUserToResizeColumns = false;
            this.dgvAsp.AllowUserToResizeRows = false;
            this.dgvAsp.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAsp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAsp.Location = new System.Drawing.Point(15, 123);
            this.dgvAsp.Name = "dgvAsp";
            this.dgvAsp.ReadOnly = true;
            this.dgvAsp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAsp.Size = new System.Drawing.Size(639, 282);
            this.dgvAsp.TabIndex = 0;
            this.dgvAsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsp_CellClick);
            this.dgvAsp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvAsp_KeyUp);
            // 
            // btnFil
            // 
            this.btnFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFil.Image = global::SistemadeControlPoliciaco.Properties.Resources._1412453866_search_16;
            this.btnFil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFil.Location = new System.Drawing.Point(417, 432);
            this.btnFil.Name = "btnFil";
            this.btnFil.Size = new System.Drawing.Size(110, 35);
            this.btnFil.TabIndex = 20;
            this.btnFil.Text = "Filtrar    ";
            this.btnFil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFil.UseVisualStyleBackColor = true;
            this.btnFil.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // btnCer
            // 
            this.btnCer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCer.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401842826_cross_24;
            this.btnCer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCer.Location = new System.Drawing.Point(544, 432);
            this.btnCer.Name = "btnCer";
            this.btnCer.Size = new System.Drawing.Size(110, 35);
            this.btnCer.TabIndex = 21;
            this.btnCer.Text = "Cerrar   ";
            this.btnCer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCer.UseVisualStyleBackColor = true;
            this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
            // 
            // btnEdi
            // 
            this.btnEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdi.Image = global::SistemadeControlPoliciaco.Properties.Resources._1412453987_new_24_16;
            this.btnEdi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdi.Location = new System.Drawing.Point(671, 432);
            this.btnEdi.Name = "btnEdi";
            this.btnEdi.Size = new System.Drawing.Size(110, 35);
            this.btnEdi.TabIndex = 19;
            this.btnEdi.Text = "Editar    ";
            this.btnEdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdi.UseVisualStyleBackColor = true;
            this.btnEdi.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txbApe
            // 
            this.txbApe.Location = new System.Drawing.Point(82, 438);
            this.txbApe.Name = "txbApe";
            this.txbApe.Size = new System.Drawing.Size(185, 22);
            this.txbApe.TabIndex = 23;
            this.txbApe.TextChanged += new System.EventHandler(this.txbApe_TextChanged);
            this.txbApe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApe_KeyPress);
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.BackColor = System.Drawing.Color.Transparent;
            this.lblApe.Location = new System.Drawing.Point(8, 441);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(73, 16);
            this.lblApe.TabIndex = 26;
            this.lblApe.Text = "Busqueda:";
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.BackColor = System.Drawing.Color.Transparent;
            this.lblMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMen.Location = new System.Drawing.Point(9, 411);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(146, 13);
            this.lblMen.TabIndex = 45;
            this.lblMen.Text = "Has selecionado el aspirante:";
            // 
            // lblSelec
            // 
            this.lblSelec.AutoSize = true;
            this.lblSelec.BackColor = System.Drawing.Color.Transparent;
            this.lblSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelec.Location = new System.Drawing.Point(164, 413);
            this.lblSelec.Name = "lblSelec";
            this.lblSelec.Size = new System.Drawing.Size(0, 13);
            this.lblSelec.TabIndex = 44;
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(665, 121);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(120, 133);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 46;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.Click += new System.EventHandler(this.pcbFoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 12);
            this.label1.TabIndex = 47;
            this.label1.Text = "Catalogo de Aspirantes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Huella Digital";
            // 
            // pcbHuella
            // 
            this.pcbHuella.Location = new System.Drawing.Point(665, 276);
            this.pcbHuella.Name = "pcbHuella";
            this.pcbHuella.Size = new System.Drawing.Size(120, 127);
            this.pcbHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHuella.TabIndex = 49;
            this.pcbHuella.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Fotografía";
            // 
            // btnHuella
            // 
            this.btnHuella.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuella.Image = global::SistemadeControlPoliciaco.Properties.Resources._1412453866_search_16;
            this.btnHuella.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuella.Location = new System.Drawing.Point(292, 432);
            this.btnHuella.Name = "btnHuella";
            this.btnHuella.Size = new System.Drawing.Size(110, 35);
            this.btnHuella.TabIndex = 51;
            this.btnHuella.Text = "Huella     ";
            this.btnHuella.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuella.UseVisualStyleBackColor = true;
            this.btnHuella.Click += new System.EventHandler(this.btnHuella_Click);
            // 
            // EditarAspirante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.modaspirantes;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnHuella);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbHuella);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.lblMen);
            this.Controls.Add(this.lblSelec);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.txbApe);
            this.Controls.Add(this.btnFil);
            this.Controls.Add(this.btnCer);
            this.Controls.Add(this.btnEdi);
            this.Controls.Add(this.dgvAsp);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarAspirante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Aspirante";
            this.Load += new System.EventHandler(this.EditarAspirante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHuella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsp;
        private System.Windows.Forms.Button btnFil;
        private System.Windows.Forms.Button btnCer;
        private System.Windows.Forms.Button btnEdi;
        private System.Windows.Forms.TextBox txbApe;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.Label lblSelec;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbHuella;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuella;
    }
}