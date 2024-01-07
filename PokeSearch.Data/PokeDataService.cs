using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace PokeSearch.Data
{
    public class PokeDataService : IPokeDataService
    {
        private readonly PokemonDbContext _context;

        public PokeDataService(PokemonDbContext context)
        {
            _context = context;
        }

        public List<PokemonDto> GetAllPokemons()
        {
            return _context.Pokemon.ToList();
        }

        public PokemonDto GetPokemonById(int id)
        {
            return _context.Pokemon.FirstOrDefault(p => p.Id == id);
        }
    }
}
