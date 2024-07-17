using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class CuentasPagar
    {
        public int Id { get; set; }
        public int? ProveedorId { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? Estado { get; set; }
    }
}
