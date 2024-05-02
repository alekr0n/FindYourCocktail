using Cocktails.Application.Common.Exceptions;
using Cocktails.Application.Interfaces;
using Cocktails.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Application.Cocktails.Commands.UpdateCocktail
{
    public class UpdateCocktailCommandHandler : IRequestHandler<UpdateCocktailCommand>
    {
        private readonly ICocktailsDbContext _dbContext;

        public UpdateCocktailCommandHandler(ICocktailsDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Unit> Handle(UpdateCocktailCommand request,
            CancellationToken cancellationToken)
        {
            var entity =
                await _dbContext.Cocktails.FirstOrDefaultAsync(cocktail => cocktail.id == request.id, cancellationToken);

            if(entity == null || entity.name != request.name)
            {
                throw new NotFoundException(nameof(Cocktail), request.id);
            }

            entity.isCustom = request.isCustom;
            entity.time = DateTime.Now;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
