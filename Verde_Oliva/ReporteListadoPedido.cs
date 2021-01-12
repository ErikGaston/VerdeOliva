using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verde_Oliva
{
    public partial class ReporteListadoPedido : Form
    {
        private DateTime fechadesde;
        private DateTime fechahasta;
        TimeSpan ts = new TimeSpan(03, 00, 0);

        public ReporteListadoPedido(DateTime desde, DateTime hasta)
        {
            InitializeComponent();
            fechadesde = desde.Date + ts;
            fechahasta = hasta.Date + ts;
        }

        private void ReporteListadoPedido_Load(object sender, EventArgs e)
        {
            this.Reporte.RefreshReport();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();
            tabla = AccesoADatos.Pedido.obtenerPedidosFecha(fechadesde, fechahasta);

            ReportDataSource ds = new ReportDataSource("DataSetPedidos", tabla);
            Reporte.LocalReport.DataSources.Clear();
            Reporte.LocalReport.DataSources.Add(ds);
            Reporte.LocalReport.Refresh();

            // CALCULAR MONTO TOTAL
            int montototal = 0;
            foreach (DataRow row in tabla.Rows)
            {
                montototal += Convert.ToInt32(row[3]);
            }
            txtMonto.Text = montototal.ToString();

        }

    }
}
