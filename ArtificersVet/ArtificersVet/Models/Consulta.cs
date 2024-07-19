using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtificersVet.Models
{
    /// <summary>
    /// Representa una consulta veterinaria para una mascota.
    /// </summary>
    public partial class Consulta
    {
        public Consulta()
        {
            Tratamiento1s = new HashSet<Tratamiento1>();
            Tratamientos = new HashSet<Tratamiento>();
        }

        /// <summary>
        /// Identificador único de la consulta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador del cliente dueño de la mascota.
        /// </summary>

        [Required(ErrorMessage = "El ID del cliente es obligatorio.")]
        public int? ClienteId { get; set; }

        /// <summary>
        /// Identificador de la mascota atendida en la consulta.
        /// </summary>
        [Required(ErrorMessage = "El ID de la mascota es obligatorio.")]
        public int? MascotaId { get; set; }

        /// <summary>
        /// Fecha y hora en que se realizó la consulta.
        /// </summary>
        [Required(ErrorMessage = "La fecha de la consulta es obligatoria.")]
        public DateTime? FechaConsulta { get; set; }

        /// <summary>
        /// Motivo de la consulta (máximo 250 caracteres).
        /// </summary>

        [StringLength(250, ErrorMessage = "El motivo no puede exceder los 250 caracteres.")]
        public string? Motivo { get; set; }

        /// <summary>
        /// Diagnóstico realizado por el veterinario (máximo 250 caracteres).
        /// </summary>
        [StringLength(250, ErrorMessage = "El diagnóstico no puede exceder los 250 caracteres.")]
        public string? Diagnostico { get; set; }

        /// <summary>
        /// Tratamiento prescrito para la mascota (máximo 500 caracteres).
        /// </summary>
        [StringLength(500, ErrorMessage = "El tratamiento no puede exceder los 500 caracteres.")]
        public string? Tratamiento { get; set; }

        /// <summary>
        /// Monto total de la consulta (entre 0 y 1000).
        /// </summary>
        [Range(0, 1000, ErrorMessage = "El monto debe ser entre 0 y 1000.")]
        public decimal? Monto { get; set; }

        /// <summary>
        /// Identificador del empleado (veterinario) que realizó la consulta.
        /// </summary>
        [Required(ErrorMessage = "El ID del empleado es obligatorio.")]
        public int? EmpleadoId { get; set; }


        /// <summary>
        /// Relación con el cliente dueño de la mascota.
        /// </summary>
        public virtual Cliente1? Cliente { get; set; }
        /// <summary>
        /// Relación con el empleado (veterinario) que realizó la consulta.
        /// </summary>
        public virtual Empleado? Empleado { get; set; }
        /// <summary>
        /// Relación con la mascota atendida en la consulta.
        /// </summary>
        public virtual Mascota1? Mascota { get; set; }
        /// <summary>
        /// Colección de tratamientos asociados a la consulta (relación uno a muchos).
        /// </summary>
        public virtual ICollection<Tratamiento1> Tratamiento1s { get; set; }
        /// <summary>
        /// Colección de tratamientos asociados a la consulta (relación uno a muchos).
        /// </summary>
        public virtual ICollection<Tratamiento> Tratamientos { get; set; }
    }
}
