using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class VwClientesConEmpleado
    {
        public int ClienteId { get; set; }
        public string? NombreCliente { get; set; }
        public string? ApellidoCliente { get; set; }
        public int? EmpleadoId { get; set; }
        public string? NombreEmpleado { get; set; }
        public string? ApellidoEmpleado { get; set; }
    }
}
