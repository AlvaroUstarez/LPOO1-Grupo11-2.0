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

    public partial class Frm_Producto : Form
    {

        private int rolCodigo;

        public Frm_Producto(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
            Estilo.titulo(lblMensajePrincipalAltaProd);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            this.Hide();
            fPrincipal.Show();
        }

        private void btnAceptarAltaProd_Click(object sender, EventArgs e)
        {
            if (txtCategoriaProd.Text != "" && txtDescripcionProd.Text != "" && txtPrecioProd.Text != "")
            {
                Producto oProd = new Producto();
                oProd.Prod_Categoria = txtCategoriaProd.Text;

                oProd.Prod_Descripcion = txtDescripcionProd.Text;

                oProd.Prod_Precio = Convert.ToDouble(txtPrecioProd.Text);


                MessageBox.Show("Categoría: " + oProd.Prod_Categoria + "\n"
                                + "Descripción: " + oProd.Prod_Descripcion + "\n"
                                + "Precio: " + oProd.Prod_Precio + "\n"
                                , "Producto Agregado");

                TrabajarProducto.insert_product(oProd);

                FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
                this.Hide();
                fPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Complete todos los campos por favor", "Error");
            }
        }

        private void Frm_Producto_Load(object sender, EventArgs e)
        {

        }
    }
}
