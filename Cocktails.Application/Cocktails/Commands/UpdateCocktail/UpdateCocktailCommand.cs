using Cocktails.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Application.Cocktails.Commands.UpdateCocktail
{
    public class UpdateCocktailCommand : IRequest
    {
        public int id { get; set; }
        public string name { get; set; }
        public Ingredients ingredients { get; set; }
        public bool isCustom { get; set; }
    }
}
