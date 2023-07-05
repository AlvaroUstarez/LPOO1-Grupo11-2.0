namespace Vistas
{
    partial class ListaCliente
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
            this.btnClienteSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwCliente = new System.Windows.Forms.DataGridView();
            this.btnClienteBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCuitOS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnOrdenarApellido = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClienteSalir
            // 
            this.btnClienteSalir.Location = new System.Drawing.Point(12, 344);
            this.btnClienteSalir.Name = "btnClienteSalir";
            this.btnClienteSalir.Size = new System.Drawing.Size(99, 40);
            this.btnClienteSalir.TabIndex = 9;
            this.btnClienteSalir.Text = "VOLVER";
            this.btnClienteSalir.UseVisualStyleBackColor = true;
            this.btnClienteSalir.Click += new System.EventHandler(this.btnClienteSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "INGRESE DNI DEL CLIENTE";
            // 
            // dgwCliente
            // 
            this.dgwCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCliente.Location = new System.Drawing.Point(12, 51);
            this.dgwCliente.Name = "dgwCliente";
            this.dgwCliente.Size = new System.Drawing.Size(496, 287);
            this.dgwCliente.TabIndex = 7;
            this.dgwCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCliente_CellContentClick);
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Location = new System.Drawing.Point(286, 23);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Size = new System.Drawing.Size(97, 23);
            this.btnClienteBuscar.TabIndex = 6;
            this.btnClienteBuscar.Text = "BUSCAR";
            this.btnClienteBuscar.UseVisualStyleBackColor = true;
            this.btnClienteBuscar.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(12, 25);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(268, 20);
            this.txtBuscarCliente.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCuitOS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDireCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellidoCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDniCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(529, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 287);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.HideSelection = false;
            this.txtIdCliente.Location = new System.Drawing.Point(98, 239);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(164, 20);
            this.txtIdCliente.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "ID";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(98, 205);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(164, 20);
            this.txtCarnet.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "N° Carnet";
            // 
            // txtCuitOS
            // 
            this.txtCuitOS.Location = new System.Drawing.Point(98, 168);
            this.txtCuitOS.Name = "txtCuitOS";
            this.txtCuitOS.Size = new System.Drawing.Size(164, 20);
            this.txtCuitOS.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Obra Social";
            // 
            // txtDireCliente
            // 
            this.txtDireCliente.Location = new System.Drawing.Point(98, 130);
            this.txtDireCliente.Name = "txtDireCliente";
            this.txtDireCliente.Size = new System.Drawing.Size(164, 20);
            this.txtDireCliente.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Direccion";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(98, 94);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(164, 20);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(98, 58);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(164, 20);
            this.txtApellidoCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(98, 22);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(164, 20);
            this.txtDniCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(716, 345);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(103, 39);
            this.btnModificarCliente.TabIndex = 11;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnOrdenarApellido
            // 
            this.btnOrdenarApellido.Location = new System.Drawing.Point(389, 23);
            this.btnOrdenarApellido.Name = "btnOrdenarApellido";
            this.btnOrdenarApellido.Size = new System.Drawing.Size(119, 23);
            this.btnOrdenarApellido.TabIndex = 12;
            this.btnOrdenarApellido.Text = "Ordenar por Apellido";
            this.btnOrdenarApellido.UseVisualStyleBackColor = true;
            this.btnOrdenarApellido.Click += new System.EventHandler(this.btnOrdenarApellido_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(529, 345);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(103, 39);
            this.btnEliminarCliente.TabIndex = 13;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 395);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnOrdenarApellido);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClienteSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwCliente);
            this.Controls.Add(this.btnClienteBuscar);
            this.Controls.Add(this.txtBuscarCliente);
            this.Name = "ListaCliente";
            this.Text = "ListaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClienteSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwCliente;
        private System.Windows.Forms.Button btnClienteBuscar;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuitOS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnOrdenarApellido;
        private System.Windows.Forms.Button btnEliminarCliente;
    }
}