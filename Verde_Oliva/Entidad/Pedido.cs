using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verde_Oliva.Entidad
{
    public class Pedido
    {
        private int IdPedido { get; set; }
        private DateTime Fecha_Hora { get; set; }
        private string Direccion { get; set; }
        private float MontoTotal { get; set; }

        public Pedido(int idpedido, DateTime fecha_hora, string direccion, float montototal){
            IdPedido = idpedido;
            Fecha_Hora = fecha_hora;
            Direccion = direccion;
            MontoTotal = montototal;
        }
    }
}
    
