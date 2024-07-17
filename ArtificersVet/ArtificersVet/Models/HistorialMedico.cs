using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class HistorialMedico
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public int? MascotaId { get; set; }
        public int? EmpleadoId { get; set; }
        public int? EnfermedadesId { get; set; }
        public int? Recetaid { get; set; }
        public string? Observacion { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Cliente1? Cliente { get; set; }
        public virtual Empleado? Empleado { get; set; }
        public virtual Enfermedade? Enfermedades { get; set; }
        public virtual Mascota1? Mascota { get; set; }
        public virtual Receta? Receta { get; set; }
    }
}
