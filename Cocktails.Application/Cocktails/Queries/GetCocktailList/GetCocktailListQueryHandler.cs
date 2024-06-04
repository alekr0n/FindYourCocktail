using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cocktails.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Application.Cocktails.Queries.GetCocktailList
{
    public class GetCocktailListQueryHandler : IRequestHandler<GetCocktailListQuery, CocktailListVm>
    {
        private readonly ICocktailsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCocktailListQueryHandler(ICocktailsDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<CocktailListVm> Handle(GetCocktailListQuery request,
            CancellationToken cancellationToken)
        {
            var cocktailsQuery = await _dbContext.Cocktails
                .Where(cocktail => cocktail.id == request.id)
                .ProjectTo<CocktailLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new CocktailListVm { Cocktails = cocktailsQuery };
        }
    }
}