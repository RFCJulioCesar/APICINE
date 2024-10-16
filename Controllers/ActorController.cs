using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using WebApplication1.DTOs;
using WebApplication1.Entidades;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("apli/actores")]
    public class ActorController : ControllerBase

    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ActorController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;

        }
        [HttpPost]
        public async Task<ActionResult> Post(ActorCreacionDTOs actorCreacionDTOs) { 
        
        var actor = mapper.Map<Actor>(actorCreacionDTOs);
            context.Add(actor);
            await context.SaveChangesAsync();
            return Ok();


        
        }
    }
}
