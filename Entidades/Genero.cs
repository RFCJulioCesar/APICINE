﻿namespace WebApplication1.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public HashSet<Pelicula> peliculas { get; set; } = new HashSet<Pelicula>();
    }
}
