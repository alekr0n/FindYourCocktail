using Cocktails.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Application.Cocktails.Commands.CreateCocktail
{
    public class CreateCocktailCommand : IRequest<int>
    {
        public int CocktailsId { get; set; }
        public string Name { get; set; }
        public Ingredients Ingredients { get; set; }
    }
}
