using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeControlPoliciaco
{
    public partial class Recursos : Form
    {
        public Recursos()
        {
            InitializeComponent();
            dgvActividades.Columns.Add("Area", "Area");
            dgvActividades.Columns.Add("Actividad", "Acividad");
            dgvActividades.Columns.Add("Monto", "Monto");
            dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActividades.RowHeadersVisible = false;
        }

        private void Recursos_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            bd.buscarg("*", "departamentos");
            cmbArea.DataSource = bd.ds.Tables[0].DefaultView;
            cmbArea.DisplayMember = "nombre";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsigna_Click(object sender, EventArgs e)
        {
            string area = cmbArea.Text;
            String actividad = txbActividad.Text;
            String monto = txbMonto.Text;
            dgvActividades.Rows.Add(area,actividad,monto);
            txbActividad.Text = "";
            txbMonto.Text = "";
            txbActividad.Focus();
        }
    }
}
