using dominio.entidades;
using Infraestructura.persistencia.modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.persistencia
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ReciboDb> Recibos { get; set; }

        // public DbSet<LoteInspeccion> Lotes { get; set; }
        // public DbSet<MateriaPrima> Suministros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
            modelBuilder.Entity<ReciboDb>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Estado).IsRequired();

            });
        }
    }
}
