using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Enfermedade1
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
