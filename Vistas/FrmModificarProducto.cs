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
    public partial class FrmModificarProducto : Form
    {

        private int rolCodigo;

        public FrmModificarProducto(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
            Estilo.titulo(label1);
        }

        private void FrmModificarProducto_Load(object sender, EventArgs e)
        {
            load_productos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgwProductos.DataSource = TrabajarProducto.buscarProductoDescripcion(txtBuscar.Text);
            }
            else
            {
                load_productos();
            }
        }

        private void load_productos()
        {
            dgwProductos.DataSource = TrabajarProducto.listar_product();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            this.Hide();
            fPrincipal.Show();
        }

        private void dgwProductos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwProductos.CurrentRow != null)
            {
                txtCodigo.Text = dgwProductos.CurrentRow.Cells["Codigo"].Value.ToString();
                txtCategoria.Text = dgwProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                txtDescripcion.Text = dgwProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgwProductos.CurrentRow.Cells["Precio"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            int id = int.Parse(txtCodigo.Text);
            producto.Prod_Categoria = txtCategoria.Text;
            producto.Prod_Descripcion = txtDescripcion.Text;
            producto.Prod_Precio = float.Parse(txtPrecio.Text);

            TrabajarProducto.modificarProductoSP(id, producto);

            load_productos();

        }
    }
}
