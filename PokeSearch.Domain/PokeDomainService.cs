using Microsoft.EntityFrameworkCore;
using PokeSearch.Data;
using PokeSearch.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task AddPokemonAsync(Pokemon pokemon)
        {
            var dto = new PokemonDto
            {
                Id = pokemon.Id,
                Name = pokemon.Name,
                Type = pokemon.Type,
                Generation = pokemon.Generation
            };

            _context.Pokemon.Add(dto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePokemonAsync(Pokemon pokemon)
        {
            var dto = new PokemonDto
            {
                Id = pokemon.Id,
                Name = pokemon.Name,
                Type = pokemon.Type,
                Generation = pokemon.Generation
            };

            _context.Pokemon.Update(dto);
            await _context.SaveChangesAsync();
        }
    }
}
