using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde_Oliva.Entidad
{
    public class Producto
    {
        private int Codigo { get; set; }
        private string Comida { get; set; }
        private float CostoUnitario { get; set; }

        public Producto(int codigo, string comida, float costounitario)
        {
            Codigo = codigo;
            Comida = comida;
            CostoUnitario = costounitario;
        }
    }
}
