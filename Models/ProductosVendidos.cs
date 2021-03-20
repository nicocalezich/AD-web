using System;
using System.Collections.Generic;

namespace ADweb.Models
{
    public partial class ProductosVendidos
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public string Producto { get; set; }
        public double Cantidad { get; set; }
    }
}
