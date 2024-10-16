using WebApplication1.Entidades;

namespace WebApplication1.DTOs
{
    public class PeliculaCreacionDTOs
    {
        public string Titulo { get; set; } = null!;
        public bool EnCines { get; set; }
        public DateTime FechaEstreno { get; set; }
        public List<int> Generos { get; set; } = new List<int>();
        public List<PeliculaActorCreacionDTOs> peliculaActores { get; set; } = new List<PeliculaActorCreacionDTOs>();

    }
}
