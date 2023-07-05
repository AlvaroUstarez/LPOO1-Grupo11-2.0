namespace Vistas
{
    partial class FrmVentas
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.dgwListProd = new System.Windows.Forms.DataGridView();
            this.btnSalirV = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.dgwDetalleVenta = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNroVenta = new System.Windows.Forms.TextBox();
            this.dgwClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.Prod_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Det_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Det_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(412, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(91, 13);
            this.lblBienvenida.TabIndex = 6;
            this.lblBienvenida.Text = "Formulario Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(173, 25);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 8;
            // 
            // dgwListProd
            // 
            this.dgwListProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListProd.Location = new System.Drawing.Point(25, 269);
            this.dgwListProd.Name = "dgwListProd";
            this.dgwListProd.Size = new System.Drawing.Size(325, 153);
            this.dgwListProd.TabIndex = 11;
            this.dgwListProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListProd_CellContentClick);
            // 
            // btnSalirV
            // 
            this.btnSalirV.Location = new System.Drawing.Point(358, 437);
            this.btnSalirV.Name = "btnSalirV";
            this.btnSalirV.Size = new System.Drawing.Size(75, 23);
            this.btnSalirV.TabIndex = 12;
            this.btnSalirV.Text = "Cancelar";
            this.btnSalirV.UseVisualStyleBackColor = true;
            this.btnSalirV.Click += new System.EventHandler(this.btnSalirV_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(467, 437);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidadProd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPrecioProd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDescripcionProd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCategoriaProd);
            this.groupBox1.Controls.Add(this.btnAgregarProd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCodigoProd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(608, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 189);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Location = new System.Drawing.Point(91, 129);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(86, 20);
            this.txtCantidadProd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(91, 102);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(86, 20);
            this.txtPrecioProd.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio";
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Location = new System.Drawing.Point(91, 76);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(86, 20);
            this.txtDescripcionProd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripción";
            // 
            // txtCategoriaProd
            // 
            this.txtCategoriaProd.Location = new System.Drawing.Point(91, 49);
            this.txtCategoriaProd.Name = "txtCategoriaProd";
            this.txtCategoriaProd.Size = new System.Drawing.Size(86, 20);
            this.txtCategoriaProd.TabIndex = 4;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Location = new System.Drawing.Point(23, 154);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(138, 23);
            this.btnAgregarProd.TabIndex = 2;
            this.btnAgregarProd.Text = "Agrear Producto";
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoría";
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Location = new System.Drawing.Point(91, 22);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(86, 20);
            this.txtCodigoProd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Buscar Cliente";
            // 
            // dgwDetalleVenta
            // 
            this.dgwDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prod_Codigo,
            this.Prod_Categoria,
            this.Prod_Descripcion,
            this.Prod_Precio,
            this.Det_Cantidad,
            this.Det_Precio});
            this.dgwDetalleVenta.Location = new System.Drawing.Point(358, 101);
            this.dgwDetalleVenta.Name = "dgwDetalleVenta";
            this.dgwDetalleVenta.Size = new System.Drawing.Size(455, 233);
            this.dgwDetalleVenta.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Venta Nro:";
            // 
            // txtNroVenta
            // 
            this.txtNroVenta.Enabled = false;
            this.txtNroVenta.Location = new System.Drawing.Point(22, 25);
            this.txtNroVenta.Name = "txtNroVenta";
            this.txtNroVenta.Size = new System.Drawing.Size(86, 20);
            this.txtNroVenta.TabIndex = 11;
            // 
            // dgwClientes
            // 
            this.dgwClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClientes.Location = new System.Drawing.Point(22, 130);
            this.dgwClientes.Name = "dgwClientes";
            this.dgwClientes.Size = new System.Drawing.Size(328, 84);
            this.dgwClientes.TabIndex = 19;
            this.dgwClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwClientes_CellContentClick);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBuscarCliente.Location = new System.Drawing.Point(25, 101);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(325, 20);
            this.txtBuscarCliente.TabIndex = 11;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Buscar Producto";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBuscarProducto.Location = new System.Drawing.Point(25, 243);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(244, 20);
            this.txtBuscarProducto.TabIndex = 22;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Apellido y Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(451, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "DNI";
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(275, 240);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarProducto.TabIndex = 26;
            this.btnSeleccionarProducto.Text = "Seleccionar";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(696, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Detalle";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Enabled = false;
            this.txtApellidoNombre.Location = new System.Drawing.Point(549, 45);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(279, 20);
            this.txtApellidoNombre.TabIndex = 28;
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(549, 71);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(101, 20);
            this.txtDNI.TabIndex = 29;
            // 
            // Prod_Codigo
            // 
            this.Prod_Codigo.HeaderText = "Código";
            this.Prod_Codigo.Name = "Prod_Codigo";
            // 
            // Prod_Categoria
            // 
            this.Prod_Categoria.HeaderText = "Categoría";
            this.Prod_Categoria.Name = "Prod_Categoria";
            // 
            // Prod_Descripcion
            // 
            this.Prod_Descripcion.HeaderText = "Descripcion";
            this.Prod_Descripcion.Name = "Prod_Descripcion";
            // 
            // Prod_Precio
            // 
            this.Prod_Precio.HeaderText = "Precio";
            this.Prod_Precio.Name = "Prod_Precio";
            // 
            // Det_Cantidad
            // 
            this.Det_Cantidad.HeaderText = "Cantidad";
            this.Det_Cantidad.Name = "Det_Cantidad";
            // 
            // Det_Precio
            // 
            this.Det_Precio.HeaderText = "Subtotal";
            this.Det_Precio.Name = "Det_Precio";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 470);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellidoNombre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSeleccionarProducto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwClientes);
            this.Controls.Add(this.txtNroVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgwDetalleVenta);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalirV);
            this.Controls.Add(this.dgwListProd);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.DataGridView dgwListProd;
        private System.Windows.Forms.Button btnSalirV;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcionProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoriaProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgwDetalleVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNroVenta;
        private System.Windows.Forms.DataGridView dgwClientes;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Det_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Det_Precio;
    }
}