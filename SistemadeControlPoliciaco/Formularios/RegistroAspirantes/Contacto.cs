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
            string telefono,celular,email;          
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                if (Vacio.cbx(this))
                {
                    if(Validar.mail(txbMail.Text))
                    {
                        telefono = txbTel.Text;
                        celular = txbCel.Text;
                        email = txbMail.Text;
                     
                        ManejoBD bd = new ManejoBD();
                        if (bd.insertar("contacto", "telefono,celular,email,aspirante_id", "'" + telefono + "','" + celular + "','" + email + "','" + Variables.aspiranteId + "'"))

                        {
                            if (bd.modificar("UPDATE aspirantes SET etapa = 3 WHERE id = '" + Variables.aspiranteId + "'")) 
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
            cbxPue.DisplayMember = "nombre";
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            Limpiar.cbx(this);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            Limpiar.cbx(this);
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
