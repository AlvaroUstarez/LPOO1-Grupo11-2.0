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
    public partial class Frm_AltaCliente : Form
    {
        private int rolCodigo;

        public Frm_AltaCliente(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
            Estilo.titulo(lblTituloAltaCliente);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            this.Hide();
            fPrincipal.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != "" && txtApellido.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "" && txtCuit.Text != "" && txtNroCarnet.Text != "")
            {
                Cliente oCliente = new Cliente();

                oCliente.Cli_DNI = txtDni.Text;
                oCliente.Cli_Apellido = txtApellido.Text;
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Direccion = txtDireccion.Text;
                oCliente.OS_CUIT = txtCuit.Text;
                oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                MessageBox.Show("DNI: " + oCliente.Cli_DNI + "\n"
                               + "Apellido: " + oCliente.Cli_Apellido + "\n"
                               + "Nombre: " + oCliente.Cli_Nombre + "\n"
                               + "Dirección: " + oCliente.Cli_Direccion + "\n"
                               + "Obra Social: " + oCliente.OS_CUIT + "\n"
                               + "Nro de Carnet: " + oCliente.Cli_NroCarnet + "\n"
                               , "Cliente Ingresado");

                TrabajarCliente.insert_cliente(oCliente);

                FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
                this.Close();
                fPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Complete todos los campos por favor", "Error");
            }

        }
    }
}
