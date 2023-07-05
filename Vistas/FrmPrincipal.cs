using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmPrincipal : Form
    {

        private int rolCodigo;

        public FrmPrincipal(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
        }

        private void agregarNuevosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Producto fAltaProducto = new Frm_Producto(rolCodigo);
            this.Hide();
            fAltaProducto.Show();
            this.Close();
        }

        private void ingresarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AltaCliente fAltaCliente = new Frm_AltaCliente(rolCodigo);
            this.Hide();
            fAltaCliente.Show();
            this.Close();
        }

        private void registrarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ObraSocial fAltaObraSocial = new Frm_ObraSocial(rolCodigo);
            this.Hide();
            fAltaObraSocial.Show();
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (rolCodigo == 1)
            {
                clienteToolStripMenuItem.Visible = false;
                obraSocialToolStripMenuItem.Visible = false;
                ventasToolStripMenuItem.Visible = false;
            }
            else if (rolCodigo == 2)
            {
                productoToolStripMenuItem.Visible = false;
                obraSocialToolStripMenuItem.Visible = false;
                usuarioToolStripMenuItem.Visible = false;
            }
            else if (rolCodigo == 3)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro(a) que desea salir del sistema?",
                 "Consulta",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_User fUser = new Frm_User(rolCodigo);
            this.Hide();
            fUser.Show();

        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCliente lCliente = new ListaCliente(rolCodigo);
            this.Hide();
            lCliente.Show();
        }

        private void listarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProducto lProducto = new ListaProducto(rolCodigo);
            this.Hide();
            lProducto.Show();
        }


        private void agregarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas formVenta = new FrmVentas(rolCodigo);
            this.Hide();
            formVenta.Show();
        }

        private void listarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaVenta frmListaVenta = new FrmListaVenta(rolCodigo);
            this.Hide();
            frmListaVenta.Show();
        }

        private void modificarProductosExistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarProducto frmModificarProducto = new FrmModificarProducto(rolCodigo);
            this.Hide();
            frmModificarProducto.Show();
            this.Close();
        }


        private void ventaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListaVentasProducto frmListaVentasProductos = new Frm_ListaVentasProducto(rolCodigo);
            this.Hide();
            frmListaVentasProductos.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarProducto frmEliminarProducto = new FrmEliminarProducto(rolCodigo);
            this.Hide();
            frmEliminarProducto.Show();
            this.Close();
        }

        private void listaDeObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaObraSocial frmListaObraSocial = new FrmListaObraSocial(rolCodigo);
            this.Hide();
            frmListaObraSocial.Show();
            this.Close();
        }



    }
}
