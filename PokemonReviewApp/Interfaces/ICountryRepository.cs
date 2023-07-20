using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        bool CountryExists(int countryId);
        ICollection<Country> GetCountries();
        Country GetCountry(int countryId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        Country GetCountryByOwner(int ownerId);

    }
}
