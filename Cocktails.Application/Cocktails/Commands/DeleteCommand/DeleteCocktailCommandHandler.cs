using Cocktails.Application.Common.Exceptions;
using Cocktails.Application.Interfaces;
using Cocktails.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Application.Cocktails.Commands.DeleteCommand
{
    public class DeleteCocktailCommandHandler : IRequestHandler<DeleteCocktailCommand>
    {
        private readonly ICocktailsDbContext _dbContext;

        public DeleteCocktailCommandHandler(ICocktailsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteCocktailCommand request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Cocktails
                .FindAsync(new object[] { request.id }, cancellationToken);

            if(entity == null || entity.name != request.name)
            {
                throw new NotFoundException(nameof(Cocktail), request.id);
            }

            _dbContext.Cocktails.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
