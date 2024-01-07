using Microsoft.EntityFrameworkCore;

namespace PokeSearch.Data
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options)
        {
        }
        public DbSet<PokemonDto> Pokemon { get; set; }
    }
}
