using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;
using Vistas;

namespace Vistas
{
    public partial class FrmVentas : Form
    {

        private int rolCodigo;
        public string Datos { get; set; }

        public FrmVentas(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
            Estilo.titulo(lblBienvenida);
            DateTimePicker fecha = dtpFechaVenta;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            load_venta();
            load_usuers();
            load_product();
            load_clientes();
        }

        private void load_product()
        {
            dgwListProd.DataSource = TrabajarProducto.listar_product();
        }

        private void load_usuers()
        {
            DataTable dt = TrabajarCliente.list_clientes_ventas();

            DataRow dr = dt.NewRow();

            //dr["dni_apellido"] = "Seleccionar un cliente";
            //dr["id"] = 0;
            //dt.Rows.InsertAt(dr, 0);
            //cbmVC.DataSource = dt;
            //cbmVC.ValueMember = "id";
            //cbmVC.DisplayMember = "dni_apellido";
            //cbmVC.SelectedIndex = 0;
        }

        private void load_clientes() 
        {
            dgwClientes.DataSource = TrabajarCliente.list_clientes_sp();
        }

        private void btnSalirV_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            this.Hide();
            fPrincipal.Show();
        }




        /*++++++++++++++++++++++++++++++++++++++++++++++++++++*/

        /*Cargar los datos del producto al formulario Cargar Detalle */
        private void dgwListProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //FrmAgregarDetalle frmAgregarDetalle = new FrmAgregarDetalle();
            //AddOwnedForm(frmAgregarDetalle);
            //frmAgregarDetalle.txtCodigoProd.Text = dgwListProd.CurrentRow.Cells["Codigo"].Value.ToString();
            //txtCategoriaProd.Text = dgwListProd.CurrentRow.Cells["Categoria"].Value.ToString();
            //txtDescripcionProd.Text = dgwListProd.CurrentRow.Cells["Descripcion"].Value.ToString();
            //txtPrecioProd.Text = dgwListProd.CurrentRow.Cells["Precio"].Value.ToString();
            //frmAgregarDetalle.Show();


