using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Receta
    {
        public Receta()
        {
            HistorialMedico1s = new HashSet<HistorialMedico1>();
            HistorialMedicos = new HashSet<HistorialMedico>();
            Tratamiento1s = new HashSet<Tratamiento1>();
            Tratamientos = new HashSet<Tratamiento>();
        }

        public int RecetaId { get; set; }
        public int? ClienteId { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual Cliente1? Cliente { get; set; }
        public virtual ICollection<HistorialMedico1> HistorialMedico1s { get; set; }
        public virtual ICollection<HistorialMedico> HistorialMedicos { get; set; }
        public virtual ICollection<Tratamiento1> Tratamiento1s { get; set; }
        public virtual ICollection<Tratamiento> Tratamientos { get; set; }
    }
}
