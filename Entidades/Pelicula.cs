using System.Data;

namespace WebApplication1.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public bool EnCine { get; set; }

        public DateTime FechaEstreno { get; set;} 
    }
}
