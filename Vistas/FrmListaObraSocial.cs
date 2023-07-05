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
    public partial class FrmListaObraSocial : Form
    {

        private int rolCodigo;

        public FrmListaObraSocial(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
            Estilo.titulo(lblTitulo);
        }

        private void FrmListaObraSocial_Load(object sender, EventArgs e)
        {
            loadObrasSociales();
        }

        private void loadObrasSociales()
        {
            dgvObrasSociales.DataSource = TrabajarObraSocial.listar_obrasocial();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            this.Hide();
            fPrincipal.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBoxBuscar.Text != "")
            {
                dgvObrasSociales.DataSource = TrabajarObraSocial.buscar_obrasocial(txtBoxBuscar.Text);
            }
            else
            {
                loadObrasSociales();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ObraSocial obraSocial = new ObraSocial();
            string cuit = txtBoxCuit.Text;
            obraSocial.Os_RazonSocial = txtBoxRazonSocial.Text;
            obraSocial.Os_Direccion = txtBoxDireccion.Text;
            obraSocial.Os_Telefono = txtTelefono.Text;

            TrabajarObraSocial.modificar_obrasocial_sp(cuit, obraSocial);

            loadObrasSociales();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtBoxCuit.Text != "")
            {
                if (MessageBox.Show("¿Seguro(a) que desea eliminar esta Obra Social?",
                     "Confirmación",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TrabajarObraSocial.borrar_obrasocial(txtBoxCuit.Text);
                    loadObrasSociales();
                }
            }
        }

        private void dgvObrasSociales_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvObrasSociales.CurrentRow != null)
            {
                txtBoxCuit.Text = dgvObrasSociales.CurrentRow.Cells["CUIT"].Value.ToString();
                txtBoxRazonSocial.Text = dgvObrasSociales.CurrentRow.Cells["RazonSocial"].Value.ToString();
                txtBoxDireccion.Text = dgvObrasSociales.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dgvObrasSociales.CurrentRow.Cells["Telefono"].Value.ToString();
            }
        }
    }
}
