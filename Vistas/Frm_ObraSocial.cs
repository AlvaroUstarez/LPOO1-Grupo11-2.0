using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class Frm_ObraSocial : Form
    {
        private int rolCodigo;

        public Frm_ObraSocial(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
            Estilo.titulo(lblTituloAltaObraSocial);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            this.Hide();
            fPrincipal.Show();


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCuit.Text != "" && txtRazonSocial.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "")
            {
                ObraSocial oObraSocial = new ObraSocial();

                oObraSocial.Os_Cuit = txtCuit.Text;
                oObraSocial.Os_RazonSocial = txtRazonSocial.Text;
                oObraSocial.Os_Direccion = txtDireccion.Text;
                oObraSocial.Os_Telefono = txtTelefono.Text;

                MessageBox.Show("CUIT: " + oObraSocial.Os_Cuit + "\n"
                               + "Razón Social: " + oObraSocial.Os_RazonSocial + "\n"
                               + "Dirección: " + oObraSocial.Os_Direccion + "\n"
                               + "Teléfono: " + oObraSocial.Os_Telefono + "\n"
                               , "Obra Social Registrada");

                TrabajarObraSocial.insert_obrasocial(oObraSocial);

                FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
                this.Hide();
                fPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Complete todos los campos por favor", "Error");
            }
        }

    }
}
