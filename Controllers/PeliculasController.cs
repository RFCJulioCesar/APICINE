using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using WebApplication1.DTOs;
using WebApplication1.Entidades;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/pelicula")]
    public class PeliculasController:ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PeliculasController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(PeliculaCreacionDTOs peliculaCreacionDTOs) { 
        
        var pelicula = mapper.Map<Pelicula>(peliculaCreacionDTOs);
            if (pelicula.generos is not null) {
                foreach (var genero in pelicula.generos) { 
                
                   context.Entry(genero).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
           
                }

            }

            if(pelicula.peliculaActors is not null)
            {
                for (int i = 0; i<pelicula.peliculaActors.Count; i++)
                {
                    //pelicula.peliculaActors[i]. = i + 1;

                }
                context.Add(pelicula);
                await context.SaveChangesAsync();
                 
            }
                return Ok(pelicula);
        }
    }
}
