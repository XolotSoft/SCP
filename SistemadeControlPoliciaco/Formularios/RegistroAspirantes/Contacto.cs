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
    public partial class Contacto : Form
    {
        public Contacto()
        {
            InitializeComponent();
        }
        private static Contacto frmInst = null;

        public static Contacto Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Contacto();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            Limpiar.cbx(this);
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            Limpiar.cbx(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                {
                    if(Validar.mail(txbMail.Text))
                    {

                       
                        string cn = txbCon.Text;
                        string pt = cbxPue.Text;
                        string tl = txbTel.Text;
                        string cl = txbCel.Text;
                        string em = txbMail.Text;
                     
                        ManejoBD bd = new ManejoBD();
                        ob_id id = new ob_id();
                        string ida = id.obtener(Variables.rfcAsp);
                        if (bd.insertar("contacto", "telAsp,celAsp,emaAsp", "'"
                       + tl + "','" + cl + "','" + em + "'"))

                        {
                            if(bd.insertar("postulado","conASp,pueASp","'"+ cn + "','"+ pt +"'"))
                            {

                                if (bd.modificar("UPDATE aspirantes SET contacto_id = (SELECT TOP 1 contacto_id FROM contacto d ORDER BY contacto_id DESC),etapa=3,postulado_id=(SELECT TOP 1 postulado_id FROM postulado d ORDER BY postulado_id DESC) WHERE idAsp = '" + ida + "'")) 
                                {
                                    MessageBox.Show("Se ha concluido satisfactoriamente la etapa 3 del registro", "Correcto",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar.txb(this);
                                    Limpiar.cbx(this);
                                    this.Close();
                                    Foto fot = null;
                                    fot = Foto.Instancia();
                                    fot.MdiParent = AdminMDI.ActiveForm;
                                    fot.MdiParent = UserMDI.ActiveForm;
                                    fot.Show();
                                }
                            }
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("El formato del e-mail es incorecto", "Error",
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

        private void Contacto_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();

            bd.buscarg("*", "puestos");
            cbxPue.DataSource = bd.ds.Tables[0].DefaultView;
            cbxPue.DisplayMember = "noPue";
        }

        private void txbTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.num(e);
        }

        private void txbCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.num(e);
        }
    }
}
