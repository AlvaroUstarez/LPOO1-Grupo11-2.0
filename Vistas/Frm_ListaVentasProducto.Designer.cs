namespace Vistas
{
    partial class Frm_ListaVentasProducto
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
            this.btnBuscarFechaPro = new System.Windows.Forms.Button();
            this.dtpFechaFinPro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicioPro = new System.Windows.Forms.DateTimePicker();
            this.cmbListaClientesProd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwListaVentaProducto = new System.Windows.Forms.DataGridView();
            this.btnBuscarVentaProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaVentaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarFechaPro
            // 
            this.btnBuscarFechaPro.Location = new System.Drawing.Point(476, 131);
            this.btnBuscarFechaPro.Name = "btnBuscarFechaPro";
            this.btnBuscarFechaPro.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarFechaPro.TabIndex = 23;
            this.btnBuscarFechaPro.Text = "BUSCAR";
            this.btnBuscarFechaPro.UseVisualStyleBackColor = true;
            this.btnBuscarFechaPro.Click += new System.EventHandler(this.btnBuscarFechaPro_Click);
            // 
            // dtpFechaFinPro
            // 
            this.dtpFechaFinPro.Location = new System.Drawing.Point(236, 131);
            this.dtpFechaFinPro.Name = "dtpFechaFinPro";
            this.dtpFechaFinPro.Size = new System.Drawing.Size(217, 20);
            this.dtpFechaFinPro.TabIndex = 22;
            // 
            // dtpFechaInicioPro
            // 
            this.dtpFechaInicioPro.Location = new System.Drawing.Point(19, 132);
            this.dtpFechaInicioPro.Name = "dtpFechaInicioPro";
            this.dtpFechaInicioPro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicioPro.TabIndex = 21;
            // 
            // cmbListaClientesProd
            // 
            this.cmbListaClientesProd.FormattingEnabled = true;
            this.cmbListaClientesProd.Location = new System.Drawing.Point(19, 92);
            this.cmbListaClientesProd.Name = "cmbListaClientesProd";
            this.cmbListaClientesProd.Size = new System.Drawing.Size(434, 21);
            this.cmbListaClientesProd.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Buscar venta por Producto";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(236, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 40);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lista Ventas";
            // 
            // dgwListaVentaProducto
            // 
            this.dgwListaVentaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListaVentaProducto.Location = new System.Drawing.Point(19, 170);
            this.dgwListaVentaProducto.Name = "dgwListaVentaProducto";
            this.dgwListaVentaProducto.Size = new System.Drawing.Size(554, 228);
            this.dgwListaVentaProducto.TabIndex = 16;
            // 
            // btnBuscarVentaProducto
            // 
            this.btnBuscarVentaProducto.Location = new System.Drawing.Point(476, 90);
            this.btnBuscarVentaProducto.Name = "btnBuscarVentaProducto";
            this.btnBuscarVentaProducto.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarVentaProducto.TabIndex = 15;
            this.btnBuscarVentaProducto.Text = "BUSCAR";
            this.btnBuscarVentaProducto.UseVisualStyleBackColor = true;
            this.btnBuscarVentaProducto.Click += new System.EventHandler(this.btnBuscarVentaProducto_Click);
            // 
            // Frm_ListaVentasProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 484);
            this.Controls.Add(this.btnBuscarFechaPro);
            this.Controls.Add(this.dtpFechaFinPro);
            this.Controls.Add(this.dtpFechaInicioPro);
            this.Controls.Add(this.cmbListaClientesProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwListaVentaProducto);
            this.Controls.Add(this.btnBuscarVentaProducto);
            this.Name = "Frm_ListaVentasProducto";
            this.Text = "Frm_ListaVentasProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaVentaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarFechaPro;
        private System.Windows.Forms.DateTimePicker dtpFechaFinPro;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioPro;
        private System.Windows.Forms.ComboBox cmbListaClientesProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwListaVentaProducto;
        private System.Windows.Forms.Button btnBuscarVentaProducto;
    }
}