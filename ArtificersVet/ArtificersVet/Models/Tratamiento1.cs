using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Tratamiento1
    {
        public int Id { get; set; }
        public int? ConsultaId { get; set; }
        public int? Recetaid { get; set; }
        public string? Tratamiento { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        public virtual Consulta? Consulta { get; set; }
        public virtual Receta? Receta { get; set; }
    }
}
