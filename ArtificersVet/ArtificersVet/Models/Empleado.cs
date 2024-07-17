using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Consulta = new HashSet<Consulta>();
            HistorialMedico1s = new HashSet<HistorialMedico1>();
            HistorialMedicos = new HashSet<HistorialMedico>();
            Logins = new HashSet<Login>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Puesto { get; set; }
        public decimal? Salario { get; set; }
        public DateTime? FechaContratacion { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual ICollection<HistorialMedico1> HistorialMedico1s { get; set; }
        public virtual ICollection<HistorialMedico> HistorialMedicos { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
    }
}
