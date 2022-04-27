using Microsoft.EntityFrameworkCore;
using Personas2.Data.Models;

namespace Personas2.Data.Context
{
    public class Personas2Context : DbContext
    {
        public Personas2Context(DbContextOptions<Personas2Context> options)
            : base(options)
        {
        }

        public DbSet<Persona2> Persona2 { get; set; }
    }
}
