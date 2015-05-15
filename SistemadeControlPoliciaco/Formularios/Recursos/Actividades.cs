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
            ManejoBD bd = new ManejoBD();
            bd.buscarg("*", "departamentos");
            cmbArea.DataSource = bd.ds.Tables[0].DefaultView;
            cmbArea.DisplayMember = "nombre";
            cmbArea.ValueMember = "id";
            ManejoBD ac = new ManejoBD();
            string sql = "SELECT d.nombre AS Departamento, a.actividad AS Actividad, a.monto AS Monto, a.fecha AS Fecha FROM actividades a INNER JOIN departamentos d ON a.departamento_id = d.id";
            ac.buscar(sql);
            dgvActividades.DataSource = ac.ds.Tables[0];

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
                string monto = txbMonto.Text;
                string fecha = dtpFecha.Text;

                ManejoBD insertar = new ManejoBD();
                string sql = "INSERT INTO actividades(departamento_id,actividad,monto,fecha) VALUES('"+area+"','"+actividad+"','"+monto+"','"+fecha+"')";
                if (insertar.insertarq(sql))
                {
                    ManejoBD res = new ManejoBD();
                    string sql0 = "SELECT * FROM recursos WHERE departamento_id = "+area+"";
                    res.buscar(sql0);
                    string actual = Convert.ToString(Convert.ToDouble( res.ds.Tables[0].Rows[0]["restante"]) - Convert.ToDouble(monto));
                    string sql1 = "UPDATE recursos SET restante ="+ actual +" WHERE departamento_id = "+ area +" ";
                    if (insertar.modificar(sql1))
                    {
                        string ida = Convert.ToString(cmbArea.SelectedValue);
                        ManejoBD re = new ManejoBD();
                        re.buscare("*", "recursos", "departamento_id", ida);
                        if (re.ds.Tables[0].Rows.Count > 0)
                        {
                            double por = (Convert.ToDouble(re.ds.Tables[0].Rows[0]["restante"]) * 100) / Convert.ToDouble(re.ds.Tables[0].Rows[0]["total"]);
                            if (por <= 20)
                            {
                               MessageBox.Show("Atencion,Cuidado te queda el 20% o menos del recurso asignado");
                               //lblRestante.Text = "$ " + Convert.ToString(re.ds.Tables[0].Rows[0]["restante"]);
                               lblPorcentaje.Text = Convert.ToString(por) + "%";
                            }
                            else
                            {
                                lblRestante.Text = "$ " + Convert.ToString(re.ds.Tables[0].Rows[0]["restante"]);
                                lblPorcentaje.Text = Convert.ToString(por) + "%";
                            }
                        }
                        MessageBox.Show("Se ha registrado correctamente la operacion");
                        string id = Convert.ToString(cmbArea.SelectedValue);
                        if (id != "System.Data.DataRowView")
                        {
                            ManejoBD rec = new ManejoBD();
                            rec.buscare("*", "recursos", "id", id);
                            if (rec.ds.Tables[0].Rows.Count > 0)
                            {
                                double por = (Convert.ToDouble(rec.ds.Tables[0].Rows[0]["restante"]) * 100) / Convert.ToDouble(rec.ds.Tables[0].Rows[0]["total"]);
                                lblRestante.Text = "$ " + Convert.ToString(rec.ds.Tables[0].Rows[0]["restante"]);
                                lblPorcentaje.Text = Convert.ToString(por) + "%";
                            }
                        }
                        ManejoBD ac = new ManejoBD();
                        string sql2 = "SELECT d.nombre AS Departamento, a.actividad AS Actividad, a.monto AS Monto, a.fecha AS Fecha FROM actividades a INNER JOIN departamentos d ON a.departamento_id = d.id";
                        ac.buscar(sql2);
                        dgvActividades.DataSource = ac.ds.Tables[0];
                        txbActividad.Text = "";
                        txbMonto.Text = "";
                        txbActividad.Focus();
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbArea_SelectedValueChanged(object sender, EventArgs e)
        {
            string id = Convert.ToString(cmbArea.SelectedValue);
            if (id != "System.Data.DataRowView")
            {
                ManejoBD rec = new ManejoBD();
                rec.buscare("*", "recursos", "departamento_id", id);
                if (rec.ds.Tables[0].Rows.Count > 0)
                {
                    double por = (Convert.ToDouble(rec.ds.Tables[0].Rows[0]["restante"]) * 100)/ Convert.ToDouble(rec.ds.Tables[0].Rows[0]["total"]);
             
                    lblRestante.Text = "$ " + Convert.ToString(rec.ds.Tables[0].Rows[0]["restante"]);
                    lblPorcentaje.Text = Convert.ToString(por) + "%";
                }
                
            }
        }
    }
}
