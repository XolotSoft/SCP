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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }
        string tipo;
        ManejoBD db = new ManejoBD();
        private static NuevoUsuario frmInst = null;

        public static NuevoUsuario Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new NuevoUsuario();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            rdbEmpleado.Checked = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked) tipo = "Administrador";
            if (rdbEmpleado.Checked) tipo = "Usuario";

            if (Vacio.txb(this))
            {
                if (txbPass.Text == txbPass2.Text)
                {
                    if (db.insertar("usuarios", "noUsu,pwUsu,tpUsu","'" +txbUser.Text + "','" + txbPass.Text + "','" + tipo +"'"))
                    {
                        MessageBox.Show("Se ha registrado el Usuario " + txbUser.Text, "Correctamente",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar.txb(this);
                    }
                    else
                    {
                        MessageBox.Show("No se ha registrado", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No puedes dejar campos vacios", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }
    }
}
