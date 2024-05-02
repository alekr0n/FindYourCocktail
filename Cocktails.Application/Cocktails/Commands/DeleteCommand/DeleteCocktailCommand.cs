using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Application.Cocktails.Commands.DeleteCommand
{
    public class DeleteCocktailCommand : IRequest
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
