using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Enfermedade
    {
        public Enfermedade()
        {
            HistorialMedico1s = new HashSet<HistorialMedico1>();
            HistorialMedicos = new HashSet<HistorialMedico>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<HistorialMedico1> HistorialMedico1s { get; set; }
        public virtual ICollection<HistorialMedico> HistorialMedicos { get; set; }
    }
}
