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
    public partial class EditarContacto : Form
    {
        public EditarContacto()
        {
            InitializeComponent();
        }
        private static EditarContacto frmInst = null;

        public static EditarContacto Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EditarContacto();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void EditarContacto_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            bd.buscare("*",
               "contacto", "aspirante_id", "" + Variables.idAsp + "");
            txbCel.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["celular"]);
            txbMail.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["email"]);
            txbTel.Text = Convert.ToString(bd.ds.Tables[0].Rows[0]["telefono"]);
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

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            EditarDomicilio ed = null;
            ed = EditarDomicilio.Instancia();
            ed.MdiParent = AdminMDI.ActiveForm;
            ed.Show();
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
