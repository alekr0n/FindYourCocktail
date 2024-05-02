using AutoMapper;
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

namespace Cocktails.Application.Cocktails.Queries.GetCocktailDetails
{
    public class GetCocktailDetailQueryHandler 
        : IRequestHandler<GetCocktailDetailsQuery, CocktailDetailsVm>
    {
        private readonly ICocktailsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCocktailDetailQueryHandler(ICocktailsDbContext dbContext,
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<CocktailDetailsVm> Handle(GetCocktailDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Cocktails
                .FirstOrDefaultAsync(cocktail =>
                cocktail.id == request.id, cancellationToken);
            if (entity == null || entity.name != request.name)
            {
                throw new NotFoundException(nameof(Cocktail), request.id);
            }

            return _mapper.Map<CocktailDetailsVm>(entity);
        }
    }
}
