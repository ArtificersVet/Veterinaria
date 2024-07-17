using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ArtificersVet.Models;

namespace ArtificersVet.Data
{
    public partial class VeterinariaDbContext : DbContext
    {
        public VeterinariaDbContext()
        {
        }

        public VeterinariaDbContext(DbContextOptions<VeterinariaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Cliente1> Clientes1 { get; set; } = null!;
        public virtual DbSet<Consulta> Consultas { get; set; } = null!;
        public virtual DbSet<Consulta1> Consultas1 { get; set; } = null!;
        public virtual DbSet<ConsultasEliminada> ConsultasEliminadas { get; set; } = null!;
        public virtual DbSet<CuentasCobrar> CuentasCobrars { get; set; } = null!;
        public virtual DbSet<CuentasCobrar1> CuentasCobrars1 { get; set; } = null!;
        public virtual DbSet<CuentasPagar> CuentasPagars { get; set; } = null!;
        public virtual DbSet<CuentasPagar1> CuentasPagars1 { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Empleado1> Empleados1 { get; set; } = null!;
        public virtual DbSet<Enfermedade> Enfermedades { get; set; } = null!;
        public virtual DbSet<Enfermedade1> Enfermedades1 { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Factura1> Facturas1 { get; set; } = null!;
        public virtual DbSet<FacturaDetalle> FacturaDetalles { get; set; } = null!;
        public virtual DbSet<FacturaDetalle1> FacturaDetalles1 { get; set; } = null!;
        public virtual DbSet<HistorialMedico> HistorialMedicos { get; set; } = null!;
        public virtual DbSet<HistorialMedico1> HistorialMedicos1 { get; set; } = null!;
        public virtual DbSet<Inventario> Inventarios { get; set; } = null!;
        public virtual DbSet<Inventario1> Inventarios1 { get; set; } = null!;
        public virtual DbSet<InventarioEliminado> InventarioEliminados { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<Login1> Logins1 { get; set; } = null!;
        public virtual DbSet<Mascota> Mascotas { get; set; } = null!;
        public virtual DbSet<Mascota1> Mascotas1 { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;
        public virtual DbSet<Proveedore1> Proveedores1 { get; set; } = null!;
        public virtual DbSet<Receta> Recetas { get; set; } = null!;
        public virtual DbSet<Receta1> Recetas1 { get; set; } = null!;
        public virtual DbSet<RecetasEliminada> RecetasEliminadas { get; set; } = null!;
        public virtual DbSet<Tratamiento> Tratamientos { get; set; } = null!;
        public virtual DbSet<Tratamiento1> Tratamientos1 { get; set; } = null!;
        public virtual DbSet<VwClientesConEmpleado> VwClientesConEmpleados { get; set; } = null!;
        public virtual DbSet<VwConsulta> VwConsultas { get; set; } = null!;
        public virtual DbSet<VwInventario> VwInventarios { get; set; } = null!;
        public virtual DbSet<VwMascota> VwMascotas { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Clientes", "Clientes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .HasColumnName("apellido");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Cliente1>(entity =>
            {
                entity.ToTable("Clientes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .HasColumnName("apellido");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(200)
                    .HasColumnName("diagnostico");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.FechaConsulta)
                    .HasColumnType("date")
                    .HasColumnName("fecha_consulta");

                entity.Property(e => e.MascotaId).HasColumnName("mascota_id");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(200)
                    .HasColumnName("motivo");

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(200)
                    .HasColumnName("tratamiento");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__Consultas__clien__403A8C7D");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("FK__Consultas__emple__4222D4EF");

                entity.HasOne(d => d.Mascota)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.MascotaId)
                    .HasConstraintName("FK__Consultas__masco__412EB0B6");
            });

            modelBuilder.Entity<Consulta1>(entity =>
            {
                entity.ToTable("Consultas", "RecursosHumanos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(200)
                    .HasColumnName("diagnostico");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.FechaConsulta)
                    .HasColumnType("date")
                    .HasColumnName("fecha_consulta");

                entity.Property(e => e.MascotaId).HasColumnName("mascota_id");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(200)
                    .HasColumnName("motivo");

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(200)
                    .HasColumnName("tratamiento");
            });

            modelBuilder.Entity<ConsultasEliminada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("consultas_eliminadas", "eliminados");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(200)
                    .HasColumnName("diagnostico");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.FechaConsulta)
                    .HasColumnType("date")
                    .HasColumnName("fecha_consulta");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_eliminacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MascotaId).HasColumnName("mascota_id");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(200)
                    .HasColumnName("motivo");

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(200)
                    .HasColumnName("tratamiento");
            });

            modelBuilder.Entity<CuentasCobrar>(entity =>
            {
                entity.ToTable("CuentasCobrar", "Contabilidad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .HasColumnName("estado");

                entity.Property(e => e.FacturaId).HasColumnName("factura_id");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_vencimiento");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");
            });

            modelBuilder.Entity<CuentasCobrar1>(entity =>
            {
                entity.ToTable("CuentasCobrar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .HasColumnName("estado");

                entity.Property(e => e.FacturaId).HasColumnName("factura_id");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_vencimiento");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.CuentasCobrar1s)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__CuentasCo__clien__4E88ABD4");

                entity.HasOne(d => d.Factura)
                    .WithMany(p => p.CuentasCobrar1s)
                    .HasForeignKey(d => d.FacturaId)
                    .HasConstraintName("FK__CuentasCo__factu__4F7CD00D");
            });

            modelBuilder.Entity<CuentasPagar>(entity =>
            {
                entity.ToTable("CuentasPagar", "Contabilidad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_vencimiento");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");
            });

            modelBuilder.Entity<CuentasPagar1>(entity =>
            {
                entity.ToTable("CuentasPagar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_vencimiento");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.CuentasPagar1s)
                    .HasForeignKey(d => d.ProveedorId)
                    .HasConstraintName("FK__CuentasPa__prove__52593CB8");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .HasColumnName("apellido");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.FechaContratacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_contratacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(100)
                    .HasColumnName("puesto");

                entity.Property(e => e.Salario)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salario");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Empleado1>(entity =>
            {
                entity.ToTable("Empleados", "RecursosHumanos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .HasColumnName("apellido");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.FechaContratacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_contratacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(100)
                    .HasColumnName("puesto");

                entity.Property(e => e.Salario)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salario");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Enfermedade>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Enfermedade1>(entity =>
            {
                entity.ToTable("Enfermedades", "RecursosHumanos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.ToTable("Facturas", "Contabilidad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("date")
                    .HasColumnName("fecha_emision");

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto_total");
            });

            modelBuilder.Entity<Factura1>(entity =>
            {
                entity.ToTable("Facturas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaEmision)
                    .HasColumnType("date")
                    .HasColumnName("fecha_emision");

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto_total");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Factura1s)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__Facturas__client__44FF419A");
            });

            modelBuilder.Entity<FacturaDetalle>(entity =>
            {
                entity.ToTable("FacturaDetalles", "Contabilidad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.FacturaId).HasColumnName("factura_id");

                entity.Property(e => e.InventarioId).HasColumnName("inventario_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_venta");
            });

            modelBuilder.Entity<FacturaDetalle1>(entity =>
            {
                entity.ToTable("FacturaDetalles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.FacturaId).HasColumnName("factura_id");

                entity.Property(e => e.InventarioId).HasColumnName("inventario_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_venta");

                entity.HasOne(d => d.Factura)
                    .WithMany(p => p.FacturaDetalle1s)
                    .HasForeignKey(d => d.FacturaId)
                    .HasConstraintName("FK__FacturaDe__factu__4AB81AF0");

                entity.HasOne(d => d.Inventario)
                    .WithMany(p => p.FacturaDetalle1s)
                    .HasForeignKey(d => d.InventarioId)
                    .HasConstraintName("FK__FacturaDe__inven__4BAC3F29");
            });

            modelBuilder.Entity<HistorialMedico>(entity =>
            {
                entity.ToTable("HistorialMedico");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.EnfermedadesId).HasColumnName("enfermedades_id");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MascotaId).HasColumnName("mascota_id");

                entity.Property(e => e.Observacion).HasColumnName("observacion");

                entity.Property(e => e.Recetaid).HasColumnName("recetaid");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.HistorialMedicos)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__Historial__clien__60A75C0F");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.HistorialMedicos)
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("FK__Historial__emple__628FA481");

                entity.HasOne(d => d.Enfermedades)
                    .WithMany(p => p.HistorialMedicos)
                    .HasForeignKey(d => d.EnfermedadesId)
                    .HasConstraintName("FK__Historial__enfer__6383C8BA");

                entity.HasOne(d => d.Mascota)
                    .WithMany(p => p.HistorialMedicos)
                    .HasForeignKey(d => d.MascotaId)
                    .HasConstraintName("FK__Historial__masco__619B8048");

                entity.HasOne(d => d.Receta)
                    .WithMany(p => p.HistorialMedicos)
                    .HasForeignKey(d => d.Recetaid)
                    .HasConstraintName("FK__Historial__recet__6477ECF3");
            });

            modelBuilder.Entity<HistorialMedico1>(entity =>
            {
                entity.ToTable("HistorialMedico", "RecursosHumanos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.EnfermedadesId).HasColumnName("enfermedades_id");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_registro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MascotaId).HasColumnName("mascota_id");

                entity.Property(e => e.Observacion).HasColumnName("observacion");

                entity.Property(e => e.Recetaid).HasColumnName("recetaid");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.HistorialMedico1s)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__Historial__clien__06CD04F7");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.HistorialMedico1s)
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("FK__Historial__emple__08B54D69");

                entity.HasOne(d => d.Enfermedades)
                    .WithMany(p => p.HistorialMedico1s)
                    .HasForeignKey(d => d.EnfermedadesId)
                    .HasConstraintName("FK__Historial__enfer__09A971A2");

                entity.HasOne(d => d.Mascota)
                    .WithMany(p => p.HistorialMedico1s)
                    .HasForeignKey(d => d.MascotaId)
                    .HasConstraintName("FK__Historial__masco__07C12930");

                entity.HasOne(d => d.Receta)
                    .WithMany(p => p.HistorialMedico1s)
                    .HasForeignKey(d => d.Recetaid)
                    .HasConstraintName("FK__Historial__recet__0A9D95DB");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.ToTable("Inventario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("date")
                    .HasColumnName("fecha_entrada");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(100)
                    .HasColumnName("nombre_producto");

                entity.Property(e => e.PrecioCompra)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_compra");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_venta");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.ProveedorId)
                    .HasConstraintName("FK__Inventari__prove__47DBAE45");
            });

            modelBuilder.Entity<Inventario1>(entity =>
            {
                entity.ToTable("Inventario", "Proveedores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("date")
                    .HasColumnName("fecha_entrada");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(100)
                    .HasColumnName("nombre_producto");

                entity.Property(e => e.PrecioCompra)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_compra");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_venta");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");
            });

            modelBuilder.Entity<InventarioEliminado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("inventario_eliminado", "eliminados");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_eliminacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_entrada");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(100)
                    .HasColumnName("nombre_producto");

                entity.Property(e => e.PrecioCompra)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_compra");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_venta");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.HasIndex(e => e.Correo, "UQ__Login__2A586E0B99C4AC09")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(100)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .HasColumnName("correo");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Rol).HasMaxLength(15);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.EmpleadoId)
                    .HasConstraintName("FK__Login__empleado___5629CD9C");
            });

            modelBuilder.Entity<Login1>(entity =>
            {
                entity.ToTable("Login", "RecursosHumanos");

                entity.HasIndex(e => e.Correo, "UQ__Login__2A586E0B1CFDC2C0")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(100)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .HasColumnName("correo");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Rol)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mascota>(entity =>
            {
                entity.ToTable("Mascotas", "Clientes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Especie)
                    .HasMaxLength(100)
                    .HasColumnName("especie");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Raza)
                    .HasMaxLength(100)
                    .HasColumnName("raza");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(10)
                    .HasColumnName("sexo");
            });

            modelBuilder.Entity<Mascota1>(entity =>
            {
                entity.ToTable("Mascotas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Especie)
                    .HasMaxLength(100)
                    .HasColumnName("especie");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Raza)
                    .HasMaxLength(100)
                    .HasColumnName("raza");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(10)
                    .HasColumnName("sexo");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Mascota1s)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__Mascotas__client__3D5E1FD2");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(100)
                    .HasColumnName("contacto");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Proveedore1>(entity =>
            {
                entity.ToTable("Proveedores", "Proveedores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(100)
                    .HasColumnName("contacto");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Receta>(entity =>
            {
                entity.Property(e => e.RecetaId).HasColumnName("receta_id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Receta)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__Recetas__cliente__59FA5E80");
            });

            modelBuilder.Entity<Receta1>(entity =>
            {
                entity.HasKey(e => e.RecetaId)
                    .HasName("PK__Recetas__4BCAA6B54C6F46F7");

                entity.ToTable("Recetas", "RecursosHumanos");

                entity.Property(e => e.RecetaId).HasColumnName("receta_id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<RecetasEliminada>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recetas_eliminadas", "eliminados");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_eliminacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.RecetaId).HasColumnName("receta_id");
            });

            modelBuilder.Entity<Tratamiento>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConsultaId).HasColumnName("consulta_id");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.Recetaid).HasColumnName("recetaid");

                entity.Property(e => e.Tratamiento1).HasColumnName("tratamiento");

                entity.HasOne(d => d.Consulta)
                    .WithMany(p => p.Tratamientos)
                    .HasForeignKey(d => d.ConsultaId)
                    .HasConstraintName("FK__Tratamien__consu__6754599E");

                entity.HasOne(d => d.Receta)
                    .WithMany(p => p.Tratamientos)
                    .HasForeignKey(d => d.Recetaid)
                    .HasConstraintName("FK__Tratamien__recet__68487DD7");
            });

            modelBuilder.Entity<Tratamiento1>(entity =>
            {
                entity.ToTable("Tratamientos", "RecursosHumanos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConsultaId).HasColumnName("consulta_id");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.Recetaid).HasColumnName("recetaid");

                entity.Property(e => e.Tratamiento).HasColumnName("tratamiento");

                entity.HasOne(d => d.Consulta)
                    .WithMany(p => p.Tratamiento1s)
                    .HasForeignKey(d => d.ConsultaId)
                    .HasConstraintName("FK__Tratamien__consu__0D7A0286");

                entity.HasOne(d => d.Receta)
                    .WithMany(p => p.Tratamiento1s)
                    .HasForeignKey(d => d.Recetaid)
                    .HasConstraintName("FK__Tratamien__recet__0E6E26BF");
            });

            modelBuilder.Entity<VwClientesConEmpleado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Clientes_Con_Empleados");

                entity.Property(e => e.ApellidoCliente).HasMaxLength(100);

                entity.Property(e => e.ApellidoEmpleado).HasMaxLength(100);

                entity.Property(e => e.NombreCliente).HasMaxLength(100);

                entity.Property(e => e.NombreEmpleado).HasMaxLength(100);
            });

            modelBuilder.Entity<VwConsulta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_consultas");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(200)
                    .HasColumnName("diagnostico");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.FechaConsulta)
                    .HasColumnType("date")
                    .HasColumnName("fecha_consulta");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.MascotaId).HasColumnName("mascota_id");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(200)
                    .HasColumnName("motivo");

                entity.Property(e => e.Tratamiento)
                    .HasMaxLength(200)
                    .HasColumnName("tratamiento");
            });

            modelBuilder.Entity<VwInventario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_inventario");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .HasColumnName("descripcion");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("date")
                    .HasColumnName("fecha_entrada");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(100)
                    .HasColumnName("nombre_producto");

                entity.Property(e => e.PrecioCompra)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_compra");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_venta");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");
            });

            modelBuilder.Entity<VwMascota>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_mascotas");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Especie)
                    .HasMaxLength(100)
                    .HasColumnName("especie");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Raza)
                    .HasMaxLength(100)
                    .HasColumnName("raza");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(10)
                    .HasColumnName("sexo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
