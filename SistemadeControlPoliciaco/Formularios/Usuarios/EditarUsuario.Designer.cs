namespace SistemadeControlPoliciaco
{
    partial class EditarUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.txbPass2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401843024_refresh;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(482, 420);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 35);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(135, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Tipo:";
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(179, 318);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.ReadOnly = true;
            this.txbTipo.Size = new System.Drawing.Size(180, 22);
            this.txbTipo.TabIndex = 31;
            // 
            // txbPass2
            // 
            this.txbPass2.Location = new System.Drawing.Point(482, 368);
            this.txbPass2.MaxLength = 9;
            this.txbPass2.Name = "txbPass2";
            this.txbPass2.PasswordChar = '*';
            this.txbPass2.Size = new System.Drawing.Size(180, 22);
            this.txbPass2.TabIndex = 27;
            this.txbPass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPass2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(399, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Confirmar:";
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.lblCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.Location = new System.Drawing.Point(176, 106);
            this.lblCatalogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(111, 13);
            this.lblCatalogo.TabIndex = 42;
            this.lblCatalogo.Text = "Catalogo de Usuarios:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(392, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(416, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(146, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401842826_cross_24;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(362, 420);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(110, 35);
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.Text = "Cerrar   ";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401843226_maximize;
            this.btnCambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiar.Location = new System.Drawing.Point(600, 420);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(110, 35);
            this.btnCambiar.TabIndex = 32;
            this.btnCambiar.Text = "Cambiar ";
            this.btnCambiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(482, 318);
            this.txbPass.Margin = new System.Windows.Forms.Padding(4);
            this.txbPass.MaxLength = 9;
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(180, 22);
            this.txbPass.TabIndex = 26;
            this.txbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPass_KeyPress);
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(482, 265);
            this.txbUser.Margin = new System.Windows.Forms.Padding(4);
            this.txbUser.MaxLength = 9;
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(180, 22);
            this.txbUser.TabIndex = 25;
            this.txbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUser_KeyPress);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(179, 265);
            this.txbId.Margin = new System.Windows.Forms.Padding(4);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(180, 22);
            this.txbId.TabIndex = 24;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(179, 123);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Size = new System.Drawing.Size(400, 119);
            this.dgvUsers.TabIndex = 23;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            this.dgvUsers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvUsers_KeyUp);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.EDIUSER;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbTipo);
            this.Controls.Add(this.txbPass2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.dgvUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Usuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.TextBox txbPass2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}