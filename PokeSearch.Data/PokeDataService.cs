namespace PokeSearch.Data
{
    public class PokeDataService : IPokeDataService
    {
        private readonly PokemonDbContext _context;

        public PokeDataService(PokemonDbContext context)
        {
            _context = context;
        }

        public List<PokemonDto> GetAllPokemon()
        {
            return _context.Pokemon.ToList();
        }

        public PokemonDto GetPokemonById(int id)
        {
            return _context.Pokemon.FirstOrDefault(p => p.Id == id);
        }
    }
}
