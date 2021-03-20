using System;
using System.Collections.Generic;

namespace ADweb.Models
{
    public partial class Pedidos
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public bool EstaEntregado { get; set; }
        public bool EstaPago { get; set; }
        public bool PedidoCerrado { get; set; }
        public double TotalCobrado { get; set; }
    }
}
