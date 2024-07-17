using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Factura
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public DateTime? FechaEmision { get; set; }
        public decimal? MontoTotal { get; set; }
        public string? Estado { get; set; }
    }
}
