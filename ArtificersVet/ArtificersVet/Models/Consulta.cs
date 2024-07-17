using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Consulta
    {
        public Consulta()
        {
            Tratamiento1s = new HashSet<Tratamiento1>();
            Tratamientos = new HashSet<Tratamiento>();
        }

        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public int? MascotaId { get; set; }
        public DateTime? FechaConsulta { get; set; }
        public string? Motivo { get; set; }
        public string? Diagnostico { get; set; }
        public string? Tratamiento { get; set; }
        public decimal? Monto { get; set; }
        public int? EmpleadoId { get; set; }

        public virtual Cliente1? Cliente { get; set; }
        public virtual Empleado? Empleado { get; set; }
        public virtual Mascota1? Mascota { get; set; }
        public virtual ICollection<Tratamiento1> Tratamiento1s { get; set; }
        public virtual ICollection<Tratamiento> Tratamientos { get; set; }
    }
}
