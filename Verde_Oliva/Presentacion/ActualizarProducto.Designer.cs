namespace Verde_Oliva.Presentacion
{
    partial class ActualizarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarProducto));
            this.VerdeOliva = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCostoUnitario = new System.Windows.Forms.Label();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.btnRegistrarUnitario = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarGrupo = new System.Windows.Forms.Button();
            this.txtCodigoGrupo = new System.Windows.Forms.TextBox();
            this.txtCostoGrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerdeOliva
            // 
            this.VerdeOliva.AutoSize = true;
            this.VerdeOliva.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerdeOliva.ForeColor = System.Drawing.Color.White;
            this.VerdeOliva.Location = new System.Drawing.Point(822, 20);
            this.VerdeOliva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VerdeOliva.Name = "VerdeOliva";
            this.VerdeOliva.Size = new System.Drawing.Size(798, 142);
            this.VerdeOliva.TabIndex = 14;
            this.VerdeOliva.Text = "Verde Oliva";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(873, 151);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(714, 94);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Actualizar Producto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grilla);
            this.panel1.Location = new System.Drawing.Point(1351, 269);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 781);
            this.panel1.TabIndex = 60;
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla.BackgroundColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grilla.ColumnHeadersHeight = 40;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Comida,
            this.CostoUnitario});
            this.grilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grilla.Location = new System.Drawing.Point(0, 0);
            this.grilla.Margin = new System.Windows.Forms.Padding(4);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grilla.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grilla.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grilla.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grilla.Size = new System.Drawing.Size(883, 781);
            this.grilla.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Comida
            // 
            this.Comida.DataPropertyName = "Comida";
            this.Comida.HeaderText = "Comida";
            this.Comida.MinimumWidth = 6;
            this.Comida.Name = "Comida";
            this.Comida.ReadOnly = true;
            this.Comida.Width = 300;
            // 
            // CostoUnitario
            // 
            this.CostoUnitario.DataPropertyName = "CostoUnitario";
            this.CostoUnitario.HeaderText = "CostoUnitario";
            this.CostoUnitario.MinimumWidth = 6;
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.ReadOnly = true;
            this.CostoUnitario.Width = 150;
            // 
            // lblCostoUnitario
            // 
            this.lblCostoUnitario.AutoSize = true;
            this.lblCostoUnitario.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoUnitario.Location = new System.Drawing.Point(36, 294);
            this.lblCostoUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(284, 47);
            this.lblCostoUnitario.TabIndex = 59;
            this.lblCostoUnitario.Text = "Costo Unitario";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnitario.Location = new System.Drawing.Point(369, 288);
            this.txtCostoUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(385, 53);
            this.txtCostoUnitario.TabIndex = 4;
            this.txtCostoUnitario.Text = " ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(36, 76);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(147, 47);
            this.lblCantidad.TabIndex = 58;
            this.lblCantidad.Text = "Codigo";
            // 
            // txtComida
            // 
            this.txtComida.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComida.Location = new System.Drawing.Point(369, 182);
            this.txtComida.Margin = new System.Windows.Forms.Padding(4);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(489, 49);
            this.txtComida.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(369, 75);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(227, 53);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.ForeColor = System.Drawing.Color.Black;
            this.lblComida.Location = new System.Drawing.Point(36, 180);
            this.lblComida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(160, 47);
            this.lblComida.TabIndex = 54;
            this.lblComida.Text = "Comida";
            // 
            // btnRegistrarUnitario
            // 
            this.btnRegistrarUnitario.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUnitario.Location = new System.Drawing.Point(848, 258);
            this.btnRegistrarUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarUnitario.Name = "btnRegistrarUnitario";
            this.btnRegistrarUnitario.Size = new System.Drawing.Size(317, 123);
            this.btnRegistrarUnitario.TabIndex = 5;
            this.btnRegistrarUnitario.Text = "Registrar";
            this.btnRegistrarUnitario.UseVisualStyleBackColor = true;
            this.btnRegistrarUnitario.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(715, 66);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(185, 69);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.btnRegistrarUnitario);
            this.groupBox1.Controls.Add(this.lblComida);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtComida);
            this.groupBox1.Controls.Add(this.txtCostoUnitario);
            this.groupBox1.Controls.Add(this.lblCostoUnitario);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(113, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1195, 414);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnRegistrarGrupo);
            this.groupBox2.Controls.Add(this.txtCodigoGrupo);
            this.groupBox2.Controls.Add(this.txtCostoGrupo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(113, 729);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1195, 321);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 47);
            this.label1.TabIndex = 58;
            this.label1.Text = "Cod. Comida";
            // 
            // btnRegistrarGrupo
            // 
            this.btnRegistrarGrupo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarGrupo.Location = new System.Drawing.Point(848, 161);
            this.btnRegistrarGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarGrupo.Name = "btnRegistrarGrupo";
            this.btnRegistrarGrupo.Size = new System.Drawing.Size(317, 123);
            this.btnRegistrarGrupo.TabIndex = 5;
            this.btnRegistrarGrupo.Text = "Registrar";
            this.btnRegistrarGrupo.UseVisualStyleBackColor = true;
            this.btnRegistrarGrupo.Click += new System.EventHandler(this.btnRegistrarGrupo_Click);
            // 
            // txtCodigoGrupo
            // 
            this.txtCodigoGrupo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoGrupo.Location = new System.Drawing.Point(369, 41);
            this.txtCodigoGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoGrupo.Name = "txtCodigoGrupo";
            this.txtCodigoGrupo.Size = new System.Drawing.Size(227, 53);
            this.txtCodigoGrupo.TabIndex = 1;
            // 
            // txtCostoGrupo
            // 
            this.txtCostoGrupo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoGrupo.Location = new System.Drawing.Point(369, 161);
            this.txtCostoGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostoGrupo.Name = "txtCostoGrupo";
            this.txtCostoGrupo.Size = new System.Drawing.Size(385, 53);
            this.txtCostoGrupo.TabIndex = 4;
            this.txtCostoGrupo.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 47);
            this.label3.TabIndex = 59;
            this.label3.Text = "Costo";
            // 
            // ActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(2271, 1067);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VerdeOliva);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "ActualizarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ActualizarProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ActualizarProducto_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VerdeOliva;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnitario;
        private System.Windows.Forms.Label lblCostoUnitario;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Button btnRegistrarUnitario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarGrupo;
        private System.Windows.Forms.TextBox txtCodigoGrupo;
        private System.Windows.Forms.TextBox txtCostoGrupo;
        private System.Windows.Forms.Label label3;
    }
}