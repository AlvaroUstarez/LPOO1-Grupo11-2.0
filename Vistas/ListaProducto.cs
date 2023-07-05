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
    public partial class ListaProducto : Form
    {

        private int rolCodigo;

        public ListaProducto(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
            Estilo.titulo(label2);
            load_product();
        }
        private void load_product()
        {
            dgwProd.DataSource = TrabajarProducto.listar_product();
        }

        private void btnSalirP_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            this.Hide();
            fPrincipal.Show();

        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            if (txtBuscarProd.Text != "")
            {
                dgwProd.DataSource = TrabajarProducto.search_producto(int.Parse(txtBuscarProd.Text));
            }
            else
            {
                load_product();
            }
        }

        private void rbtnDes_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = TrabajarProducto.listar_producto_x_descripcion();

            dgwProd.DataSource = dt;
        }

        private void rbtnCategoria_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = TrabajarProducto.listar_producto_x_categoria();

            dgwProd.DataSource = dt;
        }

        private void rbtnPDef_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = TrabajarProducto.listar_producto_x_defecto();

            dgwProd.DataSource = dt;
        }

    }
}
