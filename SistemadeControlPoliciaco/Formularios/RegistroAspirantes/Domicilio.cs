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
    public partial class Domicilio : Form
    {
        public Domicilio()
        {
            InitializeComponent();
        }
           string ef = "";
           string dm = "";
           string cl = "";
           string cp = "";
           string cy = "";
           string ne = "";
           string ni = "";
        private static Domicilio frmInst = null;

        public static Domicilio Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Domicilio();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ef = "";
            dm = "";
            cl = "";
            cp = "";
            cy = "";
            ne = "";
            ni = "";
            Limpiar.txb(this);
            Limpiar.cbx(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            Limpiar.cbx(this);
            ef = "";
            dm = "";
            cl = "";
            cp = "";
            cy = "";
            ne = "";
            ni = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEntFed.SelectedIndex == 1)
            {
                ManejoBD bd = new ManejoBD();
                bd.buscarg("*", "municipios");
                cbxDelMun.DataSource = bd.ds.Tables[0].DefaultView;
                cbxDelMun.DisplayMember = "noMun";
            }
            if (cbxEntFed.SelectedIndex == 2)
            {
                ManejoBD bd = new ManejoBD();
                bd.buscarg("*", "delegaciones");
                cbxDelMun.DataSource = bd.ds.Tables[0].DefaultView;
                cbxDelMun.DisplayMember = "noMun";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txbNumExt.Text == "") txbNumExt.Text = "S/N";
            if (txbNumInt.Text == "") txbNumInt.Text = "S/N";
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                {
                  
                     ef = cbxEntFed.Text;
                     dm = cbxDelMun.Text;
                     cl = txbCol.Text;
                     cp = txbCP.Text;
                     cy = txbCalle.Text;
                     ne = txbNumExt.Text;
                     ni = txbNumInt.Text;
              
                    ManejoBD bd = new ManejoBD();
                    ob_id id = new ob_id();
                    string ida = id.obtener(Variables.rfcAsp);
                    if (bd.insertar("domicilio", "efdAsp,domAsp,colAsp,cdpAsp,cllAsp,nueAsp,nuiAsp", "'"
                       + ef+ "','" + dm + "','" + cl + "','" +
                       cp + "','" + cy + "','" + ne + "','" + ni + "'"))
                    {
                        
                        if (bd.modificar("UPDATE aspirantes SET domicilio_id = (SELECT TOP 1 domicilio_id FROM domicilio d ORDER BY domicilio_id DESC),etapa=2 WHERE idAsp = '"+ida+"'"))
                          
                        {
                            MessageBox.Show("Se ha concluido satisfactoriamente la etapa 2 del registro", "Correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ef = "";
                            dm = "";
                            cl = "";
                            cp = "";
                            cy = "";
                            ne = "";
                            ni = "";
                            Limpiar.txb(this);
                            Limpiar.cbx(this);
                            this.Hide();
                            Contacto con = null;
                            con = Contacto.Instancia();
                            con.MdiParent = AdminMDI.ActiveForm;
                            con.MdiParent = UserMDI.ActiveForm;
                            con.Show();

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

        private void txbNumExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.num(e);
        }

        private void txbNumInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.num(e);
        }

        private void txbCodPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.num(e);
        }

        private void txbCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }

        private void txbCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }

        private void txbCol_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }

        private void txbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.num(e);
        }

        private void txbCalle_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }

        private void txbNumExt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }

        private void txbNumInt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.letynumesp(e);
        }
    }
}
