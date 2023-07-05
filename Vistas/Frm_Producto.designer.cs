namespace Vistas
{
    partial class Frm_Producto
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCategoriaProd = new System.Windows.Forms.TextBox();
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptarAltaProd = new System.Windows.Forms.Button();
            this.lblMensajePrincipalAltaProd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(27, 111);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(27, 182);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtCategoriaProd
            // 
            this.txtCategoriaProd.Location = new System.Drawing.Point(122, 111);
            this.txtCategoriaProd.Name = "txtCategoriaProd";
            this.txtCategoriaProd.Size = new System.Drawing.Size(124, 20);
            this.txtCategoriaProd.TabIndex = 2;
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Location = new System.Drawing.Point(122, 182);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(124, 20);
            this.txtDescripcionProd.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(281, 111);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(379, 111);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProd.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(284, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptarAltaProd
            // 
            this.btnAceptarAltaProd.Location = new System.Drawing.Point(389, 179);
            this.btnAceptarAltaProd.Name = "btnAceptarAltaProd";
            this.btnAceptarAltaProd.Size = new System.Drawing.Size(90, 30);
            this.btnAceptarAltaProd.TabIndex = 7;
            this.btnAceptarAltaProd.Text = "Aceptar";
            this.btnAceptarAltaProd.UseVisualStyleBackColor = true;
            this.btnAceptarAltaProd.Click += new System.EventHandler(this.btnAceptarAltaProd_Click);
            // 
            // lblMensajePrincipalAltaProd
            // 
            this.lblMensajePrincipalAltaProd.AutoSize = true;
            this.lblMensajePrincipalAltaProd.Location = new System.Drawing.Point(86, 29);
            this.lblMensajePrincipalAltaProd.Name = "lblMensajePrincipalAltaProd";
            this.lblMensajePrincipalAltaProd.Size = new System.Drawing.Size(143, 13);
            this.lblMensajePrincipalAltaProd.TabIndex = 8;
            this.lblMensajePrincipalAltaProd.Text = "Agregue un Nuevo Producto";
            // 
            // Frm_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 283);
            this.Controls.Add(this.lblMensajePrincipalAltaProd);
            this.Controls.Add(this.btnAceptarAltaProd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescripcionProd);
            this.Controls.Add(this.txtCategoriaProd);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCategoria);
            this.Name = "Frm_Producto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.Frm_Producto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCategoriaProd;
        private System.Windows.Forms.TextBox txtDescripcionProd;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptarAltaProd;
        private System.Windows.Forms.Label lblMensajePrincipalAltaProd;
    }
}