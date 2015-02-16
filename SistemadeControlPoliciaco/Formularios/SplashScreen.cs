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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            pgbCargando.Maximum = 100;
            pgbCargando.Minimum = 0;
            pgbCargando.Value = 0;
            pgbCargando.Step = 1;
            tiempo.Enabled = true;
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (pgbCargando.Value < 100)
            {
                pgbCargando.Value += 2;

                switch (pgbCargando.Value)
                {
                    case 2:
                        lblMensaje.Text = "Iniciando sistema...";
                        break;
                    case 20:
                        lblMensaje.Text = "Cargando fuentes...";
                        break;
                    case 40:
                        lblMensaje.Text = "Cargando formularios...";
                        break;
                    case 60:
                        lblMensaje.Text = "Conectando a base de datos...";
                        break;
                    case 80:
                        lblMensaje.Text = "Finalizando la carga del sistema...";
                        break;
                    case 100:
                        tiempo.Enabled = false;
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                        break;
                }
            }      
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
