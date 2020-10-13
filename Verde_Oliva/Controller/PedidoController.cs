using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verde_Oliva
{
    public class PedidoController
    {

        public void esNumero(TextBox numero)
        {
            int myInt;
            bool isNumerical = int.TryParse(numero.Text, out myInt);
            if (!isNumerical)
            {
                numero.Focus();
                MessageBox.Show("Solo permite ingresar numeros");
                numero.Text = "";
            }
        }
    }
}
