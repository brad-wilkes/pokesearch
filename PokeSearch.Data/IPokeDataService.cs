using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PokeSearch.Data
{
    public interface IPokeDataService
    {
        // Method to get all Pokemon
        List<PokemonDto> GetAllPokemons();

        // Method to get a Pokemon by its ID
        PokemonDto GetPokemonById(int id);
    }
}
