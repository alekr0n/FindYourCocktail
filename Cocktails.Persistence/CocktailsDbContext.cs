using Microsoft.EntityFrameworkCore;
using Cocktails.Application.Interfaces;
using Cocktails.Domain;
using Cocktails.Persistence.EntityTypeConfigurations;

namespace Cocktails.Persistence
{
    internal class CocktailsDbContext : DbContext, ICocktailsDbContext
    {
        public DbSet<Cocktail> Cocktails { get; set; }

        public CocktailsDbContext(DbContextOptions<CocktailsDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CocktailsConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
