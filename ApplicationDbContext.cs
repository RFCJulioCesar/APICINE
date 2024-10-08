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
            modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento).HasColumnType("date");
            modelBuilder.Entity<Actor>().Property(a => a.Fortuna).HasPrecision(18, 2);

            modelBuilder.Entity<Pelicula>().Property(a => a.Titulo).HasMaxLength(150);
            modelBuilder.Entity<Pelicula>().Property(a => a.FechaEstreno).HasColumnType("date");

            modelBuilder.Entity<Comentario>().Property(a => a.Contenido).HasMaxLength(500);

        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }
        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Actor> Actors => Set<Actor>();
        public DbSet<Pelicula> peliculas => Set<Pelicula>();
        public DbSet<Comentario> comentarios => Set<Comentario>();     
            
    }
}
