using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cocktails.Domain;

namespace Cocktails.Application.Interfaces
{
    public interface ICocktailsDbContext
    {
        DbSet<Cocktail> Cocktails { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
