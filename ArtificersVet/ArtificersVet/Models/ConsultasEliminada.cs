using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class ConsultasEliminada
    {
        public int? Id { get; set; }
        public int? ClienteId { get; set; }
        public int? MascotaId { get; set; }
        public DateTime? FechaConsulta { get; set; }
        public string? Motivo { get; set; }
        public string? Diagnostico { get; set; }
        public string? Tratamiento { get; set; }
        public decimal? Monto { get; set; }
        public int? EmpleadoId { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
