using Microsoft.EntityFrameworkCore;

namespace BDs.Models
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options)

                 : base(options)

        { }

        public DbSet<Artigo> Artigos { get; set; }


    }
}