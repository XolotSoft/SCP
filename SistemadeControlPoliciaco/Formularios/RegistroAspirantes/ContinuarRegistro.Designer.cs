namespace SistemadeControlPoliciaco
{
    partial class ContinuarRegistro
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
            this.lblApe = new System.Windows.Forms.Label();
            this.txbApe = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvAsp = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.BackColor = System.Drawing.Color.Transparent;
            this.lblMen.Location = new System.Drawing.Point(159, 361);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(364, 16);
            this.lblMen.TabIndex = 74;
            this.lblMen.Text = "Da doble click sobre el aspirante, para continuar su registro.";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.BackColor = System.Drawing.Color.Transparent;
            this.lblApe.Location = new System.Drawing.Point(41, 430);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(73, 16);
            this.lblApe.TabIndex = 69;
            this.lblApe.Text = "Busqueda:";
            // 
            // txbApe
            // 
            this.txbApe.Location = new System.Drawing.Point(122, 427);
            this.txbApe.Name = "txbApe";
            this.txbApe.Size = new System.Drawing.Size(234, 22);
            this.txbApe.TabIndex = 66;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1412453866_search_16;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(396, 421);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(110, 35);
            this.btnFiltrar.TabIndex = 63;
            this.btnFiltrar.Text = "Filtrar    ";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401842826_cross_24;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(512, 421);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 35);
            this.btnCerrar.TabIndex = 64;
            this.btnCerrar.Text = "Cerrar   ";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.dgvAsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsp.Location = new System.Drawing.Point(12, 119);
            this.dgvAsp.Name = "dgvAsp";
            this.dgvAsp.ReadOnly = true;
            this.dgvAsp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAsp.Size = new System.Drawing.Size(776, 209);
            this.dgvAsp.TabIndex = 61;
            this.dgvAsp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsp_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemadeControlPoliciaco.Properties.Resources.flecha;
            this.pictureBox1.Location = new System.Drawing.Point(122, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1412453987_new_24_16;
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.Location = new System.Drawing.Point(628, 421);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(110, 35);
            this.btnContinuar.TabIndex = 62;
            this.btnContinuar.Text = "Continuar    ";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // ContinuarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.FORMULARIO;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMen);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.txbApe);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.dgvAsp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContinuarRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContinuarRegistro";
            this.Load += new System.EventHandler(this.ContinuarRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.TextBox txbApe;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvAsp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnContinuar;
    }
}