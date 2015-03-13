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
            this.txbCon = new System.Windows.Forms.TextBox();
            this.txbApe = new System.Windows.Forms.TextBox();
            this.txbRfc = new System.Windows.Forms.TextBox();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblRfc = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblMen = new System.Windows.Forms.Label();
            this.lblSelec = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsp
            // 
            this.dgvAsp.AllowUserToAddRows = false;
            this.dgvAsp.AllowUserToDeleteRows = false;
            this.dgvAsp.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAsp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsp.Location = new System.Drawing.Point(15, 123);
            this.dgvAsp.Name = "dgvAsp";
            this.dgvAsp.ReadOnly = true;
            this.dgvAsp.Size = new System.Drawing.Size(639, 200);
            this.dgvAsp.TabIndex = 0;
            this.dgvAsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsp_CellClick);
            this.dgvAsp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvAsp_KeyUp);
            // 
            // btnFil
            // 
            this.btnFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFil.Image = global::SistemadeControlPoliciaco.Properties.Resources._1412453866_search_16;
            this.btnFil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFil.Location = new System.Drawing.Point(482, 423);
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
            this.btnCer.Location = new System.Drawing.Point(362, 423);
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
            this.btnEdi.Location = new System.Drawing.Point(602, 423);
            this.btnEdi.Name = "btnEdi";
            this.btnEdi.Size = new System.Drawing.Size(110, 35);
            this.btnEdi.TabIndex = 19;
            this.btnEdi.Text = "Editar    ";
            this.btnEdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdi.UseVisualStyleBackColor = true;
            this.btnEdi.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txbCon
            // 
            this.txbCon.Location = new System.Drawing.Point(542, 381);
            this.txbCon.Name = "txbCon";
            this.txbCon.Size = new System.Drawing.Size(170, 22);
            this.txbCon.TabIndex = 22;
            this.txbCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCon_KeyPress);
            // 
            // txbApe
            // 
            this.txbApe.Location = new System.Drawing.Point(166, 343);
            this.txbApe.Name = "txbApe";
            this.txbApe.Size = new System.Drawing.Size(170, 22);
            this.txbApe.TabIndex = 23;
            this.txbApe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApe_KeyPress);
            // 
            // txbRfc
            // 
            this.txbRfc.Location = new System.Drawing.Point(166, 381);
            this.txbRfc.Name = "txbRfc";
            this.txbRfc.Size = new System.Drawing.Size(170, 22);
            this.txbRfc.TabIndex = 24;
            this.txbRfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRfc_KeyPress);
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(542, 343);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(170, 22);
            this.txbNom.TabIndex = 25;
            this.txbNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNom_KeyPress);
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.BackColor = System.Drawing.Color.Transparent;
            this.lblApe.Location = new System.Drawing.Point(99, 346);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(61, 16);
            this.lblApe.TabIndex = 26;
            this.lblApe.Text = "Apellido:";
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.BackColor = System.Drawing.Color.Transparent;
            this.lblRfc.Location = new System.Drawing.Point(122, 384);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(38, 16);
            this.lblRfc.TabIndex = 27;
            this.lblRfc.Text = "RFC:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Location = new System.Drawing.Point(476, 346);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(60, 16);
            this.lblNom.TabIndex = 28;
            this.lblNom.Text = "Nombre:";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.Transparent;
            this.lblCon.Location = new System.Drawing.Point(445, 384);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(91, 16);
            this.lblCon.TabIndex = 29;
            this.lblCon.Text = "Convocatoria:";
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.BackColor = System.Drawing.Color.Transparent;
            this.lblMen.Location = new System.Drawing.Point(28, 432);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(236, 16);
            this.lblMen.TabIndex = 45;
            this.lblMen.Text = "Has seleccionado al Aspirante con ID:";
            // 
            // lblSelec
            // 
            this.lblSelec.AutoSize = true;
            this.lblSelec.BackColor = System.Drawing.Color.Transparent;
            this.lblSelec.Location = new System.Drawing.Point(270, 432);
            this.lblSelec.Name = "lblSelec";
            this.lblSelec.Size = new System.Drawing.Size(0, 16);
            this.lblSelec.TabIndex = 44;
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(668, 149);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(120, 133);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 46;
            this.pcbFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 12);
            this.label1.TabIndex = 47;
            this.label1.Text = "Catalogo de Aspirantes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(692, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Fotografía";
            // 
            // EditarAspirante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.modaspirantes;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.lblMen);
            this.Controls.Add(this.lblSelec);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblRfc);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.txbRfc);
            this.Controls.Add(this.txbApe);
            this.Controls.Add(this.txbCon);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsp;
        private System.Windows.Forms.Button btnFil;
        private System.Windows.Forms.Button btnCer;
        private System.Windows.Forms.Button btnEdi;
        private System.Windows.Forms.TextBox txbCon;
        private System.Windows.Forms.TextBox txbApe;
        private System.Windows.Forms.TextBox txbRfc;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.Label lblSelec;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}