using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cocktails.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Persistence.EntityTypeConfigurations
{
    public class CocktailsConfiguration : IEntityTypeConfiguration<Cocktail>
    {
        public void Configure(EntityTypeBuilder<Cocktail> builder)
        {
            builder.HasKey(cocktail => cocktail.id);
            builder.HasIndex(cocktail => cocktail.id).IsUnique();
            builder.Property(cocktail => cocktail.id).HasMaxLength(250);
        }
    }
}
