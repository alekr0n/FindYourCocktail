namespace Cocktails.Persistence
{
    internal class DbInitializer
    {
        public static void Initialize(CocktailsDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
