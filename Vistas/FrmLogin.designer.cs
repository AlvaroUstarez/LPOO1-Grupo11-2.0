namespace Vistas
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnAceptarLogin = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(88, 170);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(70, 210);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña";
            // 
            // btnAceptarLogin
            // 
            this.btnAceptarLogin.Location = new System.Drawing.Point(119, 251);
            this.btnAceptarLogin.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.btnAceptarLogin.Name = "btnAceptarLogin";
            this.btnAceptarLogin.Size = new System.Drawing.Size(133, 30);
            this.btnAceptarLogin.TabIndex = 2;
            this.btnAceptarLogin.Text = "Aceptar";
            this.btnAceptarLogin.Click += new System.EventHandler(this.btnAceptarLogin_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(10, 9);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(127, 13);
            this.lblBienvenida.TabIndex = 5;
            this.lblBienvenida.Text = "Bienvenido - Inicie sesión";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(136, 167);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(161, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(136, 207);
            this.txtPass.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = 'x';
            this.txtPass.Size = new System.Drawing.Size(161, 20);
            this.txtPass.TabIndex = 7;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnAceptarLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAceptarLogin;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}