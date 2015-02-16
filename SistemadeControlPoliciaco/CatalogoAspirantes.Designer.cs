namespace SistemadeControlPoliciaco
{
    partial class CatalogoAspirantes
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
            this.lblMen = new System.Windows.Forms.Label();
            this.lblSelec = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblRfc = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbRfc = new System.Windows.Forms.TextBox();
            this.txbApe = new System.Windows.Forms.TextBox();
            this.txbCon = new System.Windows.Forms.TextBox();
            this.dgvAsp = new System.Windows.Forms.DataGridView();
            this.btnFil = new System.Windows.Forms.Button();
            this.btnCer = new System.Windows.Forms.Button();
            this.btnEdi = new System.Windows.Forms.Button();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.BackColor = System.Drawing.Color.Transparent;
            this.lblMen.Location = new System.Drawing.Point(33, 423);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(132, 16);
            this.lblMen.TabIndex = 59;
            this.lblMen.Text = "Has seleccionado a:";
            // 
            // lblSelec
            // 
            this.lblSelec.AutoSize = true;
            this.lblSelec.BackColor = System.Drawing.Color.Transparent;
            this.lblSelec.Location = new System.Drawing.Point(186, 423);
            this.lblSelec.Name = "lblSelec";
            this.lblSelec.Size = new System.Drawing.Size(0, 16);
            this.lblSelec.TabIndex = 58;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.Transparent;
            this.lblCon.Location = new System.Drawing.Point(450, 369);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(91, 16);
            this.lblCon.TabIndex = 57;
            this.lblCon.Text = "Convocatoria:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Location = new System.Drawing.Point(481, 331);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(60, 16);
            this.lblNom.TabIndex = 56;
            this.lblNom.Text = "Nombre:";
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.BackColor = System.Drawing.Color.Transparent;
            this.lblRfc.Location = new System.Drawing.Point(127, 369);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(38, 16);
            this.lblRfc.TabIndex = 55;
            this.lblRfc.Text = "RFC:";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.BackColor = System.Drawing.Color.Transparent;
            this.lblApe.Location = new System.Drawing.Point(104, 331);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(61, 16);
            this.lblApe.TabIndex = 54;
            this.lblApe.Text = "Apellido:";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(547, 328);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(170, 22);
            this.txbNom.TabIndex = 53;
            // 
            // txbRfc
            // 
            this.txbRfc.Location = new System.Drawing.Point(171, 366);
            this.txbRfc.Name = "txbRfc";
            this.txbRfc.Size = new System.Drawing.Size(170, 22);
            this.txbRfc.TabIndex = 52;
            // 
            // txbApe
            // 
            this.txbApe.Location = new System.Drawing.Point(171, 328);
            this.txbApe.Name = "txbApe";
            this.txbApe.Size = new System.Drawing.Size(170, 22);
            this.txbApe.TabIndex = 51;
            // 
            // txbCon
            // 
            this.txbCon.Location = new System.Drawing.Point(547, 366);
            this.txbCon.Name = "txbCon";
            this.txbCon.Size = new System.Drawing.Size(170, 22);
            this.txbCon.TabIndex = 50;
            // 
            // dgvAsp
            // 
            this.dgvAsp.AllowUserToAddRows = false;
            this.dgvAsp.AllowUserToDeleteRows = false;
            this.dgvAsp.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAsp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsp.Location = new System.Drawing.Point(55, 111);
            this.dgvAsp.Name = "dgvAsp";
            this.dgvAsp.ReadOnly = true;
            this.dgvAsp.Size = new System.Drawing.Size(422, 200);
            this.dgvAsp.TabIndex = 46;
            this.dgvAsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsp_CellClick);
            // 
            // btnFil
            // 
            this.btnFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFil.Image = global::SistemadeControlPoliciaco.Properties.Resources._1412453866_search_16;
            this.btnFil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFil.Location = new System.Drawing.Point(487, 414);
            this.btnFil.Name = "btnFil";
            this.btnFil.Size = new System.Drawing.Size(110, 35);
            this.btnFil.TabIndex = 48;
            this.btnFil.Text = "Filtrar    ";
            this.btnFil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFil.UseVisualStyleBackColor = true;
            // 
            // btnCer
            // 
            this.btnCer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCer.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401842826_cross_24;
            this.btnCer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCer.Location = new System.Drawing.Point(367, 414);
            this.btnCer.Name = "btnCer";
            this.btnCer.Size = new System.Drawing.Size(110, 35);
            this.btnCer.TabIndex = 49;
            this.btnCer.Text = "Cerrar   ";
            this.btnCer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCer.UseVisualStyleBackColor = true;
            // 
            // btnEdi
            // 
            this.btnEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdi.Image = global::SistemadeControlPoliciaco.Properties.Resources._1412453987_new_24_16;
            this.btnEdi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdi.Location = new System.Drawing.Point(607, 414);
            this.btnEdi.Name = "btnEdi";
            this.btnEdi.Size = new System.Drawing.Size(110, 35);
            this.btnEdi.TabIndex = 47;
            this.btnEdi.Text = "Editar    ";
            this.btnEdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdi.UseVisualStyleBackColor = true;
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(511, 111);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(206, 200);
            this.pcbFoto.TabIndex = 60;
            this.pcbFoto.TabStop = false;
            // 
            // CatalogoAspirantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CatalogoAspirantes";
            this.Text = "CatalogoAspirantes";
            this.Load += new System.EventHandler(this.CatalogoAspirantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.Label lblSelec;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbRfc;
        private System.Windows.Forms.TextBox txbApe;
        private System.Windows.Forms.TextBox txbCon;
        private System.Windows.Forms.Button btnFil;
        private System.Windows.Forms.Button btnCer;
        private System.Windows.Forms.Button btnEdi;
        private System.Windows.Forms.DataGridView dgvAsp;
        private System.Windows.Forms.PictureBox pcbFoto;
    }
}