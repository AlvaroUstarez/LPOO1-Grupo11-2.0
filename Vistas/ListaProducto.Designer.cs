namespace Vistas
{
    partial class ListaProducto
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
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.dgwProd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnPDef = new System.Windows.Forms.RadioButton();
            this.rbtnCategoria = new System.Windows.Forms.RadioButton();
            this.rbtnDes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Location = new System.Drawing.Point(60, 44);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(189, 20);
            this.txtBuscarProd.TabIndex = 0;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(259, 42);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarP.TabIndex = 1;
            this.btnBuscarP.Text = "BUSCAR";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // dgwProd
            // 
            this.dgwProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProd.Location = new System.Drawing.Point(60, 84);
            this.dgwProd.Name = "dgwProd";
            this.dgwProd.Size = new System.Drawing.Size(554, 267);
            this.dgwProd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por código";
            // 
            // btnSalirP
            // 
            this.btnSalirP.Location = new System.Drawing.Point(257, 387);
            this.btnSalirP.Name = "btnSalirP";
            this.btnSalirP.Size = new System.Drawing.Size(99, 40);
            this.btnSalirP.TabIndex = 4;
            this.btnSalirP.Text = "SALIR";
            this.btnSalirP.UseVisualStyleBackColor = true;
            this.btnSalirP.Click += new System.EventHandler(this.btnSalirP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnPDef);
            this.groupBox1.Controls.Add(this.rbtnCategoria);
            this.groupBox1.Controls.Add(this.rbtnDes);
            this.groupBox1.Location = new System.Drawing.Point(362, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 44);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar por:";
            // 
            // rbtnPDef
            // 
            this.rbtnPDef.AutoSize = true;
            this.rbtnPDef.Location = new System.Drawing.Point(213, 19);
            this.rbtnPDef.Name = "rbtnPDef";
            this.rbtnPDef.Size = new System.Drawing.Size(82, 17);
            this.rbtnPDef.TabIndex = 2;
            this.rbtnPDef.TabStop = true;
            this.rbtnPDef.Text = "Por Defecto";
            this.rbtnPDef.UseVisualStyleBackColor = true;
            this.rbtnPDef.CheckedChanged += new System.EventHandler(this.rbtnPDef_CheckedChanged);
            // 
            // rbtnCategoria
            // 
            this.rbtnCategoria.AutoSize = true;
            this.rbtnCategoria.Location = new System.Drawing.Point(123, 19);
            this.rbtnCategoria.Name = "rbtnCategoria";
            this.rbtnCategoria.Size = new System.Drawing.Size(70, 17);
            this.rbtnCategoria.TabIndex = 1;
            this.rbtnCategoria.TabStop = true;
            this.rbtnCategoria.Text = "Categoria";
            this.rbtnCategoria.UseVisualStyleBackColor = true;
            this.rbtnCategoria.CheckedChanged += new System.EventHandler(this.rbtnCategoria_CheckedChanged);
            // 
            // rbtnDes
            // 
            this.rbtnDes.AutoSize = true;
            this.rbtnDes.Location = new System.Drawing.Point(25, 19);
            this.rbtnDes.Name = "rbtnDes";
            this.rbtnDes.Size = new System.Drawing.Size(81, 17);
            this.rbtnDes.TabIndex = 0;
            this.rbtnDes.TabStop = true;
            this.rbtnDes.Text = "Descripcion";
            this.rbtnDes.UseVisualStyleBackColor = true;
            this.rbtnDes.CheckedChanged += new System.EventHandler(this.rbtnDes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LISTAR PRODUCTOS";
            // 
            // ListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalirP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwProd);
            this.Controls.Add(this.btnBuscarP);
            this.Controls.Add(this.txtBuscarProd);
            this.Name = "ListaProducto";
            this.Text = "ListaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgwProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.DataGridView dgwProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCategoria;
        private System.Windows.Forms.RadioButton rbtnDes;
        private System.Windows.Forms.RadioButton rbtnPDef;
        private System.Windows.Forms.Label label2;
    }
}