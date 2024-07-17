using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class FacturaDetalle1
    {
        public int Id { get; set; }
        public int? FacturaId { get; set; }
        public int? InventarioId { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioVenta { get; set; }
        public string? Nombre { get; set; }

        public virtual Factura1? Factura { get; set; }
        public virtual Inventario? Inventario { get; set; }
    }
}
