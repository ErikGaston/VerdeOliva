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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido p = new Pedido();
            p.ShowDialog();
        }

        private void ListadoDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoFechaPedido f = new ListadoFechaPedido();
            f.ShowDialog();
        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarPedido ep = new EliminarPedido();
            ep.ShowDialog();
        }

        private void PedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarPedido cp = new ConsultarPedido();
            cp.ShowDialog();
        }

        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarPedido mp = new ModificarPedido();
            mp.ShowDialog();
        }

        private void AgregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarProducto rp = new RegistrarProducto();
            rp.ShowDialog();
        }

        private void EliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarProducto ep = new EliminarProducto();
            ep.ShowDialog();
        }

        private void ActualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarProducto ap = new ActualizarProducto();
            ap.ShowDialog();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProducto cp = new ConsultarProducto();
            cp.ShowDialog();
        }

    }
}
