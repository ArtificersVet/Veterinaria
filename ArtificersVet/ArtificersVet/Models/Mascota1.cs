using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Mascota1
    {
        public Mascota1()
        {
            Consulta = new HashSet<Consulta>();
            HistorialMedico1s = new HashSet<HistorialMedico1>();
            HistorialMedicos = new HashSet<HistorialMedico>();
        }

        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public string? Nombre { get; set; }
        public string? Especie { get; set; }
        public string? Raza { get; set; }
        public int? Edad { get; set; }
        public string? Sexo { get; set; }

        public virtual Cliente1? Cliente { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual ICollection<HistorialMedico1> HistorialMedico1s { get; set; }
        public virtual ICollection<HistorialMedico> HistorialMedicos { get; set; }
    }
}
