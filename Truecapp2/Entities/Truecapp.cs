using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Truecapp2.Entities
{
    public partial class Truecapp : DbContext
    {
        public Truecapp()
        {
        }

        public Truecapp(DbContextOptions<Truecapp> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Initial Catalog=TRUECAPP; Persist SecurIty Info=false; User Id=usuario; Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("producto");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("codigo");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(30)
                    .HasColumnName("categoria")
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .HasColumnName("estado")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .HasColumnName("nombre")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
