using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde_Oliva.Entidad
{
    public class EntidadDetallePedido
    {
        public int Codigo { get; set; }
        public string Comida { get; set; }
        public int Cantidad { get; set; }
        public int CostoUnitario { get; set; }
        public int CostoTotal { get; set; }

        public EntidadDetallePedido(int codigo, string comida, int cantidad, int costounitario, int costototal)
        {
            Codigo = codigo;
            Comida = comida;
            Cantidad = cantidad;
            CostoUnitario = costounitario;
            CostoTotal = costototal;
        }

    }
}
