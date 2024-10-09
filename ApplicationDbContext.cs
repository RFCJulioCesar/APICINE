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
