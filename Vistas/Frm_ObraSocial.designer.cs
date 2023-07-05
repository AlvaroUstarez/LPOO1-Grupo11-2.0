namespace Vistas
{
    partial class Frm_ObraSocial
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
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTituloAltaObraSocial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(59, 112);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "CUIT";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(59, 179);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(340, 112);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(340, 179);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(204, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(344, 253);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 30);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(169, 106);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(135, 20);
            this.txtCuit.TabIndex = 6;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(169, 173);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(135, 20);
            this.txtRazonSocial.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(453, 106);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(135, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(453, 173);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // lblTituloAltaObraSocial
            // 
            this.lblTituloAltaObraSocial.AutoSize = true;
            this.lblTituloAltaObraSocial.Location = new System.Drawing.Point(169, 37);
            this.lblTituloAltaObraSocial.Name = "lblTituloAltaObraSocial";
            this.lblTituloAltaObraSocial.Size = new System.Drawing.Size(107, 13);
            this.lblTituloAltaObraSocial.TabIndex = 10;
            this.lblTituloAltaObraSocial.Text = "Registrar Obra Social";
            // 
            // Frm_ObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 343);
            this.Controls.Add(this.lblTituloAltaObraSocial);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblCuit);
            this.Name = "Frm_ObraSocial";
            this.Text = "Registrar Obra Social";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTituloAltaObraSocial;
    }
}