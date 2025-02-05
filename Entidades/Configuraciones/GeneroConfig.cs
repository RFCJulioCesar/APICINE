using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entidades.Configuraciones
{
    public class GeneroConfig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            var cienciaFiccion = new Genero { Id = 5, Nombre = "Ciencia Ficcion" };
            var animacion = new Genero { Id = 5 , Nombre = "Animacion" };
            builder.HasData(cienciaFiccion,animacion);
        }
    }
}
