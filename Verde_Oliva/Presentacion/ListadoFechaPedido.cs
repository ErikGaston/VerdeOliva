using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verde_Oliva.Presentacion
{
    public partial class ListadoFechaPedido : Form
    {
        public ListadoFechaPedido()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ReporteListadoPedido r = new ReporteListadoPedido(dtpDesde.Value,dtpHasta.Value);
            r.Show();
        }
    }
}