            //if (dgwListProd.CurrentRow != null)
            //{
            //    txtCodigoProd.Text = dgwListProd.CurrentRow.Cells["Codigo"].Value.ToString();
            //    txtCategoriaProd.Text = dgwListProd.CurrentRow.Cells["Categoria"].Value.ToString();
            //    txtDescripcionProd.Text = dgwListProd.CurrentRow.Cells["Descripcion"].Value.ToString();
            //    txtPrecioProd.Text = dgwListProd.CurrentRow.Cells["Precio"].Value.ToString();
            //}
        }

        //Agregar productos al data grid view
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            VentaDetalle detalle = new VentaDetalle();

            detalle.ProdCodigo = int.Parse(txtCodigoProd.Text);
            detalle.DetallePrecio = float.Parse(txtPrecioProd.Text);
            detalle.DetalleCantidad = float.Parse(txtPrecioProd.Text);
            detalle.DetalleTotal = detalle.DetallePrecio * detalle.DetalleCantidad;


            MessageBox.Show("Código: " + txtCodigoProd.Text + "\n"
                           + "Categoría: " + txtCategoriaProd.Text + "\n"
                           + "Descripción: " + txtDescripcionProd.Text + "\n"
                           + "Precio: " + txtPrecioProd.Text + "\n"
                           + "Cantidad: " + txtCantidadProd.Text + "\n"
                           + "Total: " + detalle.DetalleTotal + "\n"
                           , "Producto Agregado");

            TrabajarVenta.agregar_detalle(detalle);

            dgwDetalleVenta.DataSource = TrabajarVenta.obtenerDetalles();

            dgwDetalleVenta.Columns["ProdCodigo"].HeaderText = "Código";
            dgwDetalleVenta.Columns["DetallePrecio"].HeaderText = "Categoría";
            dgwDetalleVenta.Columns["DetalleCantidad"].HeaderText = "Descripción";
            dgwDetalleVenta.Columns["DetalleTotal"].HeaderText = "Precio";


        }

        //Devuelve el número de venta y lo asigna al txtNroVenta
        private void load_venta()
        {
            int nroVenta = TrabajarVenta.iniciar_venta();
            txtNroVenta.Text = Convert.ToString(nroVenta);
        }

        //Agregar Venta
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //int idcliente = int.Parse(cbmVC.SelectedValue.ToString());
            //Venta venta = new Venta();
            //venta.VentaFecha = dtpFechaVenta.Value;
            //venta.ClienteId = idcliente;
            //TrabajarVenta.guardarVenta(venta);
            //BindingList<VentaDetalle> detalles = TrabajarVenta.obtenerDetalles();

            //foreach (VentaDetalle detalle in detalles)
            //{
            //    detalle.VentaNumero = int.Parse(txtNroVenta.Text);
            //    TrabajarVenta.guardarDetalle(detalle);
            //}

            //TrabajarVenta.agrear_venta_detalle(venta);

            //FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            //this.Hide();
            //fPrincipal.Show();

        }

        /*Evento TextCanged Buscar clientes*/
        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text != "")
            {
                dgwClientes.DataSource = TrabajarCliente.search_clientes(txtBuscarCliente.Text);
            }
            else
            {
                load_clientes();
            }
        }

        //Cargar los datos del cliente desde el dgwClientes
        private void dgwClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string apellido = dgwClientes.CurrentRow.Cells["apellido"].Value.ToString();
            string nombre = dgwClientes.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellidoNombre.Text = apellido + ", " + nombre;
            txtDNI.Text = dgwClientes.CurrentRow.Cells["dni"].Value.ToString();
        }


        /*Evento TextChanged Buscar productos  */
        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text != "")
            {
                dgwListProd.DataSource = TrabajarProducto.buscarProductoDescripcion(txtBuscarProducto.Text);
            }
            else
            {
                load_product();
            }
        }




        /*-------------------------------------------------------------------*/
        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {

            FrmAgregarDetalle frmAgregarDetalle = new FrmAgregarDetalle();

            frmAgregarDetalle.codigo = dgwListProd.CurrentRow.Cells["Codigo"].Value.ToString();
            frmAgregarDetalle.categoria = dgwListProd.CurrentRow.Cells["Categoria"].Value.ToString();
            frmAgregarDetalle.descripcion = dgwListProd.CurrentRow.Cells["Descripcion"].Value.ToString();
            frmAgregarDetalle.precio = dgwListProd.CurrentRow.Cells["Precio"].Value.ToString();

            frmAgregarDetalle.Show();

            //txtCantidadProd.Text = frmAgregarDetalle.precio;

            //MessageBox.Show(txt);

            //int n = dgwDetalleVenta.Rows.Add();

            //dgwDetalleVenta.Rows[n].Cells[0].Value = dgwListProd.CurrentRow.Cells["Codigo"].Value.ToString();
            //dgwDetalleVenta.Rows[n].Cells[0].Value = dgwListProd.CurrentRow.Cells["Categoria"].Value.ToString();
            //dgwDetalleVenta.Rows[n].Cells[0].Value = dgwListProd.CurrentRow.Cells["Descripcion"].Value.ToString();
            //dgwDetalleVenta.Rows[n].Cells[0].Value = dgwListProd.CurrentRow.Cells["Precio"].Value.ToString();
            
            //fixme: 
            //dgwDetalleVenta.Rows[n].Cells[0].Value = txtCantidadProd.Text;
            //dgwDetalleVenta.Rows[n].Cells[0].Value = txtCantidadProd + txtPrecioProd;






            //frmAgregarDetalle.txtCodigoProd.Text = dgwListProd.CurrentRow.Cells["Codigo"].Value.ToString();
            //txtCategoriaProd.Text = dgwListProd.CurrentRow.Cells["Categoria"].Value.ToString();
            //txtDescripcionProd.Text = dgwListProd.CurrentRow.Cells["Descripcion"].Value.ToString();
            //txtPrecioProd.Text = dgwListProd.CurrentRow.Cells["Precio"].Value.ToString();
            //frmAgregarDetalle.Show();
        }

        //Cargar los datos del producto al formulario Cargar Detalle
        //private void dgwClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string apellido = dgwClientes.CurrentRow.Cells["apellido"].Value.ToString();
        //    string nombre = dgwClientes.CurrentRow.Cells["nombre"].Value.ToString();
        //    txtApellidoNombre.Text = apellido + ", " + nombre;
        //    txtDNI.Text = dgwClientes.CurrentRow.Cells["dni"].Value.ToString();
        //}













    }
}
