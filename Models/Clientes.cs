using System;
using System.Collections.Generic;

namespace ADweb.Models
{
    public partial class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int? Telefono { get; set; }
        public string Localidad { get; set; }
    }
}
