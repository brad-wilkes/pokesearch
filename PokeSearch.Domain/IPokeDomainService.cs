using System.Collections.Generic;
using System.Threading.Tasks;
using PokeSearch.Domain;

public interface IPokeDomainService
{
    Task<bool> IsPokemonNameAvailableAsync(string name);
    Task<List<Pokemon>> GetPopularPokemonAsync();
    Task<List<Pokemon>> GetAllPokemonAsync();
    Task<Pokemon> GetPokemonByIdAsync(int id);

}
