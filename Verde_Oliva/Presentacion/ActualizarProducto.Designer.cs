﻿namespace Verde_Oliva.Presentacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // VerdeOliva
            // 
            this.VerdeOliva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VerdeOliva.AutoSize = true;
            this.VerdeOliva.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerdeOliva.ForeColor = System.Drawing.Color.White;
            this.VerdeOliva.Location = new System.Drawing.Point(347, 21);
            this.VerdeOliva.Name = "VerdeOliva";
            this.VerdeOliva.Size = new System.Drawing.Size(638, 114);
            this.VerdeOliva.TabIndex = 14;
            this.VerdeOliva.Text = "Verde Oliva";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(399, 120);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(572, 75);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Actualizar Producto";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.grilla);
            this.panel1.Location = new System.Drawing.Point(735, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 505);
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
            this.grilla.Size = new System.Drawing.Size(603, 505);
            this.grilla.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Comida
            // 
            this.Comida.DataPropertyName = "Comida";
            this.Comida.HeaderText = "Comida";
            this.Comida.Name = "Comida";
            this.Comida.ReadOnly = true;
            this.Comida.Width = 300;
            // 
            // CostoUnitario
            // 
            this.CostoUnitario.DataPropertyName = "CostoUnitario";
            this.CostoUnitario.HeaderText = "CostoUnitario";
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.ReadOnly = true;
            this.CostoUnitario.Width = 150;
            // 
            // lblCostoUnitario
            // 
            this.lblCostoUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCostoUnitario.AutoSize = true;
            this.lblCostoUnitario.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoUnitario.Location = new System.Drawing.Point(80, 438);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(228, 37);
            this.lblCostoUnitario.TabIndex = 59;
            this.lblCostoUnitario.Text = "Costo Unitario";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCostoUnitario.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnitario.Location = new System.Drawing.Point(336, 431);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(290, 44);
            this.txtCostoUnitario.TabIndex = 4;
            this.txtCostoUnitario.Text = " ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(80, 287);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(117, 37);
            this.lblCantidad.TabIndex = 58;
            this.lblCantidad.Text = "Codigo";
            // 
            // txtComida
            // 
            this.txtComida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComida.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComida.Location = new System.Drawing.Point(336, 357);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(368, 41);
            this.txtComida.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(336, 280);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(171, 44);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.ForeColor = System.Drawing.Color.Black;
            this.lblComida.Location = new System.Drawing.Point(80, 357);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(127, 37);
            this.lblComida.TabIndex = 54;
            this.lblComida.Text = "Comida";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(388, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 100);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(529, 273);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 56);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCostoUnitario);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VerdeOliva);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActualizarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarProducto";
            this.Load += new System.EventHandler(this.ActualizarProducto_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
    }
}