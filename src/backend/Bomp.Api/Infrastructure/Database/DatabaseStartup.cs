using Bomp.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bomp.API.Infrastructure.Database
{
    public static class DatabaseStartup
    {
        public static IServiceCollection ConfigureDatabaseSqlServer(this IServiceCollection services,
            IConfiguration Configuration)
        {
            return services.AddDbContext<PokemonContext>(options => options.UseInMemoryDatabase(databaseName: "PokemonContext"));
        }
    }
}