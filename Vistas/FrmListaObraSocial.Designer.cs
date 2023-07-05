namespace Vistas
{
    partial class FrmListaObraSocial
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvObrasSociales = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxCuit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObrasSociales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 359);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(78, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Obras Sociales";
            // 
            // dgvObrasSociales
            // 
            this.dgvObrasSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObrasSociales.Location = new System.Drawing.Point(13, 67);
            this.dgvObrasSociales.Name = "dgvObrasSociales";
            this.dgvObrasSociales.Size = new System.Drawing.Size(422, 286);
            this.dgvObrasSociales.TabIndex = 2;
            this.dgvObrasSociales.CurrentCellChanged += new System.EventHandler(this.dgvObrasSociales_CurrentCellChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(63, 39);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(290, 20);
            this.txtBoxBuscar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(359, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxRazonSocial);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtBoxDireccion);
            this.groupBox1.Controls.Add(this.txtBoxCuit);
            this.groupBox1.Location = new System.Drawing.Point(450, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 285);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obra Social";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(121, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Razón Social";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(202, 214);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CUIT";
            // 
            // txtBoxRazonSocial
            // 
            this.txtBoxRazonSocial.Location = new System.Drawing.Point(109, 89);
            this.txtBoxRazonSocial.Name = "txtBoxRazonSocial";
            this.txtBoxRazonSocial.Size = new System.Drawing.Size(168, 20);
            this.txtBoxRazonSocial.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(109, 173);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(168, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(109, 131);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(168, 20);
            this.txtBoxDireccion.TabIndex = 1;
            // 
            // txtBoxCuit
            // 
            this.txtBoxCuit.Enabled = false;
            this.txtBoxCuit.Location = new System.Drawing.Point(109, 47);
            this.txtBoxCuit.Name = "txtBoxCuit";
            this.txtBoxCuit.Size = new System.Drawing.Size(168, 20);
            this.txtBoxCuit.TabIndex = 0;
            // 
            // FrmListaObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvObrasSociales);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmListaObraSocial";
            this.Text = "FrmListaObraSocial";
            this.Load += new System.EventHandler(this.FrmListaObraSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObrasSociales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvObrasSociales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxRazonSocial;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxCuit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
    }
}