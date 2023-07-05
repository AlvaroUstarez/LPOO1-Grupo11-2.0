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
    public partial class FrmAgregarDetalle : Form
    {
        public string codigo { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }
        public string precio { get; set; }

        public FrmAgregarDetalle()
        {
            //txtCodigoProd.Text = codigo;
            //txtCategoriaProd.Text = categoria;
            //txtDescripcionProd.Text = descripcion;
            //txtPrecioProd.Text = precio;
            
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (txtPrecioProd.Text != "")
            {
                precio = txtPrecioProd.Text;
            }
            else
            {
                MessageBox.Show("Ingresar Catergoría");
            }

            this.Close();


        }
    }
}
