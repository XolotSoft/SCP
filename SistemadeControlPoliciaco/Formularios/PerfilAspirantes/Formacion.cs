using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemadeControlPoliciaco
{
    public partial class Formacion : Form
    {
        public Formacion()
        {
            InitializeComponent();
        }

        private void Formacion_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdi_Click(object sender, EventArgs e)
        {
            Pdf.guardar();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF File|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Pdf.cargar(0, File.OpenRead(ofd.FileName));
                pictureBox1.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF File|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                Pdf.cargar(1, File.OpenRead(ofd.FileName));
                pictureBox2.Visible = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF File|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Pdf.cargar(2, File.OpenRead(ofd.FileName));
                pictureBox3.Visible = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF File|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Pdf.cargar(3, File.OpenRead(ofd.FileName));
                pictureBox4.Visible = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF File|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Pdf.cargar(4, File.OpenRead(ofd.FileName));
                pictureBox5.Visible = true;

            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void btnCer_Click(object sender, EventArgs e)
        {

        }

 

    }
}
