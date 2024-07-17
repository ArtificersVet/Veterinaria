using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Inventario
    {
        public Inventario()
        {
            FacturaDetalle1s = new HashSet<FacturaDetalle1>();
        }

        public int Id { get; set; }
        public string? NombreProducto { get; set; }
        public string? Descripcion { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioVenta { get; set; }
        public int? ProveedorId { get; set; }
        public DateTime? FechaEntrada { get; set; }

        public virtual Proveedore? Proveedor { get; set; }
        public virtual ICollection<FacturaDetalle1> FacturaDetalle1s { get; set; }
    }
}
