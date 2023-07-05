namespace Vistas
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductosExistentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listaDeObrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.obraSocialToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosProductosToolStripMenuItem,
            this.modificarProductosExistentesToolStripMenuItem,
            this.listarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // agregarNuevosProductosToolStripMenuItem
            // 
            this.agregarNuevosProductosToolStripMenuItem.Name = "agregarNuevosProductosToolStripMenuItem";
            this.agregarNuevosProductosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.agregarNuevosProductosToolStripMenuItem.Text = "Agregar Nuevos Productos";
            this.agregarNuevosProductosToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevosProductosToolStripMenuItem_Click);
            // 
            // modificarProductosExistentesToolStripMenuItem
            // 
            this.modificarProductosExistentesToolStripMenuItem.Name = "modificarProductosExistentesToolStripMenuItem";
            this.modificarProductosExistentesToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.modificarProductosExistentesToolStripMenuItem.Text = "Modificar Productos Existentes";
            this.modificarProductosExistentesToolStripMenuItem.Click += new System.EventHandler(this.modificarProductosExistentesToolStripMenuItem_Click);
            // 
            // listarProductoToolStripMenuItem
            // 
            this.listarProductoToolStripMenuItem.Name = "listarProductoToolStripMenuItem";
            this.listarProductoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.listarProductoToolStripMenuItem.Text = "Listar Producto";
            this.listarProductoToolStripMenuItem.Click += new System.EventHandler(this.listarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoClienteToolStripMenuItem,
            this.listaDeClientesToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // ingresarNuevoClienteToolStripMenuItem
            // 
            this.ingresarNuevoClienteToolStripMenuItem.Name = "ingresarNuevoClienteToolStripMenuItem";
            this.ingresarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ingresarNuevoClienteToolStripMenuItem.Text = "Ingresar nuevo cliente";
            this.ingresarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarNuevoClienteToolStripMenuItem_Click);
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            this.listaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listaDeClientesToolStripMenuItem_Click);
            // 
            // obraSocialToolStripMenuItem
            // 
            this.obraSocialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarObraSocialToolStripMenuItem,
            this.listaDeObrasSocialesToolStripMenuItem});
            this.obraSocialToolStripMenuItem.Name = "obraSocialToolStripMenuItem";
            this.obraSocialToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.obraSocialToolStripMenuItem.Text = "Obra Social";
            // 
            // registrarObraSocialToolStripMenuItem
            // 
            this.registrarObraSocialToolStripMenuItem.Name = "registrarObraSocialToolStripMenuItem";
            this.registrarObraSocialToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.registrarObraSocialToolStripMenuItem.Text = "Registrar Obra Social";
            this.registrarObraSocialToolStripMenuItem.Click += new System.EventHandler(this.registrarObraSocialToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVentaToolStripMenuItem,
            this.listarVentasToolStripMenuItem,
            this.ventaProductoToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // agregarVentaToolStripMenuItem
            // 
            this.agregarVentaToolStripMenuItem.Name = "agregarVentaToolStripMenuItem";
            this.agregarVentaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.agregarVentaToolStripMenuItem.Text = "Agregar Venta";
            this.agregarVentaToolStripMenuItem.Click += new System.EventHandler(this.agregarVentaToolStripMenuItem_Click);
            // 
            // listarVentasToolStripMenuItem
            // 
            this.listarVentasToolStripMenuItem.Name = "listarVentasToolStripMenuItem";
            this.listarVentasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listarVentasToolStripMenuItem.Text = "Listar Ventas";
            this.listarVentasToolStripMenuItem.Click += new System.EventHandler(this.listarVentasToolStripMenuItem_Click);
            // 
            // ventaProductoToolStripMenuItem
            // 
            this.ventaProductoToolStripMenuItem.Name = "ventaProductoToolStripMenuItem";
            this.ventaProductoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ventaProductoToolStripMenuItem.Text = "Venta Producto";
            this.ventaProductoToolStripMenuItem.Click += new System.EventHandler(this.ventaProductoToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(562, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listaDeObrasSocialesToolStripMenuItem
            // 
            this.listaDeObrasSocialesToolStripMenuItem.Name = "listaDeObrasSocialesToolStripMenuItem";
            this.listaDeObrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.listaDeObrasSocialesToolStripMenuItem.Text = "Lista de Obras Sociales";
            this.listaDeObrasSocialesToolStripMenuItem.Click += new System.EventHandler(this.listaDeObrasSocialesToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductosExistentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarObraSocialToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeObrasSocialesToolStripMenuItem;
    }
}