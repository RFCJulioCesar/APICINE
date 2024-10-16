using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using WebApplication1.DTOs;
using WebApplication1.Entidades;

namespace WebApplication1.Controllers
{
    public class GeneroController : ControllerBase
    {
        [ApiController]
        [Route("api/generos")]
        public class GenerosController: ControllerBase
        {
            private readonly ApplicationDbContext context;
            private readonly IMapper mapper;

            public GenerosController(ApplicationDbContext Context, IMapper mapper) {

                
                this.context = Context;
                this.mapper = mapper;
            }

            [HttpPost]
            public async Task<ActionResult>Post(GeneroCreacionDTOs generoCreacion) {
               
           var genero = mapper.Map<Genero>(generoCreacion);
                context.Add(genero);
                await context.SaveChangesAsync();
                return Ok();
            }

            [HttpPost("varios")]
            public async Task<ActionResult> Post(GeneroCreacionDTOs[] generoCreacionDTOs) { 
            var generos = mapper.Map < Genero[]>(generoCreacionDTOs);
                context.AddRange(generos);
                await context.SaveChangesAsync();
                return Ok();
            }





        }

    }
}
