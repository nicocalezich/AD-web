using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ADweb.Models
{
    public partial class ADDBContext : DbContext
    {
        public ADDBContext()
        {
        }

        public ADDBContext(DbContextOptions<ADDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<ProductosVendidos> ProductosVendidos { get; set; }
        public virtual DbSet<ConfiguracionTipos> ConfiguracionTipos { get; set; }
        public virtual DbSet<ConfiguracionLocalidades> ConfiguracionLocalidades { get; set; }
        public virtual DbSet<ConfiguracionAlertaStock> ConfiguracionAlertaStock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LocalHost;Database=ADDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CantidadDisponible).HasColumnName("Cantidad_disponible");

                entity.Property(e => e.HayStock).HasColumnName("Hay_stock");

                entity.Property(e => e.PrecioKgUnidad).HasColumnName("Precio_kg_unidad");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadUsada).HasColumnName("Unidad_usada")
                   .HasMaxLength(10)
                   .IsUnicode(false);
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePersonal)
                    .HasColumnName("Nombre_personal")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMercaderia)
                    .IsRequired()
                    .HasColumnName("Tipo_mercaderia")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pedidos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(50)
                    .HasColumnName("Cliente")
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .IsRequired()
                    .HasColumnName("Fecha")
                    .IsUnicode(false);

                entity.Property(e => e.EstaEntregado)
                    .IsRequired()
                    .HasColumnName("Esta_entregado")
                    .IsUnicode(false);

                entity.Property(e => e.EstaPago)
                    .IsRequired()
                    .HasColumnName("Esta_pago")
                    .IsUnicode(false);

                entity.Property(e => e.PedidoCerrado)
                    .IsRequired()
                    .HasColumnName("Pedido_cerrado")
                    .IsUnicode(false);

                entity.Property(e => e.TotalCobrado)
                    .IsRequired()
                    .HasColumnName("Total_cobrado")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductosVendidos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdPedido)
                    .IsRequired()
                    .HasColumnName("Id_pedido")
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasColumnName("Producto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad)
                    .IsRequired()
                    .HasColumnName("Cantidad")
                    .IsUnicode(false);

            });

            modelBuilder.Entity<ConfiguracionTipos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tipos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Tipos")
                    .IsUnicode(false);

            });

            modelBuilder.Entity<ConfiguracionLocalidades>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Localidades)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Localidades")
                    .IsUnicode(false);

            });

            modelBuilder.Entity<ConfiguracionAlertaStock>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Valor")
                    .IsUnicode(false);

            });
        }
    }
}
