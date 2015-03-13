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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        string aPat = "";
        string aMat = "";
        string nAsp = "";
        string fNac = "";
        string eFed = "";
        string sAsp = "";
        private static Registro frmInst = null;

        public static Registro Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Registro();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            bd.buscarg("*", "estados");
            cbxEntFed.DataSource = bd.ds.Tables[0].DefaultView;
            cbxEntFed.DisplayMember = "noEst";
            cbxEntFed.ValueMember = "clEst";
            Limpiar.txb(this);
            dtpFecNac.ResetText();
            Limpiar.cbx(this);
            dtpFecNac.Format = DateTimePickerFormat.Custom;
            dtpFecNac.CustomFormat = "yyyy-MM-dd";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            dtpFecNac.ResetText();
            Limpiar.cbx(this);
            aPat = "";
            aMat = "";
            nAsp = "";
            fNac = "";
            eFed = "";
            sAsp = "";
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            dtpFecNac.ResetText();
            Limpiar.cbx(this);
            aPat = "";
            aMat = "";
            nAsp = "";
            fNac = "";
            eFed = "";
            sAsp = "";
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                {
                    string aPat = txbApePat.Text;
                    string aMat = txbApeMat.Text;
                    string nAsp = txbNom.Text;
                    string fNac = dtpFecNac.Text;
                    string eFed = cbxEntFed.Text;
                    string sAsp = cbxSex.Text;
                    string dAsp = txbCurAut.Text + txbCurHom.Text;
                    string rAsp = txbRfcAut.Text + txbRfcHom.Text;
                    string ecAsp = cbxEdoCiv.Text;
                    Variables.DatosPersonales(aPat, aMat, nAsp, fNac, eFed, sAsp, dAsp, rAsp, ecAsp);
                    ManejoBD bd = new ManejoBD();
                    bd.buscar("SELECT a.personales_id,a.etapa FROM personales p INNER JOIN aspirantes a ON p.personales_id = a.personales_id WHERE p.rfcAsp = '"+rAsp+"'");
                    if (bd.dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Ya se encuentra un aspirante registrado con el RFC "+rAsp+"", "Correcto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataRow u = bd.dt.Rows[0];
                        string pid = Convert.ToString(u[0]);                    
                        string etapa = Convert.ToString(u[1]);
                        if (etapa != "5")
                        {
                            DialogResult dialogo = MessageBox.Show("El aspirante ya cuenta con un registro previo desea concluirlo o eliminarlo", "Atención",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogo == DialogResult.Yes)
                            {
                                Limpiar.txb(this);
                                dtpFecNac.ResetText();
                                Limpiar.cbx(this);
                                aPat = "";
                                aMat = "";
                                nAsp = "";
                                fNac = "";
                                eFed = "";
                                sAsp = "";

                                switch (etapa)
                                {
                                    case "1":
                                        this.Hide();
                                        Domicilio dom = null;
                                        dom = Domicilio.Instancia();
                                        dom.MdiParent = AdminMDI.ActiveForm;
                                        dom.MdiParent = UserMDI.ActiveForm;
                                        dom.Show();
                                        break;
                                    case "2":
                                        this.Hide();
                                        Contacto con = null;
                                        con = Contacto.Instancia();
                                        con.MdiParent = AdminMDI.ActiveForm;
                                        con.MdiParent = UserMDI.ActiveForm;
                                        con.Show();
                                        break;
                                    case "3":
                                        this.Close();
                                        Foto fot = null;
                                        fot = Foto.Instancia();
                                        fot.MdiParent = AdminMDI.ActiveForm;
                                        fot.MdiParent = UserMDI.ActiveForm;
                                        fot.Show();
                                        break;
                                    case "4":
                                        this.Hide();
                                        Escaneo esc = null;
                                        esc = Escaneo.Instancia();
                                        esc.MdiParent = AdminMDI.ActiveForm;
                                        esc.MdiParent = UserMDI.ActiveForm;
                                        esc.Show();
                                        break;
                                    default:
                                        break;
                                }

                            }
                            if (dialogo == DialogResult.No)
                            {
                                this.Hide();
                            }

                        }
                        else
                        {
                            DialogResult dialogo = MessageBox.Show("El aspirante ya ha concluido con su proceso de registro", "Atención",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        

                    }
                    else
                    {
                        if (bd.insertar("personales", "appAsp, apmAsp, nomAsp, fncAsp, sexAsp, enfAsp, curAsp," +
                       "rfcAsp, edcAsp", "'" + Variables.appAsp + "','" + Variables.apmAsp + "','" + Variables.nomAsp +
                       "','" + Variables.fncAsp + "','" + Variables.sexAsp + "','" + Variables.enfAsp + "','" + Variables.curAsp +
                       "','" + Variables.rfcAsp + "','" + Variables.edcAsp + "'"))
                        {
                            if (bd.insertar("aspirantes", "personales_id, etapa", "(SELECT TOP 1 personales_id FROM personales ORDER BY personales_id DESC),1"))
                            {
                                MessageBox.Show("El aspirante se ha registrado", "Correcto",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                aPat = "";
                                aMat = "";
                                nAsp = "";
                                fNac = "";
                                eFed = "";
                                sAsp = "";
                                Limpiar.txb(this);
                                dtpFecNac.ResetText();
                                Limpiar.cbx(this);
                                this.Hide();
                                Domicilio dom = null;
                                dom = Domicilio.Instancia();
                                dom.MdiParent = AdminMDI.ActiveForm;
                                dom.MdiParent = UserMDI.ActiveForm;
                                dom.Show();

                            }
                            else
                            {
                                MessageBox.Show("No se registro el Aspirante", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se registro el Aspirante", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
            }
        }

        private void txbApeMat_Leave(object sender, EventArgs e)
        {
            if (txbApeMat.Text != "")
            {
                aMat = txbApeMat.Text.Substring(0, 1).ToUpper();
                txbRfcAut.Text = aPat + aMat + nAsp + fNac;
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
            }
        }

        private void txbNom_Leave(object sender, EventArgs e)
        {
            if (txbNom.Text != "")
            {
                nAsp = txbNom.Text.Substring(0, 1).ToUpper();
                txbRfcAut.Text = aPat + aMat + nAsp + fNac;
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
            }
        }

        private void dtpFecNac_Leave(object sender, EventArgs e)
        {
            dtpFecNac.Format = DateTimePickerFormat.Custom;
            dtpFecNac.CustomFormat = "yyyy-MM-dd";
            string anio = dtpFecNac.Text.Substring(2, 2);
            string mes = dtpFecNac.Text.Substring(5, 2);
            string dia = dtpFecNac.Text.Substring(8, 2);
            fNac = anio+mes+dia;
            txbRfcAut.Text = aPat + aMat + nAsp + fNac;
            txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
        }

        private void cbxSex_Leave(object sender, EventArgs e)
        {
            if (cbxSex.SelectedIndex != 0)
            {
                sAsp = cbxSex.Text.Substring(0, 1).ToUpper();
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
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
