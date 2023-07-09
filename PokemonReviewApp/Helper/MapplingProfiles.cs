using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MapplingProfiles: Profile
    {
        public MapplingProfiles()
        {
               CreateMap<Pokemon , PokemonDto>();
        }
    }
}
