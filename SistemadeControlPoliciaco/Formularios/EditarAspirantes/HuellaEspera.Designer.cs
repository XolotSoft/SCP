namespace SistemadeControlPoliciaco
{
    partial class HuellaEspera
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
            this.components = new System.ComponentModel.Container();
            this.pgbCargando = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbCargando
            // 
            this.pgbCargando.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.pgbCargando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pgbCargando.Location = new System.Drawing.Point(27, 36);
            this.pgbCargando.Name = "pgbCargando";
            this.pgbCargando.Size = new System.Drawing.Size(320, 23);
            this.pgbCargando.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbCargando.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esperando Huella.......";
            // 
            // tiempo
            // 
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // HuellaEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(389, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbCargando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HuellaEspera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HuellaEspera";
            this.Load += new System.EventHandler(this.HuellaEspera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbCargando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tiempo;
    }
}