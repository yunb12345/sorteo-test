using System;
using Microsoft.EntityFrameworkCore;


namespace Sorteo.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

    }
}
