using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde_Oliva.Entidad
{
    public class DetallePedido
    {
        public int IdDetallePedido { get; set; }

        public string Comida { get; set; }
        public int Cantidad { get; set; }
        public int CostoUnitario { get; set; }

        public int CostoTotal { get; set; }

        //
        //


    }
}
