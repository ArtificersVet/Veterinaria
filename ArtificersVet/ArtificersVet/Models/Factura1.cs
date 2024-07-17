using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Factura1
    {
        public Factura1()
        {
            CuentasCobrar1s = new HashSet<CuentasCobrar1>();
            FacturaDetalle1s = new HashSet<FacturaDetalle1>();
        }

        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public DateTime? FechaEmision { get; set; }
        public decimal? MontoTotal { get; set; }
        public string? Estado { get; set; }

        public virtual Cliente1? Cliente { get; set; }
        public virtual ICollection<CuentasCobrar1> CuentasCobrar1s { get; set; }
        public virtual ICollection<FacturaDetalle1> FacturaDetalle1s { get; set; }
    }
}
