namespace PokeSearch.Data
{
    public interface IPokeDataService
    {
        // Method to get all Pokemon
        List<PokemonDto> GetAllPokemon();

        // Method to get a Pokemon by its ID
        PokemonDto GetPokemonById(int id);
    }
}
