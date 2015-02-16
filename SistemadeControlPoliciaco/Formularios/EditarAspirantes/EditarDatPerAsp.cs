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
    public partial class EditarDatPerAsp : Form
    {
        public EditarDatPerAsp()
        {
            InitializeComponent();
        }
        private static EditarDatPerAsp frmInst = null;
        ManejoBD bd = new ManejoBD();
        string aPat = "";
        string aMat = "";
        string nAsp = "";
        string fNac = "";
        string eFed = "";
        string sAsp = "";

        public static EditarDatPerAsp Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EditarDatPerAsp();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void EditarDatPerAsp_Load(object sender, EventArgs e)
        {
            bd.buscarg("*", "estados");
            cbxEntFed.DataSource = bd.ds.Tables[0].DefaultView;
            cbxEntFed.DisplayMember = "noEst";
            cbxEntFed.ValueMember = "clEst";
            bd.dt.Reset();
            bd.buscare("appAsp,apmAsp,nomAsp,fncAsp,sexAsp,enfAsp,curAsp,rfcAsp,edcAsp",
                "aspirantes", "idAsp", ""+Variables.idAsp+"");
            DataRow drb = bd.dt.Rows[0];
            txbApePat.Text = Convert.ToString(drb[0]);
            txbApeMat.Text = Convert.ToString(drb[1]);
            txbNom.Text = Convert.ToString(drb[2]);
            dtpFecNac.Value = Convert.ToDateTime(drb[3]);
            cbxSex.Text = Convert.ToString(drb[4]);
            cbxEntFed.Text = Convert.ToString(drb[5]);
            txbCurAut.Text = Convert.ToString(drb[6]).Substring(0,13);
            txbCurHom.Text = Convert.ToString(drb[6]).Substring(13,3);
            txbRfcAut.Text = Convert.ToString(drb[7]).Substring(0,10);
            txbRfcHom.Text = Convert.ToString(drb[7]).Substring(10,3);
            cbxEdoCiv.Text = Convert.ToString(drb[8]);
            dtpFecNac.Format = DateTimePickerFormat.Custom;
            dtpFecNac.CustomFormat = "yyyy-MM-dd";
            string anio = dtpFecNac.Text.Substring(2, 2);
            string mes = dtpFecNac.Text.Substring(5, 2);
            string dia = dtpFecNac.Text.Substring(8, 2);
            aPat = txbApePat.Text.Substring(0, 2).ToUpper();
            aMat = txbApeMat.Text.Substring(0, 1).ToUpper();
            nAsp = txbNom.Text.Substring(0, 1).ToUpper();
            fNac = anio + mes + dia;
            sAsp = cbxSex.Text.Substring(0, 1).ToUpper();
            eFed = Convert.ToString(drb[6]).Substring(11, 2);
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
                    string sql = "UPDATE aspirantes SET appAsp = '" + txbApePat.Text + "'," + "apmAsp ='"+ txbApeMat.Text +"'," + 
                        "nomAsp ='" + txbNom.Text + "'," + "fncAsp ='"+ dtpFecNac.Text + "'," + "sexAsp ='" + cbxSex.Text + "'," +
                        "enfAsp ='" + cbxEntFed.Text + "'," + "curAsp ='" + txbCurAut.Text+txbCurHom.Text + "'," +
                        "rfcAsp ='" + txbRfcAut.Text+txbRfcHom.Text + "'," +"edcAsp ='" + cbxEdoCiv.Text + "' WHERE idAsp = '" + Variables.idAsp + "'";
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
            if (txbApePat.Text != "")
            {
                aPat = txbApePat.Text.Substring(0, 2).ToUpper();
                txbRfcAut.Text = aPat + aMat + nAsp + fNac;
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp + eFed;
            }
        }

        private void txbApeMat_Leave(object sender, EventArgs e)
        {
            if (txbApeMat.Text != "")
            {
                aMat = txbApeMat.Text.Substring(0, 1).ToUpper();
                txbRfcAut.Text = aPat + aMat + nAsp + fNac;
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp + eFed;
            }
        }

        private void txbNom_Leave(object sender, EventArgs e)
        {
            if (txbNom.Text != "")
            {
                nAsp = txbNom.Text.Substring(0, 1).ToUpper();
                txbRfcAut.Text = aPat + aMat + nAsp + fNac;
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp + eFed;
            }
        }

        private void dtpFecNac_Leave(object sender, EventArgs e)
        {
            dtpFecNac.Format = DateTimePickerFormat.Custom;
            dtpFecNac.CustomFormat = "yyyy-MM-dd";
            string anio = dtpFecNac.Text.Substring(2, 2);
            string mes = dtpFecNac.Text.Substring(5, 2);
            string dia = dtpFecNac.Text.Substring(8, 2);
            fNac = anio + mes + dia;
            txbRfcAut.Text = aPat + aMat + nAsp + fNac;
            txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp + eFed;
        }

        private void cbxSex_Leave(object sender, EventArgs e)
        {
            if (cbxSex.SelectedIndex != 0)
            {
                sAsp = cbxSex.Text.Substring(0, 1).ToUpper();
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp + eFed;
            }
        }

        private void cbxEntFed_Leave(object sender, EventArgs e)
        {
            if (cbxSex.SelectedIndex != 0)
            {
                eFed = cbxEntFed.SelectedValue.ToString();
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp + eFed;
            }
        }

        private void txbCurHom_Leave(object sender, EventArgs e)
        {
            txbCurHom.Text = txbCurHom.Text.ToUpper();
        }

        private void txbRfcHom_Leave(object sender, EventArgs e)
        {
            txbRfcHom.Text = txbRfcHom.Text.ToUpper();
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
    }
}
