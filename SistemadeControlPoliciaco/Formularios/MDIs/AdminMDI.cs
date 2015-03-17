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
    public partial class AdminMDI : Form
    {
        public AdminMDI()
        {
            InitializeComponent();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Registro reg = null;
            reg = Registro.Instancia();
            reg.MdiParent = this;
            reg.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarAspirante reg = null;
            reg = EditarAspirante.Instancia();
            reg.MdiParent = this;
            reg.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarAspirantes del = null;
            del = EliminarAspirantes.Instancia();
            del.MdiParent = this;
            del.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoUsuario del = null;
            del = NuevoUsuario.Instancia();
            del.MdiParent = this;
            del.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarUsuario del = null;
            del = EditarUsuario.Instancia();
            del.MdiParent = this;
            del.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarUsuario del = null;
            del = EliminarUsuario.Instancia();
            del.MdiParent = this;
            del.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora del = null;
            del = Calculadora.Instancia();
            del.MdiParent = this;
            del.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AdminMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslHora.Text = DateTime.Now.ToString("f");
        }

        private void AdminMDI_Load(object sender, EventArgs e)
        {
            tslHora.Alignment = ToolStripItemAlignment.Right;
        }

        private void catálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoAspirantes del = null;
            del = CatalogoAspirantes.Instancia();
            del.MdiParent = this;
            del.Show();
        }
    }
}
