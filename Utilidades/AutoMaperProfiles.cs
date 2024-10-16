namespace WebApplication1.Utilidades;
using AutoMapper;
using WebApplication1.Entidades;
using WebApplication1.DTOs;
using System;

public class AutoMaperProfiles
    {
    public AutoMaperProfiles()
    {
        CreateMap<GeneroCreacionDTOs, Genero>();
        CreateMap<ActorCreacionDTOs, Actor>();
        CreateMap<PeliculaCreacionDTOs, Pelicula>();
        CreateMap<PeliculaActorCreacionDTOs, PeliculaActor>();
    }

    private void CreateMap<T1, T2>()
    {
        throw new NotImplementedException();
    }
}
