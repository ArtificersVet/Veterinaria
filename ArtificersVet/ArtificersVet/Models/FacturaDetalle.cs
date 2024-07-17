using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class FacturaDetalle
    {
        public int Id { get; set; }
        public int? FacturaId { get; set; }
        public int? InventarioId { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioVenta { get; set; }
        public string? Nombre { get; set; }
    }
}
