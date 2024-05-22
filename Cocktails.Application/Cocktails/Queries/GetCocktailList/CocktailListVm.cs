using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Application.Cocktails.Queries.GetCocktailList
{
    public class CocktailListVm
    {
        public IList<CocktailLookupDto> Cocktails { get; set; }
    }
}
