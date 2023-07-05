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
    public partial class Frm_User : Form
    {

        private int rolCodigo;

        public Frm_User(int rolCodigo)
        {
            this.rolCodigo = rolCodigo;
            InitializeComponent();
            Estilo.aplicar(this);
        }

        private void Frm_User_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();
            oUser.Rol_Codigo = (int)cmbRol.SelectedValue;
            oUser.Usu_NombreUsuario = txtUsuario.Text;
            oUser.Usu_Apellido = txtApellido.Text;
            oUser.Usu_Nombre = txtNombre.Text;
            oUser.Usu_Email = txtEmail.Text;
            oUser.Usu_Contraseña = txtContraseña.Text;

            TrabajarUsuario.insert_usuario(oUser);

            FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            this.Hide();
            fPrincipal.Show();
        }

        private void load_combo_roles()
        {
            cmbRol.DataSource = TrabajarUsuario.list_roles_sp();         
            cmbRol.DisplayMember = "rol_Descripcion";
            cmbRol.ValueMember = "rol_Codigo";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtSearchUser.Text != "")
            {
                dgwUsuarios.DataSource = TrabajarUsuario.search_usuarios(txtSearchUser.Text);
            }
            else
            {
                load_usuarios();
            }
        }

        private void load_usuarios()
        {
            dgwUsuarios.DataSource = TrabajarUsuario.list_usuarios_sp();
        }
        
        private void dgwUsuarios_CurrentCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dgwUsuarios.CurrentRow != null)
                {
                    //cmbRol.SelectedValue = dgwUsuarios.CurrentRow.Cells["rol"].Value.ToString();

                    txtApellido.Text = dgwUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                    txtNombre.Text = dgwUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtEmail.Text = dgwUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                    txtUsuario.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                    txtContraseña.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                }
            }
        }

        private void btnVolverFRMUser_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal(rolCodigo);
            this.Hide();
            fPrincipal.Show();
        }

        private void dgwUsuarios_SelectionChanged(object sender, EventArgs e)
        {

        }








    }
}
