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
    public partial class PantallaPrincipal_1 : Form
    {
        public PantallaPrincipal_1()
        {
            InitializeComponent();
        }

        private void PedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarPedido cp = new ConsultarPedido();
            cp.ShowDialog();
        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido p = new Pedido();
            p.ShowDialog();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProducto cp = new ConsultarProducto();
            cp.ShowDialog();
        }
    }
}
