using Cocktails.Application.Interfaces;
using Cocktails.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Application.Cocktails.Commands.CreateCocktail
{
    public class CreateCocktailCommandHandler : IRequestHandler<CreateCocktailCommand, int>
    {
        private readonly ICocktailsDbContext _dbContext;

        public CreateCocktailCommandHandler(ICocktailsDbContext dbContext)
        {
            _dbContext = dbContext;
        }   

        public async Task<int> Handle(CreateCocktailCommand request,
            CancellationToken cancellationToken)
        {
            var cocktail = new Cocktail
            {
                id = request.CocktailsId,
                name = request.Name,
                ingredients = request.Ingredients,
                isCustom = true,
                time = DateTime.Now
            };

            await _dbContext.Cocktails.AddAsync(cocktail, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cocktail.id;
        }
    }
}
