using apiVacantes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiVacantes.Context
{
    public partial class AppDBContext : DbContext 
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }

        public DbSet<Trabajos> Trabajos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local);Database=DBVacantes;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__8A3D240CF18A19AE");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__Tipo__BDD0DFE166122BFE");

                entity.ToTable("Tipo");

                entity.Property(e => e.IdTipo)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Trabajos>(entity =>
            {
                entity.HasKey(e => e.IdTrabajo)
                    .HasName("PK__Trabajos__DDAA03FD3FC8B0D4");

                entity.Property(e => e.IdTrabajo).HasColumnName("idTrabajo");

                entity.Property(e => e.ComoAplicar)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comoAplicar");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.Property(e => e.Logo)
                    .HasColumnType("image")
                    .HasColumnName("logo");

                entity.Property(e => e.Posicion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("posicion");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ubicacion");

                entity.Property(e => e.UrlString)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("urlString");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Trabajos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Trabajos__idCate__3C69FB99");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Trabajos)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK__Trabajos__idTipo__3D5E1FD2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
