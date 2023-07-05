namespace Vistas
{
    partial class FrmListaVenta
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwListaVenta = new System.Windows.Forms.DataGridView();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbListaClientes = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(245, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 40);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista Ventas";
            // 
            // dgwListaVenta
            // 
            this.dgwListaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListaVenta.Location = new System.Drawing.Point(28, 147);
            this.dgwListaVenta.Name = "dgwListaVenta";
            this.dgwListaVenta.Size = new System.Drawing.Size(554, 228);
            this.dgwListaVenta.TabIndex = 7;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Location = new System.Drawing.Point(485, 67);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarVenta.TabIndex = 6;
            this.btnBuscarVenta.Text = "BUSCAR";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar venta por cliente";
            // 
            // cmbListaClientes
            // 
            this.cmbListaClientes.FormattingEnabled = true;
            this.cmbListaClientes.Location = new System.Drawing.Point(28, 69);
            this.cmbListaClientes.Name = "cmbListaClientes";
            this.cmbListaClientes.Size = new System.Drawing.Size(434, 21);
            this.cmbListaClientes.TabIndex = 11;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(28, 109);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(245, 108);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(217, 20);
            this.dtpFechaFin.TabIndex = 13;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.Location = new System.Drawing.Point(485, 108);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarFecha.TabIndex = 14;
            this.btnBuscarFecha.Text = "BUSCAR";
            this.btnBuscarFecha.UseVisualStyleBackColor = true;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // FrmListaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 448);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cmbListaClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwListaVenta);
            this.Controls.Add(this.btnBuscarVenta);
            this.Name = "FrmListaVenta";
            this.Text = "ListarVenta";
            this.Load += new System.EventHandler(this.FrmListaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwListaVenta;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbListaClientes;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnBuscarFecha;
    }
}