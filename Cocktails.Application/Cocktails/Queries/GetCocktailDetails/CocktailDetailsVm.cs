using AutoMapper;
using Cocktails.Application.Common.Mappings;
using Cocktails.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Application.Cocktails.Queries.GetCocktailDetails
{
    public class CocktailDetailsVm : IMapWith<Cocktail>
    {
        public int id { get; set; }
        public Ingredients ingredients { get; set; }
        public List<string>? recipe { get; set; }
        public bool isCustom { get; set; }
        public DateTime? time { get; set; }
        public Estimate? estimate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cocktail, CocktailDetailsVm>()
                .ForMember(cocktailVm => cocktailVm.id,
                opt => opt.MapFrom(cocktail => cocktail.id))
                .ForMember(cocktailVm => cocktailVm.ingredients,
                opt => opt.MapFrom(cocktail => cocktail.ingredients))
                .ForMember(cocktailVm => cocktailVm.recipe,
                opt => opt.MapFrom(cocktail => cocktail.recipe))
                .ForMember(cocktailVm => cocktailVm.isCustom,
                opt => opt.MapFrom(cocktail => cocktail.isCustom))
                .ForMember(cocktailVm => cocktailVm.time,
                opt => opt.MapFrom(cocktail => cocktail.time))
                .ForMember(cocktailVm => cocktailVm.estimate,
                opt => opt.MapFrom(cocktail => cocktail.estimate));
        }
    }
}
