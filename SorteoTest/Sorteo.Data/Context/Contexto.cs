using System;
using Microsoft.EntityFrameworkCore;
using Sorteo.Data.Entity;
using Sorteo.Data;


namespace Sorteo.Data.Context
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Sorteo> Sorteos { get; set; }
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<SorteoParticipante> SorteoParticipantes { get; set; }
        public DbSet<DetalleSorteo> DetaalleSorteos { get; set; }

    }
}
