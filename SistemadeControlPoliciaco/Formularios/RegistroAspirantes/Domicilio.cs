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

        private string entidadFederativa, delegacionMunicipio, colonia, codigoPostal, calle, numeroExterior, numeroInterior;
        Texto texto = new Texto();
        private static Domicilio domicilio = null;

        public static Domicilio Instancia()
        {
            if (((domicilio == null) || (domicilio.IsDisposed == true)))
            {
                domicilio = new Domicilio();
            }
            domicilio.BringToFront();
            return domicilio;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            Limpiar.cbx(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            Limpiar.cbx(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEntFed.SelectedIndex == 1)
            {
                ManejoBD bd = new ManejoBD();
                bd.buscarg("*", "municipios");
                cbxDelMun.DataSource = bd.ds.Tables[0].DefaultView;
                cbxDelMun.DisplayMember = "nombre";
            }
            if (cbxEntFed.SelectedIndex == 2)
            {
                ManejoBD bd = new ManejoBD();
                bd.buscarg("*", "delegaciones");
                cbxDelMun.DataSource = bd.ds.Tables[0].DefaultView;
                cbxDelMun.DisplayMember = "nombre";
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
                    entidadFederativa = cbxEntFed.Text;
                    delegacionMunicipio = cbxDelMun.Text;
                    colonia = texto.Capital(txbCol.Text);
                    codigoPostal = txbCP.Text;
                    calle = texto.Capital(txbCalle.Text);
                    numeroExterior = txbNumExt.Text;
                    numeroInterior = txbNumInt.Text;
              
                    ManejoBD bd = new ManejoBD();

                    if (bd.insertar("domicilio", "entidad_federativa,delegacion_municipio,colonia,codigo_postal,calle,numero_exterior,numero_interior,aspirante_id", "'"
                       + entidadFederativa+ "','" + delegacionMunicipio + "','" + colonia + "','" +
                       codigoPostal + "','" + calle + "','" + numeroExterior + "','" + numeroInterior + "','" + Variables.aspiranteId + "'"))
                    {
                        if (bd.modificar("UPDATE aspirantes SET etapa = 2 WHERE id = '" + Variables.aspiranteId + "'"))
                        {
                            MessageBox.Show("Se ha concluido satisfactoriamente la etapa 2 del registro", "Correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar.txb(this);
                            Limpiar.cbx(this);
                            this.Hide();
                            Contacto contacto = null;
                            contacto = Contacto.Instancia();
                            contacto.MdiParent = AdminMDI.ActiveForm;
                            contacto.MdiParent = UserMDI.ActiveForm;
                            contacto.Show();
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
        #region Validaciones
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
        #endregion
    }
}
