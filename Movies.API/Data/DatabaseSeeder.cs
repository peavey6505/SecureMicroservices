namespace Movies.API.Data
{
    public static class DatabaseSeeder
    {
        public static async Task SeedDatabase(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var moviesContext = scope.ServiceProvider.GetRequiredService<MoviesAPIContext>();
                await MoviesContextSeed.SeedAsync(moviesContext);
            }
        }
    }
}
