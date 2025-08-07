using Microsoft.EntityFrameworkCore;
using SPManager_Backend.Models;

namespace SPManager_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Encargado> Encargados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>().ToTable("Estudiante");
            modelBuilder.Entity<Detalle>().ToTable("Detalle");
            modelBuilder.Entity<Encargado>().ToTable("Encargado");
        }
    }
}
