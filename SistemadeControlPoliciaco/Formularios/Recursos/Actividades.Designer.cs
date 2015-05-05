namespace SistemadeControlPoliciaco
{
    partial class Actividades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.txbActividad = new System.Windows.Forms.TextBox();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.lblRestante = new System.Windows.Forms.Label();
            this.btnAsigna = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(82, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(469, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(52, 365);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actividad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(460, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(52, 416);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Presupuesto restante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lista de Actividades";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(127, 311);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(224, 24);
            this.cmbArea.TabIndex = 6;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            this.cmbArea.SelectedValueChanged += new System.EventHandler(this.cmbArea_SelectedValueChanged);
            // 
            // txbActividad
            // 
            this.txbActividad.Location = new System.Drawing.Point(127, 362);
            this.txbActividad.Margin = new System.Windows.Forms.Padding(4);
            this.txbActividad.MaxLength = 30;
            this.txbActividad.Name = "txbActividad";
            this.txbActividad.Size = new System.Drawing.Size(308, 22);
            this.txbActividad.TabIndex = 8;
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToAddRows = false;
            this.dgvActividades.AllowUserToDeleteRows = false;
            this.dgvActividades.AllowUserToResizeColumns = false;
            this.dgvActividades.AllowUserToResizeRows = false;
            this.dgvActividades.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(13, 118);
            this.dgvActividades.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.Size = new System.Drawing.Size(774, 170);
            this.dgvActividades.TabIndex = 9;
            // 
            // txbMonto
            // 
            this.txbMonto.Location = new System.Drawing.Point(523, 361);
            this.txbMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txbMonto.MaxLength = 9;
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(167, 22);
            this.txbMonto.TabIndex = 10;
            // 
            // lblRestante
            // 
            this.lblRestante.AutoSize = true;
            this.lblRestante.BackColor = System.Drawing.Color.Transparent;
            this.lblRestante.Location = new System.Drawing.Point(195, 416);
            this.lblRestante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestante.Name = "lblRestante";
            this.lblRestante.Size = new System.Drawing.Size(42, 16);
            this.lblRestante.TabIndex = 11;
            this.lblRestante.Text = "$ 0.00";
            // 
            // btnAsigna
            // 
            this.btnAsigna.Location = new System.Drawing.Point(639, 427);
            this.btnAsigna.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsigna.Name = "btnAsigna";
            this.btnAsigna.Size = new System.Drawing.Size(110, 35);
            this.btnAsigna.TabIndex = 12;
            this.btnAsigna.Text = "Asignar ";
            this.btnAsigna.UseVisualStyleBackColor = true;
            this.btnAsigna.Click += new System.EventHandler(this.btnAsigna_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(521, 427);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 35);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(523, 311);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(167, 22);
            this.dtpFecha.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(52, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Porcentaje restante:";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentaje.Location = new System.Drawing.Point(196, 446);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(30, 16);
            this.lblPorcentaje.TabIndex = 16;
            this.lblPorcentaje.Text = "0 %";
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeControlPoliciaco.Properties.Resources.FORMULARIO;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsigna);
            this.Controls.Add(this.lblRestante);
            this.Controls.Add(this.txbMonto);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.txbActividad);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Actividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos";
            this.Load += new System.EventHandler(this.Recursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.TextBox txbActividad;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Label lblRestante;
        private System.Windows.Forms.Button btnAsigna;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}