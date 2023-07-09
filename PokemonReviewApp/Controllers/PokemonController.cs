using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class PokemonController: Controller

    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;
        public PokemonController(IPokemonRepository pokemonRepository , IMapper mapper) { 
            _pokemonRepository = pokemonRepository;
            _mapper = mapper; 
            //to remve the nulls and to map the result to some format
        
        }
        [HttpGet]
        [ProducesResponseType( 200 ,Type =  typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _mapper.Map<List<PokemonDto>>(_pokemonRepository.GetPokemons());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pokemons);
        }

        [HttpGet("{pokeid}")]
        [ProducesResponseType(200 , Type = typeof(Pokemon))]

        public IActionResult GetPokemon(int id)
        {
            if (!_pokemonRepository.PokemonExists(id))
            {
                return BadRequest()
;            }

        var pokemon = _mapper.Map<List<Pokemon>>( _pokemonRepository.GetPokemon(id));
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(pokemon);
        }
    }
}
