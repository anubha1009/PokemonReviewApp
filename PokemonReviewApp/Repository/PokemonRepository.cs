using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository: IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context) {
            _context = context;
        
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p =>p.Id ==id).FirstOrDefault();
            //uses where clause to search in pokemon p , then searched the entity for id and assigns the id to Id in here  and returns the 1st one that comes up
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int pokeid)
        {
            return _context.Pokemon.Any(p => p.Id ==pokeid);
        }
    }
}
