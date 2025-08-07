using Microsoft.EntityFrameworkCore;
using SPManager_Backend.Models;

namespace SPManager_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Detalles> Detalles { get; set; }
        public DbSet<Encargado> Encargados { get; set; }
    }
}
