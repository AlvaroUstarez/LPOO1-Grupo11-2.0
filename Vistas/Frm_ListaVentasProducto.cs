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
    public partial class Frm_ListaVentasProducto : Form
    {

        private int rolCodigo;

        public Frm_ListaVentasProducto(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
            Estilo.titulo(label1);
            load_usuers();
        }

        private void load_usuers()
        {
            DataTable dt = TrabajarCliente.list_clientes_ventas();

            DataRow dr = dt.NewRow();

            dr["dni_apellido"] = "Seleccionar un cliente";
            dr["id"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cmbListaClientesProd.DataSource = dt;
            cmbListaClientesProd.ValueMember = "id";
            cmbListaClientesProd.DisplayMember = "dni_apellido";
            cmbListaClientesProd.SelectedIndex = 0;

        }

        private void btnBuscarVentaProducto_Click(object sender, EventArgs e)
        {
            int idcliente = int.Parse(cmbListaClientesProd.SelectedValue.ToString());
            dgwListaVentaProducto.DataSource = TrabajarVenta.buscar_venta_x_cliente_producto(idcliente);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            this.Hide();
            fPrincipal.Show();
        }

        private void btnBuscarFechaPro_Click(object sender, EventArgs e)
        {
            dgwListaVentaProducto.DataSource = TrabajarVenta.buscarVentaFechaProducto(dtpFechaInicioPro.Value, dtpFechaFinPro.Value);
        }

    }
}
