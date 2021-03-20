using System;
using System.Collections.Generic;

namespace ADweb.Models
{
    public partial class Productos
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public string Tipo { get; set; }
        public bool HayStock { get; set; }
        public double PrecioKgUnidad { get; set; }
        public double CantidadDisponible { get; set; }
        public string UnidadUsada { get; set; }
    }
}
