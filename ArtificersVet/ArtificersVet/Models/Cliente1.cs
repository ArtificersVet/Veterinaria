using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtificersVet.Models
{
    public partial class Cliente1
    {
        public Cliente1()
        {
            Consulta = new HashSet<Consulta>();
            CuentasCobrar1s = new HashSet<CuentasCobrar1>();
            Factura1s = new HashSet<Factura1>();
            HistorialMedico1s = new HashSet<HistorialMedico1>();
            HistorialMedicos = new HashSet<HistorialMedico>();
            Mascota1s = new HashSet<Mascota1>();
            Receta = new HashSet<Receta>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        [StringLength(100, ErrorMessage ="El nombre no puede tener más de 100 carcateres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El apellido del cliente es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido no puede tener más de 100 carcateres.")]
        public string? Apellido { get; set; }

        [EmailAddress(ErrorMessage ="El email es invalido.")]
        public string? Email { get; set; }

        [Phone(ErrorMessage ="El número de teléfono es inválido.")]
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual ICollection<CuentasCobrar1> CuentasCobrar1s { get; set; }
        public virtual ICollection<Factura1> Factura1s { get; set; }
        public virtual ICollection<HistorialMedico1> HistorialMedico1s { get; set; }
        public virtual ICollection<HistorialMedico> HistorialMedicos { get; set; }
        public virtual ICollection<Mascota1> Mascota1s { get; set; }
        public virtual ICollection<Receta> Receta { get; set; }
    }
}
