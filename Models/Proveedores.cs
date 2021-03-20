using System;
using System.Collections.Generic;

namespace ADweb.Models
{
    public partial class Proveedores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoMercaderia { get; set; }
        public string Direccion { get; set; }
        public int? Telefono { get; set; }
        public string NombrePersonal { get; set; }
    }
}
