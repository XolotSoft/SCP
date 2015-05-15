using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
            string rol;
            string userStored;
            string passStored;
            string userInput = txbUser.Text;
            string passInput = txbPass.Text;
            string salt = ConfigurationManager.AppSettings["salt"];
            passInput= Hash.sha1(Hash.md5(passInput + salt));
            string sql = "SELECT * FROM Usuarios WHERE username ='" + userInput + "' AND password ='" + passInput + "'";

            if (Vacio.txb(this))
            {
                db.buscar(sql);
                if (db.ds.Tables[0].Rows.Count > 0)
                {
                    userStored = Convert.ToString(db.ds.Tables[0].Rows[0]["username"]);
                    passStored = Convert.ToString(db.ds.Tables[0].Rows[0]["password"]);
                    rol = Convert.ToString(db.ds.Tables[0].Rows[0]["rol"]);

                    if (userInput == userStored && passInput == passStored && rol == "Administrador")
                    {
                        this.Hide();
                        AdminMDI mdiA = new AdminMDI();
                        mdiA.Show();
                    }

                    if (userInput == userStored && passInput == passStored && rol == "Usuario")
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
