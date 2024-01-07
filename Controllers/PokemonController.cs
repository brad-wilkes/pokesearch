using Microsoft.AspNetCore.Mvc;
using PokeSearch.Data;
using PokeSearch.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokeSearch.Controllers{

[ApiController]
[Route("api/[controller]")]
public class PokemonController : ControllerBase
{
    private readonly IPokeDomainService _pokeDomainService;

    public PokemonController(IPokeDomainService pokeDomainService)
    {
        _pokeDomainService = pokeDomainService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Pokemon>>> GetAllPokemonAsync()
    {
        var pokemon = await _pokeDomainService.GetAllPokemonAsync();
        return Ok(pokemon);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Pokemon>> GetPokemonByIdAsync(int id)
    {
        var pokemon = await _pokeDomainService.GetPokemonByIdAsync(id);
        if (pokemon == null)
        {
            return NotFound();
        }
        return Ok(pokemon);
    }
}
}