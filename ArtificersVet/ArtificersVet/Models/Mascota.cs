using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtificersVet.Models
{
    public partial class Mascota
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El cliente es requerido")]
        public int? ClienteId { get; set; }
        [Required(ErrorMessage = "El nombre de la mascota es requerida")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 carcateres.")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La especie es requerida")]
        [StringLength(100, ErrorMessage = "La especie no puede tener más de 100 carcateres.")]
        public string? Especie { get; set; }
        [Required(ErrorMessage = "La raza es requerida")]
        [StringLength(100, ErrorMessage = "La raza no puede tener más de 100 carcateres.")]
        public string? Raza { get; set; }
        [Required(ErrorMessage = "La edad es requerida")]
        public int? Edad { get; set; }
        [Required(ErrorMessage = "El sexo es requerido")]
        [StringLength(10, ErrorMessage = "El sexo no puede tener más de 10 carcateres.")]
        public string? Sexo { get; set; }
    }
}
