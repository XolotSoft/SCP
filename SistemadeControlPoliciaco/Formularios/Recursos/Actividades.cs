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
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();
            dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActividades.RowHeadersVisible = false;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd";
        }

        private static Actividades frmInst = null;
        ManejoBD departamentos = new ManejoBD();
        ManejoBD insertar = new ManejoBD();
        ManejoBD recursos = new ManejoBD();
        double porcentaje, restante;

        public static Actividades Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Actividades();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void Recursos_Load(object sender, EventArgs e)
        {
            departamentos.buscarg("*", "departamentos");
            cmbArea.DisplayMember = "nombre";
            cmbArea.ValueMember = "id";
            cmbArea.DataSource = departamentos.ds.Tables[0].DefaultView;
            CargarDgv();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsigna_Click(object sender, EventArgs e)
        {
            
            if (Vacio.txb(this))
            {
                string area = Convert.ToString(cmbArea.SelectedValue);
                string actividad = txbActividad.Text;
                double monto = Convert.ToDouble(txbMonto.Text);
                string fecha = dtpFecha.Text;

                string sql = "INSERT INTO actividades(departamento_id,actividad,monto,fecha) VALUES('"+area+"','"+actividad+"','"+monto+"','"+fecha+"')";
                Recursos(area);
                MessageBox.Show(Convert.ToString(restante));
                if (monto < restante)
                {
                    if (insertar.insertarq(sql))
                    {
                        Recursos(area);
                        string actual = Convert.ToString(restante - monto);
                        string sql1 = "UPDATE recursos SET restante =" + actual + " WHERE departamento_id = " + area + " ";
                        if (insertar.modificar(sql1))
                        {
                            MessageBox.Show("Se ha registrado correctamente la actividad");
                            Actualizar(area);
                            CargarDgv();
                            Limpiar.txb(this);
                            txbActividad.Focus();
                            if (porcentaje <= 20) MessageBox.Show("Te queda el 20% o menos de recursos","Atencion");  
                        }
                        else
                        {
                            MessageBox.Show("No se registro la actividad");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se registro la actividad");
                    }
                }
                else
                {
                    MessageBox.Show("No alcanza el presupuesto");
                }
                
            }
            else
            {
                MessageBox.Show("No dejes campos vacios");
            }
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = Convert.ToString(cmbArea.SelectedValue);
            Actualizar(id);
        }

        private void Actualizar(string id)
        {
            Recursos(id);               
            lblRestante.Text = "$ " + Convert.ToString(restante);
            lblPorcentaje.Text = Convert.ToString(porcentaje) + "%";
            
        }
        private void CargarDgv()
        {
            ManejoBD ac = new ManejoBD();
            string sql = "SELECT d.nombre AS Departamento, a.actividad AS Actividad, a.monto AS Monto, a.fecha AS Fecha"+
                " FROM actividades a INNER JOIN departamentos d ON a.departamento_id = d.id";
            ac.buscar(sql);
            dgvActividades.DataSource = ac.ds.Tables[0];
        }

        private void Recursos(string id)
        {
            recursos.ds.Clear();
            recursos.buscare("*", "recursos", "departamento_id", id);
            if (recursos.ds.Tables[0].Rows.Count > 0)
            {
                porcentaje = Math.Round((Convert.ToDouble(recursos.ds.Tables[0].Rows[0]["restante"]) * 100) / Convert.ToDouble(recursos.ds.Tables[0].Rows[0]["total"]), 2);
                restante = Convert.ToDouble(recursos.ds.Tables[0].Rows[0]["restante"]);
            }
            else
            {
                porcentaje = 0;
                restante = 0;
            }
        }
    }
}
