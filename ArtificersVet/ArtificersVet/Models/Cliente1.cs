using System;
using System.Collections.Generic;

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
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
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
