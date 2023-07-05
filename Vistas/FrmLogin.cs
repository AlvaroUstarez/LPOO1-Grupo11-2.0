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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Estilo.aplicar(this);
            Estilo.titulo(lblBienvenida);
        }

        private void btnAceptarLogin_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            Usuario usuario = new Usuario();
            Usuario oAdministrador = new Usuario("admin", "admin");
            oAdministrador.Rol_Codigo = 1;
            Usuario oOperador = new Usuario("Operador", "operador");
            oOperador.Rol_Codigo = 2;
            Usuario oAuditor = new Usuario("Auditor", "auditor");
            oAuditor.Rol_Codigo = 3;

            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(oAdministrador);
            usuarios.Add(oOperador);
            usuarios.Add(oAuditor);


            foreach (Usuario usuAux in usuarios)
            {
                if (usuAux.Usu_NombreUsuario == txtUsuario.Text & usuAux.Usu_Contraseña == txtPass.Text)
                {
                    usuario = usuAux;
                    existe = true;
                }
            }
            if (!existe)
            {
                usuario = TrabajarUsuario.login(txtUsuario.Text, txtPass.Text);
                existe = usuario != null;
            }
            if (existe)
            {
                MessageBox.Show("Bienvenido");
                this.Hide();
                FrmPrincipal fPrincipal = new FrmPrincipal(usuario.Rol_Codigo);
                fPrincipal.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("No ingresó correctamente el usuario o contraseña");
            }
        }

        /*private void btnAceptarLogin_MouseHover(object sender, EventArgs e)
        {
            btnAceptarLogin.BackColor = Color.LightGreen;
            btnAceptarLogin.Size = new Size(140, 35);
        }

        private void btnAceptarLogin_MouseLeave(object sender, EventArgs e)
        {
            btnAceptarLogin.BackColor = Color.Empty;
            btnAceptarLogin.Size = new Size(135, 30);
        }*/


    }
}
