using Microsoft.EntityFrameworkCore;
using PokeSearch.Data;

namespace PokeSearch.Domain
{
    public class PokeDomainService : IPokeDomainService
    {
        private readonly PokemonDbContext _context;

        public PokeDomainService(PokemonDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pokemon>> GetAllPokemonAsync()
        {
            var pokemonDtos = await _context.Pokemon.ToListAsync();
            return pokemonDtos.Select(dto => new Pokemon
            {
                Id = dto.Id,
                Name = dto.Name,
                Type = dto.Type,
                Generation = dto.Generation
            }).ToList();
        }
        public async Task<Pokemon?> GetPokemonByIdAsync(int id)
        {
            var dto = await _context.Pokemon.FirstOrDefaultAsync(p => p.Id == id);
            return dto != null
                ? new Pokemon
                {
                    Id = dto.Id,
                    Name = dto.Name,
                    Type = dto.Type,
                    Generation = dto.Generation
                }
                : null;
        }
    }
}
