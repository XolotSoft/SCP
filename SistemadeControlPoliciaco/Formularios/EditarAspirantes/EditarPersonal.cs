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
    public partial class EditarPersonal : Form
    {
        public EditarPersonal()
        {
            InitializeComponent();
        }
        private static EditarPersonal frmInst = null;
        ManejoBD bd = new ManejoBD();

        public static EditarPersonal Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EditarPersonal();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void EditarDatPerAsp_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            bd.buscarg("*", "estados");
            cbxEntFed.DataSource = bd.ds.Tables[0].DefaultView;
            cbxEntFed.DisplayMember = "nombre";
            cbxEntFed.ValueMember = "id";
            ManejoBD db = new ManejoBD();
            db.buscare("*",
                "personal", "aspirante_id", ""+ Variables.idAsp +"");
            txbApePat.Text = Convert.ToString(db.ds.Tables[0].Rows[0]["apellido_paterno"]);
            txbApeMat.Text = Convert.ToString(db.ds.Tables[0].Rows[0]["apellido_materno"]);
            txbNom.Text = Convert.ToString(db.ds.Tables[0].Rows[0]["nombre"]);
            dtpFecNac.Value = Convert.ToDateTime(db.ds.Tables[0].Rows[0]["fecha_nacimiento"]);
            cbxSex.Text = Convert.ToString(db.ds.Tables[0].Rows[0]["sexo"]);
            cbxEntFed.Text = Convert.ToString(db.ds.Tables[0].Rows[0]["entidad_federativa"]);
            txbCurAut.Text = Convert.ToString(db.ds.Tables[0].Rows[0]["curp"]).Substring(0,15);
            txbCurHom.Text = Convert.ToString(db.ds.Tables[0].Rows[0]["curp"]).Substring(15,3);
            txbRfcAut.Text = Convert.ToString(db.ds.Tables[0].Rows[0]["rfc"]).Substring(0,10);
            txbRfcHom.Text = Convert.ToString(db.ds.Tables[0].Rows[0]["rfc"]).Substring(10,3);
            cbxEdoCiv.Text = Convert.ToString(db.ds.Tables[0].Rows[0]["estado_civil"]);
            dtpFecNac.Format = DateTimePickerFormat.Custom;
            dtpFecNac.CustomFormat = "yyyy-MM-dd";
            string anio = dtpFecNac.Text.Substring(2, 2);
            string mes = dtpFecNac.Text.Substring(5, 2);
            string dia = dtpFecNac.Text.Substring(8, 2);        
        }

        private void btnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            this.Close();
            EditarAspirante dom = null;
            dom = EditarAspirante.Instancia();
            dom.MdiParent = AdminMDI.ActiveForm;
            dom.MdiParent = UserMDI.ActiveForm;
            dom.Show();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                {
                    string sql = "UPDATE personal SET apellido_paterno = '" + txbApePat.Text + "'," + "apellido_materno ='"+ txbApeMat.Text +"'," + 
                        "nombre ='" + txbNom.Text + "'," + "fecha_nacimiento ='"+ dtpFecNac.Text + "'," + "sexo ='" + cbxSex.Text + "'," +
                        "entidad_federativa ='" + cbxEntFed.Text + "'," + "curp ='" + txbCurAut.Text+txbCurHom.Text + "'," +
                        "rfc ='" + txbRfcAut.Text+txbRfcHom.Text + "'," +"estado_civil ='" + cbxEdoCiv.Text + "' WHERE aspirante_id = '" + Variables.idAsp + "'";
                    if (bd.modificar(sql))
                    {             
                        MessageBox.Show("Se ha modificado el Usuario", "Correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        EditarAspirante dom = null;
                        dom = EditarAspirante.Instancia();
                        dom.MdiParent = AdminMDI.ActiveForm;
                        dom.MdiParent = UserMDI.ActiveForm;
                        dom.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se ha modificado el Usuario", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes de Seleccionar una opcion", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes de llenar todos los campos", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbApePat_Leave(object sender, EventArgs e)
        {
            
        }

        private void txbApeMat_Leave(object sender, EventArgs e)
        {
            
        }

        private void txbNom_Leave(object sender, EventArgs e)
        {
           
        }

        private void dtpFecNac_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbxSex_Leave(object sender, EventArgs e)
        {
           
        }

        private void cbxEntFed_Leave(object sender, EventArgs e)
        {

        }

        private void txbCurHom_Leave(object sender, EventArgs e)
        {
            
        }

        private void txbRfcHom_Leave(object sender, EventArgs e)
        {
            
        }

        private void txbApePat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbApeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbCurHom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbRfcHom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarDomicilio ed = null;
            ed = EditarDomicilio.Instancia();
            ed.MdiParent = AdminMDI.ActiveForm;
            ed.Show();
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarContacto ec = null;
            ec = EditarContacto.Instancia();
            ec.MdiParent = AdminMDI.ActiveForm;
            ec.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditarFoto ft = null;
            ft = EditarFoto.Instancia();
            ft.MdiParent = AdminMDI.ActiveForm;
            ft.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditarHuella ft = null;
            ft = EditarHuella.Instancia();
            ft.MdiParent = AdminMDI.ActiveForm;
            ft.Show();
            this.Close();
        }
    }
}
