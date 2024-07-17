using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            CuentasPagar1s = new HashSet<CuentasPagar1>();
            Inventarios = new HashSet<Inventario>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Contacto { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<CuentasPagar1> CuentasPagar1s { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
    }
}
