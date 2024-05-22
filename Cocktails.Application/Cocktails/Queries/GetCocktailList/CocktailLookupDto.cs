using Cocktails.Application.Common.Mappings;
using Cocktails.Domain;
using AutoMapper;
using MediatR;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cocktails.Application.Cocktails.Queries.GetCocktailList
{
    public class CocktailLookupDto : IMapWith<Cocktail>
    {
        public int Id { get; set; }
        public string title { get; set; }

        public void Mapping(Cocktail cocktail)
        {
            profile.Createmap<Cocktail, CocktailLookupDto>()
                .ForMember(cocktailDto => cocktailDto.Id,
                    opt = opt.MapForm(cocktail => cocktail.Id))
                .ForMember(cocktailDto => cocktailDto.Title,
                    opt => opt.MapForm(cocktail = cocktail.Title));
        }
    }
}
