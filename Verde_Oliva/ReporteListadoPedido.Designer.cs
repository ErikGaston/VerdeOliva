namespace Verde_Oliva
{
    partial class ReporteListadoPedido
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VerdeOlivaDataSet = new Verde_Oliva.VerdeOlivaDataSet();
            this.Reporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PedidoTableAdapter = new Verde_Oliva.VerdeOlivaDataSetTableAdapters.PedidoTableAdapter();
            this.txtMonto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerdeOlivaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidoBindingSource
            // 
            this.PedidoBindingSource.DataMember = "Pedido";
            this.PedidoBindingSource.DataSource = this.VerdeOlivaDataSet;
            // 
            // VerdeOlivaDataSet
            // 
            this.VerdeOlivaDataSet.DataSetName = "VerdeOlivaDataSet";
            this.VerdeOlivaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte
            // 
            this.Reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPedidos";
            reportDataSource1.Value = this.PedidoBindingSource;
            this.Reporte.LocalReport.DataSources.Add(reportDataSource1);
            this.Reporte.LocalReport.ReportEmbeddedResource = "Verde_Oliva.ReporteListadoPedido.rdlc";
            this.Reporte.Location = new System.Drawing.Point(0, 0);
            this.Reporte.Name = "Reporte";
            this.Reporte.ServerReport.BearerToken = null;
            this.Reporte.Size = new System.Drawing.Size(1350, 730);
            this.Reporte.TabIndex = 0;
            this.Reporte.Load += new System.EventHandler(this.Reporte_Load);
            // 
            // PedidoTableAdapter
            // 
            this.PedidoTableAdapter.ClearBeforeFill = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(12, 43);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(243, 29);
            this.txtMonto.TabIndex = 2;
            // 
            // ReporteListadoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.Reporte);
            this.Name = "ReporteListadoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Pedidos";
            this.Load += new System.EventHandler(this.ReporteListadoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerdeOlivaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Reporte;
        private System.Windows.Forms.BindingSource PedidoBindingSource;
        private VerdeOlivaDataSet VerdeOlivaDataSet;
        private VerdeOlivaDataSetTableAdapters.PedidoTableAdapter PedidoTableAdapter;
        private System.Windows.Forms.TextBox txtMonto;
    }
}