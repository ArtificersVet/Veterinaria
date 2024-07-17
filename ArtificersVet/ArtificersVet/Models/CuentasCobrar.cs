using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class CuentasCobrar
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public int? FacturaId { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? Estado { get; set; }
    }
}
