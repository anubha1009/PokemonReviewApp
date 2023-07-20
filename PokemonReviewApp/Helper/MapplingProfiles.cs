using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MapplingProfiles: Profile
    {
        public MapplingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category,  CategoryDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Owner ,  OwnerDto>();
        }
    }
}
