namespace PokeSearch.Domain
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Generation { get; set; }
    }

    public interface IPokeDomainService
    {
        Task<List<Pokemon>> GetAllPokemonAsync();
        Task<Pokemon> GetPokemonByIdAsync(int id);
    }
}
