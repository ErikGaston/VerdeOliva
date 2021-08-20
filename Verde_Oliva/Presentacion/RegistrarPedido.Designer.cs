namespace Verde_Oliva
{
    partial class Pedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verdeOlivaDataSet = new Verde_Oliva.VerdeOlivaDataSet();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.pedidoTableAdapter = new Verde_Oliva.VerdeOlivaDataSetTableAdapters.PedidoTableAdapter();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtNroTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaga = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.radioBusca = new System.Windows.Forms.RadioButton();
            this.radioEnvio2 = new System.Windows.Forms.RadioButton();
            this.rtxtCuadro = new System.Windows.Forms.RichTextBox();
            this.radioEnvio1 = new System.Windows.Forms.RadioButton();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.cmbPizza = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmbOtros = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLomo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbPromo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHamb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMediaPizza = new System.Windows.Forms.ComboBox();
            this.lblMediaPizza = new System.Windows.Forms.Label();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeOlivaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(2001, 1097);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(517, 122);
            this.btnFinalizar.TabIndex = 19;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(985, 816);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(259, 103);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(531, 816);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(259, 103);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(87, 816);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(259, 103);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grilla);
            this.panel1.Location = new System.Drawing.Point(1336, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 491);
            this.panel1.TabIndex = 19;
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.grilla.ColumnHeadersHeight = 40;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Comida,
            this.CostoUnitario,
            this.CostoTotal});
            this.grilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grilla.Location = new System.Drawing.Point(0, 0);
            this.grilla.Margin = new System.Windows.Forms.Padding(4);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.RowHeadersWidth = 50;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grilla.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grilla.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grilla.Size = new System.Drawing.Size(1187, 491);
            this.grilla.TabIndex = 15;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Comida
            // 
            this.Comida.HeaderText = "Comida";
            this.Comida.MinimumWidth = 6;
            this.Comida.Name = "Comida";
            this.Comida.ReadOnly = true;
            this.Comida.Width = 380;
            // 
            // CostoUnitario
            // 
            this.CostoUnitario.HeaderText = "CostoUnitario";
            this.CostoUnitario.MinimumWidth = 6;
            this.CostoUnitario.Name = "CostoUnitario";
            this.CostoUnitario.ReadOnly = true;
            this.CostoUnitario.Width = 150;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "CostoTotal";
            this.CostoTotal.MinimumWidth = 6;
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.ReadOnly = true;
            this.CostoTotal.Width = 180;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.verdeOlivaDataSet;
            // 
            // verdeOlivaDataSet
            // 
            this.verdeOlivaDataSet.DataSetName = "VerdeOlivaDataSet";
            this.verdeOlivaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(1621, 724);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(897, 53);
            this.txtDireccion.TabIndex = 17;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(1360, 732);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(197, 47);
            this.lblDireccion.TabIndex = 25;
            this.lblDireccion.Text = "Direccion";
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.ForeColor = System.Drawing.Color.White;
            this.lblFechaHora.Location = new System.Drawing.Point(1885, 66);
            this.lblFechaHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(269, 46);
            this.lblFechaHora.TabIndex = 28;
            this.lblFechaHora.Text = "Fecha y Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1360, 993);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 47);
            this.label1.TabIndex = 29;
            this.label1.Text = "TOTAL";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(1619, 985);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(352, 53);
            this.txtMonto.TabIndex = 30;
            // 
            // txtNroTelefono
            // 
            this.txtNroTelefono.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroTelefono.Location = new System.Drawing.Point(1621, 639);
            this.txtNroTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroTelefono.Name = "txtNroTelefono";
            this.txtNroTelefono.Size = new System.Drawing.Size(349, 53);
            this.txtNroTelefono.TabIndex = 16;
            this.txtNroTelefono.Text = " ";
            this.txtNroTelefono.TextChanged += new System.EventHandler(this.TxtNroTelefono_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1360, 647);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 47);
            this.label2.TabIndex = 32;
            this.label2.Text = "Telefono";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1360, 816);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 47);
            this.label6.TabIndex = 41;
            this.label6.Text = "Paga";
            // 
            // txtPaga
            // 
            this.txtPaga.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaga.Location = new System.Drawing.Point(1619, 816);
            this.txtPaga.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaga.Name = "txtPaga";
            this.txtPaga.Size = new System.Drawing.Size(352, 53);
            this.txtPaga.TabIndex = 18;
            this.txtPaga.TextChanged += new System.EventHandler(this.TxtPaga_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(933, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(608, 94);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "Registrar Pedido";
            // 
            // radioBusca
            // 
            this.radioBusca.AutoSize = true;
            this.radioBusca.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBusca.Location = new System.Drawing.Point(985, 1169);
            this.radioBusca.Margin = new System.Windows.Forms.Padding(4);
            this.radioBusca.Name = "radioBusca";
            this.radioBusca.Size = new System.Drawing.Size(159, 50);
            this.radioBusca.TabIndex = 14;
            this.radioBusca.TabStop = true;
            this.radioBusca.Text = "BUSCA";
            this.radioBusca.UseVisualStyleBackColor = true;
            this.radioBusca.CheckedChanged += new System.EventHandler(this.RadioBusca_CheckedChanged);
            // 
            // radioEnvio2
            // 
            this.radioEnvio2.AutoSize = true;
            this.radioEnvio2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEnvio2.Location = new System.Drawing.Point(583, 1169);
            this.radioEnvio2.Margin = new System.Windows.Forms.Padding(4);
            this.radioEnvio2.Name = "radioEnvio2";
            this.radioEnvio2.Size = new System.Drawing.Size(171, 50);
            this.radioEnvio2.TabIndex = 13;
            this.radioEnvio2.TabStop = true;
            this.radioEnvio2.Text = "ENVIO 2";
            this.radioEnvio2.UseVisualStyleBackColor = true;
            this.radioEnvio2.CheckedChanged += new System.EventHandler(this.RadioEnvio_CheckedChanged);
            // 
            // rtxtCuadro
            // 
            this.rtxtCuadro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtCuadro.Location = new System.Drawing.Point(87, 959);
            this.rtxtCuadro.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtCuadro.Name = "rtxtCuadro";
            this.rtxtCuadro.Size = new System.Drawing.Size(1156, 165);
            this.rtxtCuadro.TabIndex = 12;
            this.rtxtCuadro.Text = "";
            this.rtxtCuadro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RtxtCuadro_KeyPress);
            // 
            // radioEnvio1
            // 
            this.radioEnvio1.AutoSize = true;
            this.radioEnvio1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEnvio1.Location = new System.Drawing.Point(180, 1169);
            this.radioEnvio1.Margin = new System.Windows.Forms.Padding(4);
            this.radioEnvio1.Name = "radioEnvio1";
            this.radioEnvio1.Size = new System.Drawing.Size(171, 50);
            this.radioEnvio1.TabIndex = 44;
            this.radioEnvio1.TabStop = true;
            this.radioEnvio1.Text = "ENVIO 1";
            this.radioEnvio1.UseVisualStyleBackColor = true;
            this.radioEnvio1.CheckedChanged += new System.EventHandler(this.radioEnvio1_CheckedChanged);
            // 
            // cmbEmp
            // 
            this.cmbEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmp.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(276, 180);
            this.cmbEmp.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(409, 54);
            this.cmbEmp.TabIndex = 3;
            // 
            // cmbPizza
            // 
            this.cmbPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizza.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPizza.FormattingEnabled = true;
            this.cmbPizza.Location = new System.Drawing.Point(865, 54);
            this.cmbPizza.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPizza.Name = "cmbPizza";
            this.cmbPizza.Size = new System.Drawing.Size(409, 54);
            this.cmbPizza.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 58);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(142, 47);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Lomos";
            // 
            // cmbOtros
            // 
            this.cmbOtros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtros.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOtros.FormattingEnabled = true;
            this.cmbOtros.Location = new System.Drawing.Point(865, 423);
            this.cmbOtros.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOtros.Name = "cmbOtros";
            this.cmbOtros.Size = new System.Drawing.Size(409, 54);
            this.cmbOtros.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 46);
            this.label4.TabIndex = 39;
            this.label4.Text = "Empanadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(712, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 47);
            this.label3.TabIndex = 38;
            this.label3.Text = "Pizzas";
            // 
            // cmbLomo
            // 
            this.cmbLomo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLomo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLomo.FormattingEnabled = true;
            this.cmbLomo.Location = new System.Drawing.Point(276, 54);
            this.cmbLomo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLomo.Name = "cmbLomo";
            this.cmbLomo.Size = new System.Drawing.Size(409, 54);
            this.cmbLomo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(712, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 47);
            this.label5.TabIndex = 40;
            this.label5.Text = "Otros";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(8, 607);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(185, 47);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(276, 607);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(252, 53);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.Text = " ";
            this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidad_TextChanged);
            // 
            // cmbPromo
            // 
            this.cmbPromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPromo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPromo.FormattingEnabled = true;
            this.cmbPromo.Location = new System.Drawing.Point(276, 310);
            this.cmbPromo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPromo.Name = "cmbPromo";
            this.cmbPromo.Size = new System.Drawing.Size(409, 54);
            this.cmbPromo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 46);
            this.label7.TabIndex = 42;
            this.label7.Text = "Promo";
            // 
            // cmbHamb
            // 
            this.cmbHamb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHamb.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHamb.FormattingEnabled = true;
            this.cmbHamb.Location = new System.Drawing.Point(865, 306);
            this.cmbHamb.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHamb.Name = "cmbHamb";
            this.cmbHamb.Size = new System.Drawing.Size(409, 54);
            this.cmbHamb.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(712, 310);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 46);
            this.label8.TabIndex = 44;
            this.label8.Text = "Hamb";
            // 
            // cmbMediaPizza
            // 
            this.cmbMediaPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMediaPizza.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMediaPizza.FormattingEnabled = true;
            this.cmbMediaPizza.Location = new System.Drawing.Point(865, 180);
            this.cmbMediaPizza.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMediaPizza.Name = "cmbMediaPizza";
            this.cmbMediaPizza.Size = new System.Drawing.Size(409, 54);
            this.cmbMediaPizza.TabIndex = 4;
            // 
            // lblMediaPizza
            // 
            this.lblMediaPizza.AutoSize = true;
            this.lblMediaPizza.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaPizza.Location = new System.Drawing.Point(712, 183);
            this.lblMediaPizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMediaPizza.Name = "lblMediaPizza";
            this.lblMediaPizza.Size = new System.Drawing.Size(133, 47);
            this.lblMediaPizza.TabIndex = 46;
            this.lblMediaPizza.Text = "Media";
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBebidas.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(276, 420);
            this.cmbBebidas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(409, 54);
            this.cmbBebidas.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 425);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 47);
            this.label9.TabIndex = 48;
            this.label9.Text = "Bebidas";
            // 
            // cmbMenu
            // 
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(865, 531);
            this.cmbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(409, 54);
            this.cmbMenu.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(712, 535);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 47);
            this.label10.TabIndex = 50;
            this.label10.Text = "Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbMenu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbBebidas);
            this.groupBox1.Controls.Add(this.lblMediaPizza);
            this.groupBox1.Controls.Add(this.cmbMediaPizza);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbHamb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbPromo);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbLomo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbOtros);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.cmbPizza);
            this.groupBox1.Controls.Add(this.cmbEmp);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1289, 682);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCTO";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(2541, 1241);
            this.Controls.Add(this.radioEnvio1);
            this.Controls.Add(this.rtxtCuadro);
            this.Controls.Add(this.radioEnvio2);
            this.Controls.Add(this.radioBusca);
            this.Controls.Add(this.txtPaga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNroTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeOlivaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private VerdeOlivaDataSet verdeOlivaDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private VerdeOlivaDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtNroTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPaga;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton radioBusca;
        private System.Windows.Forms.RadioButton radioEnvio2;
        private System.Windows.Forms.RichTextBox rtxtCuadro;
        private System.Windows.Forms.RadioButton radioEnvio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.ComboBox cmbPizza;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbOtros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLomo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbPromo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHamb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMediaPizza;
        private System.Windows.Forms.Label lblMediaPizza;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

