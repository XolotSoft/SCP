﻿using System;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF File|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fsi = File.OpenRead(ofd.FileName);
                FileStream fso = File.Create(Rutas.pdf()+"prueba2.pdf");
                fsi.CopyTo(fso);
                textBox1.Text = ofd.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdi_Click(object sender, EventArgs e)
        {

        }
    }
}