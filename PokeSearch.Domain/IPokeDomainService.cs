using PokeSearch.Domain;

public interface IPokeDomainService
{
    Task<List<Pokemon>> GetAllPokemonAsync();
    Task<Pokemon> GetPokemonByIdAsync(int id);

}
