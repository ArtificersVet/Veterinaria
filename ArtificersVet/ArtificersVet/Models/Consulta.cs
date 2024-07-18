using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "El ID del cliente es obligatorio.")]
        public int? ClienteId { get; set; }

        [Required(ErrorMessage = "El ID de la mascota es obligatorio.")]
        public int? MascotaId { get; set; }

        [Required(ErrorMessage = "La fecha de la consulta es obligatoria.")]
        public DateTime? FechaConsulta { get; set; }

        [StringLength(250, ErrorMessage = "El motivo no puede exceder los 250 caracteres.")]
        public string? Motivo { get; set; }

        [StringLength(250, ErrorMessage = "El diagnóstico no puede exceder los 250 caracteres.")]
        public string? Diagnostico { get; set; }

        [StringLength(500, ErrorMessage = "El tratamiento no puede exceder los 500 caracteres.")]
        public string? Tratamiento { get; set; }

        [Range(0, 1000, ErrorMessage = "El monto debe ser entre 0 y 1000.")]
        public decimal? Monto { get; set; }

        [Required(ErrorMessage = "El ID del empleado es obligatorio.")]
        public int? EmpleadoId { get; set; }

        public virtual Cliente1? Cliente { get; set; }
        public virtual Empleado? Empleado { get; set; }
        public virtual Mascota1? Mascota { get; set; }
        public virtual ICollection<Tratamiento1> Tratamiento1s { get; set; }
        public virtual ICollection<Tratamiento> Tratamientos { get; set; }
    }
}
