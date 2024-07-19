using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ArtificersVet.Models
{
    public partial class Empleado
    {
        /// <summary>
        /// Constructor que inicializa las colecciones para evitar problemas de referencia nula
        /// </summary>
        public Empleado()
        {
            Consulta = new HashSet<Consulta>();
            HistorialMedico1s = new HashSet<HistorialMedico1>();
            HistorialMedicos = new HashSet<HistorialMedico>();
            Logins = new HashSet<Login>();
        }
        /// <summary>
        ///  // Propiedad clave primaria.
        /// </summary>
        /// 
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// // Propiedades opcionales para los detalles del empleado.
        /// Nombre,Apellido,Email,Telefono,Direccion,Puesto,Salario,FechaContratacion
        /// </summary>
        /// 
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido no puede tener más de 100 caracteres.")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El email no tiene un formato válido.")]
        [StringLength(255, ErrorMessage = "El email no puede tener más de 255 caracteres.")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "El teléfono no tiene un formato válido.")]
        [StringLength(15, ErrorMessage = "El teléfono no puede tener más de 15 caracteres.")]
        public string? Telefono { get; set; }

        [StringLength(255, ErrorMessage = "La dirección no puede tener más de 255 caracteres.")]
        public string? Direccion { get; set; }

        [StringLength(100, ErrorMessage = "El puesto no puede tener más de 100 caracteres.")]
        public string? Puesto { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El salario debe ser un valor positivo.")]
        public decimal? Salario { get; set; }

        [DataType(DataType.Date, ErrorMessage = "La fecha de contratación no tiene un formato válido.")]
        public DateTime? FechaContratacion { get; set; }
        /// <summary>
        /// Propiedades de navegación que representan las relaciones.
        /// Relación uno-a-muchos con Consulta
        /// Relación uno-a-muchos con HistorialMedico1
        /// Relación uno-a-muchos con HistorialMedico
        /// Relación uno-a-muchos con Login
        /// </summary>
        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual ICollection<HistorialMedico1> HistorialMedico1s { get; set; }
        public virtual ICollection<HistorialMedico> HistorialMedicos { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
    }
}
