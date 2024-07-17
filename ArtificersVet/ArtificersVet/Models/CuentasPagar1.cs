using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class CuentasPagar1
    {
        public int Id { get; set; }
        public int? ProveedorId { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? Estado { get; set; }

        public virtual Proveedore? Proveedor { get; set; }
    }
}
