using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Application.Cocktails.Queries.GetCocktailDetails
{
    public class GetCocktailDetailsQuery : IRequest<CocktailDetailsVm>
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
