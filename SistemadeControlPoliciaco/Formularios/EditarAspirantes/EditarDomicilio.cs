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
    public partial class EditarDomicilio : Form
    {
        public EditarDomicilio()
        {
            InitializeComponent();
        }
        private static EditarDomicilio frmInst = null;
        public static EditarDomicilio Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EditarDomicilio();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void EditarDomicilio_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            bd.buscare("*",
               "domicilio", "aspirante_id", "" + Variables.idAsp + "");
            cbxDelMun.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["delegacion_municipio"]);
            txbCol.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["colonia"]);
            txbCP.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["codigo_postal"]);
            txbCalle.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["calle"]);
            txbNumExt.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["numero_exterior"]);
            txbNumInt.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["numero_interior"]);
            if (cbxEntFed.Text == "Estado de México")
            {
                ManejoBD db = new ManejoBD();
                db.buscarg("*", "municipios");
                cbxDelMun.DataSource = db.ds.Tables[0].DefaultView;
                cbxDelMun.DisplayMember = "nombre";
                cbxEntFed.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["entidad_federativa"]);
            }
            else
            {
                ManejoBD db = new ManejoBD();
                db.buscarg("*", "delegaciones");
                cbxDelMun.DataSource = db.ds.Tables[0].DefaultView;
                cbxDelMun.DisplayMember = "nombre";
                cbxEntFed.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["entidad_federativa"]);
            }

        }

        private void cbxEntFed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEntFed.SelectedIndex == 1)
            {
                ManejoBD bd = new ManejoBD();
                bd.buscarg("*", "municipios");
                cbxDelMun.DataSource = bd.ds.Tables[0].DefaultView;
                cbxDelMun.DisplayMember = "nombre";
            }
            if (cbxEntFed.SelectedIndex == 2)
            {
                ManejoBD bd = new ManejoBD();
                bd.buscarg("*", "delegaciones");
                cbxDelMun.DataSource = bd.ds.Tables[0].DefaultView;
                cbxDelMun.DisplayMember = "nombre";
            }
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            EditarContacto ec = null;
            ec = EditarContacto.Instancia();
            ec.MdiParent = AdminMDI.ActiveForm;
            ec.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            EditarAspirante con = null;
            con = EditarAspirante.Instancia();
            con.MdiParent = AdminMDI.ActiveForm;
            con.MdiParent = UserMDI.ActiveForm;
            con.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            EditarFoto ft = null;
            ft = EditarFoto.Instancia();
            ft.MdiParent = AdminMDI.ActiveForm;
            ft.Show();
            this.Close();
        }

        private void btnPersonales_Click(object sender, EventArgs e)
        {
            EditarPersonal ec = null;
            ec = EditarPersonal.Instancia();
            ec.MdiParent = AdminMDI.ActiveForm;
            ec.Show();
            this.Close();
        }

        private void btnHuella_Click(object sender, EventArgs e)
        {
            EditarHuella ft = null;
            ft = EditarHuella.Instancia();
            ft.MdiParent = AdminMDI.ActiveForm;
            ft.Show();
            this.Close();
        }
    }
}
