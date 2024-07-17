using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class CuentasCobrar1
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public int? FacturaId { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? Estado { get; set; }

        public virtual Cliente1? Cliente { get; set; }
        public virtual Factura1? Factura { get; set; }
    }
}
