using Microsoft.EntityFrameworkCore;
using WebApplication1.Entidades;

namespace WebApplication1
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genero>().HasKey(g => g.Id);
            modelBuilder.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(150);

            modelBuilder.Entity<Actor>().Property(a => a.Nombre).HasMaxLength(150);
            modelBuilder.Entity<Actor>().Property(a => a.Fortuna).HasMaxLength(150);
            modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento).HasColumnType("Date");

        }
        public DbSet<Genero> Generos => Set<Genero>();
    }
}
