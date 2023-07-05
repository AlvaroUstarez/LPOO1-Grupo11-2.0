namespace Vistas
{
    partial class FrmAgregarDetalle
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
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoriaProd = new System.Windows.Forms.TextBox();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Location = new System.Drawing.Point(151, 140);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(86, 20);
            this.txtCantidadProd.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cantidad";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(151, 113);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(86, 20);
            this.txtPrecioProd.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio";
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Location = new System.Drawing.Point(151, 87);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(86, 20);
            this.txtDescripcionProd.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descripción";
            // 
            // txtCategoriaProd
            // 
            this.txtCategoriaProd.Location = new System.Drawing.Point(151, 60);
            this.txtCategoriaProd.Name = "txtCategoriaProd";
            this.txtCategoriaProd.Size = new System.Drawing.Size(86, 20);
            this.txtCategoriaProd.TabIndex = 15;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Location = new System.Drawing.Point(82, 201);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(138, 23);
            this.btnAgregarProd.TabIndex = 13;
            this.btnAgregarProd.Text = "Agrear Producto";
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Categoría";
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Location = new System.Drawing.Point(151, 33);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(86, 20);
            this.txtCodigoProd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Código Producto";
            // 
            // FrmAgregarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 250);
            this.Controls.Add(this.txtCantidadProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescripcionProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCategoriaProd);
            this.Controls.Add(this.btnAgregarProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.label3);
            this.Name = "FrmAgregarDetalle";
            this.Text = "FrmAgregarDetalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcionProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoriaProd;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.Label label3;

    }
}