﻿using System;
using System.Collections.Generic;

namespace ArtificersVet.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public int? EmpleadoId { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }
        public string? Rol { get; set; }

        public virtual Empleado? Empleado { get; set; }
    }
}
