using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class RecetasEliminada
    {
        public int? RecetaId { get; set; }
        public int? ClienteId { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
