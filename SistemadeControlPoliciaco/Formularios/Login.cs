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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();           
        }
        ManejoBD db = new ManejoBD();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string userR;
            string passR;
            string tipo;
            string user = txbUser.Text;
            string pass = txbPass.Text;
            string salt = "hbxOlOt23";
            pass= Hash.sha1(Hash.md5(pass + salt));

            string sql = "SELECT * FROM Usuarios WHERE noUsu ='" + user + "' AND pwUsu ='" + pass + "'";

            if (Vacio.txb(this))
            {
                db.buscar(sql);
                if (db.dt.Rows.Count > 0)
                {
                    DataRow u = db.dt.Rows[0];
                    userR = Convert.ToString(u[1]);
                    passR = Convert.ToString(u[2]);
                    tipo = Convert.ToString(u[3]);

                    if (user == userR && pass == passR && tipo == "Administrador")
                    {
                        this.Hide();
                        AdminMDI mdiA = new AdminMDI();
                        mdiA.Show();
                    }

                    if (user == userR && pass == passR && tipo == "Usuario")
                    {
                        this.Hide();
                        UserMDI mdiU = new UserMDI();
                        mdiU.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar.txb(this);
                    txbUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debes de llenar ambos campos", "Error",
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEntrar.PerformClick();
            }
        }
    }
}
