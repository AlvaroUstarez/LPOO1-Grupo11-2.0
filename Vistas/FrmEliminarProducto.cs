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
    public partial class FrmEliminarProducto : Form
    {

        private int rolCodigo;

        public FrmEliminarProducto(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
            Estilo.titulo(label1);
        }

        private void FrmEliminarProducto_Load(object sender, EventArgs e)
        {
            load_productos();
        }

        private void load_productos()
        {
            dgwProductos.DataSource = TrabajarProducto.listar_product();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCodigo.Text);

            TrabajarProducto.darDeBajaProducto(id);

            load_productos();
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






    }
}
