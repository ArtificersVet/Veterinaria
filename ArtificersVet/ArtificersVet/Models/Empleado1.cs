using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Empleado1
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Puesto { get; set; }
        public decimal? Salario { get; set; }
        public DateTime? FechaContratacion { get; set; }
    }
}
