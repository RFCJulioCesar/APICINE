using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOs
{
    public class GeneroCreacionDTOs
    {
        [StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = null!;

    }
}
