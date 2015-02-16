namespace SistemadeControlPoliciaco
{
    partial class NuevoUsuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.rdbEmpleado = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txbPass2 = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401843024_refresh1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(484, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 36;
            this.button1.Text = "Limpiar  ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbEmpleado
            // 
            this.rdbEmpleado.AutoSize = true;
            this.rdbEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.rdbEmpleado.Location = new System.Drawing.Point(524, 206);
            this.rdbEmpleado.Name = "rdbEmpleado";
            this.rdbEmpleado.Size = new System.Drawing.Size(73, 20);
            this.rdbEmpleado.TabIndex = 32;
            this.rdbEmpleado.TabStop = true;
            this.rdbEmpleado.Text = "Usuario";
            this.rdbEmpleado.UseVisualStyleBackColor = false;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rdbAdmin.Location = new System.Drawing.Point(524, 179);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(109, 20);
            this.rdbAdmin.TabIndex = 31;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Administrador";
            this.rdbAdmin.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(97, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Repetir Contraseña:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401842826_cross_24;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(364, 413);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 35);
            this.btnCerrar.TabIndex = 34;
            this.btnCerrar.Text = "Cerrar   ";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::SistemadeControlPoliciaco.Properties.Resources._1401844351_plus_24;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(602, 413);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 35);
            this.btnRegistrar.TabIndex = 33;
            this.btnRegistrar.Text = "Registrar ";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txbPass2
            // 
            this.txbPass2.Location = new System.Drawing.Point(230, 283);
            this.txbPass2.MaxLength = 9;
            this.txbPass2.Name = "txbPass2";
            this.txbPass2.PasswordChar = '*';
            this.txbPass2.Size = new System.Drawing.Size(180, 22);
            this.txbPass2.TabIndex = 30;
            this.txbPass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPass2_KeyPress);
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(230, 232);
            this.txbPass.MaxLength = 9;
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(180, 22);
            this.txbPass.TabIndex = 29;
            this.txbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPass_KeyPress);
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(230, 179);
            this.txbUser.MaxLength = 9;
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(180, 22);
            this.txbUser.TabIndex = 28;
            this.txbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUser_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(479, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(143, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(94, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nombre de Usuario:";
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.nueuserok;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbEmpleado);
            this.Controls.Add(this.rdbAdmin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txbPass2);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoUsuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbEmpleado;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txbPass2;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}