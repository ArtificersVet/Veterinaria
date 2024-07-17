using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Mascota
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public string? Nombre { get; set; }
        public string? Especie { get; set; }
        public string? Raza { get; set; }
        public int? Edad { get; set; }
        public string? Sexo { get; set; }
    }
}
