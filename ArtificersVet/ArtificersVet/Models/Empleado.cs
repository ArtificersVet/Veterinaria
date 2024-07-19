using System;
using System.Collections.Generic;

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
        public int Id { get; set; }
        /// <summary>
        /// // Propiedades opcionales para los detalles del empleado.
        /// Nombre,Apellido,Email,Telefono,Direccion,Puesto,Salario,FechaContratacion
        /// </summary>
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Puesto { get; set; }
        public decimal? Salario { get; set; }
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
